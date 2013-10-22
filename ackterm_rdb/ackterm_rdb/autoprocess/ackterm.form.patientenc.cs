public partial class ackterm
{
    private partial class uc_autoprocess
    {
        private partial class uc_maptxtcaret
        {
            private void defCoordPatientEnc(
                    bool left = true,
                    int lcol = 0,
                    int xcd = 0,
                    int ycd = -1,
                    ElmScrns es = ElmScrns.NotFound,
                    int width = 0,
                    bool withVal = true,
                    UseWhat uw = UseWhat.None,
                    string strText = ""
                )
            {
                x_coord = (xcd != 0) ? xcd : ((left) ? 22 : 61);
                lftColStart = (lcol != 0) ? lcol : 0;
                lftColEnd = x_coord;

                if (left)
                    y_coord++;
                y_coord = (ycd != -1) ? ycd : y_coord;

                valwidth = x_coord + width;

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo(strText,
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(valwidth, y_coord)
                        ),
                        es,
                        withVal,
                        uw
                    ));
            }

            private void formPatientEnc()
            {
                defCoordPatientEnc(false, 55, 70, 0, ElmScrns.PatientEncNum, 6, true, UseWhat.None, "Encounter #:");
                defCoordPatientEnc(true, 0, 0, -1, ElmScrns.PatientEncRX, 26, true, UseWhat.None, "Description/Rx Number:");
                defCoordPatientEnc(false, 0, 0, -1, ElmScrns.PatientEncInjury, 10, true, UseWhat.None, "Injury:");
                defCoordPatientEnc(true, 0, 0, -1, ElmScrns.PatientEncOrderDate, 10, true, UseWhat.None, "Order Date __________:");
                defCoordPatientEnc(false, 0, 0, -1, ElmScrns.PatientEncInitialTreatment, 10, true, UseWhat.None, "Initial Treatment:");
                defCoordPatientEnc(true, 0, 0, -1, ElmScrns.PatientEncXrayDate, 10, true, UseWhat.None, "X-ray Date __________:");
                defCoordPatientEnc(false, 0, 0, -1, ElmScrns.PatientEncAcuteManifestation, 10, true, UseWhat.None, "Acute Manifestation:");
                defCoordPatientEnc(true, 0, 0, -1, ElmScrns.PatientEncAuthNum, 18, true, UseWhat.None, "Authorization No. ___:");
                defCoordPatientEnc(false, 0, 0, -1, ElmScrns.PatientEncLastSeen, 10, true, UseWhat.None, "Last Seen:");
                defCoordPatientEnc(true, 0, 0, -1, ElmScrns.PatientEncAuthorizedVisits, 9, true, UseWhat.None, "Authorized Visits ___:");
                defCoordPatientEnc(false, 0, 0, -1, ElmScrns.PatientEncEmergencyYN, 1, true, UseWhat.None, "Emergency(Y/N):");
                defCoordPatientEnc(true, 0, 0, -1, ElmScrns.PatientEncAuthFrom, 10, true, UseWhat.None, "Authorized From _____:");
                defCoordPatientEnc(false, 0, 0, -1, ElmScrns.PatientEncAuthTo, 10, true, UseWhat.None, "Authorized To:");
                defCoordPatientEnc(true, 0, 0, -1, ElmScrns.PatientEncPOS, 6, true, UseWhat.None, "Place of Service ____:");
                defCoordPatientEnc(false, 0, 0, -1, ElmScrns.PatientEncReferredLab, 6, true, UseWhat.None, "Referred Lab:");
                defCoordPatientEnc(true, 0, 0, -1, ElmScrns.PatientEncBox19Desc, 30, true, UseWhat.None, "Box 19 Description __:");
                defCoordPatientEnc(true, 0, 0, -1, ElmScrns.PatientEncHCFABox19Date, 10, true, UseWhat.None, "HCFA Box 19 Date ____:");
                defCoordPatientEnc(false, 0, 0, -1, ElmScrns.PatientEncReferringCode, 8, true, UseWhat.None, "Referring Code:");
                defCoordPatientEnc(true, 0, 0, -1, ElmScrns.PatientEncFirstSymptom, 10, true, UseWhat.None, "First Symptom _______:");
                defCoordPatientEnc(false, 0, 0, -1, ElmScrns.PatientEncFirstConsulted, 10, true, UseWhat.None, "First Consulted:");
                defCoordPatientEnc(true, 0, 0, -1, ElmScrns.PatientEncSimilarSymptom, 1, true, UseWhat.None, "Similar Symptom _____:");
                defCoordPatientEnc(false, 0, 0, -1, ElmScrns.PatientEncDischargeDate, 10, true, UseWhat.None, "Discharge Date:");
                defCoordPatientEnc(true, 0, 0, -1, ElmScrns.PatientEncStatusEmployment, 1, true, UseWhat.None, "Status Employment ___:");
                defCoordPatientEnc(false, 0, 0, -1, ElmScrns.PatientEncStatusStudent, 1, true, UseWhat.None, "Status Student(F/P/N):");
                defCoordPatientEnc(true, 0, 0, -1, ElmScrns.PatientEncRelatedAccident, 1, true, UseWhat.None, "Related: Accident ___:");
                defCoordPatientEnc(false, 0, 0, -1, ElmScrns.PatientEncEmploymentYN, 1, true, UseWhat.None, "Employment(Y/N):");
                defCoordPatientEnc(true, 0, 0, -1, ElmScrns.PatientEncUnable2WorkFrom, 10, true, UseWhat.None, "Unable to Work From _:");
                defCoordPatientEnc(false, 0, 0, -1, ElmScrns.PatientEncUnable2WorkTo, 10, true, UseWhat.None, "Unable to Work To:");
                defCoordPatientEnc(true, 0, 0, -1, ElmScrns.PatientEncHospiFrom, 10, true, UseWhat.None, "Hospitalization From_:");
                defCoordPatientEnc(false, 0, 0, -1, ElmScrns.PatientEncHospiTo, 10, true, UseWhat.None, "Hospitalization To:");
                defCoordPatientEnc(true, 0, 0, -1, ElmScrns.PatientEncDisabilityFrom, 10, true, UseWhat.None, "Disability From _____:");
                defCoordPatientEnc(false, 0, 0, -1, ElmScrns.PatientEncDisabilityTo, 10, true, UseWhat.None, "Disability To:");
                defCoordPatientEnc(true, 0, 0, -1, ElmScrns.PatientEncSoc, 3, true, UseWhat.None, "Share of Cost Code __:");
                defCoordPatientEnc(false, 0, 0, -1, ElmScrns.PatientEncSocAmount, 9, true, UseWhat.None, "Share of Cost Amount:");
                defCoordPatientEnc(true, 0, 0, -1, ElmScrns.PatientEncOrigRefNo, 26, true, UseWhat.None, "Original Ref. No.    :");
                defCoordPatientEnc(false, 0, 0, -1, ElmScrns.PatientEncStatus, 1, true, UseWhat.None, "Status:");
                defCoordPatientEnc(false, 54, 23, -1, ElmScrns.PatientEncStatus, 1, true, UseWhat.Field, "Status:");
                defCoordPatientEnc(true, 0, 0, -1, ElmScrns.PatientEncFamilyPlanning, 7, true, UseWhat.None, "Family Planning _____:");
                defCoordPatientEnc(false, 0, 0, -1, ElmScrns.PatientEncBillingLimit, 1, true, UseWhat.None, "Billing Limit:");
                defCoordPatientEnc(true, 0, 0, -1, ElmScrns.PatientEncSchedofBenefits, 8, true, UseWhat.None, "Schedule of Benefits :");
                defCoordPatientEnc(false, 0, 0, -1, ElmScrns.PatientEncReferralDate, 10, true, UseWhat.None, "Referral Date:");
                defCoordPatientEnc(true, 0, 0, -1, ElmScrns.PatientEncLastCertification, 10, true, UseWhat.None, "Last Certification   :");
                defCoordPatientEnc(false, 1, 57, 23, ElmScrns.PromptEncRecordNotFound, 0, true, UseWhat.None, "Claim: Record does not exist. Press Any Key to Continue.");
            }
        }
    }
}