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
                    int ycd = -1
                )
            {
                x_coord = (xcd != 0) ? xcd : ((left) ? 22 : 61);
                lftColStart = (lcol != 0) ? lcol : 0;
                lftColEnd = x_coord;

                if (left)
                    y_coord++;
                y_coord = (ycd != -1) ? ycd : y_coord;
            }

            private void formPatientEnc()
            {
                defCoordPatientEnc(false,55,70, 0);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Encounter #:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 6, y_coord)
                        ),
                        ElmScrns.PatientEncNum,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Description/Rx Number:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 26, y_coord)
                        ),
                        ElmScrns.PatientEncRX,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc(false);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Injury:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientEncInjury,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Order Date __________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientEncOrderDate,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc(false);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Initial Treatment:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientEncInitialTreatment,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("X-ray Date __________:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientEncXrayDate,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc(false);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Acute Manifestation:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientEncAcuteManifestation,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Authorization No. ___:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 18, y_coord)
                        ),
                        ElmScrns.PatientEncAuthNum,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc(false);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Last Seen:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientEncLastSeen,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Authorized Visits ___:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 9, y_coord)
                        ),
                        ElmScrns.PatientEncAuthorizedVisits,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc(false);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Emergency(Y/N):",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 1, y_coord)
                        ),
                        ElmScrns.PatientEncEmergencyYN,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Authorized From _____:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientEncAuthFrom,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc(false);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Authorized To:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientEncAuthTo,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Place of Service ____:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 6, y_coord)
                        ),
                        ElmScrns.PatientEncPOS,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc(false);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Referred Lab:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 6, y_coord)
                        ),
                        ElmScrns.PatientEncReferredLab,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Box 19 Description __:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 30, y_coord)
                        ),
                        ElmScrns.PatientEncBox19Desc,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("HCFA Box 19 Date ____:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientEncHCFABox19Date,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc(false);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Referring Code:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 8, y_coord)
                        ),
                        ElmScrns.PatientEncReferringCode,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("First Symptom _______:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientEncFirstSymptom,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc(false);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("First Consulted:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientEncFirstConsulted,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Similar Symptom _____:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 1, y_coord)
                        ),
                        ElmScrns.PatientEncSimilarSymptom,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc(false);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Discharge Date:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientEncDischargeDate,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Status Employment ___:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 1, y_coord)
                        ),
                        ElmScrns.PatientEncStatusEmployment,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc(false);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Status Student(F/P/N):",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 1, y_coord)
                        ),
                        ElmScrns.PatientEncStatusStudent,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Related: Accident ___:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 1, y_coord)
                        ),
                        ElmScrns.PatientEncRelatedAccident,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc(false);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Employment(Y/N):",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 1, y_coord)
                        ),
                        ElmScrns.PatientEncEmploymentYN,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Unable to Work From _:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientEncUnable2WorkFrom,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc(false);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Unable to Work To:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientEncUnable2WorkTo,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Hospitalization From_:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientEncHospiFrom,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc(false);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Hospitalization To:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientEncHospiTo,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Disability From _____:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientEncDisabilityFrom,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc(false);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Disability To:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientEncDisabilityTo,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Share of Cost Code __:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 3, y_coord)
                        ),
                        ElmScrns.PatientEncSoc,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc(false);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Share of Cost Amount:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 9, y_coord)
                        ),
                        ElmScrns.PatientEncSocAmount,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Original Ref. No.    :",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 26, y_coord)
                        ),
                        ElmScrns.PatientEncOrigRefNo,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc(false);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Status:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 1, y_coord)
                        ),
                        ElmScrns.PatientEncStatus,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc(false, 54, 23, -1);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Status:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 1, y_coord)
                        ),
                        ElmScrns.PatientEncStatus,
                        true,
                        UseWhat.Field
                    ));

                defCoordPatientEnc();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Family Planning _____:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 7, y_coord)
                        ),
                        ElmScrns.PatientEncFamilyPlanning,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc(false);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Billing Limit:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 1, y_coord)
                        ),
                        ElmScrns.PatientEncBillingLimit,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Schedule of Benefits :",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 8, y_coord)
                        ),
                        ElmScrns.PatientEncSchedofBenefits,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc(false);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Referral Date:",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientEncReferralDate,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc();

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Last Certification   :",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(x_coord + 10, y_coord)
                        ),
                        ElmScrns.PatientEncLastCertification,
                        true,
                        UseWhat.None
                    ));

                defCoordPatientEnc(false, 1, 57, 23);

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PatientEnc,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo("Claim: Record does not exist. Press Any Key to Continue.",
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(0, 0),
                            new System.Drawing.Point(0, 0)
                        ),
                        ElmScrns.PromptEncRecordNotFound,
                        true,
                        UseWhat.None
                    ));
            }
        }
    }
}