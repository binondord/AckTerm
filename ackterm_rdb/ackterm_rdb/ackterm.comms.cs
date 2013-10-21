public partial class ackterm
{

    private partial class TermWindow : System.Windows.Forms.Form
    {
        private System.AsyncCallback      callbackProc;
        private System.AsyncCallback      callbackEndDispatch;
        private System.Net.Sockets.Socket CurSocket;
        private System.Boolean            XOFF    = false;
        private System.String             OutBuff = "";

        private class uc_CommsStateObject
        {
            public System.Net.Sockets.Socket Socket;
            public System.Byte[]             Buffer;

            public uc_CommsStateObject ()
            {
                //prntSome.printSome("uc_CommsStateObject");
                this.Buffer = new System.Byte[8192];
            }
        }

        public void Connect (System.String HostName)
        {
            //prntSome.printSome("Connect");
            System.Int32           port    = 10010;
            System.Net.IPAddress addrRdb;
            System.Net.IPAddress[] addr = new System.Net.IPAddress[1];
            if (System.Net.IPAddress.TryParse(HostName, out addrRdb))
            {
                //must do push ip to array here
            }
            else
            {
                //System.Net.IPHostEntry IPHost = System.Net.Dns.GetHostEntry(HostName);
                //System.Net.IPAddress[] addr = IPHost.AddressList; 
            }
            addr[0] = addrRdb;
            
        
            try
            {
                this.runOffline = false;
                // Create New Socket 
                this.CurSocket = new System.Net.Sockets.Socket (
                    System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, 
                    System.Net.Sockets.ProtocolType.Tcp);

                // Create New EndPoint
                System.Net.IPEndPoint iep  = new System.Net.IPEndPoint(addr[0],port);  

                // This is a non blocking IO
                this.CurSocket.Blocking        = false ;    

                // Begin Asyncronous Connection
                this.CurSocket.BeginConnect (iep,  new System.AsyncCallback (ConnectCallback), CurSocket) ;                
            }
            catch (System.Exception CurException)
            {
                this.runOffline = true;
                System.Console.WriteLine ("Connect: " + CurException.Message);
            }
        }

        public void ConnectCallback (System.IAsyncResult ar)
        {
            //prntSome.printSome("ConnectCallback");
            try
            {
                // Get The connection socket from the callback
                System.Net.Sockets.Socket sock1 = (System.Net.Sockets.Socket) ar.AsyncState;

                if (sock1.Connected) 
                {
                    uc_CommsStateObject StateObject = new uc_CommsStateObject ();

                    StateObject.Socket = sock1;
    
                    // Assign Callback function to read from Asyncronous Socket
                    callbackProc = new System.AsyncCallback (OnReceivedData);

                    // Begin reading data asyncronously
                    sock1.BeginReceive (StateObject.Buffer, 0, StateObject.Buffer.Length, 
                        System.Net.Sockets.SocketFlags.None, callbackProc, StateObject);
                }
            }

            catch (System.Exception CurException)
            {
                System.Console.WriteLine ("ConnectCallback: " + CurException.Message);
            }
        }

        public void OnReceivedData (System.IAsyncResult ar)
        {
            ////prntSome.printSome("OnReceivedData");
            // Get The connection socket from the callback
            uc_CommsStateObject StateObject = (uc_CommsStateObject) ar.AsyncState;

            // Get The data , if any
            int nBytesRec = StateObject.Socket.EndReceive (ar);        

            if ( nBytesRec > 0 )
            {
                string sReceived = "";
                string sample = "";
                char aaachar;

                for (int i = 0; i < nBytesRec; i++)
                {
                    aaachar = System.Convert.ToChar (StateObject.Buffer[i]);
                    sample = aaachar.ToString();
                    //prntSome.printSome(sample, "OnReceivedData");
                    sReceived += sample;
                }

                /**rdb**/
                
                //prntSome.printSome(sReceived, "sReceived", countrdb);
                //countrdb++;
                                
                /**end rdb**/


                this.Invoke (this.RxdTextEvent, new System.String[] {System.String.Copy (sReceived)});
                this.Invoke(this.RxdDataLoaded);
                this.Invoke (this.RefreshEvent);

                // Re-Establish the next asyncronous receveived data callback as
                StateObject.Socket.BeginReceive (StateObject.Buffer, 0, StateObject.Buffer.Length, 
                    System.Net.Sockets.SocketFlags.None, new System.AsyncCallback (OnReceivedData) , StateObject);

                /**rdb**/
                
                string tmpstr = "";
                //this.CharGrid
                for (int ii = 0; ii < this.CharGrid.Length; ii++)
                {
                    var str = new string(this.CharGrid[ii]);
                    tmpstr += str + "\n";
                }
                
                //prntSome.printSome(tmpstr, "chargrid", counttxtscrnrdb);
                //rdbsb1.Clear();
                //rdbsb1.AppendFormat("\n\nchargrid #: " + counttxtscrnrdb);
                //counttxtscrnrdb++;

                //this.Caret.Pos.ToString();
                //prntSome.printSome(this.Caret.Pos.ToString(), "carret_position", countbmprdb);
                //countbmprdb++;
                /**end rdb**/
            }
            else
            {
                this.runOffline = true;
                // If no data was recieved then the connection is probably dead
                System.Console.WriteLine ("Disconnected", StateObject.Socket.RemoteEndPoint);
                rdbmsg.AppendLine("Dead....");
                StateObject.Socket.Shutdown (System.Net.Sockets.SocketShutdown.Both);

                StateObject.Socket.Close ();
            }
        }

        public void DispatchMessage (System.Object sender, string strText, System.Boolean b = false)
        {
            if (b)
            {
                //this.rdbDispatchMsg = strText;
                //prntSome.printSome(strText, "DispatchMessage", countdispatchrdb);
                //countdispatchrdb++;
            }
            if (this.XOFF == true)
            {
                // store the characters in the outputbuffer
                OutBuff += strText;
                return;
            }

            int i = 0;
            if (this.runOffline == false)
            {
                try
                {
                    System.Byte[] smk = new System.Byte[strText.Length];

                    if (OutBuff != "")
                    {
                        strText = OutBuff + strText;
                        OutBuff = "";
                    }

                    for (i = 0; i < strText.Length; i++)
                    {
                        System.Byte ss = System.Convert.ToByte(strText[i]);
                        smk[i] = ss;
                    }

                    if (callbackEndDispatch == null)
                    {
                        callbackEndDispatch = new System.AsyncCallback(EndDispatchMessage);
                    }

                    System.IAsyncResult ar = this.CurSocket.BeginSend(
                        smk,
                        0,
                        smk.Length,
                        System.Net.Sockets.SocketFlags.None,
                        callbackEndDispatch,
                        this.CurSocket);

                }
                catch (System.Exception CurException)
                {
                    System.Console.WriteLine("DispatchMessage: " + CurException.Message);
                    System.Console.WriteLine("DispatchMessage: Character is " + System.Convert.ToInt32(strText[i]));
                    System.Console.WriteLine("DispatchMessage: String is " + strText);
                }
            }
        }

        public void EndDispatchMessage (System.IAsyncResult ar)
        {
            //prntSome.printSome("EndDispatchMessage");
            try
            {
                System.Net.Sockets.Socket Sock =  (System.Net.Sockets.Socket) ar.AsyncState;

                Sock.EndSend (ar);
            }
            catch (System.Exception CurException)
            {
                System.Console.WriteLine ("EndDispatchMessage: " + CurException.Message);
            }
        }
    }
}





