public partial class ackterm
{
    private partial class uc_autoprocess
    {
        public class uc_rdbseq
        {
            public ElmScrns _p1;
            public PrimeMainMenu _p2;

            public uc_rdbseq(ElmScrns p1, PrimeMainMenu p2)
            {
                _p1 = p1;
                _p2 = p2;
            }
        }

        private class uc_formpartsinfo
        {
            public System.String param;
            public System.Drawing.Point prmStartPos;
            public System.Drawing.Point prmEndPos;
            

            public uc_formpartsinfo(
                    System.String p1,
                    System.Drawing.Point p2,
                    System.Drawing.Point p3
                )
            {
                param = p1;
                prmStartPos = p2;
                prmEndPos = p3;
            }
        }

        private class uc_maptxtcaretinfo
        {
            public PrimeMainMenu inMenu;
            public System.Drawing.Point curPos;
            public uc_formpartsinfo frmfield;
            public uc_formpartsinfo frmvalue;
            public ElmScrns seqScrn;
            public System.Int32 index = -1;
            public System.Boolean hasValue = false;
            public UseWhat useThis = UseWhat.None;

            public uc_maptxtcaretinfo(
                PrimeMainMenu r1,
                System.Drawing.Point r2,
                uc_formpartsinfo r3,
                uc_formpartsinfo r4,
                ElmScrns r5,
                System.Boolean r6,
                UseWhat r7
                )
            {
                inMenu = r1;
                curPos = r2;
                frmfield = r3;
                frmvalue = r4;
                seqScrn = r5;
                hasValue = r6;
                useThis = r7;
            }
        }
    }
}

