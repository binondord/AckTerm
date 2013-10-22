public partial class ackterm
{
    private partial class uc_autoprocess
    {
        private partial class uc_maptxtcaret
        {
            private void defCoordPatientMenu(
                    int xcd = 0,
                    int ycd = 0,
                    ElmScrns es = ElmScrns.NotFound,
                    string strText = ""
                )
            {
                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.Patient,
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

            private void menuPatient()
            {
                defCoordPatientMenu(6, 23, ElmScrns.PatientMenuAdd, "Add");
                defCoordPatientMenu(6, 23, ElmScrns.PatientMenuModify, "Modify");
                defCoordPatientMenu(6, 23, ElmScrns.PatientMenuView, "View");
                defCoordPatientMenu(6, 23, ElmScrns.PatientMenuInsurAdd, "Insur Add");
                defCoordPatientMenu(6, 23, ElmScrns.PatientMenuInsurDel, "Delete Insur");
                defCoordPatientMenu(6, 23, ElmScrns.PatientMenuLabels, "Labels");
                defCoordPatientMenu(6, 23, ElmScrns.PatientMenuRegistion, "Registration");
                defCoordPatientMenu(6, 23, ElmScrns.PatientMenuWorker, "Worker");
                defCoordPatientMenu(6, 23, ElmScrns.PatientMenuForms, "Forms");
                defCoordPatientMenu(6, 23, ElmScrns.PatientMenuSearchPt, "Search Pt");
                defCoordPatientMenu(6, 23, ElmScrns.PatientMenuSearchIns, "Search Ins");
                defCoordPatientMenu(6, 23, ElmScrns.PatientMenuExit, "Exit");
            }
        }
    }
}
