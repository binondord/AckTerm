public partial class ackterm
{
    private class uc_Mode
    {
        public static System.UInt32 Locked          = 1;           // Unlocked           = off 
        public static System.UInt32 BackSpace       = 2;           // Delete             = off 
        public static System.UInt32 NewLine         = 4;           // Line Feed          = off 
        public static System.UInt32 Repeat          = 8;           // No Repeat          = off 
        public static System.UInt32 AutoWrap        = 16;          // No AutoWrap        = off 
        public static System.UInt32 CursorAppln     = 32;          // Std Cursor Codes   = off 
        public static System.UInt32 KeypadAppln     = 64;          // Std Numeric Codes  = off 
        public static System.UInt32 DataProcessing  = 128;         // Typewriter         = off 
        public static System.UInt32 PositionReports = 256;         // CharacterCodes     = off
        public static System.UInt32 LocalEchoOff    = 512;         // LocalEchoOn        = off
        public static System.UInt32 OriginRelative  = 1024;        // OriginAbsolute     = off
        public static System.UInt32 LightBackground = 2048;        // DarkBackground     = off
        public static System.UInt32 National        = 4096;        // Multinational      = off
        public static System.UInt32 Any             = 0x80000000;  // Any Flags

        public System.UInt32 Flags;

        public uc_Mode (System.UInt32 InitialFlags)
        {
            //prntSome.printSome("uc_Mode w/ args");
            this.Flags = InitialFlags;
        } 

        public uc_Mode ()
        {
            //prntSome.printSome("uc_Mode");
            this.Flags = 0;
            this.Flags = this.Flags | uc_Mode.AutoWrap;
        } 
    }

    private delegate void KeyboardEventHandler (object Sender, System.String e, System.Boolean b);

    private class uc_Keyboard 
    {
        public event KeyboardEventHandler KeyboardEvent;

        private System.Boolean LastKeyDownSent  = false; // next WM_CHAR ignored if true 
        private bool AltIsDown    = false;
        private bool ShiftIsDown  = false;
        private bool CtrlIsDown   = false;

        private TermWindow Parent;
    
        private uc_KeyMap KeyMap = new uc_KeyMap ();
    
        public uc_Keyboard (TermWindow p1)
        {
            //prntSome.printSome("uc_Keyboard");
            this.Parent = p1;
        }
    
        public void KeyDown (System.Windows.Forms.Message KeyMess)
        {
            //prntSome.printSome("KeyDown");
            System.Byte[] lBytes;
            System.Byte[] wBytes;
            System.UInt16 KeyValue    = 0; 
            System.UInt16 RepeatCount = 0; 
            System.Byte   ScanCode    = 0; 
            System.Byte   AnsiChar    = 0;
            System.UInt16 UniChar     = 0;
            System.Byte   Flags       = 0;
    
    


            lBytes = System.BitConverter.GetBytes (KeyMess.LParam.ToInt32 ());
            wBytes = System.BitConverter.GetBytes (KeyMess.WParam.ToInt32 ());
            RepeatCount = System.BitConverter.ToUInt16 (lBytes, 0);
            ScanCode    = lBytes[2];
            Flags       = lBytes[3];
    
            // key down messages send the scan code in wParam whereas
            // key press messages send the char and unicode values in this word
            if (KeyMess.Msg == WMCodes.WM_SYSKEYDOWN ||
                KeyMess.Msg == WMCodes.WM_KEYDOWN)
            {
                KeyValue = System.BitConverter.ToUInt16 (wBytes, 0);
    
                // set the key down flags. I know you can get alt from lparam flags
                // but this feels more consistent
                switch (KeyValue)
                {
                    case 16:  // Shift Keys
                    case 160: // L Shift Key
                    case 161: // R Shift Keys
                        this.ShiftIsDown = true;
                        return;
    
                    case 17:  // Ctrl Keys
                    case 162: // L Ctrl Key
                    case 163: // R Ctrl Key
                        this.CtrlIsDown = true; 
                        return;
    
                    case 18:  // Alt Keys (Menu)
                    case 164: // L Alt Key
                    case 165: // R Ctrl Key
                        this.AltIsDown = true; 
                        return;
    
                    default:
                        break;
                }
    
                System.String Modifier = "Key";
    
                if (this.ShiftIsDown)
                {
                    Modifier = "Shift"; 
                }
                else if (this.CtrlIsDown)
                {
                    Modifier = "Ctrl";
                } 
                else if (this.AltIsDown)
                {
                    Modifier = "Alt"; 
                }
    
                // the key pressed was not a modifier so check for an override string
                System.String OutString = KeyMap.Find (ScanCode, System.Convert.ToBoolean (Flags & 0x01), Modifier, Parent.Modes.Flags);

                this.LastKeyDownSent = false;

                if (OutString != "")
                {
                    // Flag the event so that the associated WM_CHAR event (if any) is ignored
                    this.LastKeyDownSent = true;

                    
                    //Parent.NvtParser.ParseString (OutString); 
                    //this.Parent.Invalidate ();
                    

                    KeyboardEvent (this, OutString, true); 
                } 
    
            }
            else if (KeyMess.Msg == WMCodes.WM_SYSKEYUP ||
                    KeyMess.Msg == WMCodes.WM_KEYUP)
            {
                KeyValue = System.BitConverter.ToUInt16 (wBytes, 0);
    
                switch (KeyValue)
                {
                    case 16:  // Shift Keys
                    case 160: // L Shift Key
                    case 161: // R Shift Keys
                        this.ShiftIsDown = false; 
                        break;
    
                    case 17:  // Ctrl Keys
                    case 162: // L Ctrl Key
                    case 163: // R Ctrl Key
                        this.CtrlIsDown = false; 
                        break;
    
                    case 18:  // Alt Keys (Menu)
                    case 164: // L Alt Key
                    case 165: // R Ctrl Key
                        this.AltIsDown = false; 
                        break;
    
                    default:
                        break;
                }
            }
    
            else if (KeyMess.Msg == WMCodes.WM_SYSCHAR ||
                     KeyMess.Msg == WMCodes.WM_CHAR)
            {
                AnsiChar    = wBytes[0];
                UniChar     = System.BitConverter.ToUInt16 (wBytes, 0);
    
    
                // if there's a string mapped to this key combo we want to ignore the character
                // as it has been overriden in the keydown event
    
                // only send the windows generated char if there was no custom
                // string sent by the keydown event
                if (this.LastKeyDownSent == false)
                {
                    // send the character straight to the host if we haven't already handled the actual key press
                    KeyboardEvent (this, System.Convert.ToChar (AnsiChar).ToString (), true); 
                }
            }

            //prntSome.printSome(System.String.Format("AnsiChar = {0} Result = {1} ScanCode = {2} KeyValue = {3} Flags = {4} Repeat = {5} KeyMess.Msg = {6}\n ",
            //    AnsiChar, KeyMess.Result, ScanCode, KeyValue, Flags, RepeatCount, KeyMess.Msg), "KeyDown", countkeyrdb);
            //countkeyrdb++;

            //System.Console.Write ("AnsiChar = {0} Result = {1} ScanCode = {2} KeyValue = {3} Flags = {4} Repeat = {5}\n ", 
              //  AnsiChar, KeyMess.Result, ScanCode, KeyValue, Flags, RepeatCount);
        }
    
        private class uc_KeyInfo
        {
            public System.UInt16  ScanCode;
            public System.Boolean ExtendFlag;
            public System.String  Modifier;
            public System.String  OutString;
            public System.UInt32  Flag;
            public System.UInt32  FlagValue;
        
            public uc_KeyInfo (
                System.UInt16  p1,
                System.Boolean p2,
                System.String  p3,
                System.String  p4,
                System.UInt32  p5,
                System.UInt32  p6)
            {
                //prntSome.printSome("uc_KeyInfo");
                ScanCode    = p1;
                ExtendFlag  = p2;
                Modifier    = p3;
                OutString   = p4;
                Flag        = p5;
                FlagValue   = p6;
            }
        }

        private class uc_KeyMap
        {
            //public System.Collections.ArrayList Elements = new System.Collections.ArrayList ();
            public System.Collections.Generic.List<uc_KeyInfo> Elements = new System.Collections.Generic.List<uc_KeyInfo>();
        
            public uc_KeyMap () 
            {
                //prntSome.printSome("uc_KeyMap");
                this.SetToDefault ();
            }
        
            // set the key mapping up to emulate most keys on a vt420
            public void SetToDefault ()
            {
                //prntSome.printSome("SetToDefault");
                // add the default key mappings here
                Elements.Clear ();
        
                // TOPNZ Customisations these should be commented out
                //Elements.Add (new uc_KeyInfo (15,  false, "Shift", "\x1B[OI~", uc_Mode.Any,       0)); //ShTab
                //Elements.Add (new uc_KeyInfo (63,  false, "Key",   "\x1BOT",   uc_Mode.Any,       0)); //F5
                //Elements.Add (new uc_KeyInfo (64,  false, "Key",   "\x1BOU",   uc_Mode.Any,       0)); //F6
                //Elements.Add (new uc_KeyInfo (65,  false, "Key",   "\x1BOV",   uc_Mode.Any,       0)); //F7
                //Elements.Add (new uc_KeyInfo (66,  false, "Key",   "\x1BOW",   uc_Mode.Any,       0)); //F8
                //Elements.Add (new uc_KeyInfo (67,  false, "Key",   "\x1BOX",   uc_Mode.Any,       0)); //F9
                //Elements.Add (new uc_KeyInfo (68,  false, "Key",   "\x1BOY",   uc_Mode.Any,       0)); //F10
                //Elements.Add (new uc_KeyInfo (59,  false, "Shift", "\x1B[25~", uc_Mode.Any,       0)); //ShF1
                //Elements.Add (new uc_KeyInfo (60,  false, "Shift", "\x1B[26~", uc_Mode.Any,       0)); //ShF2
                //Elements.Add (new uc_KeyInfo (61,  false, "Shift", "\x1B[28~", uc_Mode.Any,       0)); //ShF3
                //Elements.Add (new uc_KeyInfo (62,  false, "Shift", "\x1B[29~", uc_Mode.Any,       0)); //ShF4
                //Elements.Add (new uc_KeyInfo (63,  false, "Shift", "\x1B[31~", uc_Mode.Any,       0)); //ShF5
                //Elements.Add (new uc_KeyInfo (64,  false, "Shift", "\x1B[32~", uc_Mode.Any,       0)); //ShF6
                //Elements.Add (new uc_KeyInfo (65,  false, "Shift", "\x1B[33~", uc_Mode.Any,       0)); //ShF7
                //Elements.Add (new uc_KeyInfo (66,  false, "Shift", "\x1B[34~", uc_Mode.Any,       0)); //ShF8
                //Elements.Add (new uc_KeyInfo (67,  false, "Shift", "\x1B[36~", uc_Mode.Any,       0)); //ShF9
                //Elements.Add (new uc_KeyInfo (68,  false, "Shift", "\x1B[37~", uc_Mode.Any,       0)); //ShF10
                //Elements.Add (new uc_KeyInfo (87,  false, "Shift", "\x1B[38~", uc_Mode.Any,       0)); //ShF11
                //Elements.Add (new uc_KeyInfo (88,  false, "Shift", "\x1B[39~", uc_Mode.Any,       0)); //ShF12


                // this is the initial list of keyboard codes
                //ANSI
                /**/
                Elements.Add (new uc_KeyInfo (15,  false, "Shift", "\x1B[Z",   uc_Mode.Any,         0)); //ShTab
                Elements.Add (new uc_KeyInfo (28,  false, "Key",   "\x0D",     uc_Mode.Any,         0)); //Return
                Elements.Add (new uc_KeyInfo (59,  false, "Key",   "\x1B[M",  uc_Mode.Any,         0)); //F1->PF1
                Elements.Add (new uc_KeyInfo (60,  false, "Key",   "\x1B[N",  uc_Mode.Any,         0)); //F2->PF2
                Elements.Add (new uc_KeyInfo (61,  false, "Key",   "\x1B[O",  uc_Mode.Any,         0)); //F3->PF3
                Elements.Add (new uc_KeyInfo (62,  false, "Key",   "\x1B[P",  uc_Mode.Any,         0)); //F4->PF4
                Elements.Add (new uc_KeyInfo (63,  false, "Key",   "\x1B[Q", uc_Mode.Any,          0)); //F5
                Elements.Add (new uc_KeyInfo (64,  false, "Key",   "\x1B[R", uc_Mode.Any,          0)); //F6
                Elements.Add (new uc_KeyInfo (65,  false, "Key",   "\x1B[S", uc_Mode.Any,          0)); //F7
                Elements.Add (new uc_KeyInfo (66,  false, "Key",   "\x1B[T", uc_Mode.Any,          0)); //F8
                Elements.Add (new uc_KeyInfo (67,  false, "Key",   "\x1B[U", uc_Mode.Any,          0)); //F9
                Elements.Add (new uc_KeyInfo (68,  false, "Key",   "\x1B[V", uc_Mode.Any,          0)); //F10
                Elements.Add (new uc_KeyInfo (87,  false, "Key",   "\x1B[W", uc_Mode.Any,          0)); //F11
                Elements.Add (new uc_KeyInfo (88,  false, "Key",   "\x1B[X", uc_Mode.Any,          0)); //F12
                Elements.Add (new uc_KeyInfo (59,  false, "Shift", "\x1B[Y", uc_Mode.Any,          0)); //ShF1 ->F13
                Elements.Add (new uc_KeyInfo (60,  false, "Shift", "\x1B[Z", uc_Mode.Any,          0)); //ShF2 ->F14
                Elements.Add (new uc_KeyInfo (61,  false, "Shift", "\x1B[a", uc_Mode.Any,          0)); //ShF3 ->F15
                Elements.Add (new uc_KeyInfo (62,  false, "Shift", "\x1B[b", uc_Mode.Any,          0)); //ShF4 ->F16
                Elements.Add (new uc_KeyInfo (63,  false, "Shift", "\x1B[c", uc_Mode.Any,          0)); //ShF5 ->F17
                Elements.Add (new uc_KeyInfo (64,  false, "Shift", "\x1B[d", uc_Mode.Any,          0)); //ShF6 ->F18
                Elements.Add (new uc_KeyInfo (65,  false, "Shift", "\x1B[e", uc_Mode.Any,          0)); //ShF7 ->F19
                Elements.Add (new uc_KeyInfo (66,  false, "Shift", "\x1B[f", uc_Mode.Any,          0)); //ShF8 ->F20
                Elements.Add (new uc_KeyInfo (67,  false, "Shift", "\x1B[g", uc_Mode.Any,          0)); //ShF9 ->F21
                Elements.Add (new uc_KeyInfo (68,  false, "Shift", "\x1B[h", uc_Mode.Any,          0)); //ShF10->F22
                Elements.Add (new uc_KeyInfo (87,  false, "Shift", "\x1B[i", uc_Mode.Any,          0)); //ShF11->F23
                Elements.Add (new uc_KeyInfo (88,  false, "Shift", "\x1B[j", uc_Mode.Any,          0)); //ShF12->F24
                Elements.Add (new uc_KeyInfo (71,  true,  "Key",   "\x1B[H",  uc_Mode.Any,         0)); //Home
                Elements.Add (new uc_KeyInfo (82,  true,  "Key",   "\x1B[I",  uc_Mode.Any,         0)); //Insert
                Elements.Add (new uc_KeyInfo (83,  true,  "Key",   "\x1B[J",  uc_Mode.Any,         0)); //Delete
                Elements.Add (new uc_KeyInfo (79,  true,  "Key",   "\x1B[F",  uc_Mode.Any,         0)); //End
                Elements.Add (new uc_KeyInfo (73,  true,  "Key",   "\x1B[E",  uc_Mode.Any,         0)); //PageUp
                Elements.Add (new uc_KeyInfo (81,  true,  "Key",   "\x1B[G",  uc_Mode.Any,         0)); //PageDown
                Elements.Add (new uc_KeyInfo (72,  true,  "Key",   "\x1B[A",   uc_Mode.CursorAppln, 0)); //CursorUp
                Elements.Add (new uc_KeyInfo (80,  true,  "Key",   "\x1B[B",   uc_Mode.CursorAppln, 0)); //CursorDown
                Elements.Add (new uc_KeyInfo (77,  true,  "Key",   "\x1B[C",   uc_Mode.CursorAppln, 0)); //CursorKeyRight
                Elements.Add (new uc_KeyInfo (75,  true,  "Key",   "\x1B[D",   uc_Mode.CursorAppln, 0)); //CursorKeyLeft
                Elements.Add (new uc_KeyInfo (72,  true,  "Key",   "\x1B[K",   uc_Mode.CursorAppln, 1)); //CursorUp
                Elements.Add (new uc_KeyInfo (80,  true,  "Key",   "\x1B[L",   uc_Mode.CursorAppln, 1)); //CursorDown
                Elements.Add (new uc_KeyInfo (77,  true,  "Key",   "\x1BOC",   uc_Mode.CursorAppln, 1)); //CursorKeyRight
                Elements.Add (new uc_KeyInfo (75,  true,  "Key",   "\x1BOD",   uc_Mode.CursorAppln, 1)); //CursorKeyLeft
                Elements.Add (new uc_KeyInfo (82,  false, "Key",   "\x1BOp",   uc_Mode.KeypadAppln, 1)); //Keypad0
                Elements.Add (new uc_KeyInfo (79,  false, "Key",   "\x1BOq",   uc_Mode.KeypadAppln, 1)); //Keypad1
                Elements.Add (new uc_KeyInfo (80,  false, "Key",   "\x1BOr",   uc_Mode.KeypadAppln, 1)); //Keypad2
                Elements.Add (new uc_KeyInfo (81,  false, "Key",   "\x1BOs",   uc_Mode.KeypadAppln, 1)); //Keypad3
                Elements.Add (new uc_KeyInfo (75,  false, "Key",   "\x1BOt",   uc_Mode.KeypadAppln, 1)); //Keypad4
                Elements.Add (new uc_KeyInfo (76,  false, "Key",   "\x1BOu",   uc_Mode.KeypadAppln, 1)); //Keypad5
                Elements.Add (new uc_KeyInfo (77,  false, "Key",   "\x1BOv",   uc_Mode.KeypadAppln, 1)); //Keypad6
                Elements.Add (new uc_KeyInfo (71,  false, "Key",   "\x1BOw",   uc_Mode.KeypadAppln, 1)); //Keypad7
                Elements.Add (new uc_KeyInfo (72,  false, "Key",   "\x1BOx",   uc_Mode.KeypadAppln, 1)); //Keypad8
                Elements.Add (new uc_KeyInfo (73,  false, "Key",   "\x1BOy",   uc_Mode.KeypadAppln, 1)); //Keypad9
                Elements.Add (new uc_KeyInfo (74,  false, "Key",   "\x1BOm",   uc_Mode.KeypadAppln, 1)); //Keypad-
                Elements.Add (new uc_KeyInfo (78,  false, "Key",   "\x1BOl",   uc_Mode.KeypadAppln, 1)); //Keypad+ (use instead of comma)
                Elements.Add (new uc_KeyInfo (83,  false, "Key",   "\x1BOn",   uc_Mode.KeypadAppln, 1)); //Keypad.
                Elements.Add (new uc_KeyInfo (28,  true,  "Key",   "\x1BOM",   uc_Mode.KeypadAppln, 1)); //Keypad Enter
                Elements.Add (new uc_KeyInfo (03,  false, "Ctrl",  "\x00",     uc_Mode.Any,         0)); //Ctrl2->Null
                Elements.Add (new uc_KeyInfo (57,  false, "Ctrl",  "\x00",     uc_Mode.Any,         0)); //CtrlSpaceBar->Null
                Elements.Add (new uc_KeyInfo (04,  false, "Ctrl",  "\x1B",     uc_Mode.Any,         0)); //Ctrl3->Escape
                Elements.Add (new uc_KeyInfo (05,  false, "Ctrl",  "\x1C",     uc_Mode.Any,         0)); //Ctrl4->FS
                Elements.Add (new uc_KeyInfo (06,  false, "Ctrl",  "\x1D",     uc_Mode.Any,         0)); //Ctrl5->GS
                Elements.Add (new uc_KeyInfo (07,  false, "Ctrl",  "\x1E",     uc_Mode.Any,         0)); //Ctrl6->RS
                Elements.Add (new uc_KeyInfo (08,  false, "Ctrl",  "\x1F",     uc_Mode.Any,         0)); //Ctrl7->US
                Elements.Add (new uc_KeyInfo (09,  false, "Ctrl",  "\x7F",     uc_Mode.Any,         0)); //Ctrl8->DEL
                /**/

                /*VT220*/
                /*
                Elements.Add (new uc_KeyInfo (15,  false, "Shift", "\x1B[Z",   uc_Mode.Any,         0)); //ShTab
                Elements.Add (new uc_KeyInfo (28,  false, "Key",   "\x0D",     uc_Mode.Any,         0)); //Return
                Elements.Add (new uc_KeyInfo (59,  false, "Key",   "\x1BOP",   uc_Mode.Any,         0)); //F1->PF1
                Elements.Add (new uc_KeyInfo (60,  false, "Key",   "\x1BOQ",   uc_Mode.Any,         0)); //F2->PF2
                Elements.Add (new uc_KeyInfo (61,  false, "Key",   "\x1BOR",   uc_Mode.Any,         0)); //F3->PF3
                Elements.Add (new uc_KeyInfo (62,  false, "Key",   "\x1BOS",   uc_Mode.Any,         0)); //F4->PF4
                //Elements.Add (new uc_KeyInfo (63,  false, "Key",   "\x1B[15~", uc_Mode.Any,         0)); //F5
                Elements.Add (new uc_KeyInfo (63,  false, "Key",   "\x1B[17~", uc_Mode.Any,         0)); //F5
                Elements.Add (new uc_KeyInfo (64,  false, "Key",   "\x1B[18~", uc_Mode.Any,         0)); //F6
                Elements.Add (new uc_KeyInfo (65,  false, "Key",   "\x1B[19~", uc_Mode.Any,         0)); //F7
                Elements.Add (new uc_KeyInfo (66,  false, "Key",   "\x1B[20~", uc_Mode.Any,         0)); //F8
                Elements.Add (new uc_KeyInfo (67,  false, "Key",   "\x1B[21~", uc_Mode.Any,         0)); //F9
                Elements.Add (new uc_KeyInfo (68,  false, "Key",   "\x1B[29~", uc_Mode.Any,         0)); //F10
                Elements.Add (new uc_KeyInfo (87,  false, "Key",   "\x1B[30~", uc_Mode.Any,         0)); //F11
                Elements.Add (new uc_KeyInfo (88,  false, "Key",   "\x1B[31~", uc_Mode.Any,         0)); //F12
                Elements.Add (new uc_KeyInfo (61,  false, "Shift", "\x1B[25~", uc_Mode.Any,         0)); //ShF3 ->F13
                Elements.Add (new uc_KeyInfo (62,  false, "Shift", "\x1B[26~", uc_Mode.Any,         0)); //ShF4 ->F14
                Elements.Add (new uc_KeyInfo (63,  false, "Shift", "\x1B[28~", uc_Mode.Any,         0)); //ShF5 ->F15
                Elements.Add (new uc_KeyInfo (64,  false, "Shift", "\x1B[29~", uc_Mode.Any,         0)); //ShF6 ->F16
                Elements.Add (new uc_KeyInfo (65,  false, "Shift", "\x1B[31~", uc_Mode.Any,         0)); //ShF7 ->F17
                Elements.Add (new uc_KeyInfo (66,  false, "Shift", "\x1B[32~", uc_Mode.Any,         0)); //ShF8 ->F18
                Elements.Add (new uc_KeyInfo (67,  false, "Shift", "\x1B[33~", uc_Mode.Any,         0)); //ShF9 ->F19
                Elements.Add (new uc_KeyInfo (68,  false, "Shift", "\x1B[34~", uc_Mode.Any,         0)); //ShF10->F20
                Elements.Add (new uc_KeyInfo (87,  false, "Shift", "\x1B[28~", uc_Mode.Any,         0)); //ShF11->Help
                Elements.Add (new uc_KeyInfo (88,  false, "Shift", "\x1B[29~", uc_Mode.Any,         0)); //ShF12->Do
                Elements.Add (new uc_KeyInfo (71,  true,  "Key",   "\x1B[1~",  uc_Mode.Any,         0)); //Home
                Elements.Add (new uc_KeyInfo (82,  true,  "Key",   "\x1B[2~",  uc_Mode.Any,         0)); //Insert
                Elements.Add (new uc_KeyInfo (83,  true,  "Key",   "\x1B[3~",  uc_Mode.Any,         0)); //Delete
                Elements.Add (new uc_KeyInfo (79,  true,  "Key",   "\x1B[4~",  uc_Mode.Any,         0)); //End
                Elements.Add (new uc_KeyInfo (73,  true,  "Key",   "\x1B[5~",  uc_Mode.Any,         0)); //PageUp
                Elements.Add (new uc_KeyInfo (81,  true,  "Key",   "\x1B[6~",  uc_Mode.Any,         0)); //PageDown
                Elements.Add (new uc_KeyInfo (72,  true,  "Key",   "\x1B[A",   uc_Mode.CursorAppln, 0)); //CursorUp
                Elements.Add (new uc_KeyInfo (80,  true,  "Key",   "\x1B[B",   uc_Mode.CursorAppln, 0)); //CursorDown
                Elements.Add (new uc_KeyInfo (77,  true,  "Key",   "\x1B[C",   uc_Mode.CursorAppln, 0)); //CursorKeyRight
                Elements.Add (new uc_KeyInfo (75,  true,  "Key",   "\x1B[D",   uc_Mode.CursorAppln, 0)); //CursorKeyLeft
                Elements.Add (new uc_KeyInfo (72,  true,  "Key",   "\x1BOA",   uc_Mode.CursorAppln, 1)); //CursorUp
                Elements.Add (new uc_KeyInfo (80,  true,  "Key",   "\x1BOB",   uc_Mode.CursorAppln, 1)); //CursorDown
                Elements.Add (new uc_KeyInfo (77,  true,  "Key",   "\x1BOC",   uc_Mode.CursorAppln, 1)); //CursorKeyRight
                Elements.Add (new uc_KeyInfo (75,  true,  "Key",   "\x1BOD",   uc_Mode.CursorAppln, 1)); //CursorKeyLeft
                Elements.Add (new uc_KeyInfo (82,  false, "Key",   "\x1BOp",   uc_Mode.KeypadAppln, 1)); //Keypad0
                Elements.Add (new uc_KeyInfo (79,  false, "Key",   "\x1BOq",   uc_Mode.KeypadAppln, 1)); //Keypad1
                Elements.Add (new uc_KeyInfo (80,  false, "Key",   "\x1BOr",   uc_Mode.KeypadAppln, 1)); //Keypad2
                Elements.Add (new uc_KeyInfo (81,  false, "Key",   "\x1BOs",   uc_Mode.KeypadAppln, 1)); //Keypad3
                Elements.Add (new uc_KeyInfo (75,  false, "Key",   "\x1BOt",   uc_Mode.KeypadAppln, 1)); //Keypad4
                Elements.Add (new uc_KeyInfo (76,  false, "Key",   "\x1BOu",   uc_Mode.KeypadAppln, 1)); //Keypad5
                Elements.Add (new uc_KeyInfo (77,  false, "Key",   "\x1BOv",   uc_Mode.KeypadAppln, 1)); //Keypad6
                Elements.Add (new uc_KeyInfo (71,  false, "Key",   "\x1BOw",   uc_Mode.KeypadAppln, 1)); //Keypad7
                Elements.Add (new uc_KeyInfo (72,  false, "Key",   "\x1BOx",   uc_Mode.KeypadAppln, 1)); //Keypad8
                Elements.Add (new uc_KeyInfo (73,  false, "Key",   "\x1BOy",   uc_Mode.KeypadAppln, 1)); //Keypad9
                Elements.Add (new uc_KeyInfo (74,  false, "Key",   "\x1BOm",   uc_Mode.KeypadAppln, 1)); //Keypad-
                Elements.Add (new uc_KeyInfo (78,  false, "Key",   "\x1BOl",   uc_Mode.KeypadAppln, 1)); //Keypad+ (use instead of comma)
                Elements.Add (new uc_KeyInfo (83,  false, "Key",   "\x1BOn",   uc_Mode.KeypadAppln, 1)); //Keypad.
                Elements.Add (new uc_KeyInfo (28,  true,  "Key",   "\x1BOM",   uc_Mode.KeypadAppln, 1)); //Keypad Enter
                Elements.Add (new uc_KeyInfo (03,  false, "Ctrl",  "\x00",     uc_Mode.Any,         0)); //Ctrl2->Null
                Elements.Add (new uc_KeyInfo (57,  false, "Ctrl",  "\x00",     uc_Mode.Any,         0)); //CtrlSpaceBar->Null
                Elements.Add (new uc_KeyInfo (04,  false, "Ctrl",  "\x1B",     uc_Mode.Any,         0)); //Ctrl3->Escape
                Elements.Add (new uc_KeyInfo (05,  false, "Ctrl",  "\x1C",     uc_Mode.Any,         0)); //Ctrl4->FS
                Elements.Add (new uc_KeyInfo (06,  false, "Ctrl",  "\x1D",     uc_Mode.Any,         0)); //Ctrl5->GS
                Elements.Add (new uc_KeyInfo (07,  false, "Ctrl",  "\x1E",     uc_Mode.Any,         0)); //Ctrl6->RS
                Elements.Add (new uc_KeyInfo (08,  false, "Ctrl",  "\x1F",     uc_Mode.Any,         0)); //Ctrl7->US
                Elements.Add (new uc_KeyInfo (09,  false, "Ctrl",  "\x7F",     uc_Mode.Any,         0)); //Ctrl8->DEL
                */
            }
        
            public System.String Find (
                System.UInt16  ScanCode, 
                System.Boolean ExtendFlag, 
                System.String  Modifier,
                System.UInt32  ModeFlags)
            {
                //prntSome.printSome("Find");
                System.String OutString = "";
        
                for (int i=0; i < Elements.Count; i++)
                {
                    uc_KeyInfo Element = Elements[i];
        
                    if (Element.ScanCode      == ScanCode   && 
                        Element.ExtendFlag    == ExtendFlag &&
                        Element.Modifier      == Modifier   &&
                        (Element.Flag == uc_Mode.Any ||
                         ((Element.Flag & ModeFlags) ==  Element.Flag && Element.FlagValue == 1) ||
                         ((Element.Flag & ModeFlags) ==  0            && Element.FlagValue == 0)))
                    {
                        //prntSome.printSome(string.Format("scancode: {0}\nExtendFlag: {1}\nModifier: {2}\nFlag: {3}\nFlagValue{4}\n",Element.ScanCode, Element.ExtendFlag, Element.Modifier,Element.Flag,Element.FlagValue), "kb", countkuprdb);
                        //countkuprdb++;
                        OutString = Element.OutString;
                        return OutString;
                    }
                }
        
                return OutString;
            }
        }
    }
}




