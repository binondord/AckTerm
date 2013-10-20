public partial class ackterm
{
    private partial class TermWindow : System.Windows.Forms.Form
    {
        private void TelnetInterpreter (object Sender, NvtParserEventArgs e)
        {
            //counttelint
            //prntSome.printSome(System.String.Format("CurChar:{0}CurSequence:{1}", e.CurChar, e.CurSequence), "TelnetInterpreter", counttelint);
            
            switch (e.Action)
            {
                case NvtActions.SendUp:
                    this.Parser.ParseString (e.CurChar.ToString ());
                    break;
                case NvtActions.Execute:
                    this.NvtExecuteChar (e.CurChar);
                    break;
                default:
                    break;
            }

            // if the sequence is a DO message
            if (e.CurSequence.StartsWith ("\xFD"))
            {
                System.Char CurCmd = System.Convert.ToChar (e.CurSequence.Substring (1, 1));
                //prntSome.printSome(System.String.Format("CurChar:{0}CurSequence:{1:X}", e.CurChar, e.CurSequence), "will", counttelint);
                //counttelint++;
                switch (CurCmd)
                {
                    // 24 - terminal type 
                    case '\x18':
                        NvtSendWill (CurCmd);
                        break;

                    default:
                        NvtSendWont (CurCmd);
                        //System.Console.Write ("unsupported telnet DO sequence {0} happened\n", 
                            //System.Convert.ToInt32 (System.Convert.ToChar (e.CurSequence.Substring (1,1))));
                        break;
                }
            }

            // if the sequence is a WILL message
            if (e.CurSequence.StartsWith ("\xFB"))
            {
                System.Char CurCmd = System.Convert.ToChar (e.CurSequence.Substring (1, 1));
                //prntSome.printSome(System.String.Format("CurChar:{0}CurSequence:{1:X}", e.CurChar, e.CurSequence), "do", counttelint);
                switch (CurCmd)
                {
                    case '\x01': // echo
                        NvtSendDo (CurCmd);
                        break;

                    default:
                        NvtSendDont (CurCmd);
                        //System.Console.Write ("unsupported telnet WILL sequence {0} happened\n", 
                            //System.Convert.ToInt32 (System.Convert.ToChar (e.CurSequence.Substring (1,1))));
                        break;
                }
            }

            // if the sequence is a SUBNEGOTIATE message
            if (e.CurSequence.StartsWith ("\xFA"))
            {
                //prntSome.printSome(System.String.Format("CurChar:{0}CurSequence:{1:X}", e.CurChar, e.CurSequence), "sub", counttelint);
                if (e.CurSequence[2] != '\x01')
                {
                    // not interested in data from host just yet as we don't ask for it at the moment
                    return;
                }

                System.Char CurCmd = System.Convert.ToChar (e.CurSequence.Substring (1, 1));

                switch (CurCmd)
                {
                    // 24 - terminal type 
                    case '\x18':
                        NvtSendSubNeg (CurCmd, "ansi");//"vt220");
                        break;

                    default:
                        NvtSendSubNeg (CurCmd, "");
                        System.Console.Write ("unsupported telnet SUBNEG sequence {0} happened\n", 
                            System.Convert.ToInt32 (System.Convert.ToChar (e.CurSequence.Substring (1,1))));
                        break;
                }
            }
            //counttelint++;
        }

        public void NvtSendWill (System.Char CurChar)
        {
            //prntSome.printSome("NvtSendWill: "+CurChar.ToString(), "montdis", countmontdisrdb);
            //countmontdisrdb++;
            DispatchMessage (this, "\xFF\xFB" + CurChar.ToString ());
        }

        public void NvtSendWont (System.Char CurChar)
        {
            //prntSome.printSome("NvtSendWont: " + CurChar.ToString(), "montdis", countmontdisrdb);
            //countmontdisrdb++;
            DispatchMessage (this, "\xFF\xFC" + CurChar.ToString ());
        }

        public void NvtSendDont (System.Char CurChar)
        {
            //prntSome.printSome("NvtSendDont: " + CurChar.ToString(), "montdis", countmontdisrdb);
            //countmontdisrdb++;
            DispatchMessage (this, "\xFF\xFE" + CurChar.ToString ());
        }

        public void NvtSendDo (System.Char CurChar)
        {
            //prntSome.printSome("NvtSendDo: " + CurChar.ToString(), "montdis", countmontdisrdb);
            //countmontdisrdb++;
            DispatchMessage (this, "\xFF\xFD" + CurChar.ToString ());
        }

        public void NvtSendSubNeg (System.Char CurChar, System.String CurString)
        {
            //prntSome.printSome("NvtSendSubNeg: " + CurChar.ToString(), "montdis", countmontdisrdb);
            //countmontdisrdb++;
            DispatchMessage (this, "\xFF\xFA" + CurChar.ToString () + "\x00" + CurString + "\xFF\xF0");
        }

        public void NvtExecuteChar (System.Char CurChar)
        {
            switch (CurChar)
            {
                default:
                    System.Console.WriteLine ("Telnet command {0} encountered", CurChar);
                    break;
            }
        }            
    }
}




