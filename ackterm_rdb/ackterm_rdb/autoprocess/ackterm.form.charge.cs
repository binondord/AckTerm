public partial class ackterm
{
    private partial class uc_autoprocess
    {
        private partial class uc_maptxtcaret
        {
            private void defCoordCharge(
                    int lcol = 0,
                    int xcd = 0,
                    bool lend = false,
                    int ycd = -1,
                    ElmScrns es = ElmScrns.NotFound,
                    int width = 0,
                    bool withVal = true,
                    UseWhat uw = UseWhat.None,
                    string strText = "",
                    FormScrnOpt frmscropt = FormScrnOpt.None,
                    int lcolend = 0
                )
            {
                x_coord = (xcd != 0) ? xcd : 27;
                lftColStart = (lcol != 0) ? lcol : 1;
                lftColEnd = (lend == true) ? x_coord : (x_coord - 1);

                if (x_coord == 27)
                    y_coord++;

                y_coord = (ycd != -1) ? ycd : y_coord;

                valwidth = x_coord + width;

                switch (frmscropt)
                {
                    case FormScrnOpt.ChargeSBNotice:
                        lftColEnd = lcolend;
                        break;
                }

                Elements.Add(
                    new uc_maptxtcaretinfo(
                        PrimeMainMenu.PostingCharges,
                        new System.Drawing.Point(x_coord, y_coord),
                        new uc_formpartsinfo(strText,
                            new System.Drawing.Point(lftColStart, y_coord),
                            new System.Drawing.Point(lftColEnd, y_coord)
                        ),
                        new uc_formpartsinfo("-val-",
                            new System.Drawing.Point(x_coord, y_coord),
                            new System.Drawing.Point(valwidth, y_coord)
                        ),
                        es,
                        withVal,
                        uw
                    ));
            }

            private void formCharge()
            {
                defCoordCharge(1, 3, true, 0, ElmScrns.ChargeSB, 6, true, UseWhat.None, "SB");
                defCoordCharge(10, 13, true, -1, ElmScrns.ChargeACN, 6, true, UseWhat.None, "ACN");
                defCoordCharge(39, 42, true, -1, ElmScrns.ChargeDR, 6, true, UseWhat.None, "Dr:");
                defCoordCharge(48, 53, true, -1, ElmScrns.ChargeRdr, 6, true, UseWhat.None, "Rdr");
                defCoordCharge(60, 63, true, -1, ElmScrns.ChargePOS, 6, true, UseWhat.None, "POS");
                defCoordCharge(69, 73, true, -1, ElmScrns.ChargeEN, 6, true, UseWhat.None, "EN#:");
                defCoordCharge(1, 19, true, 4, ElmScrns.ChargeDX, 6, true, UseWhat.None, "Diagnosis Code: ");
                defCoordCharge(1, 8, true, -1, ElmScrns.ChargePanel, 6, true, UseWhat.None, "Panel: ");
                defCoordCharge(1, 14, true, -1, ElmScrns.ChargeDrCode, 6, true, UseWhat.None, "Panel: ");
                defCoordCharge(1, 26, true, -1, ElmScrns.ChargeFrom, 6, true, UseWhat.None, "From:");
                defCoordCharge(1, 39, true, -1, ElmScrns.ChargeTo, 6, true, UseWhat.None, "To:");
                defCoordCharge(1, 50, true, -1, ElmScrns.ChargeRdx, 6, true, UseWhat.None, "To:");
                defCoordCharge(1, 3, true, -1, ElmScrns.ChargeProcedure, 6, true, UseWhat.None, "From:");
                defCoordCharge(1, 3, true, -1, ElmScrns.ChargeAmount, 6, true, UseWhat.None, "From:");
                defCoordCharge(11, 38, true, 8, ElmScrns.ChargeSBNotice, 58, true, UseWhat.Field, "W", FormScrnOpt.ChargeSBNotice, 69);
                defCoordCharge(1, 27, true, 23, ElmScrns.ChargePressAnyKey, 26, true, UseWhat.None, "Press any key to continue.");
            }
        }
    }
}
