using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace PrimePOS.Settings
{
    class CRptHeaderFooter
    {
        #region Definitions
        SqlConnection Con = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        SqlDataAdapter DA = new SqlDataAdapter();
        DataTable DT = new DataTable();
        #endregion
        public CRptHeaderFooter()
        {
            Con.ConnectionString = CDataAccess.GetConStr();
        }
        private void NewCmd()
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }
        private void FillDT()
        {
            DA = new SqlDataAdapter(Cmd);
            DT = new DataTable();
            DA.Fill(DT);
        }

        public DataTable GetSettings()
        {
            NewCmd();
            Cmd.CommandText = "select * from TblReportSettings";
            FillDT();
            return DT;
        }

        public bool UpdateSettings(string RHdr1, string RHdr2, string RHdr3, string LHdr1, string LHdr2, string LHdr3,
            byte[] PictureHdr, string Footer)
        {
            bool Result = false;
            NewCmd();
            Cmd.CommandText = "select * from TblReportSettings";
            FillDT();
            if (DT.Rows.Count == 0)
            {
                Result = AddSettings(RHdr1, RHdr2, RHdr3, LHdr1, LHdr2, LHdr3, PictureHdr, Footer);
            }
            else
            {
                Result = EditSettings(RHdr1, RHdr2, RHdr3, LHdr1, LHdr2, LHdr3, PictureHdr, Footer);
            }

            if (Result)
            {
                CLog.AddLog("TblReportSettings", "update report settings");
            }
            return Result;
        }

        private bool AddSettings(string RHdr1, string RHdr2, string RHdr3, string LHdr1, string LHdr2, string LHdr3,
            byte[] PictureHdr, string Footer)
        {
            NewCmd();
            Cmd.CommandText = @"insert into TblReportSettings (RHdr1, RHdr2, RHdr3, LHdr1, LHdr2, LHdr3, PictureHdr, Footer) 
                              values (@RHdr1, @RHdr2, @RHdr3, @LHdr1, @LHdr2, @LHdr3, @PictureHdr, @Footer)";
            
            Cmd.Parameters.AddWithValue("@RHdr1",RHdr1);
            Cmd.Parameters.AddWithValue("@RHdr2",RHdr2);
            Cmd.Parameters.AddWithValue("@RHdr3",RHdr3);
            Cmd.Parameters.AddWithValue("@LHdr1",LHdr1);
            Cmd.Parameters.AddWithValue("@LHdr2",LHdr2);
            Cmd.Parameters.AddWithValue("@LHdr3",LHdr3);
            Cmd.Parameters.AddWithValue("@PictureHdr",PictureHdr);
            Cmd.Parameters.AddWithValue("@Footer",Footer);

            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return false;
            }
            finally { Con.Close(); }
        }

        private bool EditSettings(string RHdr1, string RHdr2, string RHdr3, string LHdr1, string LHdr2, string LHdr3,
            byte[] PictureHdr, string Footer)
        {
            NewCmd();
            Cmd.CommandText = @"update TblReportSettings set RHdr1 = @RHdr1, RHdr2 = @RHdr2, RHdr3 = @RHdr3, LHdr1 = @LHdr1, 
                              LHdr2 = @LHdr2, LHdr3 = @LHdr3, PictureHdr = @PictureHdr, Footer = @Footer";

            Cmd.Parameters.AddWithValue("@RHdr1", RHdr1);
            Cmd.Parameters.AddWithValue("@RHdr2", RHdr2);
            Cmd.Parameters.AddWithValue("@RHdr3", RHdr3);
            Cmd.Parameters.AddWithValue("@LHdr1", LHdr1);
            Cmd.Parameters.AddWithValue("@LHdr2", LHdr2);
            Cmd.Parameters.AddWithValue("@LHdr3", LHdr3);
            Cmd.Parameters.AddWithValue("@PictureHdr", PictureHdr);
            Cmd.Parameters.AddWithValue("@Footer", Footer);

            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return false;
            }
            finally { Con.Close(); }
        }
    }
}
