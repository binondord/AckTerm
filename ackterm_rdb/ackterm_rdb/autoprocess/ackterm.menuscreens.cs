public partial class ackterm
{
    private enum PrimeMainMenu
    {
        None,
        Initial,

        //Main Menu
        Patient,
        Charges,
        Payment,
        Account,
        Ledger,
        Date,
        Billing,
        Management,
        Utility,
        Schedule,
        Misc,
        Main,

        //Patient Details
        PatientInfo,
        PatientIns,
        PatientEnc
    }

    public enum UseWhat
    {
        None,
        Field,
        Value
    }

    public enum DataCaptureInsResult
    {
        None,
        IsNew,
        IsOld
    }

    public enum DataCaptureEncResult
    {
        None,
        IsNew,
        IsOld
    }

    public enum SetPoint
    {
        None,
        Visited,
        New
    }

    public enum CmdSend
    {
        None,
        End,
        Cursorup,
        Enter,
        Space,
        F2
    }

    public enum ElmScrns
    {
        //Initial
        Login,
        TermAnsi,
        Ret2Begin,
        ClinicNum,
        Password,

        /******start of main menu********/
        MainPatient,
        MainCharges,
        MainPayment,
        MainAccount,
        MainLedger,
        MainDate,
        MainBilling,
        MainManagement,
        MainUtility,
        MainSchedule,
        MainMisc,

        //Patient Menu
        PatientMenuAdd,
        PatientMenuModify,
        PatientMenuView,
        PatientMenuInsurAdd,
        PatientMenuInsurDel,
        PatientMenuLabels,
        PatientMenuRegistion,
        PatientMenuWorker,
        PatientMenuForms,
        PatientMenuSearchPt,
        PatientMenuSearchIns,
        PatientMenuExit,

        //Charge Menu
        ChargeMenuCharge,
        ChargeMenuEncounter,
        ChargeMenuModify,
        ChargeMenuUBEncounter,
        ChargeMenuDialysis,
        ChargeMenuLoadAll,
        ChargeMenuFinanceCharge,
        ChargeMenuOshpd,
        ChargeMenuAttachment,

        //Payment Menu
        PaymentMenuOpenItem,
        PaymentMenuAutoPayment,
        PaymentMenuLoadMcal,
        PaymentMenuANSIAutoPay,

        //Ledger Menu
        LedgerMenuAccounting,
        LedgerMenuOpenItem,
        LedgerMenuAnalysis,
        LedgerMenuCollection,
        LedgerMenuMedication,

        //Billing Menu
        BillingMenuInsurance,
        BillingMenuStatement,
        BillingMenuTeleCom,
        BillingMenuFollowUp,
        BillingMenuWorker,

        //Management Menu
        MgtMenuJournal,
        MgtMenuFinancial,
        MgtMenuCheckSlip,
        MgtMenuBalance,
        MgtMenuStatistical,
        MgtMenuAging,
        MgtMenuCredit,
        MgtMenuReferring,
        MgtMenuInactive,
        MgtMenuAnalysis,
        MgtMenuReports,
        MgtMenuLabelOrForm,

        //Utility Menu
        UtilityMenuSetUp,
        UtilityMenuMessages,
        UtilityMenuCategory,
        UtilityMenuProvider,
        UtilityMenuInsurance,
        UtilityMenuDiagnosis,
        UtilityMenuProcedure,
        UtilityMenuFacility,
        UtilityMenuReferring,
        UtilityMenuBusiness,
        UtilityMenuMaintenance,

        //Schedule Menu
        SchedMenuAppointment,
        SchedMenuRecall,

        //Misc Menu
        MiscMenuBackUp,
        MiscMenuLoadForms,
        MiscMenuStatus,

        /******end of main menu********/
        #region Patient
        /******Form Fields Inside Patient Menu********/

        PatientDemographics,
        PatientGuarrantor,
        QuestionModifyInsInfo,
        QuestionModifyEncInfo,

        SearchPatientTextHeader,
        SearchPatientAccountNum,
        SearchPatientName,
        SearchPatientDOB,
        SearchPatientCategory,
        SearchPatientSSN,
        SearchPatientPaginate,
        SearchPatientResRow6,
        SearchPatientResRow7,
        SearchPatientResRow8,
        SearchPatientResRow9,
        SearchPatientResRow10,
        SearchPatientResRow11,
        SearchPatientResRow12,
        SearchPatientResRow13,
        SearchPatientResRow14,
        SearchPatientResRow15,
        SearchPatientResRow16,
        SearchPatientResRow17,

        

        //Patient Info
        PatientInfoAcctNum,
        PatientInfoGuarrantor,
        PatientInfoChartNum,
        PatientInfoName,
        PatientInfoAddr,
        PatientInfoZip,
        PatientInfoCity,
        PatientInfoState,
        PatientInfoHomePhone,
        PatientInfoCell,
        PatientInfoSex,
        PatientInfoDOB,
        PatientInfoAge,
        PatientInfoMStatus,
        PatientInfoEthnicity,
        PatientInfoSSN,
        PatientInfoDL,
        PatientInfoOccupation,
        PatientInfoEmployer,
        PatientInfoEmployerAddr,
        PatientInfoEmployerZip,
        PatientInfoEmployerCity,
        PatientInfoEmployerState,
        PatientInfoEmployerPhone,
        PatientInfoCategory,
        PatientInfoCategoryVal,
        PatientInfoReferral,
        PatientInfoReferralVal,
        PatientInfoPCP,
        PatientInfoHospital,
        PatientInfoLanguage,
        PatientInfoEmail,
        PatientInfoRemarks1,
        PatientInfoRemarks2,
        
        PatientInfoPressAnyKey,

        //Patient INS                 
        PatientInsCode,
        PatientInsMemNum,
        PatientInsGrp,
        PatientInsPayPlan,
        PatientInsCovPlanFrom,
        PatientInsCovPlanTo,
        PatientInsCoPayment,
        PatientInsDeductible,
        PatientInsStatus,
        PatientInsPriSec,
        PatientInsAdjuster,
        PatientInsAssignment,
        PatientInsClaimNo,
        PatientInsRel2Insured,
        PatientInsInsuredName,
        PatientInsInsuredAddress,
        PatientInsInsuredZipCode,
        PatientInsInsuredCity,
        PatientInsInsuredState,
        PatientInsInsuredPhone,
        PatientInsInsuredDOB,
        PatientInsInsuredSex,
        PatientInsInsuredSSS,
        PatientInsInsuredEmployer,
        PatientInsInsuredEmpAddr,
        PatientInsInsuredEmpZip,
        PatientInsInsuredEmpCity,
        PatientInsInsuredEmpState,
        PatientInsInsuredEmpPhone,
        PatientInsRecordInUse,


        //Patient Enc    
        PromptEncRecordNotFound,
     
        PatientEncNum,
        PatientEncRX,
        PatientEncInjury,
        PatientEncOrderDate,
        PatientEncInitialTreatment,
        PatientEncXrayDate,
        PatientEncAcuteManifestation,
        PatientEncAuthNum,
        PatientEncLastSeen,
        PatientEncAuthorizedVisits,
        PatientEncEmergencyYN,
        PatientEncAuthFrom,
        PatientEncAuthTo,
        PatientEncPOS,
        PatientEncReferredLab,
        PatientEncBox19Desc,
        PatientEncHCFABox19Date,
        PatientEncReferringCode,
        PatientEncFirstSymptom,
        PatientEncFirstConsulted,
        PatientEncSimilarSymptom,
        PatientEncDischargeDate,
        PatientEncStatusEmployment,
        PatientEncStatusStudent,
        PatientEncRelatedAccident,
        PatientEncEmploymentYN,
        PatientEncUnable2WorkFrom,
        PatientEncUnable2WorkTo,
        PatientEncHospiFrom,
        PatientEncHospiTo,
        PatientEncDisabilityFrom,
        PatientEncDisabilityTo,
        PatientEncSoc,
        PatientEncSocAmount,
        PatientEncOrigRefNo,
        PatientEncStatus,
        PatientEncFamilyPlanning,
        PatientEncBillingLimit,
        PatientEncSchedofBenefits,
        PatientEncReferralDate,
        PatientEncLastCertification,

        /******End Form Fields Inside Patient Menu********/

        #endregion Patient
        #region Charge


        #endregion Charge

        MainExit,
        NotFound
    }
}

