public partial class ackterm
{
    private partial class uc_autoprocess
    {
        public partial class uc_assocElem
        {
            public ElmScrns _a;
            public ElmScrns _b;

            public uc_assocElem(
                    ElmScrns a,
                    ElmScrns b
                )
            {
                _a = a;
                _b = b;
            }
        }

        private void seqMain()
        {
            switch (curForm)
            {
                case ElmScrns.MainPatient:
                    SendCmdKey();
                    break;
            }
        }

        private void seqPatient()
        {
            switch (curForm)
            {
                case ElmScrns.PatientMenuAdd:
                    SendStr("m");
                    break;
            }
        }

        private void seqInitial()
        {
            switch (curForm)
            {
                case ElmScrns.Login:
                    SendStr("randy", true);
                    break;

                case ElmScrns.TermAnsi:
                    SendCmdKey();
                    break;

                case ElmScrns.Ret2Begin:
                    SendCmdKey();
                    break;

                case ElmScrns.ClinicNum:
                    //SendStr("2", true);
                    SendStr("8", true);
                    break;

                case ElmScrns.Password:
                    SendStr("17784290", true);
                    break;
            }
        }

        private void seqPatientEnc()
        {
            switch (curForm)
            {
                case ElmScrns.PatientEncNum:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncRX:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncInjury:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncOrderDate:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncInitialTreatment:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncXrayDate:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncAcuteManifestation:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncAuthNum:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncLastSeen:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncAuthorizedVisits:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncEmergencyYN:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncAuthFrom:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncAuthTo:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncPOS:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncReferredLab:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncBox19Desc:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncHCFABox19Date:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncReferringCode:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncFirstSymptom:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncFirstConsulted:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncSimilarSymptom:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncDischargeDate:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncStatusEmployment:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncStatusStudent:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncRelatedAccident:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncEmploymentYN:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncUnable2WorkFrom:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncUnable2WorkTo:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncHospiFrom:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncHospiTo:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncDisabilityFrom:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncDisabilityTo:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncSoc:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncSocAmount:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncOrigRefNo:
                    //SendStr("", true, true);
                    GoToElem(ElmScrns.QuestionModifyInsInfo);
                    SendCmdKey(END);
                    break;
                case ElmScrns.PatientEncStatus:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncFamilyPlanning:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncBillingLimit:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncSchedofBenefits:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncReferralDate:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientEncLastCertification:
                    SendStr("", true, true);
                    break;
            }
        }

