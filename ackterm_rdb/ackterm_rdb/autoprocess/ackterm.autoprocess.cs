using Excel;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
public partial class ackterm
{
    private partial class uc_autoprocess
    {
        public System.Collections.Generic.List<uc_somepatient> AllPatients = new System.Collections.Generic.List<uc_somepatient>();
        private uc_somepatient currentpatient;
        private uc_somepatient excelpatient;

        private uc_autosettings autosettings = new uc_autosettings();

        private static System.Int32 acounter = 0;

        private uc_maptxtcaret myMapTxtCaret;
        private uc_rdbseq tmpInt;
        private uc_maptxtcaretinfo myMaptxtcaretinfo;
        private System.Text.StringBuilder mySB;
        private System.Int32 rRows = 0;
        private System.Int32 rColumns = 0;

        private System.Int32 SequenceNum = 0;

        private System.String Strfield = "";
        private System.String StrValue = "";
        private System.Int32 startval = 0;
        private System.Int32 endval = 0;
        private System.Int32 ypos = 0;

        private static System.String outString = "";

        public System.Collections.Generic.List<uc_rdbseq> Elements = new System.Collections.Generic.List<uc_rdbseq>();
        public System.Collections.Generic.List<uc_assocElem> MeetSender = new System.Collections.Generic.List<uc_assocElem>();

        private PrimeMainMenu curMenu = PrimeMainMenu.Initial;
        private ElmScrns curForm = ElmScrns.NotFound;
        private ElmScrns prevForm = ElmScrns.NotFound;
        private TermWindow Parent;

        private System.Boolean hasPass = false;
        private System.Boolean goBack = false;
        private System.Boolean inElement = false;

        private DataCaptureInsResult afterDataCapture = DataCaptureInsResult.None;
        private SetPoint mysetpoint = SetPoint.None;
        private System.Boolean fromDownIns = false;
        private System.Boolean fromDownPatient = false;
        private System.Int32 indexInsurances = 0;

        System.Drawing.Point rdbp1;
        public System.Char[][] rdbp2;
        public CharAttribs[][] rdbp3;

        public CmdSend lastSendCmd = CmdSend.None;

        const string ENTER = "\x0D";
        const string END = "\x1B[F";
        const string CURSORUP = "\x1B[A";
        const string F2 = "\x1B[N";
        const string F6 = "\x1B[R";
        const string SPACE = " ";
        const string SHIFT_F6 = "\x1B[d";

        string[] panels;
        FileStream stream;
        IExcelDataReader excelReader;
        DataSet output;
        DataTable ddtt;
        bool shouldIncExcelPatientCntr = false;

        int numCount;
        int currentExcelPatient = 0;

        string strPanel;
        bool contPatientLoop = false;

        public uc_autoprocess(
                System.Int32 aRows,
                System.Int32 aColumns,
                TermWindow p1
            )
        {
            this.rRows = aRows;
            this.rColumns = aColumns;
            this.Parent = p1;

            mySB = new System.Text.StringBuilder(this.rRows * this.rColumns);
            this.SetSequence();
            myMapTxtCaret = new uc_maptxtcaret(this);

            stream = File.Open(@"c:\temp\urrea.xlsx", FileMode.Open, FileAccess.Read);
            excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

            excelReader.IsFirstRowAsColumnNames = true;
            output = excelReader.AsDataSet();

            ddtt = output.Tables[0];
            numCount = ddtt.Rows.Count;

            shouldIncExcelPatientCntr = false;
        }

