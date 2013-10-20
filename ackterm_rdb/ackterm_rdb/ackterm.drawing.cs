public partial class ackterm
{
    private partial class TermWindow : System.Windows.Forms.Form
    {

        private void PrintChar (System.Char CurChar)
        {
            //prntSome.printSome("PrintChar");
            if (this.Caret.EOL == true)
            {
                if ((this.Modes.Flags & uc_Mode.AutoWrap) == uc_Mode.AutoWrap)
                {
                    this.LineFeed ();
                    this.CarriageReturn ();
                    this.Caret.EOL = false;
                }
            }

            System.Int32 X = this.Caret.Pos.X;
            System.Int32 Y = this.Caret.Pos.Y;

            this.AttribGrid[Y][X] = this.CharAttribs;

            if (this.CharAttribs.GS != null)
            {
                CurChar = uc_Chars.Get (CurChar, this.AttribGrid[Y][X].GS.Set, this.AttribGrid[Y][X].GR.Set);

                if (this.CharAttribs.GS.Set == uc_Chars.Sets.DECSG) this.AttribGrid[Y][X].IsDECSG = true;

                this.CharAttribs.GS = null;
            }
            else
            {
                CurChar = uc_Chars.Get (CurChar, this.AttribGrid[Y][X].GL.Set, this.AttribGrid[Y][X].GR.Set);

                if (this.CharAttribs.GL.Set == uc_Chars.Sets.DECSG) this.AttribGrid[Y][X].IsDECSG = true;
            }

            this.CharGrid[Y][X] = CurChar;

            this.CaretRight ();
        }

        private System.Drawing.Point GetDrawStringOffset (System.Drawing.Graphics CurGraphics, System.Int32 X, System.Int32 Y, System.Char CurChar)
        {
           //prntSome.printSome("GetDrawStringOffset");
           // DrawString doesn't actually print where you tell it to but instead consistently prints
           // with an offset. This is annoying when the other draw commands do not print with an offset
           // this method returns a point defining the offset so we can take it off the printstring command.

           System.Drawing.CharacterRange[] characterRanges =
           {
               new System.Drawing.CharacterRange(0, 1)
           };
 
           System.Drawing.RectangleF layoutRect = new System.Drawing.RectangleF (X, Y, 100, 100);

           System.Drawing.StringFormat stringFormat = new System.Drawing.StringFormat();

           stringFormat.SetMeasurableCharacterRanges(characterRanges);

           System.Drawing.Region[] stringRegions = new System.Drawing.Region[1];

           stringRegions = CurGraphics.MeasureCharacterRanges(
                CurChar.ToString (),
                this.Font,
                layoutRect,
                stringFormat);

            System.Drawing.RectangleF measureRect1 = stringRegions[0].GetBounds (CurGraphics);

            return new System.Drawing.Point ((int) (measureRect1.X + 0.5), (int) (measureRect1.Y + 0.5));
        }
        
        private System.Drawing.Point GetCharSize (System.Drawing.Graphics CurGraphics)
        {
           //prntSome.printSome("GetCharSize");
           // DrawString doesn't actually print where you tell it to but instead consistently prints
           // with an offset. This is annoying when the other draw commands do not print with an offset
           // this method returns a point defining the offset so we can take it off the printstring command.

           System.Drawing.CharacterRange[] characterRanges =
           {
               new System.Drawing.CharacterRange(0, 1)
           };
 
           System.Drawing.RectangleF layoutRect = new System.Drawing.RectangleF (0, 0, 100, 100);

           System.Drawing.StringFormat stringFormat = new System.Drawing.StringFormat();

           stringFormat.SetMeasurableCharacterRanges(characterRanges);

           System.Drawing.Region[] stringRegions = new System.Drawing.Region[1];

           stringRegions = CurGraphics.MeasureCharacterRanges(
                "A",
                this.Font,
                layoutRect,
                stringFormat);

            System.Drawing.RectangleF measureRect1 = stringRegions[0].GetBounds (CurGraphics);

            return new System.Drawing.Point ((int) (measureRect1.Width + 0.5), (int) (measureRect1.Height + 0.5));
        }

        public void AssignColors (
                CharAttribs          CurAttribs, 
            ref System.Drawing.Color CurFGColor, 
            ref System.Drawing.Color CurBGColor)
        {
            //prntSome.printSome("AssignColors");
            CurFGColor = this.FGColor; 
            CurBGColor = this.BackColor;

            if (CurAttribs.IsBlinking == true)
            {
                CurFGColor = this.BlinkColor;
            }

            // bold takes precedence over the blink color
            if (CurAttribs.IsBold == true)
            {
                CurFGColor = this.BoldColor;
            }

            if (CurAttribs.UseAltColor == true)
            {
                CurFGColor = CurAttribs.AltColor;
            }

            // alternate color takes precedence over the bold color
            if (CurAttribs.UseAltBGColor == true)
            {
                CurBGColor = CurAttribs.AltBGColor;
            }

            if (CurAttribs.IsInverse == true)
            {
                System.Drawing.Color TmpColor = CurBGColor;

                CurBGColor = CurFGColor;
                CurFGColor = TmpColor;
            }

            // If light background is on and we're not using alt colors
            // reverse the colors
            if ((this.Modes.Flags & uc_Mode.LightBackground) > 0 &&
                CurAttribs.UseAltColor == false && CurAttribs.UseAltBGColor == false)
            {

                System.Drawing.Color TmpColor = CurBGColor;

                CurBGColor = CurFGColor;
                CurFGColor = TmpColor;
            }
        }

        public void ShowChar (
            System.Drawing.Graphics CurGraphics,
            System.Char             CurChar, 
            System.Int32            Y,
            System.Int32            X, 
            CharAttribs             CurAttribs)
        {
            //prntSome.printSome("ShowChar");
            if (CurChar == '\0')
            {
                return;
            }

            System.Drawing.Color CurFGColor = System.Drawing.Color.White; 
            System.Drawing.Color CurBGColor = System.Drawing.Color.Black;

            this.AssignColors (CurAttribs, ref CurFGColor, ref CurBGColor);

            if ((CurBGColor != this.BackColor && (this.Modes.Flags & uc_Mode.LightBackground) == 0) ||
                (CurBGColor != this.FGColor   && (this.Modes.Flags & uc_Mode.LightBackground) > 0))
            {

                // Erase the current Character underneath the cursor postion
                this.EraseBuffer.Clear (CurBGColor);

                // paint a rectangle over the cursor position in the character's BGColor
                CurGraphics.DrawImageUnscaled (
                    this.EraseBitmap, 
                    X, 
                    Y);
            }

            if (CurAttribs.IsUnderscored)
            {
                CurGraphics.DrawLine (new System.Drawing.Pen (CurFGColor, 1),
                    X,                       Y + this.UnderlinePos,   
                    X + this.CharSize.Width, Y + this.UnderlinePos);
            }   

            /*VT220*/
            /*
            if ((CurAttribs.IsDECSG == true) &&
                (CurChar == 'l' ||
                 CurChar == 'q' ||
                 CurChar == 'w' ||
                 CurChar == 'k' ||
                 CurChar == 'x' ||
                 CurChar == 't' ||
                 CurChar == 'n' ||
                 CurChar == 'u' ||
                 CurChar == 'm' ||
                 CurChar == 'v' ||
                 CurChar == 'j' ||
                 CurChar == '`'))
            {
                this.ShowSpecialChar (
                    CurGraphics,
                    CurChar, 
                    Y,
                    X,
                    CurFGColor,
                    CurBGColor);

                return;               
            }*/
            /**/
            //ANSI
            if ((CurAttribs.IsDECSG == true) &&
                (CurChar == 'Z' ||
                 CurChar == 'l' ||
                 CurChar == 'q' ||
                 CurChar == 'D' ||
                 CurChar == 'B' ||
                 CurChar == '?' ||
                 CurChar == '3' ||
                 CurChar == 'C' ||
                 CurChar == 'E' ||
                 CurChar == '4' ||
                 CurChar == '@' ||
                 CurChar == 'A' ||
                 CurChar == 'Y' ||
                 CurChar == '`'))
            {
                this.ShowSpecialChar(
                    CurGraphics,
                    CurChar,
                    Y,
                    X,
                    CurFGColor,
                    CurBGColor);

                return;
            }
            /**/
            //prntSome.add2stringrdb(CurChar.ToString());
            CurGraphics.DrawString (
                 CurChar.ToString (), 
                 this.Font, 
                 new System.Drawing.SolidBrush (CurFGColor),
                 X - this.DrawStringOffset.X,
                 Y - this.DrawStringOffset.Y);

        }

        public void ShowSpecialChar (
            System.Drawing.Graphics CurGraphics,
            System.Char             CurChar, 
            System.Int32            Y,
            System.Int32            X,
            System.Drawing.Color    CurFGColor, 
            System.Drawing.Color    CurBGColor)
        {
            //prntSome.printSome("ShowSpecialChar");
            if (CurChar == '\0')
            {
                return;
            }
            switch (CurChar)
            {
                case '`': // diamond
                    
                    System.Drawing.Point[] CurPoints = new System.Drawing.Point[4];

                    CurPoints[0] = new System.Drawing.Point (X + this.CharSize.Width/2, Y + this.CharSize.Height/6);
                    CurPoints[1] = new System.Drawing.Point (X + 5*this.CharSize.Width/6, Y + this.CharSize.Height/2);
                    CurPoints[2] = new System.Drawing.Point (X + this.CharSize.Width/2, Y + 5*this.CharSize.Height/6);
                    CurPoints[3] = new System.Drawing.Point (X + this.CharSize.Width/6, Y + this.CharSize.Height/2);

                    CurGraphics.FillPolygon (
                        new System.Drawing.SolidBrush (CurFGColor),
                        CurPoints);   
                    break;
                case 'l':
                case 'Z': // top left bracket
                    CurGraphics.DrawLine (new System.Drawing.Pen (CurFGColor, 1),
                        X + this.CharSize.Width/2 -1,   Y + this.CharSize.Height/2,   
                        X + this.CharSize.Width,     Y + this.CharSize.Height/2);
                    CurGraphics.DrawLine (new System.Drawing.Pen (CurFGColor, 1),
                        X + this.CharSize.Width/2,   Y + this.CharSize.Height/2,   
                        X + this.CharSize.Width/2,   Y + this.CharSize.Height);
                    break;
                case 'q':
                case 'D': // horizontal line
                    CurGraphics.DrawLine (new System.Drawing.Pen (CurFGColor, 1),
                        X,                           Y + this.CharSize.Height/2,   
                        X + this.CharSize.Width,     Y + this.CharSize.Height/2);
                    break;

                case 'B': // top tee-piece
                    CurGraphics.DrawLine (new System.Drawing.Pen (CurFGColor, 1),
                        X,                         Y + this.CharSize.Height/2,   
                        X + this.CharSize.Width,   Y + this.CharSize.Height/2);
                    CurGraphics.DrawLine (new System.Drawing.Pen (CurFGColor, 1),
                        X + this.CharSize.Width/2, Y + this.CharSize.Height/2,   
                        X + this.CharSize.Width/2, Y + this.CharSize.Height);
                    break;

                case '?': // top right bracket
                    CurGraphics.DrawLine (new System.Drawing.Pen (CurFGColor, 1),
                        X,                         Y + this.CharSize.Height/2,   
                        X + this.CharSize.Width/2, Y + this.CharSize.Height/2);
                    CurGraphics.DrawLine (new System.Drawing.Pen (CurFGColor, 1),
                        X + this.CharSize.Width/2, Y + this.CharSize.Height/2,   
                        X + this.CharSize.Width/2, Y + this.CharSize.Height);
                    break;

                case '3': // vertical line
                    CurGraphics.DrawLine (new System.Drawing.Pen (CurFGColor, 1),
                        X + this.CharSize.Width/2, Y,   
                        X + this.CharSize.Width/2, Y + this.CharSize.Height);
                    break;

                case 'C': // left hand tee-piece
                    CurGraphics.DrawLine (new System.Drawing.Pen (CurFGColor, 1),
                        X + this.CharSize.Width/2, Y,   
                        X + this.CharSize.Width/2, Y + this.CharSize.Height);
                    CurGraphics.DrawLine (new System.Drawing.Pen (CurFGColor, 1),
                        X + this.CharSize.Width/2, Y + this.CharSize.Height/2,   
                        X + this.CharSize.Width,   Y + this.CharSize.Height/2);
                    break;

                case 'E': // cross piece
                    CurGraphics.DrawLine (new System.Drawing.Pen (CurFGColor, 1),
                        X + this.CharSize.Width/2, Y,   
                        X + this.CharSize.Width/2, Y + this.CharSize.Height);
                    CurGraphics.DrawLine (new System.Drawing.Pen (CurFGColor, 1),
                        X,                         Y + this.CharSize.Height/2,   
                        X + this.CharSize.Width,   Y + this.CharSize.Height/2);
                    break;

                case '4': // right hand tee-piece
                    CurGraphics.DrawLine (new System.Drawing.Pen (CurFGColor, 1),
                        X,                         Y + this.CharSize.Height/2,   
                        X + this.CharSize.Width/2, Y + this.CharSize.Height/2);
                    CurGraphics.DrawLine (new System.Drawing.Pen (CurFGColor, 1),
                        X + this.CharSize.Width/2, Y,   
                        X + this.CharSize.Width/2, Y + this.CharSize.Height);
                    break;

                case '@': // bottom left bracket
                    CurGraphics.DrawLine (new System.Drawing.Pen (CurFGColor, 1),
                        X + this.CharSize.Width/2, Y + this.CharSize.Height/2,   
                        X + this.CharSize.Width,   Y + this.CharSize.Height/2);
                    CurGraphics.DrawLine (new System.Drawing.Pen (CurFGColor, 1),
                        X + this.CharSize.Width/2, Y,   
                        X + this.CharSize.Width/2, Y + this.CharSize.Height/2);
                    break;

                case 'A': // bottom tee-piece
                    CurGraphics.DrawLine (new System.Drawing.Pen (CurFGColor, 1),
                        X,                         Y + this.CharSize.Height/2,   
                        X + this.CharSize.Width,   Y + this.CharSize.Height/2);
                    CurGraphics.DrawLine (new System.Drawing.Pen (CurFGColor, 1),
                        X + this.CharSize.Width/2, Y,   
                        X + this.CharSize.Width/2, Y + this.CharSize.Height/2);
                    break;

                case 'Y': // bottom right bracket
                    CurGraphics.DrawLine (new System.Drawing.Pen (CurFGColor, 1),
                        X,                         Y + this.CharSize.Height/2,   
                        X + this.CharSize.Width/2, Y + this.CharSize.Height/2);
                    CurGraphics.DrawLine (new System.Drawing.Pen (CurFGColor, 1),
                        X + this.CharSize.Width/2, Y,   
                        X + this.CharSize.Width/2, Y + this.CharSize.Height/2);
                    break;

                default:
                    break;
            }

        }

        public void WipeScreen (System.Drawing.Graphics CurGraphics)
        {
           //prntSome.printSome("WipeScreen");
           // clear the screen buffer area
           if ((this.Modes.Flags & uc_Mode.LightBackground) > 0)
           {
               CurGraphics.Clear (this.FGColor);
           }
           else
           {
               CurGraphics.Clear (this.BackColor);
           }
        }

        public void ClearDown (System.Int32 Param)
        {
            //prntSome.printSome("ClearDown");
            System.Int32 X = this.Caret.Pos.X;
            System.Int32 Y = this.Caret.Pos.Y;

            switch (Param)
            {
                case 0: // from cursor to bottom inclusive

                    System.Array.Clear (this.CharGrid[Y],   X, this.CharGrid[Y].Length   - X);
                    System.Array.Clear (this.AttribGrid[Y], X, this.AttribGrid[Y].Length - X);

                    for (int i = Y + 1; i < this.Rows; i++)
                    {
                        System.Array.Clear (this.CharGrid[i],   0, this.CharGrid[i].Length);
                        System.Array.Clear (this.AttribGrid[i], 0, this.AttribGrid[i].Length);
                    }
                    break;

                case 1: // from top to cursor inclusive

                    System.Array.Clear (this.CharGrid[Y],   0, X + 1);
                    System.Array.Clear (this.AttribGrid[Y], 0, X + 1);

                    for (int i = 0; i < Y; i++)
                    {
                        System.Array.Clear (this.CharGrid[i],   0, this.CharGrid[i].Length);
                        System.Array.Clear (this.AttribGrid[i], 0, this.AttribGrid[i].Length);
                    }
                    break;

                case 2: // entire screen
                    for (int i = 0; i < this.Rows; i++)
                    {
                        System.Array.Clear (this.CharGrid[i],   0, this.CharGrid[i].Length);
                        System.Array.Clear (this.AttribGrid[i], 0, this.AttribGrid[i].Length);
                    }
                    break;

                default:
                    break;
            }
        }

        public void ClearRight (System.Int32 Param)
        {
            System.Int32 X = this.Caret.Pos.X;
            System.Int32 Y = this.Caret.Pos.Y;

            switch (Param)
            {
                case 0: // from cursor to end of line inclusive

                    System.Array.Clear (this.CharGrid[Y],   X, this.CharGrid[Y].Length   - X);
                    System.Array.Clear (this.AttribGrid[Y], X, this.AttribGrid[Y].Length - X);
                    break;

                case 1: // from beginning to cursor inclusive
                    System.Array.Clear (this.CharGrid[Y],   0, X + 1);
                    System.Array.Clear (this.AttribGrid[Y], 0, X + 1);
                    break;

                case 2: // entire line
                    System.Array.Clear (this.CharGrid[Y],   0, this.CharGrid[Y].Length);
                    System.Array.Clear (this.AttribGrid[Y], 0, this.AttribGrid[Y].Length);
                    break;

                default:
                    break;
            }
        }

        private void ShowBuffer ()
        {
            //prntSome.printSome("ShowBuffer");
              this.Invalidate ();
        }

        private void Redraw (System.Drawing.Graphics CurGraphics)
        {
            System.Drawing.Point CurPoint;
            System.Char CurChar;        
            
            //prntSome.printSome("Redraw");
            //
            // refresh the screen
            for (System.Int32 Y = 0; Y < this.Rows; Y++)
            {
                for (System.Int32 X = 0; X < this.Columns; X++)
                {
                    CurChar = this.CharGrid[Y][X];

                    if (CurChar == '\0')
                    {
                        continue;
                    }

                    CurPoint = new System.Drawing.Point (
                        X * this.CharSize.Width,
                        Y * this.CharSize.Height);

                    this.ShowChar (
                        CurGraphics,
                        CurChar, 
                        CurPoint.Y,
                        CurPoint.X,
                        this.AttribGrid[Y][X]);
                    
                }
            }

            //prntSome.printSome(sb.ToString());
            //sb = null;
            //prntSome.initstring();

        }
    }

    private struct CharAttribs
    {
        public System.Boolean       IsBold;
        public System.Boolean       IsDim;
        public System.Boolean       IsUnderscored;
        public System.Boolean       IsBlinking;
        public System.Boolean       IsInverse;
        public System.Boolean       IsPrimaryFont;
        public System.Boolean       IsAlternateFont;
        public System.Boolean       UseAltColor;
        public System.Drawing.Color AltColor;
        public System.Boolean       UseAltBGColor;
        public System.Drawing.Color AltBGColor;
        public uc_Chars             GL;
        public uc_Chars             GR;
        public uc_Chars             GS;
        public System.Boolean       IsDECSG;

        public CharAttribs ( 
            System.Boolean       p1,
            System.Boolean       p2,
            System.Boolean       p3,
            System.Boolean       p4,
            System.Boolean       p5,
            System.Boolean       p6,
            System.Boolean       p7,
            System.Boolean       p12,
            System.Drawing.Color p13,
            System.Boolean       p14,
            System.Drawing.Color p15,
            uc_Chars             p16,
            uc_Chars             p17,
            uc_Chars             p18,
            System.Boolean       p19)
        {
            //prntSome.printSome("CharAttribs");
            IsBold          = p1;
            IsDim           = p2;
            IsUnderscored   = p3;
            IsBlinking      = p4;
            IsInverse       = p5;
            IsPrimaryFont   = p6;
            IsAlternateFont = p7;
            UseAltColor     = p12;
            AltColor        = p13;
            UseAltBGColor   = p14;
            AltBGColor      = p15;
            GL              = p16;
            GR              = p17;
            GS              = p18;
            IsDECSG         = p19;
        }

    }    
}
