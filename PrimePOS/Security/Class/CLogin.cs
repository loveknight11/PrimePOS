using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PrimePOS.Security
{
    class CLogin
    {
        #region Definitions
        SqlConnection Con = new SqlConnection();
        SqlDataAdapter DA = new SqlDataAdapter();
        SqlCommand Cmd = new SqlCommand();
        DataTable DT = new DataTable();
        #endregion

        public CLogin()
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

        public DataTable Login(string UserName, string Password)
        {
            NewCmd();
            Cmd.CommandText = "select * from TblUsers where UserName = @Name and Password = @Password";
            Cmd.Parameters.AddWithValue("@Name", UserName);
            Cmd.Parameters.AddWithValue("@Password", CDB.SHA512(Password));
            //Cmd.Parameters.AddWithValue("@Password", Password);
            FillDT();
            return DT;
        }
        public void SaveLogin(string UserID)
        {
            NewCmd();
            Cmd.CommandText = "insert into LogIn (Date , UserID) values (@Date , @ID)";
            Cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToShortDateString());
            Cmd.Parameters.AddWithValue("@ID", UserID);
            Con.Open();
            Cmd.ExecuteNonQuery();
            Con.Close();
        }
        public bool CheckValidity()
        {
            NewCmd();
            Cmd.CommandText = "select * from Settings";
            FillDT();
            if (DT.Rows[0]["Disable"].ToString() == "True")
            {
                return false;
            }
            NewCmd();
            Cmd.CommandText = "select * from LogIn where Date >= @Date and UserID = 0";
            TimeSpan TS = new TimeSpan(7, 0, 0, 0);
            DateTime DDate = DateTime.Now.Subtract(TS);
            Cmd.Parameters.AddWithValue("@Date", DDate.ToShortDateString());
            FillDT();
            if (DT.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public void DisableProgram(int Val)
        {
            NewCmd();
            Cmd.CommandText = "update Settings set Disable = @Val";
            Cmd.Parameters.AddWithValue("@Val", Val);
            Con.Open();
            Cmd.ExecuteNonQuery();
            Con.Close();
        }
    }
}