        private void seqPatientInfo()
        {
            switch (curForm)
            {
                case ElmScrns.PatientDemographics:
                    /*switch (lastSendCmd)
                    {
                        default:
                            GoToElem(ElmScrns.PatientDemographics);
                            rdbsb1.Insert(0, string.Format("sending space"));
                            SendCmdKey(SPACE);
                            GoToElem(ElmScrns.SearchPatientAccountNum);
                            rdbsb1.Insert(0, string.Format("sending f2"));
                            SendCmdKey(F2);
                            break;
                    }*/
                    if (autosettings.bHasAccountNo)
                    {
                        if (autosettings.bStartCharge)
                        {
                            GoToElem(ElmScrns.ChargeSB);
                            SendCmdKey(F6);
                        }
                        else
                        {
                            SendStr(excelpatient.PatientInfoAcctNum, true);
                        }
                    }
                    else if (autosettings.bDoneSearch == false)
                    {
                        autosettings.bInSearch = true;
                        SendCmdKey(F2);
                    }
                    break;

                case ElmScrns.QuestionModifyInsInfo:
                    if (autosettings.bTraversePatientIns == false)
                    {
                        GoToElem(ElmScrns.QuestionModifyEncInfo);
                        SendStr("n");
                    }
                    else
                    {
                        SendStr("y");
                    }
                    break;
                    
                /************Fields***********/

                case ElmScrns.PatientInfoAcctNum:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInfoGuarrantor:
                    /*
                     *Capture All Patients Info on the screen to currentpatient
                     */
                    if (fromDownPatient == false)
                    {
                        if (DataCapturePatientInfo() == true)
                        {
                            if (autosettings.bTraversePatientInfo == false)
                            {
                                GoToElem(ElmScrns.QuestionModifyInsInfo);
                                SendCmdKey(END);
                            }
                            else
                            {
                                SendStr("", true, true);
                            }
                        }
                    }
                    else
                    {
                        fromDownPatient = false;
                        GoToElem(ElmScrns.QuestionModifyInsInfo);
                        SendCmdKey(END);
                    }
                    
                    break;
                case ElmScrns.PatientInfoChartNum:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInfoName:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInfoAddr:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInfoZip:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInfoCity:
                    ComeBack("", ElmScrns.PatientInfoState);
                    break;
                case ElmScrns.PatientInfoState:
                    UpOrSendData("");
                    break;
                case ElmScrns.PatientInfoHomePhone:
                    GoBackorContinue("");
                    break;
                case ElmScrns.PatientInfoCell:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInfoSex:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInfoDOB:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInfoAge:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInfoMStatus:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInfoEthnicity:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInfoSSN:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInfoDL:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInfoOccupation:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInfoEmployer:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInfoEmployerAddr:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInfoEmployerZip:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInfoEmployerCity:
                    ComeBack("", ElmScrns.PatientInfoEmployerState);
                    break;
                case ElmScrns.PatientInfoEmployerState:
                    UpOrSendData("");
                    break;
                case ElmScrns.PatientInfoEmployerPhone:
                    GoBackorContinue("");
                    break;
                case ElmScrns.PatientInfoCategory:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInfoReferral:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInfoPCP:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInfoHospital:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInfoLanguage:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInfoEmail:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInfoRemarks1:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInfoRemarks2:
                    fromDownPatient = true;
                    GoToElem(ElmScrns.PatientInfoGuarrantor);
                    SendStr("", true, true);
                    break;
            }
        }

        public void seqSearchPatient()
        {
            switch (curForm)
            {
                case ElmScrns.SearchPatientAccountNum:
                    if(autosettings.bHasAccountNo)
                        SendStr(excelpatient.PatientInfoAcctNum, true, true);
                    else SendStr("", true, true);
                    break;
                case ElmScrns.SearchPatientName:
                    if (autosettings.bHasLastName)
                        SendStr("*"+excelpatient.PatientInfoLastName, true, true);
                    else SendStr("", true, true);
                    break;
                case ElmScrns.SearchPatientDOB:
                    if (autosettings.bHasDOB)
                        SendStr(excelpatient.PatientInfoDOB.ToString("MM/dd/yyyy"), true, true);
                    else SendStr("", true, true);
                    break;
                case ElmScrns.SearchPatientCategory:
                    SendStr("", true, true);
                    break;
                case ElmScrns.SearchPatientSSN:
                    SendStr("", true, true);
                    break;

                case ElmScrns.SearchPatientNotFound:
                    autosettings.bSearchPatientNotFound = true;
                    GoToElem(ElmScrns.SearchPatientAccountNum);
                    SendCmdKey();
                    break;

                case ElmScrns.SearchPatientResRow6:
                    if (autosettings.bInSearch)
                    {

                    }
                    //SendStr("", true, true);
                    break;
                case ElmScrns.SearchPatientResRow7:
                    //SendStr("", true, true);
                    break;
                case ElmScrns.SearchPatientResRow8:
                    //SendStr("", true, true);
                    break;
                case ElmScrns.SearchPatientResRow9:
                    //SendStr("", true, true);
                    break;
                case ElmScrns.SearchPatientResRow10:
                    //SendStr("", true, true);
                    break;
                case ElmScrns.SearchPatientResRow11:
                    //SendStr("", true, true);
                    break;
                case ElmScrns.SearchPatientResRow12:
                    //SendStr("", true, true);
                    break;
                case ElmScrns.SearchPatientResRow13:
                    //SendStr("", true, true);
                    break;
                case ElmScrns.SearchPatientResRow14:
                    //SendStr("", true, true);
                    break;
                case ElmScrns.SearchPatientResRow15:
                    //SendStr("", true, true);
                    break;
                case ElmScrns.SearchPatientResRow16:
                    //SendStr("", true, true);
                    break;
                case ElmScrns.SearchPatientResRow17:
                    //SendStr("", true, true);
                    break;
            }
        }

