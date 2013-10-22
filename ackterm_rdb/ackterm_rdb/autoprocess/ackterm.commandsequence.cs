public partial class ackterm
{
    private partial class uc_autoprocess
    {
        public void SetSequence()
        {
            //resultsets
            Elements.Clear();

            Elements.Add(new uc_rdbseq(ElmScrns.Login, PrimeMainMenu.Initial));//0
            Elements.Add(new uc_rdbseq(ElmScrns.TermAnsi, PrimeMainMenu.Initial));//1
            Elements.Add(new uc_rdbseq(ElmScrns.Ret2Begin, PrimeMainMenu.Initial));//2
            Elements.Add(new uc_rdbseq(ElmScrns.ClinicNum, PrimeMainMenu.Initial));//3
            Elements.Add(new uc_rdbseq(ElmScrns.Password, PrimeMainMenu.Initial));//4
            Elements.Add(new uc_rdbseq(ElmScrns.MainPatient, PrimeMainMenu.Main));//5
            Elements.Add(new uc_rdbseq(ElmScrns.PatientMenuAdd, PrimeMainMenu.Patient));//6
            
            Elements.Add(new uc_rdbseq(ElmScrns.PatientDemographics, PrimeMainMenu.PatientInfo));//7

            Elements.Add(new uc_rdbseq(ElmScrns.SearchPatientAccountNum, PrimeMainMenu.PatientInfo));//7
            Elements.Add(new uc_rdbseq(ElmScrns.SearchPatientName, PrimeMainMenu.PatientInfo));//7
            Elements.Add(new uc_rdbseq(ElmScrns.SearchPatientDOB, PrimeMainMenu.PatientInfo));//7
            Elements.Add(new uc_rdbseq(ElmScrns.SearchPatientCategory, PrimeMainMenu.PatientInfo));//7
            Elements.Add(new uc_rdbseq(ElmScrns.SearchPatientSSN, PrimeMainMenu.PatientInfo));//7
            Elements.Add(new uc_rdbseq(ElmScrns.SearchPatientResRow6, PrimeMainMenu.PatientInfo));//7
            Elements.Add(new uc_rdbseq(ElmScrns.SearchPatientResRow7, PrimeMainMenu.PatientInfo));//7
            Elements.Add(new uc_rdbseq(ElmScrns.SearchPatientResRow8, PrimeMainMenu.PatientInfo));//7
            Elements.Add(new uc_rdbseq(ElmScrns.SearchPatientResRow9, PrimeMainMenu.PatientInfo));//7
            Elements.Add(new uc_rdbseq(ElmScrns.SearchPatientResRow10, PrimeMainMenu.PatientInfo));//7
            Elements.Add(new uc_rdbseq(ElmScrns.SearchPatientResRow11, PrimeMainMenu.PatientInfo));//7
            Elements.Add(new uc_rdbseq(ElmScrns.SearchPatientResRow12, PrimeMainMenu.PatientInfo));//7
            Elements.Add(new uc_rdbseq(ElmScrns.SearchPatientResRow13, PrimeMainMenu.PatientInfo));//7
            Elements.Add(new uc_rdbseq(ElmScrns.SearchPatientResRow14, PrimeMainMenu.PatientInfo));//7
            Elements.Add(new uc_rdbseq(ElmScrns.SearchPatientResRow15, PrimeMainMenu.PatientInfo));//7
            Elements.Add(new uc_rdbseq(ElmScrns.SearchPatientResRow16, PrimeMainMenu.PatientInfo));//7
            Elements.Add(new uc_rdbseq(ElmScrns.SearchPatientResRow17, PrimeMainMenu.PatientInfo));//7

            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoPressAnyKey, PrimeMainMenu.PatientInfo));//7

            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoGuarrantor, PrimeMainMenu.PatientInfo));//8
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoChartNum, PrimeMainMenu.PatientInfo));//9
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoName, PrimeMainMenu.PatientInfo));//10
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoAddr, PrimeMainMenu.PatientInfo));//11
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoZip, PrimeMainMenu.PatientInfo));//12
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoHomePhone, PrimeMainMenu.PatientInfo));//13
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoState, PrimeMainMenu.PatientInfo));//14
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoCity, PrimeMainMenu.PatientInfo));//15
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoCell, PrimeMainMenu.PatientInfo));//16
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoSex, PrimeMainMenu.PatientInfo));//17
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoDOB, PrimeMainMenu.PatientInfo));//18
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoAge, PrimeMainMenu.PatientInfo));//19
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoMStatus, PrimeMainMenu.PatientInfo));//20
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoEthnicity, PrimeMainMenu.PatientInfo));//21
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoSSN, PrimeMainMenu.PatientInfo));//22
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoDL, PrimeMainMenu.PatientInfo));//23
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoOccupation, PrimeMainMenu.PatientInfo));//24
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoEmployer, PrimeMainMenu.PatientInfo));//25
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoEmployerAddr, PrimeMainMenu.PatientInfo));//26
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoEmployerZip, PrimeMainMenu.PatientInfo));//27
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoEmployerPhone, PrimeMainMenu.PatientInfo));//28
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoEmployerState, PrimeMainMenu.PatientInfo));//29
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoEmployerCity, PrimeMainMenu.PatientInfo));//30
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoCategory, PrimeMainMenu.PatientInfo));//31
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoReferral, PrimeMainMenu.PatientInfo));//32
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoPCP, PrimeMainMenu.PatientInfo));//33
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoHospital, PrimeMainMenu.PatientInfo));//34
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoLanguage, PrimeMainMenu.PatientInfo));//35
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoEmail, PrimeMainMenu.PatientInfo));//36
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoRemarks1, PrimeMainMenu.PatientInfo));//37
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInfoRemarks2, PrimeMainMenu.PatientInfo));//38

            Elements.Add(new uc_rdbseq(ElmScrns.QuestionModifyInsInfo, PrimeMainMenu.PatientInfo));//39

            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsCode, PrimeMainMenu.PatientIns));//40
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsMemNum, PrimeMainMenu.PatientIns));//41
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsGrp, PrimeMainMenu.PatientIns));//42
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsPayPlan, PrimeMainMenu.PatientIns));//43
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsCovPlanFrom, PrimeMainMenu.PatientIns));//44
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsCovPlanTo, PrimeMainMenu.PatientIns));//45
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsCoPayment, PrimeMainMenu.PatientIns));//46
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsDeductible, PrimeMainMenu.PatientIns));//47
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsStatus, PrimeMainMenu.PatientIns));//48
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsPriSec, PrimeMainMenu.PatientIns));//49
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsAdjuster, PrimeMainMenu.PatientIns));//50
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsAssignment, PrimeMainMenu.PatientIns));//51
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsClaimNo, PrimeMainMenu.PatientIns));//52
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsRel2Insured, PrimeMainMenu.PatientIns));//53
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsInsuredName, PrimeMainMenu.PatientIns));//54
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsInsuredAddress, PrimeMainMenu.PatientIns));//55
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsInsuredZipCode, PrimeMainMenu.PatientIns));//56
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsInsuredPhone, PrimeMainMenu.PatientIns));//57
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsInsuredState, PrimeMainMenu.PatientIns));//58
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsInsuredCity, PrimeMainMenu.PatientIns));//59
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsInsuredDOB, PrimeMainMenu.PatientIns));//50
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsInsuredSex, PrimeMainMenu.PatientIns));//51
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsInsuredSSS, PrimeMainMenu.PatientIns));//52
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsInsuredEmployer, PrimeMainMenu.PatientIns));//53
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsInsuredEmpAddr, PrimeMainMenu.PatientIns));//54
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsInsuredEmpZip, PrimeMainMenu.PatientIns));//55
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsInsuredEmpPhone, PrimeMainMenu.PatientIns));//56
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsInsuredEmpState, PrimeMainMenu.PatientIns));//57
            Elements.Add(new uc_rdbseq(ElmScrns.PatientInsInsuredEmpCity, PrimeMainMenu.PatientIns));//58

            Elements.Add(new uc_rdbseq(ElmScrns.QuestionModifyEncInfo, PrimeMainMenu.PatientIns)); //59
            
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncNum, PrimeMainMenu.PatientEnc)); //60
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncRX, PrimeMainMenu.PatientEnc)); //61
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncInjury, PrimeMainMenu.PatientEnc)); //62
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncOrderDate, PrimeMainMenu.PatientEnc)); //63
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncInitialTreatment, PrimeMainMenu.PatientEnc)); //64
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncXrayDate, PrimeMainMenu.PatientEnc)); //65
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncAcuteManifestation, PrimeMainMenu.PatientEnc)); //66
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncAuthNum, PrimeMainMenu.PatientEnc)); //67
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncLastSeen, PrimeMainMenu.PatientEnc)); //68
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncAuthorizedVisits, PrimeMainMenu.PatientEnc)); //69
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncEmergencyYN, PrimeMainMenu.PatientEnc)); //70
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncAuthFrom, PrimeMainMenu.PatientEnc)); //71
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncAuthTo, PrimeMainMenu.PatientEnc)); //72
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncPOS, PrimeMainMenu.PatientEnc)); //73
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncReferredLab, PrimeMainMenu.PatientEnc)); //74
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncBox19Desc, PrimeMainMenu.PatientEnc)); //75
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncHCFABox19Date, PrimeMainMenu.PatientEnc)); //76
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncReferringCode, PrimeMainMenu.PatientEnc)); //77
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncFirstSymptom, PrimeMainMenu.PatientEnc)); //78
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncFirstConsulted, PrimeMainMenu.PatientEnc)); //79
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncSimilarSymptom, PrimeMainMenu.PatientEnc)); //80
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncDischargeDate, PrimeMainMenu.PatientEnc)); //81
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncStatusEmployment, PrimeMainMenu.PatientEnc)); //82
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncStatusStudent, PrimeMainMenu.PatientEnc)); //83
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncRelatedAccident, PrimeMainMenu.PatientEnc)); //84
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncEmploymentYN, PrimeMainMenu.PatientEnc)); //85
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncUnable2WorkFrom, PrimeMainMenu.PatientEnc)); //86
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncUnable2WorkTo, PrimeMainMenu.PatientEnc)); //87
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncHospiFrom, PrimeMainMenu.PatientEnc)); //88
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncHospiTo, PrimeMainMenu.PatientEnc)); //89
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncDisabilityFrom, PrimeMainMenu.PatientEnc)); //90
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncDisabilityTo, PrimeMainMenu.PatientEnc)); //91
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncSoc, PrimeMainMenu.PatientEnc)); //92
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncSocAmount, PrimeMainMenu.PatientEnc)); //93
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncOrigRefNo, PrimeMainMenu.PatientEnc)); //94
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncStatus, PrimeMainMenu.PatientEnc)); //95
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncFamilyPlanning, PrimeMainMenu.PatientEnc)); //96
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncBillingLimit, PrimeMainMenu.PatientEnc)); //97
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncSchedofBenefits, PrimeMainMenu.PatientEnc)); //98
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncReferralDate, PrimeMainMenu.PatientEnc)); //99
            Elements.Add(new uc_rdbseq(ElmScrns.PatientEncLastCertification, PrimeMainMenu.PatientEnc)); //100

            Elements.Add(new uc_rdbseq(ElmScrns.ChargeSB, PrimeMainMenu.PostingCharges)); //100
            Elements.Add(new uc_rdbseq(ElmScrns.ChargeSBNotice, PrimeMainMenu.PostingCharges)); //100
            Elements.Add(new uc_rdbseq(ElmScrns.ChargeACN, PrimeMainMenu.PostingCharges)); //100
            Elements.Add(new uc_rdbseq(ElmScrns.ChargeDR, PrimeMainMenu.PostingCharges)); //100
            Elements.Add(new uc_rdbseq(ElmScrns.ChargeRdr, PrimeMainMenu.PostingCharges)); //100
            Elements.Add(new uc_rdbseq(ElmScrns.ChargePOS, PrimeMainMenu.PostingCharges)); //100
            Elements.Add(new uc_rdbseq(ElmScrns.ChargeEN, PrimeMainMenu.PostingCharges)); //100
            Elements.Add(new uc_rdbseq(ElmScrns.ChargeDX, PrimeMainMenu.PostingCharges)); //100
            Elements.Add(new uc_rdbseq(ElmScrns.ChargePanel, PrimeMainMenu.PostingCharges)); //100
            Elements.Add(new uc_rdbseq(ElmScrns.ChargeDrCode, PrimeMainMenu.PostingCharges)); //100
            Elements.Add(new uc_rdbseq(ElmScrns.ChargeFrom, PrimeMainMenu.PostingCharges)); //100
            Elements.Add(new uc_rdbseq(ElmScrns.ChargeTo, PrimeMainMenu.PostingCharges)); //100
            Elements.Add(new uc_rdbseq(ElmScrns.ChargeProcedure, PrimeMainMenu.PostingCharges)); //100
            Elements.Add(new uc_rdbseq(ElmScrns.ChargeAmount, PrimeMainMenu.PostingCharges)); //100
        }

        public int GetElementIndex(ElmScrns p)
        {
            System.Int32                 x = -1;
            System.Boolean          isfound = false;
            uc_rdbseq tempObj;

            for (int i=0; i < Elements.Count; i++)
            {
                tempObj = Elements[i];
                if (tempObj._p1 == p)
                {
                    isfound = true;
                    x = i;
                    break;
                }
            }

            if(isfound == true)
                return x;
            return -1;
        }

        public void CmdDispatch()
        {
            if (myMaptxtcaretinfo.seqScrn != ElmScrns.NotFound && myMaptxtcaretinfo.seqScrn == curForm)
            {
                inElement = true;
                SequenceNum++;
                rdbmsg.Insert(0, string.Format("seqScrn: {0} - a counter: {1}\n", myMaptxtcaretinfo.seqScrn.ToString(), acounter));
                switch (curMenu)
                {
                    case PrimeMainMenu.Initial:
                        seqInitial();
                        break;
                    case PrimeMainMenu.Main:
                        seqMain();
                        break;
                    case PrimeMainMenu.Patient:
                        seqPatient();
                        break;
                    case PrimeMainMenu.PatientInfo:
                        seqPatientInfo();
                        break;
                    case PrimeMainMenu.PatientIns:
                        seqPatientIns();
                        break;
                    case PrimeMainMenu.PatientEnc:
                        seqPatientEnc();
                        break;
                    case PrimeMainMenu.PostingCharges:
                        seqPostingCharges();
                        break;
                    default:
                        //
                        break;
                }
            }
            else
            {
                
                if (acounter == 0 && GetElementIndex(curForm) >= GetElementIndex(ElmScrns.MainPatient))
                {
                    WhatElementInCurPos();
                }

            }
        }

        public bool WhatElementInCurPos()
        {
            Strfield = "";
            acounter++;


            System.Collections.Generic.List<uc_maptxtcaretinfo> rbtmp = new System.Collections.Generic.List<uc_maptxtcaretinfo>();
            Strfield = retrieveStrData(rdbp2, rdbp3, 0, rdbp1.X, rdbp1.Y);

            //todo process Caret Pos depending on the keyboard event
            rbtmp = myMapTxtCaret.SearchElems(rdbp1, Strfield, curMenu);
            if (rbtmp.Count == 1)
            {
                myMaptxtcaretinfo = rbtmp[0];
                ElmScrns elmOut = myMaptxtcaretinfo.seqScrn;

                switch (prevForm)
                {
                    case ElmScrns.PatientDemographics:
                        switch (elmOut)
                        {
                            case ElmScrns.PatientInfoPressAnyKey:
                                GoToElem(ElmScrns.PatientInfoGuarrantor);
                                SendCmdKey();
                                break;
                            case ElmScrns.PatientInfoGuarrantor:
                                curForm = elmOut;
                                GoToElem(elmOut);
                                break;
                        }
                        break;
                    case ElmScrns.PatientInsCode:
                        switch (elmOut)
                        {
                            case ElmScrns.QuestionModifyEncInfo:
                                curForm = elmOut;
                                GoToElem(elmOut);
                                break;
                        }
                        break;
                    case ElmScrns.PatientEncRX:
                        switch (myMaptxtcaretinfo.seqScrn)
                        {
                            case ElmScrns.PromptEncRecordNotFound:
                                GoToElem(ElmScrns.PatientDemographics);
                                SendCmdKey();
                                break;
                        }
                        break;
                    case ElmScrns.PatientEncLastCertification:
                        //this is the end of the sequence:
                        //just do something or end
                        GoToElem(ElmScrns.PatientDemographics);
                        SendCmdKey(END);
                        break;
                        /*
                    case ElmScrns.ChargeSBNotice:
                    case ElmScrns.ChargeSB:
                        rdbmsg.Insert(0, string.Format("elmOut: {0}\n", elmOut.ToString()));
                        switch (elmOut)
                        {
                            case ElmScrns.ChargeRdr:
                            //case ElmScrns.ChargePOS:
                            //case ElmScrns.ChargeDR:
                                curForm = elmOut;
                                GoToElem(elmOut);
                                break;
                        }

                        break;
                        */
                    default:
                        switch (elmOut)
                        {
                            case ElmScrns.PatientInsRecordInUse:
                                //GoToElem(ElmScrns.PatientInsCode);
                                //SendCmdKey(END);
                                break;
                        }
                        break;
                        
                }
            }
            else
            {
                return false;
            }

            CmdDispatch();

            return true;
        }
	}
}
