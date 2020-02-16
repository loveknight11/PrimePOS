using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PrimePOS
{
    class CRptParent
    {
        public static void PrepareReport(RptParent Rpt)
        {
            DataTable DTSettings = CDB.GetRptSettings();
            if (DTSettings.Rows.Count == 0)
            {
                Rpt.PictureHdr.Visible = false;
                Rpt.LblFooter.Visible = false;
                Rpt.LblLHdr1.Visible = false;
                Rpt.LblLHdr2.Visible = false;
                Rpt.LblLHdr3.Visible = false;
                Rpt.LblRHdr1.Visible = false;
                Rpt.LblRHdr2.Visible = false;
                Rpt.LblRHdr3.Visible = false;
            }
            else
            {
                string Footer = DTSettings.Rows[0]["Footer"].ToString();
                string LHdr1 = DTSettings.Rows[0]["LHdr1"].ToString();
                string LHdr2 = DTSettings.Rows[0]["LHdr2"].ToString();
                string LHdr3 = DTSettings.Rows[0]["LHdr3"].ToString();
                string RHdr1 = DTSettings.Rows[0]["RHdr1"].ToString();
                string RHdr2 = DTSettings.Rows[0]["RHdr2"].ToString();
                string RHdr3 = DTSettings.Rows[0]["RHdr3"].ToString();
                if (DTSettings.Rows[0]["PictureHdr"].ToString() != "")
                {
                    Rpt.PictureHdr.Image = CImage.ArrayTextToImage(DTSettings.Rows[0]["PictureHdr"]);
                }
                else
                {
                    Rpt.PictureHdr.Visible = false;
                }

                if (Footer != "")
                {
                    Rpt.LblFooter.Text = Footer;
                }
                else
                {
                    Rpt.LblFooter.Visible = false;
                }

                if (LHdr1 != "")
                {
                    Rpt.LblLHdr1.Text = LHdr1;
                }
                else
                {
                    Rpt.LblLHdr1.Visible = false;
                }

                if (LHdr2 != "")
                {
                    Rpt.LblLHdr2.Text = LHdr2;
                }
                else
                {
                    Rpt.LblLHdr2.Visible = false;
                }

                if (LHdr3 != "")
                {
                    Rpt.LblLHdr3.Text = LHdr3;
                }
                else
                {
                    Rpt.LblLHdr3.Visible = false;
                }

                if (RHdr1 != "")
                {
                    Rpt.LblRHdr1.Text = RHdr1;
                }
                else
                {
                    Rpt.LblRHdr1.Visible = false;
                }

                if (RHdr2 != "")
                {
                    Rpt.LblRHdr2.Text = RHdr2;
                }
                else
                {
                    Rpt.LblRHdr2.Visible = false;
                }

                if (RHdr3 != "")
                {
                    Rpt.LblRHdr3.Text = RHdr3;
                }
                else
                {
                    Rpt.LblRHdr3.Visible = false;
                }
            }
        }
    }
}
