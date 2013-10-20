public partial class ackterm
{

    private struct NvtParserEventArgs 
    {
        public NvtActions        Action;
        public System.Char       CurChar;
        public System.String     CurSequence;
        public uc_Params         CurParams;

        public NvtParserEventArgs (
            NvtActions        p1,
            System.Char       p2,
            System.String     p3,
            uc_Params         p4)
        {
            //prntSome.printSome("NvtParserEventArgs");
            Action       = p1;
            CurChar      = p2;
            CurSequence  = p3;
            CurParams    = p4;
        }
    }

    private enum NvtCommand 
    {
        SE    = 240, 
        NOP   = 241, 
        DM    = 242, 
        BREAK = 243, 
        IP    = 244, 
        AO    = 245, 
        AYT   = 246, 
        EC    = 247, 
        EL    = 248, 
        GA    = 249, 
        SB    = 250, 
        WILL  = 251, 
        WONT  = 252, 
        DO    = 253, 
        DONT  = 254, 
        IAC   = 255, 
    }
    
    private enum NvtOption
    {
        ECHO     = 1,   // echo
        SGA      = 3,   // suppress go ahead
        STATUS   = 5,   // status
        TM       = 6,   // timing mark
        TTYPE    = 24,  // terminal type
        NAWS     = 31,  // window size
        TSPEED   = 32,  // terminal speed
        LFLOW    = 33,  // remote flow control
        LINEMODE = 34,  // linemode
        ENVIRON  = 36,  // environment variables
    }

    private enum NvtActions 
    {
        None       = 0,
        SendUp     = 1,
        Dispatch   = 2,
        Collect    = 4,
        NewCollect = 5,
        Param      = 6,
        Execute    = 7,
    }

    private delegate void NvtParserEventHandler (object Sender, NvtParserEventArgs e);

    private class uc_TelnetParser
    {
        public event NvtParserEventHandler NvtParserEvent;
        States State = States.Ground;
        System.Char   CurChar     = '\0';
        System.String CurSequence = "";
        
        System.Collections.ArrayList ParamList = new System.Collections.ArrayList ();
        uc_CharEvents        CharEvents        = new uc_CharEvents ();
        uc_StateChangeEvents StateChangeEvents = new uc_StateChangeEvents ();
        uc_Params            CurParams         = new uc_Params ();

        public uc_TelnetParser ()
        {
            //prntSome.printSome("uc_TelnetParser");
        }

        public void ParseString (System.String InString)
        {
            //prntSome.printSome("ParseString");
            States        NextState        = States.None;
            NvtActions    NextAction       = NvtActions.None;
            NvtActions    StateExitAction  = NvtActions.None;
            NvtActions    StateEntryAction = NvtActions.None;
    
            foreach (System.Char C in InString)
            {
                this.CurChar = C;
   
                // Get the next state and associated action based 
                // on the current state and char event
                CharEvents.GetStateEventAction (State, CurChar, ref NextState, ref NextAction);

                // execute any actions arising from leaving the current state
                if  (NextState != States.None && NextState != this.State)
                {
                    // check for state exit actions
                    StateChangeEvents.GetStateChangeAction (this.State, Transitions.Exit, ref StateExitAction);
    
                    // Process the exit action
                    if (StateExitAction != NvtActions.None) DoAction (StateExitAction);
    
                }
    
                // process the action specified
                if (NextAction != NvtActions.None) DoAction (NextAction);
    
                // set the new parser state and execute any actions arising entering the new state
                if  (NextState != States.None && NextState != this.State)
                {
                    // change the parsers state attribute
                    this.State = NextState;
    
                    // check for state entry actions
                    StateChangeEvents.GetStateChangeAction (this.State, Transitions.Entry, ref StateExitAction);
    
                    // Process the entry action
                    if (StateEntryAction != NvtActions.None) DoAction (StateEntryAction);
                }
            }
        }
        
        private void DoAction (NvtActions NextAction)
        {
            //prntSome.printSome("DoAction");
            // Manage the contents of the Sequence and Param Variables
            switch (NextAction)
            {
                case NvtActions.Dispatch:
                case NvtActions.Collect:
                    this.CurSequence += CurChar.ToString ();
                    break;
    
                case NvtActions.NewCollect:
                    this.CurSequence = CurChar.ToString ();
                    this.CurParams.Clear ();
                    break;
    
                case NvtActions.Param:
                    this.CurParams.Add (CurChar);
                    break;
    
                default:
                    break;
            }
    
            // send the external event requests
            switch (NextAction)
            {
                case NvtActions.Dispatch:
                    //System.Console.Write
                   //rdbsb.Append(System.String.Format("Seq:{0},Char:{1},NxtAct:{4}\n",
                    //   this.CurSequence, (int) this.CurChar, this.CurParams.Count (), 
                    //   this.State, NextAction));

                    NvtParserEvent (this, new NvtParserEventArgs (NextAction, CurChar, CurSequence, CurParams));
                    break;

                case NvtActions.Execute:
                case NvtActions.SendUp:
                    NvtParserEvent (this, new NvtParserEventArgs (NextAction, CurChar, CurSequence, CurParams));

                    //rdbsb.Append(System.String.Format("Seq:{0},Char:{1},NxtAct:{4}\n",
                    //    this.CurSequence, (int) this.CurChar, this.CurParams.Count (), 
                    //    this.State, NextAction));
                    break;
                default:
                    break; 
            }
    
    
            switch (NextAction)
            {
                case NvtActions.Dispatch:
                    this.CurSequence = "";
                    this.CurParams.Clear ();
                    break;

                default:
                    break;
            }
        }
    
        private enum States 
        {
            None              = 0,
            Ground            = 1,
            Command           = 2,
            Anywhere          = 3,
            Synch             = 4,
            Negotiate         = 5,  
            SynchNegotiate    = 6,  
            SubNegotiate      = 7,  
            SubNegValue       = 8,  
            SubNegParam       = 9,  
            SubNegEnd         = 10,  
            SynchSubNegotiate = 11,  
        }
        
        private enum Transitions 
        {
            None  = 0,
            Entry = 1,
            Exit  = 2,
        }
        
        private struct uc_StateChangeInfo
        {
            public States        State;
            public Transitions   Transition;    // the next state we are going to 
            public NvtActions    NextAction;
        
            public uc_StateChangeInfo (
                States      p1,
                Transitions p2,
                NvtActions  p3)
            {
                //prntSome.printSome("uc_StateChangeInfo");
                this.State      = p1;
                this.Transition = p2;
                this.NextAction = p3;
            }
        }
    
        private class uc_StateChangeEvents 
        {
            private uc_StateChangeInfo[] Elements = 
            {
                new uc_StateChangeInfo (States.None, Transitions.None, NvtActions.None),
            };
        
            public uc_StateChangeEvents ()
            {
                //prntSome.printSome("uc_StateChangeEvents");
            }
        
            public System.Boolean GetStateChangeAction (
                    States      State, 
                    Transitions Transition,
                ref NvtActions  NextAction)
            {
                //prntSome.printSome("GetStateChangeAction");
                uc_StateChangeInfo Element;
        
                for (System.Int32 i = 0; i < Elements.Length; i++)
                {
                    Element = Elements[i];
        
                    if (State      == Element.State &&
                        Transition == Element.Transition)
                    {
                        NextAction = Element.NextAction;
                        return true;
                    }
                }
                    
                return false;
            } 
        }
    
        private struct uc_CharEventInfo
        {
            public States        CurState;
            public System.Char   CharFrom;
            public System.Char   CharTo;
            public NvtActions    NextAction;
            public States        NextState;  // the next state we are going to 
        
            public uc_CharEventInfo (
                States  p1,
                System.Char   p2,
                System.Char   p3,
                NvtActions    p4,
                States  p5)
            {
                //prntSome.printSome("uc_CharEventInfo");
                this.CurState   = p1;
                this.CharFrom   = p2;
                this.CharTo     = p3;
                this.NextAction = p4;
                this.NextState  = p5;
            }
        }
        
        private class uc_CharEvents 
        {
            public System.Boolean GetStateEventAction (
                States         CurState, 
                System.Char    CurChar, 
                ref States     NextState,
                ref NvtActions NextAction)
            {
                //prntSome.printSome("GetStateEventAction");
                uc_CharEventInfo Element;

                for (System.Int32 i = 0; i < uc_CharEvents.Elements.Length; i++)
                {
                    Element = uc_CharEvents.Elements[i];        
                    if (CurChar  >= Element.CharFrom &&
                        CurChar  <= Element.CharTo   &&
                        (CurState == Element.CurState || Element.CurState == States.Anywhere))
                    {
                        NextState  = Element.NextState;
                        NextAction = Element.NextAction;

                        return true;
                    }
                }
                    
                return false;
            }

            public uc_CharEvents ()
            {
                //prntSome.printSome("uc_CharEvents");
            }

            public static uc_CharEventInfo[] Elements = 
            {
                new uc_CharEventInfo (States.Ground,       (char) 000, (char) 254, NvtActions.SendUp,     States.None),
                new uc_CharEventInfo (States.Ground,       (char) 255, (char) 255, NvtActions.None,       States.Command),
                new uc_CharEventInfo (States.Command,      (char) 000, (char) 239, NvtActions.SendUp,     States.Ground),
                new uc_CharEventInfo (States.Command,      (char) 240, (char) 241, NvtActions.None,       States.Ground),
                new uc_CharEventInfo (States.Command,      (char) 242, (char) 249, NvtActions.Execute,    States.Ground),
                new uc_CharEventInfo (States.Command,      (char) 250, (char) 250, NvtActions.NewCollect, States.SubNegotiate),
                new uc_CharEventInfo (States.Command,      (char) 251, (char) 254, NvtActions.NewCollect, States.Negotiate),
                new uc_CharEventInfo (States.Command,      (char) 255, (char) 255, NvtActions.SendUp,     States.Ground),
                new uc_CharEventInfo (States.SubNegotiate, (char) 000, (char) 255, NvtActions.Collect,    States.SubNegValue),
                new uc_CharEventInfo (States.SubNegValue,  (char) 000, (char) 001, NvtActions.Collect,    States.SubNegParam),
                new uc_CharEventInfo (States.SubNegValue,  (char) 002, (char) 255, NvtActions.None,       States.Ground),
                new uc_CharEventInfo (States.SubNegParam,  (char) 000, (char) 254, NvtActions.Param,      States.None),
                new uc_CharEventInfo (States.SubNegParam,  (char) 255, (char) 255, NvtActions.None,       States.SubNegEnd),
                new uc_CharEventInfo (States.SubNegEnd,    (char) 000, (char) 239, NvtActions.None,       States.Ground),
                new uc_CharEventInfo (States.SubNegEnd,    (char) 240, (char) 240, NvtActions.Dispatch,   States.Ground),
                new uc_CharEventInfo (States.SubNegEnd,    (char) 241, (char) 254, NvtActions.None,       States.Ground),
                new uc_CharEventInfo (States.SubNegEnd,    (char) 255, (char) 255, NvtActions.Param,      States.SubNegParam),
                new uc_CharEventInfo (States.Negotiate,    (char) 000, (char) 255, NvtActions.Dispatch,   States.Ground),
            };
        }
    }
}




