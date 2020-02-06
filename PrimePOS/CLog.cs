using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PrimePOS
{
    class CLog
    {
        public static void AddLog(string Table, string Message)
        {
            SqlConnection Con = new SqlConnection(CDataAccess.GetConStr());
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;

            Cmd.CommandText = "insert into TblLog (Date, Message, Tbl, UserID) values (@Date, @Message, @Tbl, @UserID)";
            Cmd.Parameters.AddWithValue("@Date", DateTime.Now);
            Cmd.Parameters.AddWithValue("@Message", Message);
            Cmd.Parameters.AddWithValue("@Tbl", Table);
            Cmd.Parameters.AddWithValue("@UserID", Program.UserID);

            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally { Con.Close(); }
        }
    }
}
