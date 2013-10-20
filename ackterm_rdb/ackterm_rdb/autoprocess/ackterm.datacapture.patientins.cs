public partial class ackterm
{
    private partial class uc_autoprocess
    {
        public DataCaptureInsResult DataCapturePatientIns()
        {
            string strPatientInsCode="";
            string strPatientInsMemNum="";
            string strPatientInsGrp="";
            string strPatientInsPayPlan="";
            string strPatientInsCovPlanFrom="";
            string strPatientInsCovPlanTo="";
            string strPatientInsCoPayment="";
            string strPatientInsDeductible="";
            string strPatientInsStatus="";
            string strPatientInsPriSec="";
            string strPatientInsAdjuster="";
            string strPatientInsAssignment="";
            string strPatientInsClaimNo="";
            string strPatientInsRel2Insured="";
            string strPatientInsInsuredName="";
            string strPatientInsInsuredAddress="";
            string strPatientInsInsuredZipCode="";
            string strPatientInsInsuredCity="";
            string strPatientInsInsuredState="";
            string strPatientInsInsuredPhone="";
            string strPatientInsInsuredDOB="";
            string strPatientInsInsuredSex="";
            string strPatientInsInsuredSSS="";
            string strPatientInsInsuredEmployer="";
            string strPatientInsInsuredEmpAddr="";
            string strPatientInsInsuredEmpZip="";
            string strPatientInsInsuredEmpCity="";
            string strPatientInsInsuredEmpState="";
            string strPatientInsInsuredEmpPhone="";

            int dataStartVal = 0;
            int dataEndVal = 0;
            int dataYPOS = 0;

            DataCaptureInsResult res = DataCaptureInsResult.None;

            string tmpstring = "";
            int insCount = 0;
            
            uc_maptxtcaretinfo tmpElement;
            System.Collections.Generic.List<uc_maptxtcaretinfo> applicableElems = myMapTxtCaret.FindElemByPrimeMainMenu(curMenu);

            for (int i=0; i < applicableElems.Count; i++)
            {
                tmpElement = applicableElems[i];

                dataStartVal = tmpElement.frmvalue.prmStartPos.X;
                dataEndVal = tmpElement.frmvalue.prmEndPos.X;
                dataYPOS = tmpElement.frmvalue.prmStartPos.Y;

                tmpstring = retrieveStrData(rdbp2, rdbp3, dataStartVal, dataEndVal, dataYPOS);

                

                if (tmpElement.seqScrn == ElmScrns.PatientInsCode)
                {
                    //prntSome.printSome(string.Format("a:{0}\nb:{1}\nc:{2}\nd:{3}\ne:{4}\n", dataStartVal, dataEndVal, dataYPOS, tmpElement.seqScrn, aaa) + " -" + tmpstring + "-", "indiv", countkdownrdb);
                    //countkdownrdb++;
                }

                

                switch (tmpElement.seqScrn)
                {
                    case ElmScrns.PatientInsCode:
                        strPatientInsCode = tmpstring;
                        break;
                    case ElmScrns.PatientInsMemNum:
                        strPatientInsMemNum = tmpstring;
                        break;
                    case ElmScrns.PatientInsGrp:
                        strPatientInsGrp = tmpstring;
                        break;
                    case ElmScrns.PatientInsPayPlan:
                        strPatientInsPayPlan = tmpstring;
                        break;
                    case ElmScrns.PatientInsCovPlanFrom:
                        strPatientInsCovPlanFrom = tmpstring;
                        break;
                    case ElmScrns.PatientInsCovPlanTo:
                        strPatientInsCovPlanTo = tmpstring;
                        break;
                    case ElmScrns.PatientInsCoPayment:
                        strPatientInsCoPayment = tmpstring;
                        break;
                    case ElmScrns.PatientInsDeductible:
                        strPatientInsDeductible = tmpstring;
                        break;
                    case ElmScrns.PatientInsStatus:
                        strPatientInsStatus = tmpstring;
                        break;
                    case ElmScrns.PatientInsPriSec:
                        strPatientInsPriSec = tmpstring;
                        break;
                    case ElmScrns.PatientInsAdjuster:
                        strPatientInsAdjuster = tmpstring;
                        break;
                    case ElmScrns.PatientInsAssignment:
                        strPatientInsAssignment = tmpstring;
                        break;
                    case ElmScrns.PatientInsClaimNo:
                        strPatientInsClaimNo = tmpstring;
                        break;
                    case ElmScrns.PatientInsRel2Insured:
                        strPatientInsRel2Insured = tmpstring;
                        break;

                    /****rel2insure = 2***/
                    case ElmScrns.PatientInsInsuredName:
                        strPatientInsInsuredName = tmpstring;
                        break;
                    case ElmScrns.PatientInsInsuredAddress:
                        
                        strPatientInsInsuredAddress = tmpstring;
                        break;
                    case ElmScrns.PatientInsInsuredZipCode:
                        strPatientInsInsuredZipCode = tmpstring;
                        break;
                    case ElmScrns.PatientInsInsuredPhone:
                        strPatientInsInsuredPhone = tmpstring;
                        break;

                    case ElmScrns.PatientInsInsuredState:
                        strPatientInsInsuredState = tmpstring;
                        break;
                    case ElmScrns.PatientInsInsuredCity:
                        strPatientInsInsuredCity = tmpstring;
                        break;
                    case ElmScrns.PatientInsInsuredDOB:
                        strPatientInsInsuredDOB = tmpstring;
                        break;
                    case ElmScrns.PatientInsInsuredSex:
                        strPatientInsInsuredSex = tmpstring;
                        break;
                    case ElmScrns.PatientInsInsuredSSS:
                        strPatientInsInsuredSSS = tmpstring;
                        break;
                    case ElmScrns.PatientInsInsuredEmployer:
                        strPatientInsInsuredEmployer = tmpstring;
                        break;
                    case ElmScrns.PatientInsInsuredEmpAddr:
                        strPatientInsInsuredEmpAddr = tmpstring;
                        break;
                    case ElmScrns.PatientInsInsuredEmpZip:
                        strPatientInsInsuredEmpZip = tmpstring;
                        break;
                    case ElmScrns.PatientInsInsuredEmpPhone:
                        strPatientInsInsuredEmpPhone = tmpstring;
                        break;
                    case ElmScrns.PatientInsInsuredEmpState:
                        strPatientInsInsuredEmpState = tmpstring;
                        break;
                    case ElmScrns.PatientInsInsuredEmpCity:
                        strPatientInsInsuredEmpCity = tmpstring;
                        break;
                }
            }

            //check first if this is the same insurance as before
            uc_someinsurance tmpInsurance;
            insCount = currentpatient.myInsurances.Count;

            //rdbsb1.Clear();

            //string curpat = string.Format("indexins: {0} - inscount: {1}  -upif\n", indexInsurances, insCount);

            if (indexInsurances != 0 && indexInsurances == insCount)
            {
                tmpInsurance = currentpatient.myInsurances[indexInsurances -1];

                /*
                curpat += string.Format("indexins: {0} - inscount: {1}",indexInsurances,insCount);

                curpat += "PatientInsCode					" + tmpInsurance.PatientInsCode + "\n";
                curpat += "PatientInsMemNum					" + tmpInsurance.PatientInsMemNum + "\n";
                curpat += "PatientInsGrp					" + tmpInsurance.PatientInsGrp + "\n";
                curpat += "PatientInsPayPlan				" + tmpInsurance.PatientInsPayPlan + "\n";
                curpat += "PatientInsCovPlanFrom			" + tmpInsurance.PatientInsCovPlanFrom + "\n";
                curpat += "PatientInsCovPlanTo				" + tmpInsurance.PatientInsCovPlanTo + "\n";
                curpat += "PatientInsCoPayment				" + tmpInsurance.PatientInsCoPayment + "\n";
                curpat += "PatientInsDeductible				" + tmpInsurance.PatientInsDeductible + "\n";
                curpat += "PatientInsStatus					" + tmpInsurance.PatientInsStatus + "\n";
                curpat += "PatientInsPriSec					" + tmpInsurance.PatientInsPriSec + "\n";
                curpat += "PatientInsAdjuster				" + tmpInsurance.PatientInsAdjuster + "\n";
                curpat += "PatientInsAssignment				" + tmpInsurance.PatientInsAssignment + "\n";
                curpat += "PatientInsClaimNo				" + tmpInsurance.PatientInsClaimNo + "\n";
                curpat += "PatientInsRel2Insured			" + tmpInsurance.PatientInsRel2Insured + "\n";
                curpat += "PatientInsInsuredName			" + tmpInsurance.PatientInsInsuredName + "\n";
                curpat += "PatientInsInsuredAddress			" + tmpInsurance.PatientInsInsuredAddress + "\n";
                curpat += "PatientInsInsuredZipCode			" + tmpInsurance.PatientInsInsuredZipCode + "\n";
                curpat += "PatientInsInsuredCity			" + tmpInsurance.PatientInsInsuredCity + "\n";
                curpat += "PatientInsInsuredState			" + tmpInsurance.PatientInsInsuredState + "\n";
                curpat += "PatientInsInsuredPhone			" + tmpInsurance.PatientInsInsuredPhone + "\n";
                curpat += "PatientInsInsuredDOB				" + tmpInsurance.PatientInsInsuredDOB + "\n";
                curpat += "PatientInsInsuredSex				" + tmpInsurance.PatientInsInsuredSex + "\n";
                curpat += "PatientInsInsuredSSS				" + tmpInsurance.PatientInsInsuredSSS + "\n";
                curpat += "PatientInsInsuredEmployer		" + tmpInsurance.PatientInsInsuredEmployer + "\n";
                curpat += "PatientInsInsuredEmpAddr			" + tmpInsurance.PatientInsInsuredEmpAddr + "\n";
                curpat += "PatientInsInsuredEmpZip			" + tmpInsurance.PatientInsInsuredEmpZip + "\n";
                curpat += "PatientInsInsuredEmpCity			" + tmpInsurance.PatientInsInsuredEmpCity + "\n";
                curpat += "PatientInsInsuredEmpState		" + tmpInsurance.PatientInsInsuredEmpState + "\n";
                curpat += "PatientInsInsuredEmpPhone		" + tmpInsurance.PatientInsInsuredEmpPhone + "\n";

                prntSome.printSome(curpat, "stored-", countbmprdb);
                //countbmprdb++;

                string curpatt = "";

                curpatt += "PatientInsCode					" + strPatientInsCode + "\n";
                curpatt += "PatientInsMemNum					" + strPatientInsMemNum + "\n";
                curpatt += "PatientInsGrp					" + strPatientInsGrp + "\n";
                curpatt += "PatientInsPayPlan				" + strPatientInsPayPlan + "\n";
                curpatt += "PatientInsCovPlanFrom			" + strPatientInsCovPlanFrom + "\n";
                curpatt += "PatientInsCovPlanTo				" + strPatientInsCovPlanTo + "\n";
                curpatt += "PatientInsCoPayment				" + strPatientInsCoPayment + "\n";
                curpatt += "PatientInsDeductible				" + strPatientInsDeductible + "\n";
                curpatt += "PatientInsStatus					" + strPatientInsStatus + "\n";
                curpatt += "PatientInsPriSec					" + strPatientInsPriSec + "\n";
                curpatt += "PatientInsAdjuster				" + strPatientInsAdjuster + "\n";
                curpatt += "PatientInsAssignment				" + strPatientInsAssignment + "\n";
                curpatt += "PatientInsClaimNo				" + strPatientInsClaimNo + "\n";
                curpatt += "PatientInsRel2Insured			" + strPatientInsRel2Insured + "\n";
                curpatt += "PatientInsInsuredName			" + strPatientInsInsuredName + "\n";
                curpatt += "PatientInsInsuredAddress			" + strPatientInsInsuredAddress + "\n";
                curpatt += "PatientInsInsuredZipCode			" + strPatientInsInsuredZipCode + "\n";
                curpatt += "PatientInsInsuredCity			" + strPatientInsInsuredCity + "\n";
                curpatt += "PatientInsInsuredState			" + strPatientInsInsuredState + "\n";
                curpatt += "PatientInsInsuredPhone			" + strPatientInsInsuredPhone + "\n";
                curpatt += "PatientInsInsuredDOB				" + strPatientInsInsuredDOB + "\n";
                curpatt += "PatientInsInsuredSex				" + strPatientInsInsuredSex + "\n";
                curpatt += "PatientInsInsuredSSS				" + strPatientInsInsuredSSS + "\n";
                curpatt += "PatientInsInsuredEmployer		" + strPatientInsInsuredEmployer + "\n";
                curpatt += "PatientInsInsuredEmpAddr			" + strPatientInsInsuredEmpAddr + "\n";
                curpatt += "PatientInsInsuredEmpZip			" + strPatientInsInsuredEmpZip + "\n";
                curpatt += "PatientInsInsuredEmpCity			" + strPatientInsInsuredEmpCity + "\n";
                curpatt += "PatientInsInsuredEmpState		" + strPatientInsInsuredEmpState + "\n";
                curpatt += "PatientInsInsuredEmpPhone		" + strPatientInsInsuredEmpPhone + "\n";

                prntSome.printSome(curpatt, "internal-", countbmprdb);
                countbmprdb++;
                */


                if (tmpInsurance.PatientInsCode != strPatientInsCode)
                {
                    //rdbsb1.AppendLine(string.Format("strPatientInsCode \"{0}\" = \"{1}\"", tmpInsurance.PatientInsCode, strPatientInsCode));
                    res = DataCaptureInsResult.IsNew;
                }
                else if (tmpInsurance.PatientInsMemNum != strPatientInsMemNum)
                {
                    //rdbsb1.AppendLine(string.Format("strPatientInsMemNum \"{0}\" = \"{1}\"", tmpInsurance.PatientInsMemNum, strPatientInsMemNum));
                    res = DataCaptureInsResult.IsNew;
                }
                else if (tmpInsurance.PatientInsGrp != strPatientInsGrp)
                {
                    //rdbsb1.AppendLine(string.Format("strPatientInsGrp \"{0}\" = \"{1}\"", tmpInsurance.PatientInsGrp, strPatientInsGrp));
                    res = DataCaptureInsResult.IsNew;
                }
                else if (tmpInsurance.PatientInsCovPlanFrom != strPatientInsCovPlanFrom)
                {
                    //rdbsb1.AppendLine(string.Format("strPatientInsCovPlanFrom \"{0}\" = \"{1}\"", tmpInsurance.PatientInsCovPlanFrom, strPatientInsCovPlanFrom));
                    res = DataCaptureInsResult.IsNew;
                }
                else if (tmpInsurance.PatientInsPriSec != strPatientInsPriSec)
                {
                    //rdbsb1.AppendLine(string.Format("strPatientInsPriSec \"{0}\" = \"{1}\"", tmpInsurance.PatientInsPriSec, strPatientInsPriSec));
                    res = DataCaptureInsResult.IsNew;
                }
                else if (tmpInsurance.PatientInsAdjuster != strPatientInsAdjuster)
                {
                    //rdbsb1.AppendLine(string.Format("strPatientInsAdjuster \"{0}\" = \"{1}\"", tmpInsurance.PatientInsAdjuster, strPatientInsAdjuster));
                    res = DataCaptureInsResult.IsNew;
                }
                else if (tmpInsurance.PatientInsClaimNo != strPatientInsClaimNo)
                {
                    //rdbsb1.AppendLine(string.Format("strPatientInsClaimNo \"{0}\" = \"{1}\"", tmpInsurance.PatientInsClaimNo, strPatientInsClaimNo));
                    res = DataCaptureInsResult.IsNew;
                }
                else if (tmpInsurance.PatientInsRel2Insured != strPatientInsRel2Insured)
                {
                    //rdbsb1.AppendLine(string.Format("strPatientInsRel2Insured \"{0}\" = \"{1}\"", tmpInsurance.PatientInsRel2Insured, strPatientInsRel2Insured));
                    res = DataCaptureInsResult.IsNew;
                }
                else if (tmpInsurance.PatientInsRel2Insured != "1")
                {
                    if (tmpInsurance.PatientInsInsuredName != strPatientInsInsuredName)
                    {
                        //rdbsb1.AppendLine(string.Format("strPatientInsInsuredName \"{0}\" = \"{1}\"", tmpInsurance.PatientInsInsuredName, strPatientInsInsuredName));
                        res = DataCaptureInsResult.IsNew;
                    }
                    else if (tmpInsurance.PatientInsInsuredAddress != strPatientInsInsuredAddress)
                    {
                        //rdbsb1.AppendLine(string.Format("strPatientInsInsuredAddress \"{0}\" = \"{1}\"", tmpInsurance.PatientInsInsuredAddress, strPatientInsInsuredAddress));
                        res = DataCaptureInsResult.IsNew;
                    }
                    else if (tmpInsurance.PatientInsInsuredZipCode != strPatientInsInsuredZipCode)
                    {
                        //rdbsb1.AppendLine(string.Format("strPatientInsInsuredZipCode \"{0}\" = \"{1}\"", tmpInsurance.PatientInsInsuredZipCode, strPatientInsInsuredZipCode));
                        res = DataCaptureInsResult.IsNew;
                    }
                    else if (tmpInsurance.PatientInsInsuredCity != strPatientInsInsuredCity)
                    {
                        //rdbsb1.AppendLine(string.Format("strPatientInsInsuredCity \"{0}\" = \"{1}\"", tmpInsurance.PatientInsInsuredCity, strPatientInsInsuredCity));
                        res = DataCaptureInsResult.IsNew;
                    }
                    else if (tmpInsurance.PatientInsInsuredState != strPatientInsInsuredState)
                    {
                        //rdbsb1.AppendLine(string.Format("strPatientInsInsuredState \"{0}\" = \"{1}\"", tmpInsurance.PatientInsInsuredState, strPatientInsInsuredState));
                        res = DataCaptureInsResult.IsNew;
                    }
                    else if (tmpInsurance.PatientInsInsuredPhone != strPatientInsInsuredPhone)
                    {
                        //rdbsb1.AppendLine(string.Format("strPatientInsInsuredPhone \"{0}\" = \"{1}\"", tmpInsurance.PatientInsInsuredPhone, strPatientInsInsuredPhone));
                        res = DataCaptureInsResult.IsNew;
                    }
                    else if (tmpInsurance.PatientInsInsuredDOB != strPatientInsInsuredDOB)
                    {
                        //rdbsb1.AppendLine(string.Format("strPatientInsInsuredDOB \"{0}\" = \"{1}\"", tmpInsurance.PatientInsInsuredDOB, strPatientInsInsuredDOB));
                        res = DataCaptureInsResult.IsNew;
                    }
                    else if (tmpInsurance.PatientInsInsuredSex != strPatientInsInsuredSex)
                    {
                        //rdbsb1.AppendLine(string.Format("strPatientInsInsuredSex \"{0}\" = \"{1}\"", tmpInsurance.PatientInsInsuredSex, strPatientInsInsuredSex));
                        res = DataCaptureInsResult.IsNew;
                    }
                    else if (tmpInsurance.PatientInsInsuredSSS != strPatientInsInsuredSSS)
                    {
                        //rdbsb1.AppendLine(string.Format("strPatientInsInsuredSSS \"{0}\" = \"{1}\"", tmpInsurance.PatientInsInsuredSSS, strPatientInsInsuredSSS));
                        res = DataCaptureInsResult.IsNew;
                    }
                    else if (tmpInsurance.PatientInsInsuredEmployer != strPatientInsInsuredEmployer)
                    {
                        //rdbsb1.AppendLine(string.Format("strPatientInsInsuredEmployer \"{0}\" = \"{1}\"", tmpInsurance.PatientInsInsuredEmployer, strPatientInsInsuredEmployer));
                        res = DataCaptureInsResult.IsNew;
                    }
                    else if (tmpInsurance.PatientInsInsuredEmpAddr != strPatientInsInsuredEmpAddr)
                    {

                        //rdbsb1.AppendLine(string.Format("strPatientInsInsuredEmpAddr \"{0}\" = \"{1}\"", tmpInsurance.PatientInsInsuredEmpAddr, strPatientInsInsuredEmpAddr));
                        res = DataCaptureInsResult.IsNew;
                    }
                    else if (tmpInsurance.PatientInsInsuredEmpZip != strPatientInsInsuredEmpZip)
                    {
                        //rdbsb1.AppendLine(string.Format("strPatientInsInsuredEmpZip \"{0}\" = \"{1}\"", tmpInsurance.PatientInsInsuredEmpZip, strPatientInsInsuredEmpZip));
                        res = DataCaptureInsResult.IsNew;
                    }
                    else if (tmpInsurance.PatientInsInsuredEmpCity != strPatientInsInsuredEmpCity)
                    {
                        //rdbsb1.AppendLine(string.Format("strPatientInsInsuredEmpCity \"{0}\" = \"{1}\"", tmpInsurance.PatientInsInsuredEmpCity, strPatientInsInsuredEmpCity));
                        res = DataCaptureInsResult.IsNew;
                    }
                    else if (tmpInsurance.PatientInsInsuredEmpState != strPatientInsInsuredEmpState)
                    {
                        //rdbsb1.AppendLine(string.Format("strPatientInsInsuredEmpState \"{0}\" = \"{1}\"", tmpInsurance.PatientInsInsuredEmpState, strPatientInsInsuredEmpState));
                        res = DataCaptureInsResult.IsNew;
                    }
                    else if (tmpInsurance.PatientInsInsuredEmpPhone != strPatientInsInsuredEmpPhone)
                    {
                        //rdbsb1.AppendLine(string.Format("strPatientInsInsuredEmpPhone \"{0}\" = \"{1}\"", tmpInsurance.PatientInsInsuredEmpPhone, strPatientInsInsuredEmpPhone));
                        res = DataCaptureInsResult.IsNew;
                    }
                    else
                    {
                        //rdbsb1.AppendLine("IsOld");
                        res = DataCaptureInsResult.IsOld;
                    }
                }
                else
                {
                    //rdbsb1.AppendLine("IsOld");
                    res = DataCaptureInsResult.IsOld;
                }
            }
            else
            {
                res = DataCaptureInsResult.IsNew;
            }

            //just capture for now
            res = DataCaptureInsResult.IsNew;

            if (res == DataCaptureInsResult.IsNew)
            {
                currentpatient.myInsurances.Add(
                        new uc_someinsurance(
                                strPatientInsCode,
                                strPatientInsMemNum,
                                strPatientInsGrp,
                                strPatientInsPayPlan,
                                strPatientInsCovPlanFrom,
                                strPatientInsCovPlanTo,
                                strPatientInsCoPayment,
                                strPatientInsDeductible,
                                strPatientInsStatus,
                                strPatientInsPriSec,
                                strPatientInsAdjuster,
                                strPatientInsAssignment,
                                strPatientInsClaimNo,
                                strPatientInsRel2Insured,
                                strPatientInsInsuredName,
                                strPatientInsInsuredAddress,
                                strPatientInsInsuredZipCode,
                                strPatientInsInsuredCity,
                                strPatientInsInsuredState,
                                strPatientInsInsuredPhone,
                                strPatientInsInsuredDOB,
                                strPatientInsInsuredSex,
                                strPatientInsInsuredSSS,
                                strPatientInsInsuredEmployer,
                                strPatientInsInsuredEmpAddr,
                                strPatientInsInsuredEmpZip,
                                strPatientInsInsuredEmpCity,
                                strPatientInsInsuredEmpState,
                                strPatientInsInsuredEmpPhone
                            )
                        );

                indexInsurances++;
                /*
                string curpat = "";
                insCount = currentpatient.myInsurances.Count;
                uc_someinsurance tempins = currentpatient.myInsurances[insCount - 1];

                curpat += "PatientInsCode					" + tempins.PatientInsCode + "\n";
                curpat += "PatientInsMemNum					" + tempins.PatientInsMemNum + "\n";
                curpat += "PatientInsGrp					" + tempins.PatientInsGrp + "\n";
                curpat += "PatientInsPayPlan				" + tempins.PatientInsPayPlan + "\n";
                curpat += "PatientInsCovPlanFrom			" + tempins.PatientInsCovPlanFrom + "\n";
                curpat += "PatientInsCovPlanTo				" + tempins.PatientInsCovPlanTo + "\n";
                curpat += "PatientInsCoPayment				" + tempins.PatientInsCoPayment + "\n";
                curpat += "PatientInsDeductible				" + tempins.PatientInsDeductible + "\n";
                curpat += "PatientInsStatus					" + tempins.PatientInsStatus + "\n";
                curpat += "PatientInsPriSec					" + tempins.PatientInsPriSec + "\n";
                curpat += "PatientInsAdjuster				" + tempins.PatientInsAdjuster + "\n";
                curpat += "PatientInsAssignment				" + tempins.PatientInsAssignment + "\n";
                curpat += "PatientInsClaimNo				" + tempins.PatientInsClaimNo + "\n";
                curpat += "PatientInsRel2Insured			" + tempins.PatientInsRel2Insured + "\n";
                curpat += "PatientInsInsuredName			" + tempins.PatientInsInsuredName + "\n";
                curpat += "PatientInsInsuredAddress			" + tempins.PatientInsInsuredAddress + "\n";
                curpat += "PatientInsInsuredZipCode			" + tempins.PatientInsInsuredZipCode + "\n";
                curpat += "PatientInsInsuredCity			" + tempins.PatientInsInsuredCity + "\n";
                curpat += "PatientInsInsuredState			" + tempins.PatientInsInsuredState + "\n";
                curpat += "PatientInsInsuredPhone			" + tempins.PatientInsInsuredPhone + "\n";
                curpat += "PatientInsInsuredDOB				" + tempins.PatientInsInsuredDOB + "\n";
                curpat += "PatientInsInsuredSex				" + tempins.PatientInsInsuredSex + "\n";
                curpat += "PatientInsInsuredSSS				" + tempins.PatientInsInsuredSSS + "\n";
                curpat += "PatientInsInsuredEmployer		" + tempins.PatientInsInsuredEmployer + "\n";
                curpat += "PatientInsInsuredEmpAddr			" + tempins.PatientInsInsuredEmpAddr + "\n";
                curpat += "PatientInsInsuredEmpZip			" + tempins.PatientInsInsuredEmpZip + "\n";
                curpat += "PatientInsInsuredEmpCity			" + tempins.PatientInsInsuredEmpCity + "\n";
                curpat += "PatientInsInsuredEmpState		" + tempins.PatientInsInsuredEmpState + "\n";
                curpat += "PatientInsInsuredEmpPhone		" + tempins.PatientInsInsuredEmpPhone + "\n";

                prntSome.printSome(curpat, "tmpstring-", countbmprdb);
                countbmprdb++;

                */
            }

            //int insCount = currentpatient.myInsurances.Count;
            //uc_someinsurance tmp = currentpatient.myInsurances[insCount - 1];
            //rdbmsg.Insert(0, string.Format("a: {0} b: {1} c: {2} d: {3}\n", res, fromDownIns, insCount, tmp.PatientInsCode));

            return res;
        }
    }
}