        private void seqPatientIns()
        {
            switch (curForm)
            {
                /************Fields***********/

                case ElmScrns.PatientInsCode:
                    /*
                     * If previous capture is empty, continue traversing,
                     * capture all field values and compare each one
                     * If there is a difference from the previous capture, do something
                     * If no difference, send END
                     */
                    rdbsb1.Insert(0, string.Format("elm:{0}\n sp: {1}\n down:{2}\n", curForm, mysetpoint, fromDownIns));
                    //afterDataCapture = DataCaptureInsResult.None;

                    if (mysetpoint == SetPoint.None)
                    {
                        //if (currentpatient.myInsurances.Count == 0)
                            DataCapturePatientIns();

                        SendStr("", true, true);
                    }
                    else if(mysetpoint == SetPoint.New)
                    {
                        //if (currentpatient.myInsurances.Count > 0)
                        //    DataCapturePatientIns();
                        mysetpoint = SetPoint.None;
                        GoToElem(ElmScrns.PatientInsCode);
                        fromDownIns = false;
                        
                    }
                    break;
                case ElmScrns.PatientInsMemNum:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInsGrp:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInsPayPlan:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInsCovPlanFrom:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInsCovPlanTo:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInsCoPayment:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInsDeductible:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInsStatus:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInsPriSec:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInsAdjuster:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInsAssignment:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInsClaimNo:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInsRel2Insured:
                    fromDownIns = true;
                    mysetpoint = SetPoint.Visited;
                    SendStr("", true, true);
                    break;

                /****rel2insure = 2***/
                case ElmScrns.PatientInsInsuredName:
                    string aa = GetInsuranceFieldValue(ElmScrns.PatientInsRel2Insured);
                    if (aa == "1")
                    {
                        mysetpoint = SetPoint.New;
                        GoToElem(ElmScrns.PatientInsCode);
                        SendCmdKey(END);
                    }
                    else
                    {
                        SendStr("", true, true);
                    }
                    break;
                case ElmScrns.PatientInsInsuredAddress:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInsInsuredZipCode:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInsInsuredPhone:
                    GoBackorContinue("");
                    break;

                case ElmScrns.PatientInsInsuredState:
                    UpOrSendData("");
                    break;
                case ElmScrns.PatientInsInsuredCity:
                    ComeBack("", ElmScrns.PatientInsInsuredState);
                    break;

                case ElmScrns.PatientInsInsuredDOB:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInsInsuredSex:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInsInsuredSSS:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInsInsuredEmployer:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInsInsuredEmpAddr:
                    SendStr("", true, true);
                    break;
                case ElmScrns.PatientInsInsuredEmpZip:
                    SendStr("", true, true);
                    break;

                case ElmScrns.PatientInsInsuredEmpPhone:
                    GoBackorContinue("");
                    break;
                case ElmScrns.PatientInsInsuredEmpState:
                    UpOrSendData("");
                    break;
                case ElmScrns.PatientInsInsuredEmpCity:
                    ComeBack("", ElmScrns.PatientInsInsuredEmpState);
                    break;

                case ElmScrns.QuestionModifyEncInfo:
                    if (autosettings.bTraversePatientEnc == false)
                    {
                        autosettings.bStartCharge = true;
                        GoToElem(ElmScrns.PatientDemographics);
                        SendStr("n");
                    }
                    else
                    {
                        GoToElem(ElmScrns.PatientEncNum);
                        SendStr("y");
                    }
                    break;

                case ElmScrns.PatientInsRecordInUse:
                    SendCmdKey();
                    break;

                default:
                    //
                    break;

            }
        }

