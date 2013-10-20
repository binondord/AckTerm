public partial class ackterm
{
    private partial class TermWindow : System.Windows.Forms.Form
    {
        private class uc_TabStops
        {
            public System.Boolean[] Columns;

            public uc_TabStops ()
            {
                //prntSome.printSome("uc_TabStops");
                Columns = new System.Boolean[256];

                Columns[8]   = true;
                Columns[16]  = true;
                Columns[24]  = true;
                Columns[32]  = true;
                Columns[40]  = true;
                Columns[48]  = true;
                Columns[56]  = true;
                Columns[64]  = true;
                Columns[72]  = true;
                Columns[80]  = true;
                Columns[88]  = true;
                Columns[96]  = true;
                Columns[104] = true;
                Columns[112] = true;
                Columns[120] = true;
                Columns[128] = true;
            }
        };

        private class uc_CaretAttribs
        {
            public System.Drawing.Point Pos;
            public uc_Chars.Sets        G0Set;
            public uc_Chars.Sets        G1Set;
            public uc_Chars.Sets        G2Set;
            public uc_Chars.Sets        G3Set;
            public CharAttribs          Attribs;

            public uc_CaretAttribs (
                System.Drawing.Point p1,
                uc_Chars.Sets        p2,
                uc_Chars.Sets        p3,
                uc_Chars.Sets        p4,
                uc_Chars.Sets        p5,
                CharAttribs          p6)
            {
                //prntSome.printSome("uc_CaretAttribs");
                this.Pos     = p1;
                this.G0Set   = p2;
                this.G1Set   = p3;
                this.G2Set   = p4;
                this.G3Set   = p5;
                this.Attribs = p6;
            }
        }

        private void CarriageReturn () 
        {
            //prntSome.printSome("CarriageReturn");
            this.CaretToAbs (this.Caret.Pos.Y, 0);
        }

        private void Tab () 
        {
            //prntSome.printSome("Tab");
            for (System.Int32 i = 0; i < this.TabStops.Columns.Length; i++)
            {
                if (i > this.Caret.Pos.X && this.TabStops.Columns[i]  == true)
                {
                    this.CaretToAbs (this.Caret.Pos.Y, i);
                    return;
                }
            }

            this.CaretToAbs (this.Caret.Pos.Y, this.Columns -1);
            return;
        }

        public void TabSet ()
        {
            //prntSome.printSome("TabSet");
            this.TabStops.Columns[this.Caret.Pos.X] = true;
        }

        public void ClearTabs (uc_Params CurParams) // TBC 
        {
            //prntSome.printSome("ClearTabs");
            System.Int32 Param = 0;

            if (CurParams.Count () > 0)
            {
                Param = System.Convert.ToInt32 (CurParams.Elements[0]);
            }

            switch (Param)
            {
                case 0: // Current Position
                    this.TabStops.Columns[this.Caret.Pos.X] = false;
                    break;

                case 3: // All Tabs
                    for (int i = 0; i < this.TabStops.Columns.Length; i++)
                    {
                        this.TabStops.Columns[i] = false;
                    }
                    break;

                default:
                    break;
            }
        }

        private void ReverseLineFeed ()
        {
            //prntSome.printSome("ReverseLineFeed");
            // if we're at the top of the scroll region (top margin)
            if (this.Caret.Pos.Y == this.TopMargin)
            {
                // we need to add a new line at the top of the screen margin
                // so shift all the rows in the scroll region down in the array and
                // insert a new row at the top
                
                int i;

   
                for (i = this.BottomMargin; i > this.TopMargin; i--)
                {
                    this.CharGrid[i]   = this.CharGrid[i - 1];
                    this.AttribGrid[i] = this.AttribGrid[i - 1];
                }

                this.CharGrid[this.TopMargin] = new System.Char[this.Columns];

                this.AttribGrid[this.TopMargin] = new CharAttribs[this.Columns];
            }

            this.CaretUp ();
        }

        private void InsertLine (uc_Params CurParams)
        {
            //prntSome.printSome("InsertLine");
            // if we're not in the scroll region then bail
            if (this.Caret.Pos.Y < this.TopMargin ||
                this.Caret.Pos.Y > this.BottomMargin)
            {
                return;
            }

            System.Int32 NbrOff = 1;

            if (CurParams.Count () > 0)
            {
                NbrOff = System.Convert.ToInt32 (CurParams.Elements[0]);
            }

            while (NbrOff > 0)
            { 

                // Shift all the rows from the current row to the bottom margin down one place
                for (int i = this.BottomMargin; i > this.Caret.Pos.Y; i--)
                {
                    this.CharGrid[i]   = this.CharGrid[i - 1];
                    this.AttribGrid[i] = this.AttribGrid[i - 1];
                }

                this.CharGrid[this.Caret.Pos.Y]   = new System.Char[this.Columns];
                this.AttribGrid[this.Caret.Pos.Y] = new CharAttribs[this.Columns];

                NbrOff--;
            }

        }

        private void DeleteLine (uc_Params CurParams)
        {
            //prntSome.printSome("DeleteLine");
            // if we're not in the scroll region then bail
            if (this.Caret.Pos.Y < this.TopMargin ||
                this.Caret.Pos.Y > this.BottomMargin)
            {
                return;
            }

            System.Int32 NbrOff = 1;

            if (CurParams.Count () > 0)
            {
                NbrOff = System.Convert.ToInt32 (CurParams.Elements[0]);
            }

            while (NbrOff > 0)
            { 

                // Shift all the rows from below the current row to the bottom margin up one place
                for (int i = this.Caret.Pos.Y; i < this.BottomMargin; i++)
                {
                    this.CharGrid[i]   = this.CharGrid[i + 1];
                    this.AttribGrid[i] = this.AttribGrid[i + 1];
                }

                this.CharGrid[this.BottomMargin]   = new System.Char[this.Columns];
                this.AttribGrid[this.BottomMargin] = new CharAttribs[this.Columns];

                NbrOff--;
            }
        }

        private void LineFeed ()
        {
            //prntSome.printSome("LineFeed");
            if (this.Caret.Pos.Y == this.BottomMargin || this.Caret.Pos.Y == this.Rows - 1)
            {
                // we need to add a new line so shift all the rows up in the array and
                // insert a new row at the bottom
                
                int i;
                
                for (i = this.TopMargin; i < this.BottomMargin; i++)
                {
                    this.CharGrid[i]   = this.CharGrid[i + 1];
                    this.AttribGrid[i] = this.AttribGrid[i + 1];
                }

                this.CharGrid[i]   = new System.Char[this.Columns];
                this.AttribGrid[i] = new CharAttribs[this.Columns];

            }

            this.CaretDown ();
        }

        private void Index (System.Int32 Param)
        {
            //prntSome.printSome("Index");
            if (Param == 0) Param = 1;

            for (int i = 0; i < Param; i++)
            {
                this.LineFeed ();
            }
        }

        private void ReverseIndex (System.Int32 Param)
        {
            //prntSome.printSome("ReverseIndex");
            if (Param == 0) Param = 1;

            for (int i = 0; i < Param; i++)
            {
                this.ReverseLineFeed ();
            }
        }

        public void CaretOff ()
        {
            //prntSome.printSome("ReverseIndex");
            if (this.Caret.IsOff == true)
            {
                return;
            }

            this.Caret.IsOff = true;
        }

        public void CaretOn ()
        {
            //prntSome.printSome("ReverseIndex");
            if (this.Caret.IsOff == false)
            {
                return;
            }

            this.Caret.IsOff = false;

        }

        public void ShowCaret (System.Drawing.Graphics CurGraphics)
        {
            //prntSome.printSome("ShowCaret");
            System.Int32 X = this.Caret.Pos.X;
            System.Int32 Y = this.Caret.Pos.Y;

            if (this.Caret.IsOff == true)
            {
                return;
            }

            // paint a rectangle over the cursor position
            CurGraphics.DrawImageUnscaled (
                this.Caret.Bitmap, 
                X * (int) this.CharSize.Width, 
                Y * (int) this.CharSize.Height);

            // if we don't have a char to redraw then leave
            if (this.CharGrid[Y][X] == '\0')
            {
                return;
            }

            CharAttribs CurAttribs = new CharAttribs ();

            CurAttribs.UseAltColor = true;

            CurAttribs.GL = this.AttribGrid[Y][X].GL;
            CurAttribs.GR = this.AttribGrid[Y][X].GR;
            CurAttribs.GS = this.AttribGrid[Y][X].GS;

            if (this.AttribGrid[Y][X].UseAltBGColor == false)
            {
                CurAttribs.AltColor = this.BackColor;
            }
            else if (this.AttribGrid[Y][X].UseAltBGColor == true)
            {
                CurAttribs.AltColor = this.AttribGrid[Y][X].AltBGColor;
            }

            CurAttribs.IsUnderscored = this.AttribGrid[Y][X].IsUnderscored;
            CurAttribs.IsDECSG       = this.AttribGrid[Y][X].IsDECSG;
 
            // redispay the current char in the background colour
            this.ShowChar (
                CurGraphics,
                this.CharGrid[Y][X], 
                Caret.Pos.Y * this.CharSize.Height,
                Caret.Pos.X * this.CharSize.Width,
                CurAttribs);
        }

        public void CaretUp ()
        {
            //prntSome.printSome("CaretUp");
            this.Caret.EOL = false;

            if ((this.Caret.Pos.Y > 0              && (this.Modes.Flags & uc_Mode.OriginRelative) == 0) ||
                (this.Caret.Pos.Y > this.TopMargin && (this.Modes.Flags & uc_Mode.OriginRelative) >  0))
            {
                this.Caret.Pos.Y -= 1;
            }
        }

        public void CaretDown ()
        {
            //prntSome.printSome("CaretDown");
            this.Caret.EOL = false;

            if ((this.Caret.Pos.Y < this.Rows - 1     && (this.Modes.Flags & uc_Mode.OriginRelative) == 0) ||
                (this.Caret.Pos.Y < this.BottomMargin && (this.Modes.Flags & uc_Mode.OriginRelative)  > 0))
            {
                this.Caret.Pos.Y += 1;
            }
        }

        public void CaretLeft ()
        {
            //prntSome.printSome("CaretLeft");
            this.Caret.EOL = false;

            if (this.Caret.Pos.X > 0)
            {
                this.Caret.Pos.X -= 1;
            }
        }

        public void CaretRight ()
        {
            //prntSome.printSome("CaretRight");
            if (this.Caret.Pos.X < this.Columns - 1)
            {
                this.Caret.Pos.X += 1;
                this.Caret.EOL = false;
            }
            else
            {
                this.Caret.EOL = true;
            }
        }


        public void CaretToRel (
            System.Int32       Y,
            System.Int32       X) 
        {
            this.Caret.EOL = false;
            /* This code is used when we get a cursor position command from
               the host. Even if we're not in relative mode we use this as this will
               sort that out for us. The ToAbs code is used internally by this prog 
               but is smart enough to stay within the margins if the originrelative 
               flagis set. */

            if ((this.Modes.Flags & uc_Mode.OriginRelative) == 0)
            {
                this.CaretToAbs (Y, X);
                return;
            }

            /* the origin mode is relative so add the top and left margin
               to Y and X respectively */
            Y += this.TopMargin;

            if (X < 0)
            {
                X = 0;
            }

            if (X > this.Columns - 1)
            {
                X = this.Columns - 1;
            }
 
            if (Y < this.TopMargin)
            {
                Y = this.TopMargin;
            }

            if (Y > this.BottomMargin)
            {
                Y = this.BottomMargin;
            }

            this.Caret.Pos.Y = Y;
            this.Caret.Pos.X = X;
        }

        public void CaretToAbs (
            System.Int32       Y,
            System.Int32       X)
        {
            //prntSome.printSome("CaretToAbs");
            this.Caret.EOL = false;

            if (X < 0)
            {
                X = 0;
            }

            if (X > this.Columns - 1)
            {
                X = this.Columns - 1;
            }

            if (Y < 0 && (this.Modes.Flags & uc_Mode.OriginRelative) == 0)
            {
                Y = 0;
            }

            if (Y < this.TopMargin && (this.Modes.Flags & uc_Mode.OriginRelative) > 0)
            {
                Y = this.TopMargin;
            }

            if (Y > this.Rows - 1 && (this.Modes.Flags & uc_Mode.OriginRelative) == 0)
            {
                Y = this.Rows - 1;
            }

            if (Y > this.BottomMargin && (this.Modes.Flags & uc_Mode.OriginRelative) > 0)
            {
                Y = this.BottomMargin;
            }

            this.Caret.Pos.Y = Y;
            this.Caret.Pos.X = X;
        }

    }

    private class uc_Caret
    {
        public System.Drawing.Point    Pos;
        public System.Drawing.Color    Color  = System.Drawing.Color.FromArgb (255, 181,106);
        public System.Drawing.Bitmap   Bitmap = null;
        public System.Drawing.Graphics Buffer = null;
        public System.Boolean          IsOff  = false;
        public System.Boolean          EOL    = false;

        public uc_Caret ()
        {
            //prntSome.printSome("uc_Caret");
            this.Pos = new System.Drawing.Point(0, 0);
        }
   }
}

