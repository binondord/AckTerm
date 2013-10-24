using System;
public partial class ackterm
{
    private partial class uc_autoprocess
    {
        public bool DataCapturePatientInfo()
        {
            string 	strPatientInfoAcctNum= "";
            string 	strPatientInfoGuarrantor= "";
            string 	strPatientInfoChartNum= "";
            string 	strPatientInfoName= "";
            string 	strPatientInfoAddr= "";
            string 	strPatientInfoZip= "";
            string 	strPatientInfoCity= "";
            string 	strPatientInfoState= "";
            string 	strPatientInfoHomePhone= "";
            string 	strPatientInfoCell= "";
            string 	strPatientInfoSex= "";
            DateTime datePatientInfoDOB = DateTime.Now;
            string 	strPatientInfoAge= "";
            string 	strPatientInfoMStatus= "";
            string 	strPatientInfoEthnicity= "";
            string 	strPatientInfoSSN= "";
            string 	strPatientInfoDL= "";
            string 	strPatientInfoOccupation= "";
            string 	strPatientInfoEmployer= "";
            string 	strPatientInfoEmployerAddr= "";
            string 	strPatientInfoEmployerZip= "";
            string 	strPatientInfoEmployerCity= "";
            string 	strPatientInfoEmployerState= "";
            string 	strPatientInfoEmployerPhone= "";
            string 	strPatientInfoCategory= "";
            string 	strPatientInfoReferral= "";
            string 	strPatientInfoPCP= "";
            string 	strPatientInfoHospital= "";
            string 	strPatientInfoLanguage= "";
            string 	strPatientInfoEmail= "";
            string 	strPatientInfoRemarks1= "";
            string 	strPatientInfoRemarks2= "";

            string strPatientInfoCategoryVal="";
            string strPatientInfoReferralVal="";

            bool isNew = false;
            int dataStartVal = 0;
            int dataEndVal = 0;
            int dataYPOS = 0;

            string tmpstring = "";
            uc_maptxtcaretinfo tmpElement;
            System.Collections.Generic.List<uc_maptxtcaretinfo> applicableElems = myMapTxtCaret.FindElemByPrimeMainMenu(curMenu);
            //rdbmsg.Clear();

            /*for (int jj=0; jj < rdbp2.Length; jj++)
            {

                string tmp = new string(rdbp2[jj]);
                tmpstring += tmp + "\n";
            }*/
            

            for (int i=0; i < applicableElems.Count; i++)
            {
                tmpElement = applicableElems[i];

                dataStartVal = tmpElement.frmvalue.prmStartPos.X;
                dataEndVal = tmpElement.frmvalue.prmEndPos.X;
                dataYPOS = tmpElement.frmvalue.prmStartPos.Y;

                tmpstring = retrieveStrData(rdbp2, rdbp3, dataStartVal, dataEndVal, dataYPOS);
                
                //rdbmsg.Insert(0, string.Format("a: {0} b: {1} c: {2} d: {3}\n", tmpstring, dataStartVal, dataEndVal, dataYPOS));

                switch (tmpElement.seqScrn)
                {
                    case ElmScrns.PatientInfoAcctNum:
                        strPatientInfoAcctNum = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoAcctNum", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoGuarrantor:
                        strPatientInfoGuarrantor = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoGuarrantor", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoChartNum:
                        strPatientInfoChartNum = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoChartNum", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoName:
                        strPatientInfoName = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoName", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoAddr:
                        strPatientInfoAddr = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoAddr", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoZip:
                        strPatientInfoZip = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoZip", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoCity:
                        strPatientInfoCity = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoCity", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoState:
                        strPatientInfoState = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoState", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoHomePhone:
                        strPatientInfoHomePhone = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoHomePhone", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoCell:
                        strPatientInfoCell = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoCell", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoSex:
                        strPatientInfoSex = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoSex", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoDOB:
                        datePatientInfoDOB = Convert.ToDateTime(tmpstring);
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoDOB", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoAge:
                        strPatientInfoAge = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoAge", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoMStatus:
                        strPatientInfoMStatus = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoMStatus", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoEthnicity:
                        strPatientInfoEthnicity = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoEthnicity", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoSSN:
                        strPatientInfoSSN = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoSSN", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoDL:
                        strPatientInfoDL = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoDL", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoOccupation:
                        strPatientInfoOccupation = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoOccupation", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoEmployer:
                        strPatientInfoEmployer = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoEmployer", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoEmployerAddr:
                        strPatientInfoEmployerAddr = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoEmployerAddr", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoEmployerZip:
                        strPatientInfoEmployerZip = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoEmployerZip", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoEmployerCity:
                        strPatientInfoEmployerCity = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoEmployerCity", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoEmployerState:
                        strPatientInfoEmployerState = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoEmployerState", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoEmployerPhone:
                        strPatientInfoEmployerPhone = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoEmployerPhone", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoCategory:
                        strPatientInfoCategory = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoCategory", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoReferral:
                        strPatientInfoReferral = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoReferral", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoPCP:
                        strPatientInfoPCP = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoPCP", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoHospital:
                        strPatientInfoHospital = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoHospital", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoLanguage:
                        strPatientInfoLanguage = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoLanguage", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoEmail:
                        strPatientInfoEmail = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoEmail", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoRemarks1:
                        strPatientInfoRemarks1 = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoRemarks1", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoRemarks2:
                        strPatientInfoRemarks2 = tmpstring;
                        //prntSome.printSome(tmpstring, "rdbp-strPatientInfoRemarks2", countbmprdb);
                        //countbmprdb++;
                        break;
                    case ElmScrns.PatientInfoCategoryVal:
                        strPatientInfoCategoryVal = tmpstring;
                        break;
                    case ElmScrns.PatientInfoReferralVal:
                        strPatientInfoCategoryVal = tmpstring;
                        break;
                }
            }

            //check first if this is the same patient as before
            uc_somepatient tmpatient = currentpatient;

            if (tmpatient != null)
            {
                isNew = (tmpatient.PatientInfoAcctNum == strPatientInfoAcctNum && isNew == false) ? false : true;
                //rdbmsg.AppendFormat("a:{0}\nb:{1}\nc:{2}\n", strPatientInfoAcctNum, tmpatient.PatientInfoAcctNum,isNew);
            }
            else isNew = true;

            
            if(isNew == true)
            {
                //currentpatient = null;
                currentpatient = new uc_somepatient(
                                    strPatientInfoAcctNum,
                                    strPatientInfoGuarrantor,
                                    strPatientInfoChartNum,
                                    strPatientInfoName,
                                    strPatientInfoAddr,
                                    strPatientInfoZip,
                                    strPatientInfoCity,
                                    strPatientInfoState,
                                    strPatientInfoHomePhone,
                                    strPatientInfoCell,
                                    strPatientInfoSex,
                                    datePatientInfoDOB,
                                    strPatientInfoAge,
                                    strPatientInfoMStatus,
                                    strPatientInfoEthnicity,
                                    strPatientInfoSSN,
                                    strPatientInfoDL,
                                    strPatientInfoOccupation,
                                    strPatientInfoEmployer,
                                    strPatientInfoEmployerAddr,
                                    strPatientInfoEmployerZip,
                                    strPatientInfoEmployerCity,
                                    strPatientInfoEmployerState,
                                    strPatientInfoEmployerPhone,
                                    strPatientInfoCategory,
                                    strPatientInfoReferral,
                                    strPatientInfoPCP,
                                    strPatientInfoHospital,
                                    strPatientInfoLanguage,
                                    strPatientInfoEmail,
                                    strPatientInfoRemarks1,
                                    strPatientInfoRemarks2,
                                    strPatientInfoCategoryVal,
                                    strPatientInfoReferralVal
                    );
                /*
                string curpat = "";

                curpat += "PatientInfoAcctNum			" + currentpatient.PatientInfoAcctNum + "\n";
                curpat += "PatientInfoGuarrantor		" + currentpatient.PatientInfoGuarrantor + "\n";
                curpat += "PatientInfoChartNum		" + currentpatient.PatientInfoChartNum + "\n";
                curpat += "PatientInfoName			" + currentpatient.PatientInfoName + "\n";
                curpat += "PatientInfoAddr			" + currentpatient.PatientInfoAddr + "\n";
                curpat += "PatientInfoZip				" + currentpatient.PatientInfoZip + "\n";
                curpat += "PatientInfoCity			" + currentpatient.PatientInfoCity + "\n";
                curpat += "PatientInfoState			" + currentpatient.PatientInfoState + "\n";
                curpat += "PatientInfoHomePhone		" + currentpatient.PatientInfoHomePhone + "\n";
                curpat += "PatientInfoCell			" + currentpatient.PatientInfoCell + "\n";
                curpat += "PatientInfoSex				" + currentpatient.PatientInfoSex + "\n";
                curpat += "PatientInfoDOB				" + currentpatient.PatientInfoDOB + "\n";
                curpat += "PatientInfoAge				" + currentpatient.PatientInfoAge + "\n";
                curpat += "PatientInfoMStatus			" + currentpatient.PatientInfoMStatus + "\n";
                curpat += "PatientInfoEthnicity		" + currentpatient.PatientInfoEthnicity + "\n";
                curpat += "PatientInfoSSN				" + currentpatient.PatientInfoSSN + "\n";
                curpat += "PatientInfoDL				" + currentpatient.PatientInfoDL + "\n";
                curpat += "PatientInfoOccupation		" + currentpatient.PatientInfoOccupation + "\n";
                curpat += "PatientInfoEmployer		" + currentpatient.PatientInfoEmployer + "\n";
                curpat += "PatientInfoEmployerAddr	" + currentpatient.PatientInfoEmployerAddr + "\n";
                curpat += "PatientInfoEmployerZip		" + currentpatient.PatientInfoEmployerZip + "\n";
                curpat += "PatientInfoEmployerCity	" + currentpatient.PatientInfoEmployerCity + "\n";
                curpat += "PatientInfoEmployerState	" + currentpatient.PatientInfoEmployerState + "\n";
                curpat += "PatientInfoEmployerPhone	" + currentpatient.PatientInfoEmployerPhone + "\n";
                curpat += "PatientInfoCategory		" + currentpatient.PatientInfoCategory + "\n";
                curpat += "PatientInfoReferral		" + currentpatient.PatientInfoReferral + "\n";
                curpat += "PatientInfoPCP				" + currentpatient.PatientInfoPCP + "\n";
                curpat += "PatientInfoHospital		" + currentpatient.PatientInfoHospital + "\n";
                curpat += "PatientInfoLanguage		" + currentpatient.PatientInfoLanguage + "\n";
                curpat += "PatientInfoEmail			" + currentpatient.PatientInfoEmail + "\n";
                curpat += "PatientInfoRemarks1		" + currentpatient.PatientInfoRemarks1 + "\n";
                curpat += "PatientInfoRemarks2       	" + currentpatient.PatientInfoRemarks2 + "\n";
                curpat += "PatientInfoCategoryVal		" + currentpatient.PatientInfoCategoryVal + "\n";
                curpat += "PatientInfoReferralVal       	" + currentpatient.PatientInfoReferralVal + "\n";


                prntSome.printSome(curpat, "curpat-", countbmprdb);
                countbmprdb++;
                */
            }
            return isNew;
        }
    }
}