        public string start()
        {
            acounter = 0;
            outString = "";
            StrValue = "";
            ypos = 0;

            startval = 0;
            endval = 0;

            rdbp1 = this.Parent.Caret.Pos;
            rdbp2 = this.Parent.CharGrid;
            rdbp3 = this.Parent.AttribGrid;

            //conditional traverse here

            do
            {
                if (currentExcelPatient >= numCount)
                    break;
                
                strPanel = ddtt.Rows[currentExcelPatient]["panel"] + "";
                if (strPanel.Length == 0)
                {
                    contPatientLoop = true;
                    currentExcelPatient++;
                }
                else
                {
                    panels = Regex.Split(strPanel, "/");
                    foreach (string pnl in panels)
                    {
                        switch (pnl)
                        {
                                /*
                            case "2081":
                                autosettings.bTraversePatientInfo = false;
                                autosettings.bTraversePatientIns = false;
                                autosettings.bTraversePatientEnc = false;

                                contPatientLoop = false;
                                break;
                                */
                            default:
                                contPatientLoop = false; //true to skip
                                shouldIncExcelPatientCntr = false; //default: true
                                break;
                        }
                    }

                    if(shouldIncExcelPatientCntr)
                        currentExcelPatient++;
                }
            }
            while (contPatientLoop);

            //start excel data capture here
            excelpatient = new uc_somepatient();
            excelpatient.PatientInfoAcctNum         = ddtt.Rows[currentExcelPatient]["acctno"] + "";
            //excelpatient.PatientChargeAcn           = ddtt.Rows[currentExcelPatient]["acctno"] + "";
            excelpatient.PatientChargeSB            = ddtt.Rows[currentExcelPatient]["superbill"] + "";
            autosettings.bHasSB = (excelpatient.PatientChargeSB.Length != 0) ? true : false;
            
            excelpatient.PatientChargeDr            = ddtt.Rows[currentExcelPatient]["dr"] + "";
            excelpatient.PatientChargeRdr           = ddtt.Rows[currentExcelPatient]["refdr"] + "";
            excelpatient.PatientChargePOS           = ddtt.Rows[currentExcelPatient]["pos"] + "";
            //excelpatient.PatientChargeEN          = ddtt.Rows[currentExcelPatient]["superbill"] + "";
            excelpatient.PatientChargeDX            = ddtt.Rows[currentExcelPatient]["diagnosis"] + "";
            excelpatient.PatientChargeFrom          = ddtt.Rows[currentExcelPatient]["dos"] + "";
            //excelpatient.PatientChargeTo            = ddtt.Rows[currentExcelPatient]["superbill"] + "";

            rdbmsg.Insert(0, string.Format("panel:{0} - excelPatCount: {1}\n", strPanel, currentExcelPatient));

            //currentExcelPatient++;

            Strfield = retrieveStrData(rdbp2, rdbp3, 0, rdbp1.X, rdbp1.Y);

            if (SequenceNum >= Elements.Count)
            {
                SequenceNum = Elements.Count - 1;
            }
            tmpInt = Elements[SequenceNum];

            curMenu = tmpInt._p2;
            curForm = tmpInt._p1;
            //curIndex = GetElementIndex(curForm);

            //prevForm = curForm;

            //process Caret Pos depending on the keyboard event
            myMaptxtcaretinfo = myMapTxtCaret.SearchElem(rdbp1, Strfield, curMenu, curForm);

            if (myMaptxtcaretinfo.seqScrn != ElmScrns.NotFound)
            {
                prevForm = curForm;
            }

            outString = string.Format("curmenu:{0}\nSeqNum:{1}\nenum:{2}\nprvform:{3}\ncurform:{4}\n", curMenu, SequenceNum,myMapTxtCaret.Elements.Count,prevForm, curForm);
            outString += myMaptxtcaretinfo.frmfield.param;

            //retreiveValue
            startval = myMaptxtcaretinfo.frmvalue.prmStartPos.X;
            endval = myMaptxtcaretinfo.frmvalue.prmEndPos.X;
            ypos = myMaptxtcaretinfo.frmvalue.prmStartPos.Y;
            if (myMaptxtcaretinfo.hasValue == true)
            {
                StrValue = retrieveStrData(rdbp2, rdbp3, startval, endval, ypos);
                myMaptxtcaretinfo.frmvalue.param = StrValue;
            }

            outString += string.Format("\nOut:{0}\nStartval:{1}\nendVal:{2}\nY:{3}\n", StrValue, startval, endval, ypos);

            CmdDispatch();

           
            if (currentpatient != null)
            {

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


                prntSome.printSome(curpat, "curpata-", countbmprdb);
                 */
                //rdbmsg.Clear();
                string curpat = "";
                int aaacount = currentpatient.myInsurances.Count;
                for (int m = 0; m < aaacount; m++)
                {
                    uc_someinsurance tmpInsurance = currentpatient.myInsurances[m];
                    //rdbmsg.Insert(0, string.Format("numins: {0} - m: {1} - code: {2}\n", aaacount, m, tmpInsurance.PatientInsCode));

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

                    //prntSome.printSome(curpat, "stored-" + counttelint + "-", m);

                    
                }
                //counttelint++;
            }
            return outString;
        }

        public string retrieveStrData(System.Char[][] p1, CharAttribs[][] p2, int startval, int endval, int y)
        {
            string outStr = "";
            int jj = startval;

            System.Text.StringBuilder sb = new System.Text.StringBuilder(100);

            if ((endval == 0) || (endval > this.rColumns+1))
                return outStr;

            try
            {
                for (; jj < endval; jj++)
                {
                    if (p1[y][jj] == '\0' || p2[y][jj].IsDECSG == true)
                    {
                        //sb.Clear();
                        if (rdbp3[rdbp1.Y][jj].IsDECSG == true)
                        {
                            //Search Main Header Strings
                        }
                        continue;
                    }
                    sb.Append(p1[y][jj]);
                }
                outStr = sb.ToString();
            }
            catch (System.Exception e)
            {
                outStr += e.Message + string.Format("jj:{0}, y:{1}", jj, y);
                string tmpstr = "";

                for (int ii = 0; ii < p1.Length; ii++)
                {
                    var str = new string(p1[ii]);
                    tmpstr += str + "\n";
                }

                prntSome.printSome(outStr + "\n\n\n" + tmpstr, "chargrid-rdb", counttxtscrnrdb);
                counttxtscrnrdb++;
            }

            sb.Clear();
            return outStr;
        }
    }
}
