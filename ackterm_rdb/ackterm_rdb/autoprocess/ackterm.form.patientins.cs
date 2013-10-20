public partial class ackterm
{
    private partial class uc_autoprocess
    {
        private partial class uc_maptxtcaret
        {
            private void defCoordPatientIns(
                    int lcol = 0,
                    int xcd = 0,
                    bool lend = false
                )
            {
                x_coord = (xcd != 0) ? xcd : 27;
                lftColStart = (lcol != 0) ? lcol : 1;
                lftColEnd = (lend == true) ? x_coord : (x_coord - 1);

                if(x_coord == 27)
                    y_coord++;
            }

            private void formPatientIns()
            {
                y_coord = 0;

                defCoordPatientIns();
                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Insurance Company Code _:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 6, y_coord)
                        ),
                        ElmScrns.PatientInsCode,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns();
                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Subscriber No. _________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 26, y_coord)
                        ),
                        ElmScrns.PatientInsMemNum,
                        true,
                        UseWhat.None
                    ));
                defCoordPatientIns();
                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Group No. ______________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 26, y_coord)
                        ),
                        ElmScrns.PatientInsGrp,
                        true,
                        UseWhat.None
                    ));
                defCoordPatientIns();
                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Pay Plan _______________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientInsPayPlan,
                        true,
                        UseWhat.None
                    ));
                defCoordPatientIns();
                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Coverage From __________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientInsCovPlanFrom,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns(45,48,true);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("To:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientInsCovPlanTo,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Co Payment _____________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 9, y_coord)
                        ),
                        ElmScrns.PatientInsCoPayment,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Deductible Met _________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 9, y_coord)
                        ),
                        ElmScrns.PatientInsDeductible,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns(41, 48, true);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Status:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 20, y_coord)
                        ),
                        ElmScrns.PatientInsStatus,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Primary/Secondary(P/S/X):",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 1, y_coord)
                        ),
                        ElmScrns.PatientInsPriSec,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns(39,48, true);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Adjuster:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 26, y_coord)
                        ),
                        ElmScrns.PatientInsAdjuster,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Assignment _____________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 1, y_coord)
                        ),
                        ElmScrns.PatientInsAssignment,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns(38,48,true);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Claim No.:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 20, y_coord)
                        ),
                        ElmScrns.PatientInsClaimNo,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Relation to Insured ____:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 1, y_coord)
                        ),
                        ElmScrns.PatientInsRel2Insured,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Insured's Name _________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 26, y_coord)
                        ),
                        ElmScrns.PatientInsInsuredName,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Address ________________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 35, y_coord)
                        ),
                        ElmScrns.PatientInsInsuredAddress,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Zip Code _______________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientInsInsuredZipCode,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns(43,48,true);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("City:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 19, y_coord)
                        ),
                        ElmScrns.PatientInsInsuredCity,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns(67, 73, true);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("State:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 2, y_coord)
                        ),
                        ElmScrns.PatientInsInsuredState,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord + 1, y_coord),
                        new uc_formpartsinfo("Phone No. ______________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord + 1, y_coord),
                            new System.Drawing.Point(x_coord + 13 , y_coord)
                        ),
                        ElmScrns.PatientInsInsuredPhone,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Insured's DOB __________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientInsInsuredDOB,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns(69,73,true);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Sex:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 1, y_coord)
                        ),
                        ElmScrns.PatientInsInsuredSex,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Social Security No. ____:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientInsInsuredSSS,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Insured's Employer _____:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 26, y_coord)
                        ),
                        ElmScrns.PatientInsInsuredEmployer,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Employer Address _______:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 25, y_coord)
                        ),
                        ElmScrns.PatientInsInsuredEmpAddr,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Zip Code _______________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientInsInsuredEmpZip,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns(43,48,true);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("City:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 19, y_coord)
                        ),
                        ElmScrns.PatientInsInsuredEmpCity,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns(67, 73, true);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("State:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 2, y_coord)
                        ),
                        ElmScrns.PatientInsInsuredEmpState,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord + 1, y_coord),
                        new uc_formpartsinfo("Phone No. ______________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord + 1, y_coord),
                            new System.Drawing.Point(x_coord + 13, y_coord)
                        ),
                        ElmScrns.PatientInsInsuredEmpPhone,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns(1,63,true);
                y_coord = 23;

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Record In Use At Another Terminal.  Press Any Key To Continue.",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(0, 0),
                            new System.Drawing.Point(0, 0)
                        ),
                        ElmScrns.PatientInsRecordInUse,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientIns();
            }
        }
    }
}
