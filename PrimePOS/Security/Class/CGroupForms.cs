using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace PrimePOS.Security
{
    class CGroupForms
    {
        #region Definitions
        SqlConnection Con = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        SqlDataAdapter DA = new SqlDataAdapter();
        DataTable DT = new DataTable();
        #endregion
        public CGroupForms()
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

        public void CheckGroupForms(string GroupID)
        {
            NewCmd();
            Cmd.CommandText = "select * from TblForms where ID not in (select FormID from TblUserGroupForms where UserGroupID = @ID)";
            Cmd.Parameters.AddWithValue("@ID", GroupID);
            FillDT();
            
            foreach (DataRow DR in DT.Rows)
            {
                NewCmd();
                Cmd.CommandText = @"insert into TblUserGroupForms (UserGroupID, FormID, AllowOpen, AllowSave, AllowEdit, AllowDelete) 
                                  values (@GroupID, @FormID, @False, @False, @False, @False)";
                Cmd.Parameters.AddWithValue("@GroupID", GroupID);
                Cmd.Parameters.AddWithValue("@False", false);
                Cmd.Parameters.AddWithValue("@FormID", DR["ID"].ToString());
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw;
                }
                finally { Con.Close(); }
            }
        }

        public DataTable GetGroupForms(string GroupID, string Module)
        {
            NewCmd();
            Cmd.CommandText = "select * from ViewUserGroupForms where UserGroupID = @ID and Module = @Module order by FormID";
            Cmd.Parameters.AddWithValue("@ID", GroupID);
            Cmd.Parameters.AddWithValue("@Module", Module);
            FillDT();
            return DT;
        }

        public bool SaveGroupForm(string ID, bool AllowOpen, bool AllowSave, bool AllowEdit, bool AllowDelete)
        {
            NewCmd();
            Cmd.CommandText = @"update TblUserGroupForms set AllowOpen = @AllowOpen, AllowSave = @AllowSave, AllowEdit = @AllowEdit, 
                               AllowDelete = @AllowDelete where ID = @ID";
            Cmd.Parameters.AddWithValue("@AllowOpen",AllowOpen);
            Cmd.Parameters.AddWithValue("@AllowSave",AllowSave);
            Cmd.Parameters.AddWithValue("@AllowEdit",AllowEdit);
            Cmd.Parameters.AddWithValue("@AllowDelete",AllowDelete);
            Cmd.Parameters.AddWithValue("@ID",ID);

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
