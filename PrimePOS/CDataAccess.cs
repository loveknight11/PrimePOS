using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace PrimePOS
{
    class CDataAccess
    {

        public static string GetConStr()
        {
            SqlConnectionStringBuilder SqlStr = new SqlConnectionStringBuilder();
            DataSet ds = new DataSet();
            ds.ReadXml("CS.xml");
            if(ds.Tables.Count != 0)
            {
                if (ds.Tables[0].Rows.Count != 0)
                {
                    if (ds.Tables[0].Rows[0]["DataSource"].ToString() != "")
                    {
                        if (ds.Tables[0].Rows[0]["DataBaseName"].ToString() != "")
                        {
                                SqlStr.DataSource = ds.Tables[0].Rows[0]["DataSource"].ToString();
                                SqlStr.InitialCatalog = ds.Tables[0].Rows[0]["DataBaseName"].ToString();

                            if (ds.Tables[0].Rows[0]["Security"].ToString() != "")
                            {

                                SqlStr.IntegratedSecurity = Convert.ToBoolean(ds.Tables[0].Rows[0]["Security"].ToString());
                            }
                            else
                            {

                            }

                        } 
                    }
                }
            }
           
          

            return SqlStr.ToString();


        }
    }
}