        private void seqPostingCharges()
        {
            switch (curForm)
            {
                case ElmScrns.ChargeSB:
                    if (autosettings.bHasSB)
                    {
                        SendStr(excelpatient.PatientChargeSB, true, true);
                    }
                    else SendStr("", true, true);
                    break;
                case ElmScrns.ChargeACN:
                    break;
                case ElmScrns.ChargeDR:
                    break;
                case ElmScrns.ChargeRdr:
                    SendStr("", true, true);
                    break;
                case ElmScrns.ChargePOS:
                    SendStr("", true, true);
                    break;
                case ElmScrns.ChargeEN:
                    SendStr("", true, true);
                    break;
                case ElmScrns.ChargeDX:
                    break;
                case ElmScrns.ChargePanel:
                    break;
                case ElmScrns.ChargeDrCode:
                    break;
                case ElmScrns.ChargeFrom:
                    break;
                case ElmScrns.ChargeTo:
                    break;
                case ElmScrns.ChargeRdx:
                    break;
                case ElmScrns.ChargeProcedure:
                    break;
                case ElmScrns.ChargeAmount:
                    break;

                case ElmScrns.ChargeSBNotice:
                    SendCmdKey();
                    break;
                case ElmScrns.ChargePressAnyKey:
                    if (autosettings.bHasSB)
                    {
                        GoToElem(ElmScrns.ChargeRdr);
                    }
                    //else GoToElem(ElmScrns.ChargeRdr); // go somewhere
                    SendCmdKey();
                    break;
            }
        }

        private int MatchMeSender(ElmScrns s)
        {
            System.Int32                 x = -1;
            uc_assocElem tmpObj;
            System.Boolean  isfound = false;

            for (int i=0; i < MeetSender.Count;i++)
            {
                tmpObj = MeetSender[i];
                if (tmpObj._b == s)
                {
                    isfound = true;
                    x = i;
                    break;
                }
            }
            if (isfound == true)
                return x;
            return -1;
        }

        private void UpOrSendData(string data="")
        {
            int aa = MatchMeSender(curForm);
            if (aa != -1 || data.Length != 0)
            {
                if (aa != -1)
                    MeetSender.RemoveAt(aa);
                SequenceNum -= 2;
                hasPass = true;
                SendStr(data, true, true);
            }
            else SendCmdKey(CURSORUP);
        }

        private void ComeBack(string data="",ElmScrns a=ElmScrns.NotFound, int r=4)
        {
            if (data.Length != 0)
            {
                SequenceNum -= 2;
                MeetSender.Add(new uc_assocElem(curForm,a));
                SendStr(data, true, true);
            }
            else if(SequenceNum >= r)
            {
                hasPass = true;
                SequenceNum -= r;
                SendCmdKey(CURSORUP);
            }
        }

        private void GoBackorContinue(string data="",int r=2)
        {
            if (hasPass == true)
            {
                SequenceNum += r;
                hasPass = false;
                if (data.Length != 0)
                {
                    SendStr(data, false, true);
                }
                SendCmdKey();
            }
            else SendCmdKey(CURSORUP);
        }

        private void GoToElem(ElmScrns a)
        {
            int index = GetElementIndex(a);
            if (index != -1)
            {
                SequenceNum = index;
            }
        }

