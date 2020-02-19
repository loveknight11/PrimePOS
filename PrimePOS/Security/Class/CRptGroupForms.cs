using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PrimePOS.Security
{
    class CRptGroupForms
    {
        #region Definitions
        SqlConnection Con = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        SqlDataAdapter DA = new SqlDataAdapter();
        DataTable DT = new DataTable();
        #endregion
        public CRptGroupForms()
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

        public DataTable GetRptData(string GroupID)
        {
            NewCmd();
            Cmd.CommandText = "select * from ViewUserGroupForms where UserGroupID = @ID order by ModuleID";
            Cmd.Parameters.AddWithValue("@ID",GroupID);
            FillDT();
            return DT;
        }
    }
}
