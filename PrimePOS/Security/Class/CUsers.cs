using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace PrimePOS.Security
{
    class CUsers
    {
        #region Definitions
        SqlConnection Con = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        SqlDataAdapter DA = new SqlDataAdapter();
        DataTable DT = new DataTable();
        #endregion
        public CUsers()
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

        public DataTable GetAllUsers()
        {
            NewCmd();
            Cmd.CommandText = "select * from TblUsers";
            FillDT();
            return DT;
        }

        public bool CheckNew(string UserName)
        {
            NewCmd();
            Cmd.CommandText = "select * from TblUsers where UserName = @Name";
            Cmd.Parameters.AddWithValue("@Name", UserName);
            FillDT();
            return DT.Rows.Count == 0;
        }

        public bool CheckUpdate(string UserName, string ID)
        {
            NewCmd();
            Cmd.CommandText = "select * from TblUsers where UserName = @Name and ID != @ID";
            Cmd.Parameters.AddWithValue("@Name", UserName);
            Cmd.Parameters.AddWithValue("@ID", ID);
            FillDT();
            return DT.Rows.Count == 0;
        }

        public bool SaveUser(string Name, string UserName, string Password, string GroupID)
        {
            Password = CDB.SHA512(Password);
            NewCmd();
            Cmd.CommandText = @"insert into TblUsers (Name, UserName, Password, UserGroupID, InsertedDate, InsertedUser) 
                              values (@Name, @UserName, @Password, @UserGroupID, @InsertedDate, @InsertedUser)";
            Cmd.Parameters.AddWithValue("@Name", Name);
            Cmd.Parameters.AddWithValue("@UserName", UserName);
            Cmd.Parameters.AddWithValue("@Password", Password);
            Cmd.Parameters.AddWithValue("@UserGroupID", GroupID);
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

            CLog.AddLog("TblUsers", "Add New User " + Name + " Username " + UserName + " Group ID " + GroupID);
            return true;
        }

        public bool UpdateUser(string Name, string UserName, string GroupID, string ID)
        {
            NewCmd();
            Cmd.CommandText = "update TblUsers set Name = @Name, LUUser = @User, LUDate = @Date, UserGroupID = @UserGroupID where ID = @ID";
            Cmd.Parameters.AddWithValue("@Name", Name);
            Cmd.Parameters.AddWithValue("@UserName", UserName);
            Cmd.Parameters.AddWithValue("@UsergroupID", GroupID);
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

            CLog.AddLog("TblUsers", "update User ID " + ID + " to name " + Name + " and UserName to " + UserName + " and Group ID to " + GroupID);
            return true;
        }

        public bool DisableUser(string ID)
        {
            NewCmd();
            Cmd.CommandText = "update TblUsers set AllowLogin = 0 where ID = @ID";
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

            CLog.AddLog("TblUsers", "Disable User ID " + ID);
            return true;
        }

        public bool EnableUser(string ID)
        {
            NewCmd();
            Cmd.CommandText = "update TblUsers set AllowLogin = 1 where ID = @ID";
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

            CLog.AddLog("TblUsers", "Enable User ID " + ID);
            return true;
        }

        public bool ResetPassword(string ID, string OldPassword, string NewPassword)
        {
            OldPassword = CDB.SHA512(OldPassword);
            NewPassword = CDB.SHA512(NewPassword);
            NewCmd();
            Cmd.CommandText = "update TblUsers set Password = @NewPassword where ID = @ID and Password = @OldPassword";
            Cmd.Parameters.AddWithValue("@NewPassword", NewPassword);
            Cmd.Parameters.AddWithValue("@ID", ID);
            Cmd.Parameters.AddWithValue("@OldPassword", OldPassword);

            int Update;
            try
            {
                Con.Open();
                Update = Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return false;
            }
            finally { Con.Close(); }

            return Update == 1;
        }

        
    }
}