        private string GetInsuranceFieldValue(ElmScrns a)
        {
            string str = "";

            uc_someinsurance tmpInsurance;
            int numIns = currentpatient.myInsurances.Count;

            if (numIns != 0)
            {
                tmpInsurance = currentpatient.myInsurances[numIns - 1];

                switch (a)
                {
                    /************Fields***********/

                    case ElmScrns.PatientInsCode:
                        str = tmpInsurance.PatientInsCode;
                        break;
                    case ElmScrns.PatientInsMemNum:
                        str = tmpInsurance.PatientInsMemNum;
                        break;
                    case ElmScrns.PatientInsGrp:
                        str = tmpInsurance.PatientInsGrp;
                        break;
                    case ElmScrns.PatientInsPayPlan:
                        str = tmpInsurance.PatientInsPayPlan;
                        break;
                    case ElmScrns.PatientInsCovPlanFrom:
                        str = tmpInsurance.PatientInsCovPlanFrom;
                        break;
                    case ElmScrns.PatientInsCovPlanTo:
                        str = tmpInsurance.PatientInsCovPlanTo;
                        break;
                    case ElmScrns.PatientInsCoPayment:
                        str = tmpInsurance.PatientInsCoPayment;
                        break;
                    case ElmScrns.PatientInsDeductible:
                        str = tmpInsurance.PatientInsDeductible;
                        break;
                    case ElmScrns.PatientInsStatus:
                        str = tmpInsurance.PatientInsStatus;
                        break;
                    case ElmScrns.PatientInsPriSec:
                        str = tmpInsurance.PatientInsPriSec;
                        break;
                    case ElmScrns.PatientInsAdjuster:
                        str = tmpInsurance.PatientInsAdjuster;
                        break;
                    case ElmScrns.PatientInsAssignment:
                        str = tmpInsurance.PatientInsAssignment;
                        break;
                    case ElmScrns.PatientInsClaimNo:
                        str = tmpInsurance.PatientInsClaimNo;
                        break;
                    case ElmScrns.PatientInsRel2Insured:
                        str = tmpInsurance.PatientInsRel2Insured;
                        break;

                    /****rel2insure = 2***/
                    case ElmScrns.PatientInsInsuredName:
                        str = tmpInsurance.PatientInsInsuredName;
                        break;
                    case ElmScrns.PatientInsInsuredAddress:
                        str = tmpInsurance.PatientInsInsuredAddress;
                        break;
                    case ElmScrns.PatientInsInsuredZipCode:
                        str = tmpInsurance.PatientInsInsuredZipCode;
                        break;
                    case ElmScrns.PatientInsInsuredPhone:
                        str = tmpInsurance.PatientInsInsuredPhone;
                        break;
                    case ElmScrns.PatientInsInsuredState:
                        str = tmpInsurance.PatientInsInsuredState;
                        break;
                    case ElmScrns.PatientInsInsuredCity:
                        str = tmpInsurance.PatientInsInsuredCity;
                        break;
                    case ElmScrns.PatientInsInsuredDOB:
                        str = tmpInsurance.PatientInsInsuredDOB;
                        break;
                    case ElmScrns.PatientInsInsuredSex:
                        str = tmpInsurance.PatientInsInsuredSex;
                        break;
                    case ElmScrns.PatientInsInsuredSSS:
                        str = tmpInsurance.PatientInsInsuredSSS;
                        break;
                    case ElmScrns.PatientInsInsuredEmployer:
                        str = tmpInsurance.PatientInsInsuredEmployer;
                        break;
                    case ElmScrns.PatientInsInsuredEmpAddr:
                        str = tmpInsurance.PatientInsInsuredEmpAddr;
                        break;
                    case ElmScrns.PatientInsInsuredEmpZip:
                        str = tmpInsurance.PatientInsInsuredEmpZip;
                        break;

                    case ElmScrns.PatientInsInsuredEmpPhone:
                        str = tmpInsurance.PatientInsInsuredEmpPhone;
                        break;
                    case ElmScrns.PatientInsInsuredEmpState:
                        str = tmpInsurance.PatientInsInsuredEmpState;
                        break;
                    case ElmScrns.PatientInsInsuredEmpCity:
                        str = tmpInsurance.PatientInsInsuredEmpCity;
                        break;
                }
            }

            return str;
        }

        private void SendCmdKey(string comm = ENTER)
        {
            /*
             *  this one will set indicators 
                if operation is exiting/entering a form
             */
            switch(comm)
            {
                case END:
                    lastSendCmd = CmdSend.End;
                    SenderFnc(comm);
                    break;
                case CURSORUP:
                    lastSendCmd = CmdSend.Cursorup;
                    SenderFnc(comm);
                    break;
                case ENTER:
                    lastSendCmd = CmdSend.Enter;
                    SenderFnc(comm);
                    break;
                case SPACE:
                    lastSendCmd = CmdSend.Space;
                    SenderFnc(comm);
                    break;
                case F2:
                    lastSendCmd = CmdSend.F2;
                    SenderFnc(comm);
                    break;
                case F6:
                    lastSendCmd = CmdSend.F6;
                    SenderFnc(comm);
                    break;
                case SHIFT_F6:
                    lastSendCmd = CmdSend.SHIFT_F6;
                    SenderFnc(comm);
                    break;
                default:
                    SenderFnc(ENTER);
                    break;
            }
        }

        //should not use this one directly inside cmddispatcher
        private void SenderFnc(string str)
        {
            this.Parent.DispatchMessage(this.Parent, str);
        }

        private void SendStr(string str, bool sendCR = false, bool sendspace = false)
        {
            if (str.Length != 0)
            {
                if (sendspace == true)
                    SenderFnc(" ");
                SenderFnc(str);
            }
            if (sendCR == true)
                SendCmdKey();
        }
    }
}