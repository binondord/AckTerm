public partial class ackterm
{
    private partial class uc_autoprocess
    {
        private partial class uc_maptxtcaret
        {
            private void mainform()
            {
                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.Initial,
                        new System.Drawing.Point(7, 3),
                        new uc_formpartsinfo("login:",
                            new System.Drawing.Point(0, 0),
                            new System.Drawing.Point(0, 0)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(0, 0),
                            new System.Drawing.Point(0, 0)
                        ),
                        ElmScrns.Login,
                        false,
                        UseWhat.None
                    ));
                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.Initial,
                        new System.Drawing.Point(14, 14),
                        new uc_formpartsinfo("TERM = (ansi) ",
                            new System.Drawing.Point(0, 0),
                            new System.Drawing.Point(0, 0)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(0, 0),
                            new System.Drawing.Point(0, 0)
                        ),
                        ElmScrns.TermAnsi,
                        false,
                        UseWhat.None
                    ));
                //Urrea
                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.Initial,
                        new System.Drawing.Point(14, 17),
                        new uc_formpartsinfo("TERM = (ansi) ",
                            new System.Drawing.Point(0, 0),
                            new System.Drawing.Point(0, 0)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(0, 0),
                            new System.Drawing.Point(0, 0)
                        ),
                        ElmScrns.TermAnsi,
                        false,
                        UseWhat.None
                    ));
                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.Initial,
                        new System.Drawing.Point(51, 20),
                        new uc_formpartsinfo("Press Return To Begin: ",
                            new System.Drawing.Point(0, 0),
                            new System.Drawing.Point(0, 0)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(0, 0),
                            new System.Drawing.Point(0, 0)
                        ),
                        ElmScrns.Ret2Begin,
                        false,
                        UseWhat.None
                    ));
                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.Initial,
                        new System.Drawing.Point(25, 6),
                        new uc_formpartsinfo("Clinic No.____________:",
                            new System.Drawing.Point(0, 0),
                            new System.Drawing.Point(0, 0)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(0, 0),
                            new System.Drawing.Point(0, 0)
                        ),
                        ElmScrns.ClinicNum,
                        false,
                        UseWhat.None
                    ));
                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.Initial,
                        new System.Drawing.Point(25, 8),
                        new uc_formpartsinfo("Password _____________:",
                            new System.Drawing.Point(0, 0),
                            new System.Drawing.Point(0, 0)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(0, 0),
                            new System.Drawing.Point(0, 0)
                        ),
                        ElmScrns.Password,
                        false,
                        UseWhat.None
                    ));
                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.Main,
                        new System.Drawing.Point(14, 23),
                        new uc_formpartsinfo("  New Patient ",
                            new System.Drawing.Point(0, 0),
                            new System.Drawing.Point(0, 0)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(0, 0),
                            new System.Drawing.Point(0, 0)
                        ),
                        ElmScrns.MainPatient,
                        false,
                        UseWhat.None
                    ));
                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.Main,
                        new System.Drawing.Point(47, 23),
                        new uc_formpartsinfo("Would You Like To Quit/Change Clinic(Y/C/N)?   ",
                            new System.Drawing.Point(0, 0),
                            new System.Drawing.Point(0, 0)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(0, 0),
                            new System.Drawing.Point(0, 0)
                        ),
                        ElmScrns.MainExit,
                        false,
                        UseWhat.None
                    ));
            }
        }
    }
}
