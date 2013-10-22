public partial class ackterm
{
    private partial class uc_autoprocess
    {
        private partial class uc_maptxtcaret
        {
            private void defCoordMainForm(
                    int xcd = 0,
                    int ycd = 0,
                    PrimeMainMenu pm = PrimeMainMenu.Initial,
                    ElmScrns es = ElmScrns.NotFound,
                    string strText = ""
                )
            {
                Elements.Add(
                    new uc_maptxtcaretinfo(
                        pm,
                        new System.Drawing.Point(xcd, ycd),
                        new uc_formpartsinfo(strText,
                            new System.Drawing.Point(0, 0),
                            new System.Drawing.Point(0, 0)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(0, 0),
                            new System.Drawing.Point(0, 0)
                        ),
                        es,
                        false,
                        UseWhat.None
                    ));
            }

            private void mainform()
            {
                defCoordMainForm(7, 3, PrimeMainMenu.Initial, ElmScrns.Login, "login:");
                defCoordMainForm(14, 14, PrimeMainMenu.Initial, ElmScrns.TermAnsi, "TERM = (ansi) ");
                defCoordMainForm(14, 17, PrimeMainMenu.Initial, ElmScrns.TermAnsi, "TERM = (ansi) ");
                defCoordMainForm(51, 20, PrimeMainMenu.Initial, ElmScrns.Ret2Begin, "Press Return To Begin: ");
                defCoordMainForm(25, 6, PrimeMainMenu.Initial, ElmScrns.ClinicNum, "Clinic No.____________:");
                defCoordMainForm(25, 8, PrimeMainMenu.Initial, ElmScrns.Password, "Password _____________:");
                defCoordMainForm(14, 23, PrimeMainMenu.Main, ElmScrns.MainPatient, "  New Patient ");
                defCoordMainForm(47, 23, PrimeMainMenu.Main, ElmScrns.MainExit, "Would You Like To Quit/Change Clinic(Y/C/N)?   ");
            }
        }
    }
}
