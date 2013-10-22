public partial class ackterm
{
    public static int countrdb = 0;
    public static int countbmprdb = 0;
    public static int counttxtscrnrdb = 0;
    public static int countkeyrdb = 0;
    public static int countdispatchrdb = 0;
    public static int countmontdisrdb = 0;

    public static int counttelint = 0;

    public static int countkuprdb = 0;
    public static int countkdownrdb = 0;
    public static int countkpressrdb = 0;
    public static System.Drawing.Bitmap bmp;
    public static System.Text.StringBuilder sb = new System.Text.StringBuilder(20000);
    public static System.Text.StringBuilder rdbsb = new System.Text.StringBuilder(20000);
    public static System.Text.StringBuilder rdbsb1 = new System.Text.StringBuilder(20000);
    public static System.Text.StringBuilder rdbmsg = new System.Text.StringBuilder(20000);

    

    public static class prntSome{

        public static void initstring()
        {
            int cap = 200 * 100;
            sb = new System.Text.StringBuilder(cap);
        }

        public static void add2stringrdb(System.String mystring)
        {
            sb.Append(mystring);
        }

        public static void destroyString()
        {
            sb = null;
        }
        
        public static void printSome(string something, string fnamerdb = "somethings", int cntrdb = 0)
        {
            //countrdb++;
            /********/
            System.String rdbfile = "c:\\app\\log\\" + fnamerdb + cntrdb + ".txt";
            if (System.IO.File.Exists(rdbfile))
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(rdbfile, true))
                {
                    //file.WriteLine("start-------" + countrdb + "------------------------------------------------------------------------------------");
                    file.Write(something);
                    //file.WriteLine("end-------------------------------------------------------------------------------------------------------start");
                    file.Close();
                }

            }
            else
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(rdbfile))
                {
                    //file.WriteLine("start-------" + countrdb + "-------------------------------------------------------------------------------");
                    file.Write(something);
                    //file.WriteLine("end----------------------------------------------------------------------------------------------------------start");
                    file.Close();
                }
            }
            /********/
        }
    }

    

    private partial class uc_VertScrollBar : System.Windows.Forms.VScrollBar
    {
        public uc_VertScrollBar ()
        {
            //prntSome.printSome("uc_VertScrollBar");
            this.SetStyle (System.Windows.Forms.ControlStyles.Selectable, false);
            this.Maximum = 0;
        }
    }

    private class HostWindow : System.Windows.Forms.Form
    {
        public System.Windows.Forms.TextBox HostName;
        public System.Windows.Forms.Button  OkBtn;
        public System.Windows.Forms.Button  CnBtn;

        public HostWindow ()
        {
            ////prntSome.printSome("HostWindow");
            this.Text = "Enter Host Name";
            this.Height = 200;
            this.Width  = 300;

            HostName = new System.Windows.Forms.TextBox ();
            HostName.Width  = 200;
            HostName.Left   = 50;
            HostName.Top    = 50;
            HostName.Parent = this;

            OkBtn = new System.Windows.Forms.Button ();
            OkBtn.Text = "&Ok";
            OkBtn.Left   = 75;
            OkBtn.Top    = 100;
            OkBtn.Parent = this;
            OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;

            CnBtn = new System.Windows.Forms.Button ();
            CnBtn.Text = "&Cancel";
            CnBtn.Left   = 150;
            CnBtn.Top    = 100;
            CnBtn.Parent = this;
            CnBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;

        }

    }

    private partial class TermWindow : System.Windows.Forms.Form
    {
        [System.STAThread]
        public static void Main (string[] Args)
        {
            TermWindow MainWindow = new TermWindow ();

            System.Windows.Forms.Application.Run (MainWindow);
            //System.Windows.Forms.Application.Run(testfrm);
        }

        // the main objects associated with the TermWindow
        private readonly MouseKeyboardActivityMonitor.KeyboardHookListener m_KeyboardHookManager;
        private readonly System.String frmTitleRDB = "WiSDoM";

        private WindowsFormsApplication1.settings settingsFrm;

        private System.String rdbDispatchMsg = null;

        private System.Windows.Forms.Button rdbNextBtn;
        private System.Windows.Forms.ListBox rdbListBox;
        private System.Collections.Generic.List<string> _rdbitems;
        public System.Drawing.Bitmap rdbBitmap = null;
        public System.Drawing.Graphics rdbGraphics = null;

        private readonly int txtedge = 5;
        private readonly int logwidth = 200;
        private readonly int messageheight = 150;
        private System.Drawing.Font rdbFont;

        private System.Drawing.Point mousepnt;

        private int scrnwidth = 0;
        private int scrnheight = 0;

        private System.Windows.Forms.OpenFileDialog rbdlg   = null;
        private System.Boolean               runOffline     = true;

        private uc_Parser                    Parser         = null;
        private uc_TelnetParser              NvtParser      = null;
        private uc_Keyboard                  Keyboard       = null;
        private uc_autoprocess               rdbAutoProcess = null;
        private uc_TabStops                  TabStops       = null;
        private System.Drawing.Bitmap        EraseBitmap    = null;
        private System.Drawing.Graphics      EraseBuffer    = null;
        public System.Char[][]              CharGrid       = null;
        public CharAttribs[][] AttribGrid = null;
        private CharAttribs                  CharAttribs;

        private System.Int32                 Columns;
        private System.Int32                 Rows;
        private System.Int32                 TopMargin;
        private System.Int32                 BottomMargin;
        private System.String                TypeFace      = "Courier New";
        private System.Drawing.FontStyle     TypeStyle     = System.Drawing.FontStyle.Regular;
        private System.Int32                 TypeSize      = 13;
        private System.Drawing.Size          CharSize;
        private System.Int32                 UnderlinePos; 
        public uc_Caret                     Caret;
        private System.Collections.Generic.List<uc_CaretAttribs> SavedCarets;
        private System.Drawing.Point         DrawStringOffset;
        private System.Drawing.Color         FGColor;
        private System.Drawing.Color         BoldColor;
        private System.Drawing.Color         BlinkColor;

        private uc_Chars                     G0;
        private uc_Chars                     G1;
        private uc_Chars                     G2;
        private uc_Chars                     G3;
        public  uc_Mode                      Modes;
        private uc_VertScrollBar             VertScrollBar;

        private delegate void RxdDataLoadedHander();
        private event RxdDataLoadedHander RxdDataLoaded;

        private delegate void RefreshEventHandler ();
        private event RefreshEventHandler RefreshEvent;

        private delegate void RxdTextEventHandler (System.String sReceived);
        private event RxdTextEventHandler RxdTextEvent;

        private delegate void CaretOffEventHandler ();
        private event CaretOffEventHandler CaretOffEvent;

        private delegate void CaretOnEventHandler ();
        private event CaretOnEventHandler CaretOnEvent;

        private bool hasFocusrdb = false;

        public TermWindow ()
        {
            m_KeyboardHookManager = new MouseKeyboardActivityMonitor.KeyboardHookListener(new MouseKeyboardActivityMonitor.WinApi.GlobalHooker());
            m_KeyboardHookManager.Enabled = true;

            ////prntSome.printSome("TermWindow");
            // set the display options
            this.SetStyle (
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint|
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);

            this.settingsFrm    = new WindowsFormsApplication1.settings();
            this.runOffline     = true;
            this.Keyboard       = new uc_Keyboard (this);
            this.Parser         = new uc_Parser   ();
            this.NvtParser      = new uc_TelnetParser   ();
            this.Caret          = new uc_Caret    ();
            this.Modes          = new uc_Mode ();
            this.TabStops       = new uc_TabStops ();
            this.SavedCarets    = new System.Collections.Generic.List<uc_CaretAttribs> ();

            this.Name       = this.frmTitleRDB;
            this.Text       = this.frmTitleRDB;

            this.Caret.Pos  = new System.Drawing.Point (0, 0); 
            this.CharSize   = new System.Drawing.Size ();
            this.rdbFont    = new System.Drawing.Font(this.TypeFace, this.TypeSize, this.TypeStyle);
            this.Font       = this.rdbFont;
            this.mousepnt   = new System.Drawing.Point();

            this.FGColor      = System.Drawing.Color.FromArgb (200, 200, 200);
            this.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);//(0,0,160);
            this.BoldColor    = System.Drawing.Color.FromArgb (255, 255, 255);
            this.BlinkColor   = System.Drawing.Color.Red;

            this.G0 = new uc_Chars (uc_Chars.Sets.ASCII);
            this.G1 = new uc_Chars (uc_Chars.Sets.ASCII);
            this.G2 = new uc_Chars (uc_Chars.Sets.DECSG);
            this.G3 = new uc_Chars (uc_Chars.Sets.DECSG);

            this.CharAttribs.GL = G0;
            this.CharAttribs.GR = G2;
            this.CharAttribs.GS = null;

            this.GetFontInfo ();

            // Create and initialize a VScrollBar.
            VertScrollBar = new uc_VertScrollBar();

            // Dock the scroll bar to the right side of the form.
            VertScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
    
            // Add the scroll bar to the form.
            //Controls.Add (VertScrollBar);

            this.CreateMenu ();

            // create the character grid (rows by columns). This is a shadow of what's displayed
            // Set the window size to match
            this.SetSize (25, 80);

            this.rdbAutoProcess = new uc_autoprocess(this.Rows, this.Columns, this);

            this.Parser.ParserEvent       += new ParserEventHandler    (CommandRouter);
            this.Keyboard.KeyboardEvent   += new KeyboardEventHandler  (DispatchMessage);
            this.NvtParser.NvtParserEvent += new NvtParserEventHandler (TelnetInterpreter);
            this.RefreshEvent             += new RefreshEventHandler   (ShowBuffer);
            this.RxdDataLoaded            += new RxdDataLoadedHander   (StartAutoProcess);
            this.CaretOffEvent            += new CaretOffEventHandler  (this.CaretOff);
            this.CaretOnEvent             += new CaretOnEventHandler   (this.CaretOn);
            this.RxdTextEvent             += new RxdTextEventHandler   (this.NvtParser.ParseString);

            //rdb
            //this.OnClickConnect (new System.Object (), new System.EventArgs ());
            //endrdb
            this.rbdlg = new System.Windows.Forms.OpenFileDialog();
            this.rbdlg.Multiselect = false;

            this.scrnwidth = this.CharSize.Width * this.Columns;
            this.scrnheight = (this.CharSize.Height * this.Rows) + this.CharSize.Height;

            /*this._rdbitems = new System.Collections.Generic.List<string>();
            this._rdbitems.Add("aaa");
            this._rdbitems.Add("bbb");
            this._rdbitems.Add("ccc");
            this.rdbListBox = new System.Windows.Forms.ListBox();
            this.rdbListBox.Top = 500;
            this.rdbListBox.Left = 500;
            this.rdbListBox.DataSource = this._rdbitems;
            this.Controls.Add(this.rdbListBox);

            this.rdbNextBtn = new System.Windows.Forms.Button();
            this.rdbNextBtn.Text = "Next";
            this.rdbNextBtn.Location = new System.Drawing.Point(600, 500);

            this.Controls.Add(this.rdbNextBtn);*/
            //this.GotFocus += MainWindow_GotFocus;
            //this.LostFocus += MainWindow_LostFocus;
            this.CenterToScreen();
        }

        private void StartAutoProcess()
        {
            rdbsb.Clear();
            if(this.Caret.Pos.X != 0)
                rdbsb.AppendLine(this.rdbAutoProcess.start());
        }

        private void MainWindow_GotFocus(object sender, System.EventArgs e)
        {
            if (hasFocusrdb == false)
            {
                m_KeyboardHookManager.KeyDown += HookManager_KeyDown;
                m_KeyboardHookManager.KeyUp += HookManager_KeyUp;
                m_KeyboardHookManager.KeyPress += HookManager_KeyPress;
            }
            //System.Windows.Forms.MessageBox.Show("Got focus..");
            hasFocusrdb = true;
        }

        private void MainWindow_LostFocus(object sender, System.EventArgs e)
        {
            if (hasFocusrdb == true)
            {
                m_KeyboardHookManager.KeyDown -= HookManager_KeyDown;
                m_KeyboardHookManager.KeyUp -= HookManager_KeyUp;
                m_KeyboardHookManager.KeyPress -= HookManager_KeyPress;
            }
            hasFocusrdb = false;
        }

        private void HookManager_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //prntSome.printSome(string.Format("KeyDown \t\t {0} Alt: {1} CTRL: {2} SHIFT: {3} MOD: {4} SUP: {5}, HAND: {6}\n", e.KeyCode, e.Alt, e.Control, e.Shift, e.Modifiers, e.SuppressKeyPress, e.Handled), "kdown", countkeyrdb);
            //countkeyrdb++;
            //countkdownrdb
        }

        private void HookManager_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //prntSome.printSome(string.Format("KeyUp  \t\t {0} Alt: {1} CTRL: {2} SHIFT: {3} MOD: {4} SUP: {5}, HAND: {6}\n", e.KeyCode, e.Alt, e.Control, e.Shift, e.Modifiers, e.SuppressKeyPress, e.Handled), "kup", countkeyrdb);
            //countkuprdb++;
            //countkeyrdb++;
        }

        private void HookManager_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //prntSome.printSome(string.Format("KeyPress \t\t {0} HAND: {1}\n", e.KeyChar, e.Handled), "kpress", countkeyrdb);
            //countkpressrdb++;
            //countkeyrdb++;
        }

        protected override void OnPaint (System.Windows.Forms.PaintEventArgs e)
        {
            this.Font = this.rdbFont;
            //bmp = new System.Drawing.Bitmap(1000, 1000, e.Graphics);
            //System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bmp);
            
            e.Graphics.SmoothingMode     = System.Drawing.Drawing2D.SmoothingMode.None;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            e.Graphics.TextContrast      = 0;
            e.Graphics.PixelOffsetMode   = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

            //this.WipeScreen (g);//e.Graphics);
            //this.Redraw     (g);//e.Graphics);
            //this.ShowCaret  (g);//e.Graphics);

            //bmp.Save("c:\\temp\\aaaa\\txt" + countbmprdb + ".bmp");
            //countbmprdb++;

            //prntSome.initstring(4000);

            this.WipeScreen(e.Graphics);
            this.Redraw(e.Graphics);
            this.ShowCaret(e.Graphics);

            e.Graphics.DrawRectangle(new System.Drawing.Pen(System.Drawing.Color.OliveDrab), 0, 0, this.scrnwidth, this.scrnheight);
            e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.OliveDrab), this.scrnwidth, this.scrnheight, this.scrnwidth + this.logwidth, this.scrnheight);
            e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.OliveDrab), this.scrnwidth + this.logwidth, 0, this.scrnwidth + this.logwidth, this.scrnheight);

            rdbDrawString(e.Graphics, "MESSAGE TRAIL", 5, this.scrnheight);
            rdbDrawString(e.Graphics, "PROPERTIES", (this.scrnwidth + this.txtedge), 0);

            rdbDrawString(e.Graphics, System.String.Format("Caret x:{0} y:{1}",this.Caret.Pos.X, this.Caret.Pos.Y), this.scrnwidth + 5, this.CharSize.Height, 10);
            rdbDrawString(e.Graphics, System.String.Format( "CurPos: x:{0} y:{1}",(this.mousepnt.X/this.CharSize.Width), (this.mousepnt.Y/this.CharSize.Height)), this.scrnwidth + 5, this.CharSize.Height *2,10);
            rdbDrawString(e.Graphics, rdbsb.ToString(), this.scrnwidth + 5, this.CharSize.Height * 3, 10);
            rdbDrawString(e.Graphics, rdbsb1.ToString(), this.scrnwidth + 5, this.CharSize.Height * 14, 10);
            rdbDrawString(e.Graphics, rdbmsg.ToString(), 5, this.scrnheight + this.CharSize.Height, 10);
            //this.BackColor = System.Drawing.Color.Black;
            //bmp.Dispose();
            //bmp = null;
            rdbDrawScrnMatrix(e.Graphics);
            rdbDrawCrossHair(e.Graphics);

            base.OnPaint(e);
        }

        public void rdbDrawCrossHair(System.Drawing.Graphics rdb)
        {
            if (this.mousepnt.Y < this.scrnheight && this.mousepnt.X < this.scrnwidth)
            {
                rdb.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Cyan), this.mousepnt.X, this.mousepnt.Y, this.scrnwidth, this.mousepnt.Y);
                rdb.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Cyan), this.mousepnt.X, 0, this.mousepnt.X, this.mousepnt.Y);
                rdb.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Cyan), 0, this.mousepnt.Y, this.mousepnt.X, this.mousepnt.Y);
                rdb.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Cyan), this.mousepnt.X, this.mousepnt.Y, this.mousepnt.X, this.scrnheight);
            }
        }

        public void rdbDrawString(System.Drawing.Graphics rdb, System.String str, int x, int y, float fontsize = 13)
        {
            if (fontsize != 13)
            {
                this.Font = new System.Drawing.Font(this.TypeFace, fontsize, this.TypeStyle);
            }
            else this.Font = this.rdbFont;


            rdb.DrawString(str, this.Font, new System.Drawing.SolidBrush(System.Drawing.Color.White),
                 x - this.DrawStringOffset.X,
                 y - this.DrawStringOffset.Y);
        }

        private void rdbDrawScrnMatrix(System.Drawing.Graphics rdb)
        {
            int numxlines = this.scrnwidth / this.CharSize.Width;
            int numylines = this.scrnheight / this.CharSize.Height;
            int xpos = 0;
            int ypos = 0;
            for (int ix = 0; ix < numxlines; ix++)
            {
                xpos = this.CharSize.Width * ix;
                if(ix % 2 == 1)
                    rdbDrawString(rdb, ix.ToString(), xpos+2, this.scrnheight - (this.CharSize.Height/2), 6);
                rdb.DrawLine(new System.Drawing.Pen(System.Drawing.Color.FromArgb(0x150000FF)), xpos, 0, xpos, this.scrnheight);
            }
            for (int iy = 0; iy < numylines; iy++)
            {
                ypos = this.CharSize.Height * iy;
                rdbDrawString(rdb, iy.ToString(), this.scrnwidth - this.CharSize.Width+2, ypos, 6);
                rdb.DrawLine(new System.Drawing.Pen(System.Drawing.Color.FromArgb(0x150000FF)), 0, ypos, this.scrnwidth, ypos);
            }

            //this.rdbBitmap = new System.Drawing.Bitmap(this.CharSize.Width, this.CharSize.Height);
            //this.rdbGraphics = System.Drawing.Graphics.FromImage(this.rdbBitmap);
            //this.rdbGraphics.Clear(System.Drawing.Color.FromArgb(255, 181, 106));

            //rdb.DrawImageUnscaled(this.rdbBitmap, mousepnt.X, mousepnt.Y);
        }

        protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs e)
        {
            ////prntSome.printSome("OnPaintBackground");
        }

        protected override void WndProc (ref System.Windows.Forms.Message m)
        {
            // Listen for operating system messages and handle the key events.
            switch (m.Msg)
            {
                case WMCodes.WM_KEYDOWN:
                case WMCodes.WM_SYSKEYDOWN:
                case WMCodes.WM_KEYUP:
                case WMCodes.WM_SYSKEYUP:
                case WMCodes.WM_SYSCHAR:
                case WMCodes.WM_CHAR:
                    this.Keyboard.KeyDown (m);
                    break;

                default:
                    // don't do any default handling for the aforementioned events
                    // this means things like keyboard shortcut events are ignored
                    base.WndProc (ref m);
                    break;               
            }
        }

        protected override void OnMouseDown (System.Windows.Forms.MouseEventArgs CurArgs)
        {
            //prntSome.printSome("OnMouseDown");
            if (CurArgs.Button == System.Windows.Forms.MouseButtons.Right)
            {
                // Get the clipboard text
                System.Windows.Forms.IDataObject CurDataObject = System.Windows.Forms.Clipboard.GetDataObject ();
                
                if(CurDataObject.GetDataPresent (System.Windows.Forms.DataFormats.Text)) 
                {
                    if (CurDataObject.GetData (System.Windows.Forms.DataFormats.Text) != null)
                    {
                        this.DispatchMessage (
                            this, 
                           CurDataObject.GetData (System.Windows.Forms.DataFormats.Text).ToString ()); 
                    }
                }
            } 
            base.OnMouseDown (CurArgs);
        }

        protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e)
        {
            this.mousepnt = e.Location;
            this.Invalidate();
            base.OnMouseMove(e);
        }

        private void SetSize (System.Int32 Rows, System.Int32 Columns)
        {
            //prntSome.printSome("SetSize");
            this.Rows    = Rows;
            this.Columns = Columns;

            this.TopMargin    = 0;
            this.BottomMargin = Rows - 1;

            //this.VertScrollBar.Width
            this.ClientSize = new System.Drawing.Size (
                System.Convert.ToInt32 (this.CharSize.Width  * this.Columns + 2) + this.logwidth,
                System.Convert.ToInt32 (this.CharSize.Height * this.Rows    + 2) + this.messageheight);

            // create the character grid (rows by columns) this is a shadow of what's displayed
            this.CharGrid = new System.Char[Rows][];

            this.Caret.Pos.X = 0;
            this.Caret.Pos.Y = 0;

            for (int i = 0; i < this.CharGrid.Length; i++)
            {
                this.CharGrid[i] = new System.Char[Columns];
            }

            this.AttribGrid = new CharAttribs[Rows][];

            for (int i = 0; i < this.AttribGrid.Length; i++)
            {
                this.AttribGrid[i]   = new CharAttribs[Columns];
            }
        }

        private void CreateMenu ()
        {
            //prntSome.printSome("CreateMenu");
            // Create an empty MainMenu.
            System.Windows.Forms.MainMenu mainMenu1 = new System.Windows.Forms.MainMenu();

            System.Windows.Forms.MenuItem[] SettingsItems = new System.Windows.Forms.MenuItem[1];
            System.Windows.Forms.MenuItem[] EditItems = new System.Windows.Forms.MenuItem[2];
            System.Windows.Forms.MenuItem[] FileItems     = new System.Windows.Forms.MenuItem[2];

            //SettingsItems[0] = new System.Windows.Forms.MenuItem ("&Font",    new System.EventHandler (this.OnClickFont));
            SettingsItems[0] = new System.Windows.Forms.MenuItem("&Settings", new System.EventHandler(this.OnClickSettings));
            FileItems[0]     = new System.Windows.Forms.MenuItem ("&Connect", new System.EventHandler (this.OnClickConnect));
            FileItems[1] = new System.Windows.Forms.MenuItem("&Quit", new System.EventHandler(this.OnClickQuit));
            EditItems[0]     = new System.Windows.Forms.MenuItem ("&Data Stream", new System.EventHandler (this.OnClickDataStream));
            EditItems[1]     = new System.Windows.Forms.MenuItem("Clear &Screen", new System.EventHandler(this.OnClickClearScrn));

            System.Windows.Forms.MenuItem FileMenu     = new System.Windows.Forms.MenuItem ("&File", FileItems);
            System.Windows.Forms.MenuItem EditMenu = new System.Windows.Forms.MenuItem("&Edit", EditItems);
            System.Windows.Forms.MenuItem SettingsMenu = new System.Windows.Forms.MenuItem ("&Settings", SettingsItems);

            // Add two MenuItem objects to the MainMenu.
            mainMenu1.MenuItems.Add (FileMenu);
            mainMenu1.MenuItems.Add (EditMenu);
            mainMenu1.MenuItems.Add (SettingsMenu);
   
            // Bind the MainMenu to Form1.
            this.Menu = mainMenu1;
        }
        
        private void GetFontInfo ()
        {
            //prntSome.printSome("GetFontInfo");
            System.Drawing.Graphics tmpGraphics = this.CreateGraphics ();

            // get the offset that the moron Graphics.Drawstring method adds by default
            this.DrawStringOffset = this.GetDrawStringOffset (tmpGraphics, 0, 0, 'A');

            // get the size of the character using the same type of method
            System.Drawing.Point tmpPoint = this.GetCharSize (tmpGraphics);

            this.CharSize.Width  = tmpPoint.X;
            this.CharSize.Height = tmpPoint.Y;

            tmpGraphics.Dispose ();

            this.UnderlinePos = this.CharSize.Height - 2;

            this.Caret.Bitmap    =  new System.Drawing.Bitmap (this.CharSize.Width, this.CharSize.Height);
            this.Caret.Buffer    =  System.Drawing.Graphics.FromImage (this.Caret.Bitmap);
            this.Caret.Buffer.Clear (System.Drawing.Color.FromArgb (255, 181, 106));
            this.EraseBitmap     =  new System.Drawing.Bitmap (this.CharSize.Width, this.CharSize.Height);
            this.EraseBuffer     =  System.Drawing.Graphics.FromImage (this.EraseBitmap);
        }

        private void OnClickSettings(System.Object Sender, System.EventArgs e)
        {
            this.settingsFrm = new WindowsFormsApplication1.settings();
            this.settingsFrm.Show();
        }

        private void OnClickClearScrn(System.Object Sender, System.EventArgs e)
        {
            this.Text = this.frmTitleRDB;
            for (int i = 0; i < this.Rows; i++)
            {
                System.Array.Clear(this.CharGrid[i], 0, this.CharGrid[i].Length);
                System.Array.Clear(this.AttribGrid[i], 0, this.AttribGrid[i].Length);
            }
            this.ShowBuffer();
            this.runOffline = false;

            this.Caret.Pos.X = 0;
            this.Caret.Pos.Y = 0;
            //rdbmsg.Clear();
            rdbsb.Clear();
        }

        private void OnClickDataStream(System.Object Sender, System.EventArgs e)
        {
            //rdbmsg.Clear();
            this.Text = this.frmTitleRDB;
            this.runOffline = true;
            System.Windows.Forms.DialogResult rbdgres = this.rbdlg.ShowDialog();
            if (rbdgres == System.Windows.Forms.DialogResult.OK)
            {
                string sReceived = System.IO.File.ReadAllText(this.rbdlg.FileName);
                //sReceived = sReceived.Remove(sReceived.Length - 2);
                rdbmsg.Insert(0, string.Format("{0}\n", sReceived));
                //rdbmsg.AppendLine(sReceived);
                this.Text += " : "+this.rbdlg.FileName;
                //System.Windows.Forms.MessageBox.Show(sReceived);
                this.Invoke(this.RxdTextEvent, new System.String[] { System.String.Copy(sReceived) });
                this.Invoke(this.RefreshEvent);

                /*
                string tmpstr = "";
                //this.CharGrid
                for (int ii = 0; ii < this.CharGrid.Length; ii++)
                {
                    var str = new string(this.CharGrid[ii]);
                    tmpstr += str + "\n";
                    //tmpstr = new string(this.CharGrid[ 
                }
                prntSome.printSome(tmpstr, "chargrid", counttxtscrnrdb);
                counttxtscrnrdb++;
                */
            }
            //else System.Windows.Forms.MessageBox.Show("open - cancel");
        }

        private void OnClickFont (System.Object Sender, System.EventArgs e)
        {
            //prntSome.printSome("OnClickFont");
            System.Windows.Forms.FontDialog fontDialog = new System.Windows.Forms.FontDialog ();

            fontDialog.FixedPitchOnly = true;
            fontDialog.ShowEffects    = false;
            fontDialog.Font           = this.Font;

            if (fontDialog.ShowDialog () != System.Windows.Forms.DialogResult.Cancel)
            {
                // Change the font
                this.Font = fontDialog.Font;

                this.GetFontInfo ();

                this.ClientSize = new System.Drawing.Size (
                    System.Convert.ToInt32 (this.CharSize.Width  * this.Columns + 2) + this.VertScrollBar.Width,
                    System.Convert.ToInt32 (this.CharSize.Height * this.Rows    + 2));
            };
        }

        private void OnClickQuit(System.Object Sender, System.EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread ();
            System.Windows.Forms.Application.Exit ();
        }

        private void OnClickConnect (System.Object Sender, System.EventArgs e)
        {
            //prntSome.printSome("OnClickConnect");
            HostWindow hostWindow = new HostWindow ();
            hostWindow.HostName.Text = "192.168.3.85";
            //hostWindow.HostName.Text = "5.8.67.246";
            this.runOffline = true;
            System.Windows.Forms.DialogResult RetVal = hostWindow.ShowDialog (this);
            
            if (RetVal == System.Windows.Forms.DialogResult.OK)
            {
                hostWindow.Dispose ();
                this.runOffline = false;
                this.Connect (hostWindow.HostName.Text);
            }
            else
            {
                hostWindow.Dispose ();
                this.runOffline = true;
                //System.Windows.Forms.Application.ExitThread ();
                //System.Windows.Forms.Application.Exit ();
            }
        }
    }
}
