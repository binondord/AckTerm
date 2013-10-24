using System;
public partial class ackterm
{
    private partial class uc_autoprocess
    {
        public string assignifcolnameexists(string _colname)
        {
            string retval = ddtt.Columns.Contains(_colname) ? ddtt.Rows[currentExcelPatient][_colname] + "" : "";
            return retval;
        }

        public DateTime assignifcolnameexists(string _colname, RdbDataType b = RdbDataType.DateTime)
        {
            DateTime rv;
            string retval = ddtt.Columns.Contains(_colname) ? ddtt.Rows[currentExcelPatient][_colname] + "" : "";

            if (retval.Length == 0)
            {
                autosettings.bHasDOB = false;
            }
            else autosettings.bHasDOB = true;
            
            rv = Convert.ToDateTime(retval);
            return rv;
        }

        public void setSettings()
        {
            autosettings.bHasSB = (excelpatient.PatientChargeSB.Length != 0) ? true : false;
            autosettings.bHasAccountNo = (excelpatient.PatientInfoAcctNum.Length != 0) ? true : false;
            autosettings.bHasLastName = (excelpatient.PatientInfoLastName.Length != 0) ? true : false;
            autosettings.bHasFirstName = (excelpatient.PatientInfoFirstName.Length != 0) ? true : false;
        }
    }
}
