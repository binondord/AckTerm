public partial class ackterm
{
    private partial class uc_autoprocess
    {
        private partial class uc_maptxtcaret
        {
            private void defCoordSearchPatient(
                    int cur_x = 0,
                    int cur_y = 0,
                    int lbls_x = 0,
                    int lble_x = 0,
                    int lbl_y = 0,
                    int vals_x = 0,
                    int vale_x = 0,
                    int val_y = 0,
                    ElmScrns a = ElmScrns.NotFound,
                    bool b = false,
                    UseWhat c = UseWhat.Field,
                    string strText = ""
                )
            {
                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.SearchPatient,
                        new System.Drawing.Point(cur_x, cur_y),
                        new uc_formpartsinfo(strText,
                            new System.Drawing.Point(lbls_x, lbl_y),
                            new System.Drawing.Point(lble_x, lbl_y)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(vals_x, val_y),
                            new System.Drawing.Point(vale_x, val_y)
                        ),
                        a,
                        b,
                        c
                    ));
            }

            private void searchpatientinfo()
            {
                defCoordSearchPatient(5, 19, 5, 10, 4, 5, 14, 19, ElmScrns.SearchPatientAccountNum, false, UseWhat.Field, "ACN #");
                defCoordSearchPatient(17, 19, 17, 21, 4, 17, 34, 19, ElmScrns.SearchPatientName, false, UseWhat.Field, "Name");
                defCoordSearchPatient(37, 19, 37, 40, 4, 37, 49, 19, ElmScrns.SearchPatientDOB, false, UseWhat.Field, "DOB");
                defCoordSearchPatient(52, 19, 52, 60, 4, 52, 56, 19, ElmScrns.SearchPatientCategory, false, UseWhat.Field, "Category");
                defCoordSearchPatient(63, 19, 63, 68, 4, 63, 74, 19, ElmScrns.SearchPatientSSN, false, UseWhat.Field, "SSN #");
                defCoordSearchPatient(25, 2, 25, 53, 2, 0, 0, 0, ElmScrns.SearchPatientTextHeader, false, UseWhat.Field, "Selection Screen for Patient");
                defCoordSearchPatient(64, 0, 64, 68, 0, 68, 77, 0, ElmScrns.SearchPatientPaginate, false, UseWhat.Field, "Page");
                defCoordSearchPatient(2, 6, 2, 3, 4, 0, 0, 0, ElmScrns.SearchPatientResRow6, false, UseWhat.Field, "C");
                defCoordSearchPatient(2, 7, 2, 3, 4, 0, 0, 0, ElmScrns.SearchPatientResRow7, false, UseWhat.Field, "C");
                defCoordSearchPatient(2, 8, 2, 3, 4, 0, 0, 0, ElmScrns.SearchPatientResRow8, false, UseWhat.Field, "C");
                defCoordSearchPatient(2, 9, 2, 3, 4, 0, 0, 0, ElmScrns.SearchPatientResRow8, false, UseWhat.Field, "C");
                defCoordSearchPatient(2, 9, 2, 3, 4, 0, 0, 0, ElmScrns.SearchPatientResRow9, false, UseWhat.Field, "C");
                defCoordSearchPatient(2, 10, 2, 3, 4, 0, 0, 0, ElmScrns.SearchPatientResRow10, false, UseWhat.Field, "C");
                defCoordSearchPatient(2, 11, 2, 3, 4, 0, 0, 0, ElmScrns.SearchPatientResRow11, false, UseWhat.Field, "C");
                defCoordSearchPatient(2, 12, 2, 3, 4, 0, 0, 0, ElmScrns.SearchPatientResRow12, false, UseWhat.Field, "C");
                defCoordSearchPatient(2, 13, 2, 3, 4, 0, 0, 0, ElmScrns.SearchPatientResRow13, false, UseWhat.Field, "C");
                defCoordSearchPatient(2, 14, 2, 3, 4, 0, 0, 0, ElmScrns.SearchPatientResRow14, false, UseWhat.Field, "C");
                defCoordSearchPatient(2, 15, 2, 3, 4, 0, 0, 0, ElmScrns.SearchPatientResRow15, false, UseWhat.Field, "C");
                defCoordSearchPatient(2, 16, 2, 3, 4, 0, 0, 0, ElmScrns.SearchPatientResRow16, false, UseWhat.Field, "C");
                defCoordSearchPatient(2, 17, 2, 3, 4, 0, 0, 0, ElmScrns.SearchPatientResRow17, false, UseWhat.Field, "C");

                defCoordSearchPatient(58, 11, 20, 58, 11, 0, 0, 0, ElmScrns.SearchPatientNotFound, false, UseWhat.Field, "No Choices Found That Match Your Reque");
            }
        }
    }
}