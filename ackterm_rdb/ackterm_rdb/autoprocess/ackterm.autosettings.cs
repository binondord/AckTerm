public partial class ackterm
{
    private partial class uc_autoprocess
    {
        public partial class uc_autosettings
        {
            public bool bTraversePatientInfo = true;
            public bool bTraversePatientIns = true;
            public bool bTraversePatientEnc = true;

            public bool bStartCharge = false;

            public bool bHasSB = false;
            public bool bHasAccountNo = false;
            public bool bHasLastName = false;
            public bool bHasFirstName = false;
            public bool bHasDOB = false;

            public bool bInSearch = false;
            public bool bDoneSearch = false;
            public bool bSearchPatientNotFound = false;
            public bool bSearchPlayWithLastName = false;

            public uc_autosettings()
            {

            }

            public bool setSearchTest(int a)
            {
                if (bInSearch && a >= 4)
                {
                    a = 0;
                    return false;
                }


                switch (a)
                {
                    case 0:
                        break;
                    /*case 1:
                        bHasAccountNo = false;
                        bHasLastName = false;
                        bHasDOB = (bHasDOB) ? true : false;
                        break;*/
                    case 1:
                        bHasAccountNo = false;
                        bHasLastName = (bHasLastName) ? true : false;
                        bHasDOB = false;
                        break;
                    case 2:
                        bHasAccountNo = false;
                        bHasLastName = (bHasLastName) ? true : false;
                        bHasDOB = false;
                        bSearchPlayWithLastName = true;
                        break;
                    default:
                        return false;
                }

                return true;
            }
        }
    }
}
