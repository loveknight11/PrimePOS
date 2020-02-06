using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace PrimePOS.Security
{
    class CUserGroups
    {
        #region Definitions
        SqlConnection Con = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        SqlDataAdapter DA = new SqlDataAdapter();
        DataTable DT = new DataTable();
        #endregion
        public CUserGroups()
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

        public DataTable GetAllGroups()
        {
            NewCmd();
            Cmd.CommandText = "select * from TblUserGroups";
            FillDT();
            return DT;
        }

        public bool CheckNew(string Name)
        {
            NewCmd();
            Cmd.CommandText = "select * from TblUserGroups where Name = @Name";
            Cmd.Parameters.AddWithValue("@Name", Name);
            FillDT();
            return DT.Rows.Count == 0;
        }

        public bool CheckUpdate(string Name, string ID)
        {
            NewCmd();
            Cmd.CommandText = "select * from TblUserGroups where Name = @Name and ID != @ID";
            Cmd.Parameters.AddWithValue("@Name", Name);
            Cmd.Parameters.AddWithValue("@ID", ID);
            FillDT();
            return DT.Rows.Count == 0;
        }

        public bool SaveGroup(string Name)
        {
            NewCmd();
            Cmd.CommandText = @"insert into TblUserGroups (Name, InsertedDate, InsertedUser) values (@Name, @InsertedDate, @InsertedUser)";
            Cmd.Parameters.AddWithValue("@Name", Name);
            Cmd.Parameters.AddWithValue("@InsertedDate",DateTime.Now);
            Cmd.Parameters.AddWithValue("@InsertedUser",Program.UserID);
            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return false;
            }
            finally { Con.Close(); }

            CLog.AddLog("TblUserGroups", "Add New Group " + Name);
            return true;
        }

        public bool UpdateGroup(string Name, string ID)
        {
            NewCmd();
            Cmd.CommandText = "update TblUserGroups set Name = @Name, LUUser = @User, LUDate = @Date where ID = @ID";
            Cmd.Parameters.AddWithValue("@Name", Name);
            Cmd.Parameters.AddWithValue("@ID", ID);
            Cmd.Parameters.AddWithValue("@User", Program.UserID);
            Cmd.Parameters.AddWithValue("@Date", DateTime.Now);
            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return false;
            }
            finally { Con.Close(); }

            CLog.AddLog("TblUserGroups", "update group ID " + ID + " to name " + Name);
            return true;
        }

        public bool IsEmptyGroup(string ID)
        {
            NewCmd();
            Cmd.CommandText = "select * from TblUsers where UserGroupID = @ID";
            Cmd.Parameters.AddWithValue("@ID", ID);
            FillDT();
            return DT.Rows.Count == 0;
        }

        public bool DeleteGroup(string ID)
        {
            NewCmd();
            Cmd.CommandText = "delete from TblUserGroups where ID = @ID";
            Cmd.Parameters.AddWithValue("@ID", ID);
            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return false;
            }
            finally { Con.Close(); }

            CLog.AddLog("TblUserGroups", "Delete group ID " + ID);
            return true;
        }

    }
}
