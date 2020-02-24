using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace PrimePOS.Items
{
    class Cunits
    {
        #region Definitions
        SqlConnection Con = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        SqlDataAdapter DA = new SqlDataAdapter();
        DataTable DT = new DataTable();
        #endregion
        public Cunits()
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

        public DataTable GetAllUnits()
        {
            NewCmd();
            Cmd.CommandText = "select * from TblItemUnits";
            FillDT();
            return DT;
        }

        public bool CheckNew(string Name)
        {
            NewCmd();
            Cmd.CommandText = "select * from TblItemUnits where Name = @Name";
            Cmd.Parameters.AddWithValue("@Name", Name);
            FillDT();
            return DT.Rows.Count == 0;
        }

        public bool CheckUpdate(string Name, string ID)
        {
            NewCmd();
            Cmd.CommandText = "select * from TblItemUnits where Name = @Name and ID != @ID";
            Cmd.Parameters.AddWithValue("@Name", Name);
            Cmd.Parameters.AddWithValue("@ID", ID);
            FillDT();
            return DT.Rows.Count == 0;
        }

        public bool SaveUnit(string Name)
        {
            NewCmd();
            Cmd.CommandText = @"insert into TblItemUnits (Name, InsertedDate, InsertedUser) values (@Name, @InsertedDate, @InsertedUser)";
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

            CLog.AddLog("TblItemUnits", "Add New Unit " + Name);
            return true;
        }

        public bool UpdateGroup(string Name, string ID)
        {
            NewCmd();
            Cmd.CommandText = "update TblItemUnits set Name = @Name, LUUser = @User, LUDate = @Date where ID = @ID";
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

            CLog.AddLog("TblItemUnits", "update Unit ID " + ID + " to name " + Name);
            return true;
        }

        public bool IsEmptyUnit(string ID)
        {
            NewCmd();
            Cmd.CommandText = "select * from TblItems where SmallUnitID = @ID or BigUnitID = @ID";
            Cmd.Parameters.AddWithValue("@ID", ID);
            FillDT();
            return DT.Rows.Count == 0;
        }

        public bool DeleteUnit(string ID)
        {
            NewCmd();
            Cmd.CommandText = "delete from TblItemUnits where ID = @ID";
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

            CLog.AddLog("TblItemUnits", "Delete Unit ID " + ID);
            return true;
        }
    }
}
