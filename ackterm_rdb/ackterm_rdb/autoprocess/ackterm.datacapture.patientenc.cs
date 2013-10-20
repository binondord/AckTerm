public partial class ackterm
{
    private partial class uc_autoprocess
    {
        public DataCaptureEncResult DataCapturePatientEnc()
        {
            string strPatientEncNum = "";
            string strPatientEncRX = "";
            string strPatientEncInjury = "";
            string strPatientEncOrderDate = "";
            string strPatientEncInitialTreatment = "";
            string strPatientEncXrayDate = "";
            string strPatientEncAcuteManifestation = "";
            string strPatientEncAuthNum = "";
            string strPatientEncLastSeen = "";
            string strPatientEncAuthorizedVisits = "";
            string strPatientEncEmergencyYN = "";
            string strPatientEncAuthFrom = "";
            string strPatientEncAuthTo = "";
            string strPatientEncPOS = "";
            string strPatientEncReferredLab = "";
            string strPatientEncBox19Desc = "";
            string strPatientEncHCFABox19Date = "";
            string strPatientEncReferringCode = "";
            string strPatientEncFirstSymptom = "";
            string strPatientEncFirstConsulted = "";
            string strPatientEncSimilarSymptom = "";
            string strPatientEncDischargeDate = "";
            string strPatientEncStatusEmployment = "";
            string strPatientEncStatusStudent = "";
            string strPatientEncRelatedAccident = "";
            string strPatientEncEmploymentYN = "";
            string strPatientEncUnable2WorkFrom = "";
            string strPatientEncUnable2WorkTo = "";
            string strPatientEncHospiFrom = "";
            string strPatientEncHospiTo = "";
            string strPatientEncDisabilityFrom = "";
            string strPatientEncDisabilityTo = "";
            string strPatientEncSoc = "";
            string strPatientEncSocAmount = "";
            string strPatientEncOrigRefNo = "";
            string strPatientEncStatus = "";
            string strPatientEncFamilyPlanning = "";
            string strPatientEncBillingLimit = "";
            string strPatientEncSchedofBenefits = "";
            string strPatientEncReferralDate = "";
            string strPatientEncLastCertification = "";

            int dataStartVal = 0;
            int dataEndVal = 0;
            int dataYPOS = 0;

            DataCaptureEncResult res = DataCaptureEncResult.None;

            string tmpstring = "";
            int encCount = 0;

            uc_maptxtcaretinfo tmpElement;
            System.Collections.Generic.List<uc_maptxtcaretinfo> applicableElems = myMapTxtCaret.FindElemByPrimeMainMenu(curMenu);

            for (int i = 0; i < applicableElems.Count; i++)
            {
                tmpElement = applicableElems[i];

                dataStartVal = tmpElement.frmvalue.prmStartPos.X;
                dataEndVal = tmpElement.frmvalue.prmEndPos.X;
                dataYPOS = tmpElement.frmvalue.prmStartPos.Y;

                tmpstring = retrieveStrData(rdbp2, rdbp3, dataStartVal, dataEndVal, dataYPOS);

                switch(tmpElement.seqScrn)
                {
                    case ElmScrns.PatientEncNum:
                        strPatientEncNum = tmpstring;
                        break;
                    case ElmScrns.PatientEncRX:
                        strPatientEncRX = tmpstring;
                        break;
                    case ElmScrns.PatientEncInjury:
                        strPatientEncInjury = tmpstring;
                        break;
                    case ElmScrns.PatientEncOrderDate:
                        strPatientEncOrderDate = tmpstring;
                        break;
                    case ElmScrns.PatientEncInitialTreatment:
                        strPatientEncInitialTreatment = tmpstring;
                        break;
                    case ElmScrns.PatientEncXrayDate:
                        strPatientEncXrayDate = tmpstring;
                        break;
                    case ElmScrns.PatientEncAcuteManifestation:
                        strPatientEncAcuteManifestation = tmpstring;
                        break;
                    case ElmScrns.PatientEncAuthNum:
                        strPatientEncAuthNum = tmpstring;
                        break;
                    case ElmScrns.PatientEncLastSeen:
                        strPatientEncLastSeen = tmpstring;
                        break;
                    case ElmScrns.PatientEncAuthorizedVisits:
                        strPatientEncAuthorizedVisits = tmpstring;
                        break;
                    case ElmScrns.PatientEncEmergencyYN:
                        strPatientEncEmergencyYN = tmpstring;
                        break;
                    case ElmScrns.PatientEncAuthFrom:
                        strPatientEncAuthFrom = tmpstring;
                        break;
                    case ElmScrns.PatientEncAuthTo:
                        strPatientEncAuthTo = tmpstring;
                        break;
                    case ElmScrns.PatientEncPOS:
                        strPatientEncPOS = tmpstring;
                        break;
                    case ElmScrns.PatientEncReferredLab:
                        strPatientEncReferredLab = tmpstring;
                        break;
                    case ElmScrns.PatientEncBox19Desc:
                        strPatientEncBox19Desc = tmpstring;
                        break;
                    case ElmScrns.PatientEncHCFABox19Date:
                        strPatientEncHCFABox19Date = tmpstring;
                        break;
                    case ElmScrns.PatientEncReferringCode:
                        strPatientEncReferringCode = tmpstring;
                        break;
                    case ElmScrns.PatientEncFirstSymptom:
                        strPatientEncFirstSymptom = tmpstring;
                        break;
                    case ElmScrns.PatientEncFirstConsulted:
                        strPatientEncFirstConsulted = tmpstring;
                        break;
                    case ElmScrns.PatientEncSimilarSymptom:
                        strPatientEncSimilarSymptom = tmpstring;
                        break;
                    case ElmScrns.PatientEncDischargeDate:
                        strPatientEncDischargeDate = tmpstring;
                        break;
                    case ElmScrns.PatientEncStatusEmployment:
                        strPatientEncStatusEmployment = tmpstring;
                        break;
                    case ElmScrns.PatientEncStatusStudent:
                        strPatientEncStatusStudent = tmpstring;
                        break;
                    case ElmScrns.PatientEncRelatedAccident:
                        strPatientEncRelatedAccident = tmpstring;
                        break;
                    case ElmScrns.PatientEncEmploymentYN:
                        strPatientEncEmploymentYN = tmpstring;
                        break;
                    case ElmScrns.PatientEncUnable2WorkFrom:
                        strPatientEncUnable2WorkFrom = tmpstring;
                        break;
                    case ElmScrns.PatientEncUnable2WorkTo:
                        strPatientEncUnable2WorkTo = tmpstring;
                        break;
                    case ElmScrns.PatientEncHospiFrom:
                        strPatientEncHospiFrom = tmpstring;
                        break;
                    case ElmScrns.PatientEncHospiTo:
                        strPatientEncHospiTo = tmpstring;
                        break;
                    case ElmScrns.PatientEncDisabilityFrom:
                        strPatientEncDisabilityFrom = tmpstring;
                        break;
                    case ElmScrns.PatientEncDisabilityTo:
                        strPatientEncDisabilityTo = tmpstring;
                        break;
                    case ElmScrns.PatientEncSoc:
                        strPatientEncSoc = tmpstring;
                        break;
                    case ElmScrns.PatientEncSocAmount:
                        strPatientEncSocAmount = tmpstring;
                        break;
                    case ElmScrns.PatientEncOrigRefNo:
                        strPatientEncOrigRefNo = tmpstring;
                        break;
                    case ElmScrns.PatientEncStatus:
                        strPatientEncStatus = tmpstring;
                        break;
                    case ElmScrns.PatientEncFamilyPlanning:
                        strPatientEncFamilyPlanning = tmpstring;
                        break;
                    case ElmScrns.PatientEncBillingLimit:
                        strPatientEncBillingLimit = tmpstring;
                        break;
                    case ElmScrns.PatientEncSchedofBenefits:
                        strPatientEncSchedofBenefits = tmpstring;
                        break;
                    case ElmScrns.PatientEncReferralDate:
                        strPatientEncReferralDate = tmpstring;
                        break;
                    case ElmScrns.PatientEncLastCertification:
                        strPatientEncLastCertification = tmpstring;
                        break;
                }
            }

            //just capture for now
            res = DataCaptureEncResult.IsNew;

            if(res == DataCaptureEncResult.IsNew)
            {
                currentpatient.myEncounters.Add(
                    new uc_someencounter(
                                            strPatientEncNum,
                                            strPatientEncRX,
                                            strPatientEncInjury,
                                            strPatientEncOrderDate,
                                            strPatientEncInitialTreatment,
                                            strPatientEncXrayDate,
                                            strPatientEncAcuteManifestation,
                                            strPatientEncAuthNum,
                                            strPatientEncLastSeen,
                                            strPatientEncAuthorizedVisits,
                                            strPatientEncEmergencyYN,
                                            strPatientEncAuthFrom,
                                            strPatientEncAuthTo,
                                            strPatientEncPOS,
                                            strPatientEncReferredLab,
                                            strPatientEncBox19Desc,
                                            strPatientEncHCFABox19Date,
                                            strPatientEncReferringCode,
                                            strPatientEncFirstSymptom,
                                            strPatientEncFirstConsulted,
                                            strPatientEncSimilarSymptom,
                                            strPatientEncDischargeDate,
                                            strPatientEncStatusEmployment,
                                            strPatientEncStatusStudent,
                                            strPatientEncRelatedAccident,
                                            strPatientEncEmploymentYN,
                                            strPatientEncUnable2WorkFrom,
                                            strPatientEncUnable2WorkTo,
                                            strPatientEncHospiFrom,
                                            strPatientEncHospiTo,
                                            strPatientEncDisabilityFrom,
                                            strPatientEncDisabilityTo,
                                            strPatientEncSoc,
                                            strPatientEncSocAmount,
                                            strPatientEncOrigRefNo,
                                            strPatientEncStatus,
                                            strPatientEncFamilyPlanning,
                                            strPatientEncBillingLimit,
                                            strPatientEncSchedofBenefits,
                                            strPatientEncReferralDate,
                                            strPatientEncLastCertification
                        )
                    );
            }

            return res;
        }
    }
}
