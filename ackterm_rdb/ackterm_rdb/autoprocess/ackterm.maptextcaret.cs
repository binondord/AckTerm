public partial class ackterm
{
    private partial class uc_autoprocess
    {
        private partial class uc_maptxtcaret
        {
            //public System.Collections.ArrayList Elements = new System.Collections.ArrayList();
            public System.Collections.Generic.List<uc_maptxtcaretinfo> Elements = new System.Collections.Generic.List<uc_maptxtcaretinfo>();
            private System.Int32 x_coord = 0;
            private System.Int32 y_coord = 0;
            private System.Int32 lftColStart = 0;
            private System.Int32 lftColEnd = 0;
            private System.Int32 valwidth = 0;

            private uc_autoprocess thisautoproc;

            public uc_maptxtcaret(uc_autoprocess p)
            {
                thisautoproc = p;
                this.SetToDefault();
            }

            public void SetToDefault()
            {
                Elements.Clear();
                mainform();
                menuPatient();
                searchpatientinfo();
                formPatientInfo();
                formPatientIns();
                formPatientEnc();
                formCharge();
            }

            public void LoadForms(PrimeMainMenu p1, ElmScrns p2)
            {
                //Elements.Clear();

                switch(p1)
                {
                    case PrimeMainMenu.Initial:
                        break;
                    default:
                        break;
                }
            }

            public System.Collections.Generic.List<uc_maptxtcaretinfo> FindElemByPrimeMainMenu(PrimeMainMenu param, ElmScrns a = ElmScrns.NotFound)
            {
                //System.Collections.ArrayList outElements = new System.Collections.ArrayList();
                System.Collections.Generic.List<uc_maptxtcaretinfo> outElements = new System.Collections.Generic.List<uc_maptxtcaretinfo>();
                uc_maptxtcaretinfo tmpElement;

                for (int i=0; i < Elements.Count; i++)
                {
                    tmpElement = Elements[i];
                    if (param == tmpElement.inMenu && a == ElmScrns.NotFound)
                    {
                        outElements.Add(tmpElement);
                    }
                    else if(param == tmpElement.inMenu && a == tmpElement.seqScrn)
                    {
                        outElements.Add(tmpElement);
                    }
                }
                return outElements;
            }

            public uc_maptxtcaretinfo SearchElem(
                    System.Drawing.Point curPos,
                    System.String str,
                    PrimeMainMenu p1,
                    ElmScrns cfr = ElmScrns.NotFound
                )
            {
                //LoadForms(p1, cfr);

                uc_maptxtcaretinfo tmpElement;
                uc_maptxtcaretinfo defElement = new uc_maptxtcaretinfo(
                        PrimeMainMenu.None,
                        new System.Drawing.Point(0, 0),
                        new uc_formpartsinfo("Not Found ",
                            new System.Drawing.Point(0, 0),
                            new System.Drawing.Point(0, 0)
                        ),
                        new uc_formpartsinfo("values",
                            new System.Drawing.Point(0, 0),
                            new System.Drawing.Point(0, 0)
                        ),
                        ElmScrns.NotFound,
                        false,
                        UseWhat.None
                    );
                bool isFound = false;
                tmpElement = defElement;
                string tmpStr;

                for (int i = 0; i < Elements.Count; i++)
                {
                    tmpElement = Elements[i];
                    tmpStr = str;

                    if(cfr == tmpElement.seqScrn && tmpElement.inMenu == p1 && tmpElement.curPos.X == curPos.X && tmpElement.curPos.Y == curPos.Y)
                    {
                        switch (tmpElement.useThis)
                        {
                            case UseWhat.Field:
                                str = thisautoproc.retrieveStrData(thisautoproc.rdbp2, thisautoproc.rdbp3, tmpElement.frmfield.prmStartPos.X, tmpElement.frmfield.prmEndPos.X, tmpElement.frmfield.prmStartPos.Y);
                                break;
                            case UseWhat.Value:
                                str = thisautoproc.retrieveStrData(thisautoproc.rdbp2, thisautoproc.rdbp3, tmpElement.frmvalue.prmStartPos.X, tmpElement.frmvalue.prmEndPos.X, tmpElement.frmvalue.prmStartPos.Y);
                                break;
                        }
                    }

                    //rdbmsg.Clear();
                    //rdbmsg.AppendFormat("a:{0}\nb:{1}\nc:{2}\nd:{3}\ne:{4}\nf:{5}\n", cfr, tmpElement.curPos.ToString(), str, curPos.ToString(), str.Contains(tmpElement.frmfield.param), tmpElement.seqScrn);

                    if (cfr == tmpElement.seqScrn && tmpElement.inMenu == p1 && tmpElement.curPos.X == curPos.X && tmpElement.curPos.Y == curPos.Y && str.Contains(tmpElement.frmfield.param))
                    {
                        isFound = true;
                        tmpElement.index = i;
                        break;
                    }
                }
                if (isFound == true)
                    return tmpElement;
                else return defElement;
            }


            public System.Collections.Generic.List<uc_maptxtcaretinfo> SearchElems(
                    System.Drawing.Point curPos,
                    System.String str,
                    PrimeMainMenu p1,
                    ElmScrns cfr = ElmScrns.NotFound
                )
            {
                //LoadForms(p1, cfr);
                //System.Collections.ArrayList resultset = new System.Collections.ArrayList();
                System.Collections.Generic.List<uc_maptxtcaretinfo> resultset = new System.Collections.Generic.List<uc_maptxtcaretinfo>();

                uc_maptxtcaretinfo tmpElement;
                uc_maptxtcaretinfo defElement = new uc_maptxtcaretinfo(
                        PrimeMainMenu.None,
                        new System.Drawing.Point(0, 0),
                        new uc_formpartsinfo("Not Found ",
                            new System.Drawing.Point(0, 0),
                            new System.Drawing.Point(0, 0)
                        ),
                        new uc_formpartsinfo("values",
                            new System.Drawing.Point(0, 0),
                            new System.Drawing.Point(0, 0)
                        ),
                        ElmScrns.NotFound,
                        false,
                        UseWhat.None
                    );
                //bool isFound = false;
                tmpElement = defElement;
                string tmpStr;

                for (int i = 0; i < Elements.Count; i++)
                {
                    tmpElement = Elements[i];
                    tmpStr = str;

                    if (tmpElement.inMenu == p1 && tmpElement.curPos.X == curPos.X && tmpElement.curPos.Y == curPos.Y)
                    {
                        switch (tmpElement.useThis)
                        {
                            case UseWhat.Field:
                                str = thisautoproc.retrieveStrData(thisautoproc.rdbp2, thisautoproc.rdbp3, tmpElement.frmfield.prmStartPos.X, tmpElement.frmfield.prmEndPos.X, tmpElement.frmfield.prmStartPos.Y);
                                break;
                            case UseWhat.Value:
                                str = thisautoproc.retrieveStrData(thisautoproc.rdbp2, thisautoproc.rdbp3, tmpElement.frmvalue.prmStartPos.X, tmpElement.frmvalue.prmEndPos.X, tmpElement.frmvalue.prmStartPos.Y);
                                break;
                        }
                    }

                    //rdbmsg.Clear();
                    //rdbmsg.AppendFormat("a:{0}\nb:{1}\nc:{2}\nd:{3}\ne:{4}\nf:{5}\n", cfr, tmpElement.curPos.ToString(), str, curPos.ToString(), str.Contains(tmpElement.frmfield.param), tmpElement.seqScrn);

                    if (tmpElement.inMenu == p1 && tmpElement.curPos.X == curPos.X && tmpElement.curPos.Y == curPos.Y && str.Contains(tmpElement.frmfield.param))
                    {
                        //isFound = true;
                        tmpElement.index = i;
                        resultset.Add(tmpElement);
                        break;
                    }
                }
                //if (isFound == true)
                //    return tmpElement;
                //else return defElement;
                return resultset;
            }
        }
    }
}
