using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PrimePOS.Security
{
    class CSecurity
    {
        #region Definitions
        static SqlConnection Con = new SqlConnection();
        static SqlCommand Cmd = new SqlCommand();
        static SqlDataAdapter DA = new SqlDataAdapter();
        static DataTable DT = new DataTable();
        #endregion

        private static void NewCmd()
        {
            Cmd = new SqlCommand();
            Con.ConnectionString = CDataAccess.GetConStr();
            Cmd.Connection = Con;
        }
        private static void FillDT()
        {
            DA = new SqlDataAdapter(Cmd);
            DT = new DataTable();
            DA.Fill(DT);
        }

        public static DataTable GetFormSecurity(string FormName)
        {
            NewCmd();
            Cmd.CommandText = "select * from ViewUserGroupForms where FormName = @FormName and UserGroupID = @GroupID";
            Cmd.Parameters.AddWithValue("@FormName", FormName);
            Cmd.Parameters.AddWithValue("@GroupID", Program.GroupID);
            FillDT();
            return DT;
        }

        public static DataTable GetAllowedForms()
        {
            NewCmd();
            Cmd.CommandText = "select * from ViewUserGroupForms where UserGroupID = @GroupID and AllowOpen = @Allow";
            Cmd.Parameters.AddWithValue("@GroupID", Program.GroupID);
            Cmd.Parameters.AddWithValue("@Allow", true);
            FillDT();
            return DT;
        }
    }
}
