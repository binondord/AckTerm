public partial class ackterm
{
    private partial class uc_autoprocess
    {
        private partial class uc_maptxtcaret
        {
            private void defCoordPatientIns(
                    int lcol = 0,
                    int xcd = 0,
                    bool lend = false,
                    int ycd = -1,
                    ElmScrns es = ElmScrns.NotFound,
                    int width = 0,
                    bool withVal = true,
                    UseWhat uw = UseWhat.None,
                    string strText = "",
                    FormScrnOpt frmscropt = FormScrnOpt.None
                )
            {
                x_coord = (xcd != 0) ? xcd : 27;
                lftColStart = (lcol != 0) ? lcol : 1;
                lftColEnd = (lend == true) ? x_coord : (x_coord - 1);

                if(x_coord == 27)
                    y_coord++;

                y_coord = (ycd != -1) ? ycd : y_coord;

                valwidth = x_coord + width;

                int phonecoord_x = x_coord;
                switch (frmscropt)
                {
                    case FormScrnOpt.PhoneWithParen:
                        phonecoord_x++;
                        break;
                }

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientIns,
                        new System.Drawing.Point(phonecoord_x, y_coord),
                        new uc_formpartsinfo(strText,
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(phonecoord_x, y_coord),
                            new System.Drawing.Point(valwidth, y_coord)
                        ),
                        es,
                        withVal,
                        uw
                    ));
            }

            private void formPatientIns()
            {
                defCoordPatientIns(0, 0, false, 1, ElmScrns.PatientInsCode, 6, true, UseWhat.None, "Insurance Company Code _:");
                defCoordPatientIns(0, 0, false, -1, ElmScrns.PatientInsMemNum, 26, true, UseWhat.None, "Subscriber No. _________:");
                defCoordPatientIns(0, 0, false, -1, ElmScrns.PatientInsGrp, 26, true, UseWhat.None, "Group No. ______________:");
                defCoordPatientIns(0, 0, false, -1, ElmScrns.PatientInsPayPlan, 10, true, UseWhat.None, "Pay Plan _______________:");
                defCoordPatientIns(0, 0, false, -1, ElmScrns.PatientInsCovPlanFrom, 10, true, UseWhat.None, "Coverage From __________:");
                defCoordPatientIns(45, 48, true, -1, ElmScrns.PatientInsCovPlanTo, 10, true, UseWhat.None, "To:");
                defCoordPatientIns(0, 0, false, -1, ElmScrns.PatientInsCoPayment, 9, true, UseWhat.None, "Co Payment _____________:");
                defCoordPatientIns(0, 0, false, -1, ElmScrns.PatientInsDeductible, 9, true, UseWhat.None, "Deductible Met _________:");
                defCoordPatientIns(41, 48, true, -1, ElmScrns.PatientInsStatus, 20, true, UseWhat.None, "Status:");
                defCoordPatientIns(0, 0, false, -1, ElmScrns.PatientInsPriSec, 1, true, UseWhat.None, "Primary/Secondary(P/S/X):");
                defCoordPatientIns(39, 48, true, -1, ElmScrns.PatientInsAdjuster, 26, true, UseWhat.None, "Adjuster:");
                defCoordPatientIns(0, 0, false, -1, ElmScrns.PatientInsAssignment, 1, true, UseWhat.None, "Assignment _____________:");
                defCoordPatientIns(38, 48, true, -1, ElmScrns.PatientInsClaimNo, 20, true, UseWhat.None, "Claim No.:");
                defCoordPatientIns(0, 0, false, -1, ElmScrns.PatientInsRel2Insured, 1, true, UseWhat.None, "Relation to Insured ____:");
                defCoordPatientIns(0, 0, false, -1, ElmScrns.PatientInsInsuredName, 26, true, UseWhat.None, "Insured's Name _________:");
                defCoordPatientIns(0, 0, false, -1, ElmScrns.PatientInsInsuredAddress, 35, true, UseWhat.None, "Address ________________:");
                defCoordPatientIns(0, 0, false, -1, ElmScrns.PatientInsInsuredZipCode, 10, true, UseWhat.None, "Zip Code _______________:");
                defCoordPatientIns(43, 48, true, -1, ElmScrns.PatientInsInsuredCity, 19, true, UseWhat.None, "City:");
                defCoordPatientIns(67, 73, true, -1, ElmScrns.PatientInsInsuredState, 2, true, UseWhat.None, "State:");
                defCoordPatientIns(0, 0, false, -1, ElmScrns.PatientInsInsuredPhone, 13, true, UseWhat.None, "Phone No. ______________:", FormScrnOpt.PhoneWithParen);
                defCoordPatientIns(0, 0, false, -1, ElmScrns.PatientInsInsuredDOB, 10, true, UseWhat.None, "Insured's DOB __________:");
                defCoordPatientIns(69, 73, true, -1, ElmScrns.PatientInsInsuredSex, 1, true, UseWhat.None, "Sex:");
                defCoordPatientIns(0, 0, false, -1, ElmScrns.PatientInsInsuredSSS, 10, true, UseWhat.None, "Social Security No. ____:");
                defCoordPatientIns(0, 0, false, -1, ElmScrns.PatientInsInsuredEmployer, 26, true, UseWhat.None, "Insured's Employer _____:");
                defCoordPatientIns(0, 0, false, -1, ElmScrns.PatientInsInsuredEmpAddr, 25, true, UseWhat.None, "Employer Address _______:");
                defCoordPatientIns(0, 0, false, -1, ElmScrns.PatientInsInsuredEmpZip, 10, true, UseWhat.None, "Zip Code _______________:");
                defCoordPatientIns(43, 48, true, -1, ElmScrns.PatientInsInsuredEmpCity, 19, true, UseWhat.None, "City:");
                defCoordPatientIns(67, 73, true, -1, ElmScrns.PatientInsInsuredEmpState, 2, true, UseWhat.None, "State:");
                defCoordPatientIns(0, 0, false, -1, ElmScrns.PatientInsInsuredEmpPhone, 13, true, UseWhat.None, "Phone No. ______________:", FormScrnOpt.PhoneWithParen);
                defCoordPatientIns(1, 63, true, 23, ElmScrns.PatientInsRecordInUse, 0, true, UseWhat.None, "Record In Use At Another Terminal.  Press Any Key To Continue.");
                defCoordPatientIns(1, 54, true, 23, ElmScrns.QuestionModifyEncInfo, 1, true, UseWhat.None, "  Would You Like to Modify Encounter Information (Y/N)");
            }
        }
    }
}
