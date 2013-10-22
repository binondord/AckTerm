public partial class ackterm
{
    private partial class uc_autoprocess
    {
        private partial class uc_maptxtcaret
        {
            private void defCoordPatientInfo(
                    int lcol = 0,
                    int xcd = 0,
                    int ycd = -1,
                    ElmScrns es = ElmScrns.NotFound,
                    int width = 0,
                    bool withVal = true,
                    UseWhat uw = UseWhat.None,
                    string strText = "",
                    FormScrnOpt frmscropt = FormScrnOpt.None,
                    int vstartx = 0
                )
            {
                

                x_coord = (xcd != 0) ? xcd : 25;
                int cur_x = x_coord;
                int valstart_x = x_coord;
                

                lftColStart = (lcol != 0) ? lcol : 1;
                lftColEnd = x_coord;

                if (x_coord == 25)
                    y_coord++;

                y_coord = (ycd != -1) ? ycd : y_coord;

                int lblcoord_y = y_coord;

                valwidth = x_coord + width;

                switch (frmscropt)
                {
                    case FormScrnOpt.Remark2:
                        lblcoord_y = lblcoord_y - 1;
                        break;
                    case FormScrnOpt.InLinewithAnother:
                        valstart_x = valstart_x + vstartx;
                        break;
                    case FormScrnOpt.PhoneWithParen:
                        lftColStart = lftColStart - 1;
                        cur_x = cur_x + 1;
                        break;
                }

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(cur_x, y_coord),
                        new uc_formpartsinfo(strText,
                            new System.Drawing.Point(lftColStart, lblcoord_y),
                            new System.Drawing.Point(lftColEnd, lblcoord_y)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(valstart_x, y_coord),
                            new System.Drawing.Point(valwidth, y_coord)),
                        es,
                        withVal,
                        uw
                    ));
            }

            private void formPatientInfo()
            {
                defCoordPatientInfo(0, 0, 0, ElmScrns.PatientDemographics, 26, true, UseWhat.None, "Patient's Account No. _:");
                defCoordPatientInfo(0, 0, 0, ElmScrns.PatientInfoAcctNum, 26, true, UseWhat.None, "Patient's Account No. _:");
                defCoordPatientInfo(0, 0, -1, ElmScrns.PatientInfoGuarrantor, 7, true, UseWhat.None, "Guarantor _____________:");
                defCoordPatientInfo(0, 0, -1, ElmScrns.PatientInfoChartNum, 12, true, UseWhat.None, "Chart Number __________:");
                defCoordPatientInfo(0, 0, -1, ElmScrns.PatientInfoName, 26, true, UseWhat.None, "Name(Last, First Init.):");
                defCoordPatientInfo(0, 0, -1, ElmScrns.PatientInfoAddr, 35, true, UseWhat.None, "Address _______________:");
                defCoordPatientInfo(0, 0, -1, ElmScrns.PatientInfoZip, 10, true, UseWhat.None, "Zip Code ______________:");
                defCoordPatientInfo(39, 45, -1, ElmScrns.PatientInfoCity, 19, true, UseWhat.None, "City:");
                defCoordPatientInfo(64, 71, -1, ElmScrns.PatientInfoState, 2, true, UseWhat.None, "State:");
                defCoordPatientInfo(0, 0, -1, ElmScrns.PatientInfoHomePhone, 13, true, UseWhat.None, "Home Phone No. ________:", FormScrnOpt.PhoneWithParen);
                defCoordPatientInfo(39, 46, -1, ElmScrns.PatientInfoCell, 18, true, UseWhat.None, "Cell:");

                //URREA
                defCoordPatientInfo(39, 45, -1, ElmScrns.PatientInfoCell, 20, true, UseWhat.None, "Cell:");

                defCoordPatientInfo(0, 0, -1, ElmScrns.PatientInfoSex, 1, true, UseWhat.None, "Sex (M/F/U)____________:");
                defCoordPatientInfo(39, 45, -1, ElmScrns.PatientInfoDOB, 10, true, UseWhat.None, "DOB :");
                defCoordPatientInfo(66, 71, -1, ElmScrns.PatientInfoAge, 6, true, UseWhat.None, "Age:");
                defCoordPatientInfo(0, 0, -1, ElmScrns.PatientInfoMStatus, 1, true, UseWhat.None, "Marital Status (S/M/D)_:");
                defCoordPatientInfo(33, 45, -1, ElmScrns.PatientInfoEthnicity, 1, true, UseWhat.None, "Ethnicity :");
                defCoordPatientInfo(0, 0, -1, ElmScrns.PatientInfoSSN, 11, true, UseWhat.None, "Social Security No. ___:");
                defCoordPatientInfo(39, 45, -1, ElmScrns.PatientInfoDL, 14, true, UseWhat.None, "DL# :");
                defCoordPatientInfo(0, 0, -1, ElmScrns.PatientInfoOccupation, 26, true, UseWhat.None, "Occupation ____________:");
                defCoordPatientInfo(0, 0, -1, ElmScrns.PatientInfoEmployer, 26, true, UseWhat.None, "Employer ______________:");
                defCoordPatientInfo(0, 0, -1, ElmScrns.PatientInfoEmployerAddr, 26, true, UseWhat.None, "Address _______________:");
                defCoordPatientInfo(0, 0, -1, ElmScrns.PatientInfoEmployerZip, 10, true, UseWhat.None, "Zip Code ______________:");
                defCoordPatientInfo(39, 45, -1, ElmScrns.PatientInfoEmployerCity, 19, true, UseWhat.None, "City:");
                defCoordPatientInfo(64, 71, -1, ElmScrns.PatientInfoEmployerState, 2, true, UseWhat.None, "State:");
                defCoordPatientInfo(0, 0, -1, ElmScrns.PatientInfoEmployerPhone, 18, true, UseWhat.None, "Phone _________________:", FormScrnOpt.PhoneWithParen);
                defCoordPatientInfo(0, 0, -1, ElmScrns.PatientInfoCategory, 4, true, UseWhat.None, "Category ______________:");
                defCoordPatientInfo(0, 0, y_coord, ElmScrns.PatientInfoCategoryVal, 51, true, UseWhat.Field, "Category ______________:", FormScrnOpt.InLinewithAnother, 12);
                defCoordPatientInfo(0, 0, -1, ElmScrns.PatientInfoReferral, 6, true, UseWhat.None, "Referral ______________:");
                defCoordPatientInfo(0, 0, y_coord, ElmScrns.PatientInfoReferralVal, 37, true, UseWhat.Field, "Referral ______________:", FormScrnOpt.InLinewithAnother, 12);
                defCoordPatientInfo(0, 0, -1, ElmScrns.PatientInfoPCP, 6, true, UseWhat.None, "PCP ___________________:");
                defCoordPatientInfo(35, 45, -1, ElmScrns.PatientInfoHospital, 6, true, UseWhat.None, "Hospital:");
                defCoordPatientInfo(55, 65, -1, ElmScrns.PatientInfoLanguage, 10, true, UseWhat.None, "Language:");
                defCoordPatientInfo(0, 0, -1, ElmScrns.PatientInfoEmail, 35, true, UseWhat.None, "E-mail ________________:");
                defCoordPatientInfo(0, 0, -1, ElmScrns.PatientInfoRemarks1, 40, true, UseWhat.None, "Remark ________________:");
                defCoordPatientInfo(0, 0, -1, ElmScrns.PatientInfoRemarks2, 40, true, UseWhat.Field, "Remark ________________:", FormScrnOpt.Remark2);
                defCoordPatientInfo(1, 54, 23, ElmScrns.QuestionModifyInsInfo, 1, true, UseWhat.None, "  Would You Like to Modify Insurance Information (Y/N)");
                defCoordPatientInfo(1, 27, 23, ElmScrns.PatientInfoPressAnyKey, 1, true, UseWhat.None, "Press any key to continue.");                
            }
        }
    }
}