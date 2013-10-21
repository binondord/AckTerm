public partial class ackterm
{
    private partial class uc_autoprocess
    {
        private partial class uc_maptxtcaret
        {
            private void defCoordPatientInfo(
                    int lcol = 0,
                    int xcd = 0
                )
            {
                x_coord = (xcd != 0) ? xcd : 25;
                lftColStart = (lcol != 0) ? lcol : 1;
                lftColEnd = x_coord;

                if (x_coord == 25)
                    y_coord++;
            }

            private void formPatientInfo()
            {
                defCoordPatientInfo();
                y_coord = 0;

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Patient's Account No. _:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 26, y_coord)),
                        ElmScrns.PatientDemographics,
                        true,
                        UseWhat.None
                    ));
                //Patient Info Screen
                
                defCoordPatientInfo();
                y_coord = 0;

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Patient's Account No. _:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 26, y_coord)),
                        ElmScrns.PatientInfoAcctNum,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Guarantor _____________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 7, y_coord)
                        ),
                        ElmScrns.PatientInfoGuarrantor,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Chart Number __________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 12, y_coord)),
                        ElmScrns.PatientInfoChartNum,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Name(Last, First Init.):",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 26, y_coord)),
                        ElmScrns.PatientInfoName,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Address _______________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 35, y_coord)),
                        ElmScrns.PatientInfoAddr,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Zip Code ______________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)),
                        ElmScrns.PatientInfoZip,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo(39,45);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("City:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 19, y_coord)),
                        ElmScrns.PatientInfoCity,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo(64,71);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("State:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 2, y_coord)),
                        ElmScrns.PatientInfoState,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord + 1, y_coord),
                        new uc_formpartsinfo("Home Phone No. ________:",
                            new System.Drawing.Point(lftColStart-1, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord + 1, y_coord),
                            new System.Drawing.Point(x_coord + 13, y_coord)),
                        ElmScrns.PatientInfoHomePhone,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo(39,46);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Cell:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 18, y_coord)),
                        ElmScrns.PatientInfoCell,
                        true,
                        UseWhat.None
                    ));

                //URREA
                
                defCoordPatientInfo(39, 45);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Cell:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 20, y_coord)),
                        ElmScrns.PatientInfoCell,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Sex (M/F/U)____________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 1, y_coord)),
                        ElmScrns.PatientInfoSex,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo(39,45);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("DOB :",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)),
                        ElmScrns.PatientInfoDOB,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo(66,71);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Age:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 6, y_coord)),
                        ElmScrns.PatientInfoAge,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Marital Status (S/M/D)_:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 1, y_coord)),
                        ElmScrns.PatientInfoMStatus,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo(33,45);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Ethnicity :",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 1, y_coord)),
                        ElmScrns.PatientInfoEthnicity,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Social Security No. ___:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 11, y_coord)),
                        ElmScrns.PatientInfoSSN,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo(39,45);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("DL# :",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 14, y_coord)),
                        ElmScrns.PatientInfoDL,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Occupation ____________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 26, y_coord)),
                        ElmScrns.PatientInfoOccupation,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Employer ______________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 26, y_coord)),
                        ElmScrns.PatientInfoEmployer,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Address _______________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 26, y_coord)),
                        ElmScrns.PatientInfoEmployerAddr,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Zip Code ______________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)),
                        ElmScrns.PatientInfoEmployerZip,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo(39,45);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("City:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 19, y_coord)),
                        ElmScrns.PatientInfoEmployerCity,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo(64,71);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("State:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 2, y_coord)),
                        ElmScrns.PatientInfoEmployerState,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord + 1, y_coord),
                        new uc_formpartsinfo("Phone _________________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord + 1, y_coord),
                            new System.Drawing.Point(x_coord + 18, y_coord)),
                        ElmScrns.PatientInfoEmployerPhone,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Category ______________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 4, y_coord)),
                        ElmScrns.PatientInfoCategory,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo();
                y_coord--;

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Category ______________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord + 12, y_coord),
                            new System.Drawing.Point(x_coord + 51, y_coord)),
                        ElmScrns.PatientInfoCategoryVal,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Referral ______________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 6, y_coord)),
                        ElmScrns.PatientInfoReferral,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo();
                y_coord--;

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Referral ______________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord + 12, y_coord),
                            new System.Drawing.Point(x_coord + 37, y_coord)),
                        ElmScrns.PatientInfoReferralVal,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("PCP ___________________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 6, y_coord)),
                        ElmScrns.PatientInfoPCP,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo(35,45);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Hospital:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 6, y_coord)),
                        ElmScrns.PatientInfoHospital,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo(55,65);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Language:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)),
                        ElmScrns.PatientInfoLanguage,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("E-mail ________________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 35, y_coord)),
                        ElmScrns.PatientInfoEmail,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Remark ________________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 40, y_coord)),
                        ElmScrns.PatientInfoRemarks1,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Remark ________________:",
                            new System.Drawing.Point(lftColStart, y_coord - 1),
                            new System.Drawing.Point(lftColEnd, y_coord - 1)),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 40, y_coord)),
                        ElmScrns.PatientInfoRemarks2,
                        true,
                        UseWhat.Field
                    ));

                defCoordPatientInfo(1, 54);

                y_coord = 23;
                //54,23
                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("  Would You Like to Modify Insurance Information (Y/N)",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 1, y_coord)
                        ),
                        ElmScrns.QuestionModifyInsInfo,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo(1,54);
                y_coord = 23;
                //54,23
                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("  Would You Like to Modify Encounter Information (Y/N)",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 1, y_coord)
                        ),
                        ElmScrns.QuestionModifyEncInfo,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientInfo(1, 27);
                y_coord = 23;
                //54,23
                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientInfo,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Press any key to continue.",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 1, y_coord)
                        ),
                        ElmScrns.PatientInfoPressAnyKey,
                        true,
                        UseWhat.None
                    ));
            }
        }
    }
}