using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.IO;
using System.Security.Cryptography;
using System.Management;
using System.Management.Instrumentation;

namespace PrimePOS
{
    class CDB
    {
        #region Definitions
        static SqlConnection Con = new SqlConnection();
        static SqlCommand Cmd = new SqlCommand();
        static SqlDataAdapter DA = new SqlDataAdapter();
        static DataTable DT = new DataTable();
        #endregion
        #region Security
        public static string SHA512(string Pass_word)
        {

            SHA512Managed SHA512 = new SHA512Managed();
            byte[] Hash = System.Text.Encoding.UTF8.GetBytes(Pass_word);
            Hash = SHA512.ComputeHash(Hash);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in Hash)
            {
                sb.Append(b.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
        public static bool AllowPermission(string Name, string GroupID , string PermissionID)
        {
            if (GroupID == "0")
            {
                return true;
            }
            NewCmd();
            Cmd.CommandText = "select * from [View-Sec-GroupPermission] where Form = @Name and GroupID = @GID and PermissionID = @PID and Active = 'True'";
            Cmd.Parameters.AddWithValue("@Name", Name);
            Cmd.Parameters.AddWithValue("@GID", GroupID);
            Cmd.Parameters.AddWithValue("@PID", PermissionID);
            FillDT();
            if (DT.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return bool.Parse(DT.Rows[0]["Allow"].ToString());
            }
        }
        //private static string GetHardSerial()
        //{
        //    ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

        //    foreach (ManagementObject wmi_HD in searcher.Get())
        //    {
        //        return wmi_HD["SerialNumber"].ToString();
        //    }
        //    return "";
        //}
        //public static DataTable GetCashier()
        //{
        //    string Serial = GetHardSerial();
        //    NewCmd();
        //    Cmd.CommandText = "select * from Cashier where PCSerial = @Serial";
        //    Cmd.Parameters.AddWithValue("@Serial", Serial);
        //    FillDT();
        //    return DT;
        //}
        //public static bool AddCashier(string Name)
        //{
        //    string Serial = GetHardSerial();
        //    NewCmd();
        //    Cmd.CommandText = "insert into Cashier (PCSerial, Name) values (@PCSerial, @Name)";
        //    Cmd.Parameters.AddWithValue("@PCSerial", Serial);
        //    Cmd.Parameters.AddWithValue("@Name", Name);
        //    try
        //    {
        //        Con.Open();
        //        Cmd.ExecuteNonQuery();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //    finally { Con.Close(); }
        //}
        public static void AddLog(string UserID,string CashierID, string FormName, string Action)
        {
            NewCmd();
            Cmd.CommandText = "insert into [Sec-Log] (Date, Time, UserID, CashierID, FormName, Action) values (@Date, @Time, @UserID, @CashierID, @FormName, @Action)";
            Cmd.Parameters.AddWithValue("@Date",DateTime.Now.ToShortDateString());
            Cmd.Parameters.AddWithValue("@Time",DateTime.Now.ToShortTimeString());
            Cmd.Parameters.AddWithValue("@UserID",UserID);
            Cmd.Parameters.AddWithValue("@CashierID", CashierID);
            Cmd.Parameters.AddWithValue("@FormName",FormName);
            Cmd.Parameters.AddWithValue("@Action",Action);

            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
            }
            catch (Exception)
            { }
            finally { Con.Close(); }
        }
        #endregion

        private static void NewCmd()
        {
            Con = new SqlConnection();
            Con.ConnectionString = CDataAccess.GetConStr();
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }
        private static void FillDT()
        {
            DA = new SqlDataAdapter(Cmd);
            DT = new DataTable();
            DA.Fill(DT);
        }

//        public static DataTable AllData(string TableName)
//        {
//            NewCmd();
//            Cmd.CommandText = "select * from " + TableName + " order by ID";
//            FillDT();
//            return DT;
//        }
//        public static bool Save (DataTable DT, string TableName)
//        {
//            if (DT.Rows.Count == 0)
//                {
//                    return false;
//                }
//            NewCmd();
//            int Row = DT.Rows.Count - 1;
//            string Parameters = "";
//            string Values = "";
//            for (int i = 0; i < DT.Columns.Count; i++)
//            {
//                if (DT.Columns[i].Caption.ToString() != "ID")
//                {
//                    Parameters = Parameters + " " + DT.Columns[i].Caption.ToString() + " ,";
//                    if (DT.Columns[i].Caption.ToString() == "UserID")
//                    {
//                        Values = Values + " '" + Program.UserID + "' ,";
//                    }
//                    else
//                    {
//                        if (DT.Columns[i].Caption.ToString() == "CashierID")
//                        {
//                            Values = Values + " '" + Program.CashierID + "' ,";
//                        }
//                        else
//                        {
//                            if (DT.Columns[i].Caption.ToString() == "IsertDate")
//                            {
//                                Values = Values + " '" + DateTime.Now.ToShortDateString() + "' ,";
//                            }
//                            else
//                            {
//                                if (DT.Columns[i].Caption.ToString() == "IsertTime")
//                                {
//                                    Values = Values + " '" + DateTime.Now.ToShortTimeString() + "' ,";
//                                }
//                                else
//                                {
//                                    Values = Values + " '" + DT.Rows[Row][i].ToString() + "' ,";
//                                }
//                            }
//                        }
//                    }
                    
//                }
//            }
//            Parameters = Parameters.Remove(Parameters.LastIndexOf(','));
//            Values = Values.Remove(Values.LastIndexOf(','));
//            Cmd.CommandText = "insert into " + TableName + " ( " + Parameters + " ) values ( " + Values + ")";
//            try
//            {
//                Con.Open();
//                Cmd.ExecuteNonQuery();
//                return true;
//            }
//            catch (Exception)
//            {
//                return false;
//            }
//            finally
//            {
//                Con.Close();
//            }
//        }
//        public static bool Update(DataTable DT, int Mark, string TableName)
//        {
//            if (DT.Rows.Count == 0)
//            {
//                return false;
//            }
//            NewCmd();
//            string Parameters = "";
//            string IDVal = "";
//            for (int i = 0; i < DT.Columns.Count; i++)
//            {
//                if (DT.Columns[i].Caption.ToString() == "ID")
//                {
//                    IDVal = DT.Rows[Mark][i].ToString();
//                }
//                else
//                {
//                    Parameters =Parameters + " " + DT.Columns[i].Caption.ToString() + " = '" + DT.Rows[Mark][i].ToString() + "' ,";
//                }
//            }
//            Parameters = Parameters.Remove(Parameters.LastIndexOf(','));
//            Cmd.CommandText = "update " + TableName + " set " + Parameters + " where ID = " + IDVal;
//            try
//            {
//                Con.Open();
//                Cmd.ExecuteNonQuery();
//                return true;
//            }
//            catch (Exception EX)
//            {
//                return false;
//            }
//            finally
//            {
//                Con.Close();
//            }
//        }
//        public static bool Delete(string TableName, string IDVal)
//        {
//            NewCmd();
//            Cmd.CommandText = "delete from " + TableName + " where ID = " + IDVal;
//            try
//            {
//                Con.Open();
//                Cmd.ExecuteNonQuery();
//                return true;
//            }
//            catch (Exception)
//            {
//                return false;
//            }
//            finally
//            {
//                Con.Close();
//            }
//        }

//        public static void FillComboBox(System.Windows.Forms.ComboBox cb, string TableName, string Display, string Val)
//        {
//            NewCmd();
//            Cmd.CommandText = "select " + Val + " , " + Display + " from " + TableName;
//            FillDT();

//            cb.DataSource = DT;
//            cb.DisplayMember = Display;
//            cb.ValueMember = Val;
//            cb.SelectedIndex = -1;

//        }
//        public static void FillLookUpEdit(LookUpEdit LU, string TableName, String Display, string Value)
//        {
//            NewCmd();
//            Cmd.CommandText = "select " + Display + " , " + Value + " from " + TableName;
//            FillDT();

//            LU.Properties.DataSource = DT;
//            LU.Properties.DisplayMember = Display;
//            LU.Properties.ValueMember = Value;
//            LU.Properties.SearchMode = SearchMode.AutoComplete;
//            LU.Properties.AutoSearchColumnIndex = 0;
//            LU.ItemIndex = 0;
//        }
//        public static void FillLookUpEdit(DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LU, string TableName, String Display, string Value)
//        {
//            NewCmd();
//            Cmd.CommandText = "select " + Display + " , " + Value + " from " + TableName;
//            FillDT();

//            LU.DataSource = DT;
//            LU.DisplayMember = Display;
//            LU.ValueMember = Value;
//            LU.SearchMode = SearchMode.AutoComplete;
//            LU.AutoSearchColumnIndex = 0;
//            //LU.ItemIndex = 0;
//        }
//        //public static void FillLookUpEdit(SearchLookUpEdit LU, string TableName, String Display, string Value)
//        //{
//        //    NewCmd();
//        //    Cmd.CommandText = "select " + Display + " , " + Value + " from " + TableName;
//        //    FillDT();

//        //    LU.Properties.DataSource = DT;
//        //    LU.Properties.DisplayMember = Display;
//        //    LU.Properties.ValueMember = Value;
//        //}
//        public static void FillLookUpEditOnCondition(LookUpEdit LU, string TableName, String Display, string Value, string Condition, string ConditionColumn)
//        {
//            NewCmd();
//            Cmd.CommandText = "select " + Display + " , " + Value + " from " + TableName + " where " + ConditionColumn + " = " + Condition;
//            FillDT();

//            LU.Properties.DataSource = DT;
//            LU.Properties.DisplayMember = Display;
//            LU.Properties.ValueMember = Value;
//            LU.Properties.SearchMode = SearchMode.AutoComplete;
//            LU.Properties.AutoSearchColumnIndex = 0;
//            LU.ItemIndex = 0;
//        }
//        //public static void FillLookUpEditOnCondition(SearchLookUpEdit LU, string TableName, String Display, string Value, string Condition, string ConditionColumn)
//        //{
//        //    NewCmd();
//        //    Cmd.CommandText = "select " + Display + " , " + Value + " from " + TableName + " where " + ConditionColumn + " = " + Condition;
//        //    FillDT();

//        //    LU.Properties.DataSource = DT;
//        //    LU.Properties.DisplayMember = Display;
//        //    LU.Properties.ValueMember = Value;
//        //}

//        public static bool CheckExistance(string Name, string TableName , string ColumnName)
//        {
//            NewCmd();
//            Cmd.CommandText = "select * from " + TableName + " where " + ColumnName + " = '" + Name + "'";
//            FillDT();
//            if (DT.Rows.Count == 0)
//            {
//                return false;
//            }
//            else
//            {
//                return true;
//            }
//        }
//        public static int SearchDT(DataTable DT, string SearchClmn, string Val, int Mark)
//        {
//            for (int i = Mark; i < DT.Rows.Count ; i++)
//            {
//                if (DT.Rows[i][SearchClmn].ToString().StartsWith(Val))
//                {
//                    return i;
//                }
//            }
//            for (int i = 0; i < Mark; i++)
//            {
//                if (DT.Rows[i][SearchClmn].ToString().StartsWith(Val))
//                {
//                    return i;
//                }
//            }
//            return -1;
//        }
//        public static bool UpdateSettings(DataTable DT)
//        {
//            if (DT.Rows.Count == 0)
//            {
//                return false;
//            }
//            NewCmd();
//            string Parameters = "";
//            for (int i = 0; i < DT.Columns.Count; i++)
//            {
//                Parameters = Parameters + " " + DT.Columns[i].Caption.ToString() + " = '" + DT.Rows[0][i].ToString() + "' ,";
//            }
//            Parameters = Parameters.Remove(Parameters.LastIndexOf(','));
//            Cmd.CommandText = "update [Settings] set " + Parameters;
//            try
//            {
//                Con.Open();
//                Cmd.ExecuteNonQuery();
//                return true;
//            }
//            catch (Exception EX)
//            {
//                return false;
//            }
//            finally
//            {
//                Con.Close();
//            }
//        }
//        public static string GetExpiry(DateTime Expiry)
//        {
//            DateTime DDTT = new DateTime(Expiry.Year, Expiry.Month, DateTime.DaysInMonth(Expiry.Year, Expiry.Month));
//            return DDTT.ToShortDateString();

//        }
//        public static void Backup_DB()
//        {
//            if (!(Directory.Exists("H:")))
//            {
//                //XtraMessageBox.Show("ادخل الفلاشة");
//            }
//            else
//            {
//                NewCmd();
//                string Path = "H:\\SZDB_Backup";
//                Path = Path + "\\" + DateTime.Now.ToShortDateString() + "-" + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString();
//                Cmd.CommandText = "BACKUP DATABASE @DB TO DISK = @Path";
//                Cmd.Parameters.AddWithValue("@DB", Con.Database);
//                Cmd.Parameters.AddWithValue("@Path", Path);
//                try
//                {
//                    Con.Open();
//                    Cmd.ExecuteNonQuery();
//                }
//                catch (Exception EX)
//                {
//                }
//                finally { Con.Close(); }
//            }

//            //NewCmd();
//            //Cmd.CommandText = "select * from Settings";
//            //FillDT();
//            //string Path = DT.Rows[0]["BackupFolder"].ToString();
//            //if (Path != "")
//            //{
                
//            //}
//        }
//        public static void DeleteOldBackup()
//        {
//            NewCmd();
//            Cmd.CommandText = "select * from Settings";
//            FillDT();
//            string Path = DT.Rows[0]["BackupFolder"].ToString();
//            string Days = DT.Rows[0]["BackupDays"].ToString();
//            if (Path != "" && Days != "")
//            {
//                TimeSpan TS = new TimeSpan(int.Parse(Days),0,0,0);
//                DateTime DDate = DateTime.Now.Date.Subtract(TS);
//                string[] Files = Directory.GetFiles(Path);
//                for (int i = 0; i < Files.Length; i++)
//                {
//                    if (File.GetCreationTime(Files[i].ToString()) < DDate)
//                    {
//                        File.Delete(Files[i].ToString());
//                    }
//                }
//            }
//        }
//        public static string ExpiryFromDate(DateTime Expiry)
//        {
//            DateTime EExpiry = new DateTime(Expiry.Year, Expiry.Month, DateTime.DaysInMonth(Expiry.Year, Expiry.Month));
//            return EExpiry.ToShortDateString();
//        }
//        public static string ExpiryFromDate(string Expiry)
//        {
//            if (Expiry == "")
//            {
//                return "";
//            }
//            DateTime DTExpiry = DateTime.Parse(Expiry);
//            DateTime EExpiry = new DateTime(DTExpiry.Year, DTExpiry.Month, DateTime.DaysInMonth(DTExpiry.Year, DTExpiry.Month));
//            return EExpiry.ToShortDateString();
//        }
//        public enum CashBalanece
//        {
//            AddBalance,SubtractBalance
//        }
//        public static string GetCashBalanceBeforeUpdate(string TableName, string ID, string Column)
//        {
//            NewCmd();
//            Cmd.CommandText = "select " + Column + " from " + TableName + " where ID = " + ID;
//            FillDT();
//            return DT.Rows[0][0].ToString();
//        }
//        private static void AddCashBalanceAccount(string AccountID)
//        {
//            NewCmd();
//            Cmd.CommandText = "insert into CashBalance (AccountID, Balance) values (@AccountID, @Balance)";
//            Cmd.Parameters.AddWithValue("@AccountID", AccountID);
//            Cmd.Parameters.AddWithValue("@Balance", "0");
//            try
//            {
//                Con.Open();
//                Cmd.ExecuteNonQuery();
//            }
//            catch (Exception)
//            {
//            }
//            finally
//            {
//                Con.Close();
//            }
//        }
//        public static void CashBalance(string Balance , CashBalanece State)
//        {
//            bool AccountByUser;
//            NewCmd();
//            Cmd.CommandText = "select * from [Settings]";
//            FillDT();
//            if (DT.Rows[0]["AccountByUser"].ToString() == "")
//            {
//                AccountByUser = false;
//            }
//            else
//            {
//                AccountByUser = bool.Parse(DT.Rows[0]["AccountByUser"].ToString());
//            }
//            NewCmd();
//            Cmd.CommandText = "select * from CashBalance where AccountID = @ID";
//            string AccountID;
//            if (AccountByUser)
//            {
//                Cmd.Parameters.AddWithValue("@ID", Program.UserID);
//                AccountID = Program.UserID;
//            }
//            else
//            {
//                Cmd.Parameters.AddWithValue("@ID", Program.CashierID);
//                AccountID = Program.CashierID;
//            }
//            FillDT();
//            double CurrentCash = 0;
//            if (DT.Rows.Count >0)
//            {
//                CurrentCash = double.Parse(DT.Rows[0]["Balance"].ToString());
//            }
//            else
//            {
//                AddCashBalanceAccount(AccountID);
//            }
//            if (State.ToString() == "AddBalance")
//            {
//                CurrentCash = CurrentCash + double.Parse(Balance);
//            }
//            else
//            {
//                CurrentCash = CurrentCash - double.Parse(Balance);
//            }
//            NewCmd();
//            Cmd.CommandText = "update CashBalance set Balance = @Balance where AccountID = @ID";
//            Cmd.Parameters.AddWithValue("@ID", AccountID);
//            Cmd.Parameters.AddWithValue("@Balance", CurrentCash.ToString());
//            try
//            {
//                Con.Open();
//                Cmd.ExecuteNonQuery();
//            }
//            catch (Exception)
//            {
//            }
//            finally { Con.Close(); }
//        }


//        public static object ExecuteSP(string Name, List<SqlParameter> List)
//        {
//            NewCmd();
//            Cmd.CommandType = CommandType.StoredProcedure;
//            Cmd.CommandText = Name;
//            if (List != null)
//            {
//                foreach (SqlParameter Param in List)
//                {
//                    Cmd.Parameters.AddWithValue(Param.ParameterName, Param.Value);
//                }
//            }
//            using (Con)
//            {
//                Con.Open();
//                return Cmd.ExecuteScalar();
//            }
//        }

//        public static DataTable ExecuteSql(string sql)
//        {
//            NewCmd();
//            Cmd.CommandText = sql;
//            FillDT();
//            return DT;
//        }

//        public static DataTable GetStatistics(string DateFrom, string DateTo, string MandobID)
//        {
//            NewCmd();
//            Cmd.CommandType = CommandType.StoredProcedure;
//            if (MandobID == "-1")
//            {
//                Cmd.CommandText = "spGetStatisticsAll";
//            }
//            else
//            {
//                Cmd.CommandText = "spGetStatisticsByMandob";
//                Cmd.Parameters.AddWithValue("@MandobID", MandobID);
//            }
//            Cmd.Parameters.AddWithValue("@DateFrom", DateFrom);
//            Cmd.Parameters.AddWithValue("@DateTo", DateTo);
//            FillDT();
//            return DT;
//        }

//        public static void Prices()
//        {
//            NewCmd();
//            Cmd.CommandText = "select * from Sales where Date = '2018-12-01'";
//            FillDT();
//            DataTable DTPrices = new DataTable();
//            string O2="", AST="", Argon="", CO2="", Nitroz="", Mix="", Other="", N2="";
//            foreach (DataRow DR in DT.Rows)
//            {
//                NewCmd();
//                Cmd.CommandText = "select * from CustomerItems where CustID = " + DR["CustID"].ToString() + " order by ItemID";
//                DTPrices = new DataTable();
//                DA = new SqlDataAdapter(Cmd);
//                DA.Fill(DTPrices);

//                foreach (DataRow DRPrices in DTPrices.Rows)
//                {
//                    switch (DRPrices["ItemID"].ToString())
//                    {
//                        case "1":
//                            O2 = DRPrices["Price"].ToString();
//                            break;
//                        case "2":
//                            AST = DRPrices["Price"].ToString();
//                            break;
//                        case "3":
//                            Argon = DRPrices["Price"].ToString();
//                            break;
//                        case "4":
//                            N2 = DRPrices["Price"].ToString();
//                            break;
//                        case "5":
//                            CO2 = DRPrices["Price"].ToString();
//                            break;
//                        case "6":
//                            Nitroz = DRPrices["Price"].ToString();
//                            break;
//                        case "7":
//                            Mix = DRPrices["Price"].ToString();
//                            break;
//                        case "8":
//                            Other = DRPrices["Price"].ToString();
//                            break;
//                        default:
//                            break;
//                    }
//                }

//                NewCmd();
//                Cmd.CommandText = @"update Sales set [O2-Price] = @O2, [AST-Price] = @AST, [Argon-Price] = @Argon, [N2-Price] = @N2, 
//                [CO2-Price] = @CO2, [Nitroz-Price] = @Nitroz, [Mix-Price] = @Mix, [Other-Price] = @Other where ID = @ID";
//                Cmd.Parameters.AddWithValue("@O2",O2);
//                Cmd.Parameters.AddWithValue("@AST",AST);
//                Cmd.Parameters.AddWithValue("@Argon",Argon);
//                Cmd.Parameters.AddWithValue("@N2",N2);
//                Cmd.Parameters.AddWithValue("@CO2",CO2);
//                Cmd.Parameters.AddWithValue("@Nitroz",Nitroz);
//                Cmd.Parameters.AddWithValue("@Mix",Mix);
//                Cmd.Parameters.AddWithValue("@Other",Other);
//                Cmd.Parameters.AddWithValue("@ID",DR["ID"].ToString());
//                Con.Open();
//                Cmd.ExecuteNonQuery();
//                Con.Close();
//            }
//        }

//        public static DataTable GetNotUpdatedPrices(string Date, string Mandob)
//        {
//            NewCmd();
//            if (Mandob == "")
//            {
//                Cmd.CommandText = "select * from ViewRptPricesNotUpdated where LUDate < @Date and ItemID in (1,2) and CONVERT(float, Price) > 0 order by Mandob,CustID";
//            }
//            else
//            {
//                Cmd.CommandText = "select * from ViewRptPricesNotUpdated where LUDate < @Date and ItemID in (1,2) and CONVERT(float, Price) > 0 and MandobID = @Mandob order by Mandob,CustID";
//                Cmd.Parameters.AddWithValue("@Mandob", Mandob);
//            }
            
//            Cmd.Parameters.AddWithValue("@Date", Date);
//            FillDT();
//            return DT;
//        }

//        public static string GetLastCustomerTransactionDate(string CustID)
//        {
//            NewCmd();
//            Cmd.CommandText = "select MAX(Date) from CustomerLog where CustID = @ID";
//            Cmd.Parameters.AddWithValue("@ID", CustID);
//            FillDT();
//            if (DT.Rows.Count != 0 && DT.Rows[0][0].ToString() != "")
//            {
//                return DT.Rows[0][0].ToString();
//            }
//            else
//            {
//                return "1900-01-01";
//            }
//        }

//        public static DataTable GetCurrentAccounts(string MandobID)
//        {
//            NewCmd();
//            Cmd.CommandText = "select * from ViewAccounts where MandobID = @ID and Sum >= 5";
//            Cmd.Parameters.AddWithValue("@ID", MandobID);

//            FillDT();

//            return DT;
//        }

//        public static string GetCustomerAccountAtDate(string Date, string CustID)
//        {
//            NewCmd();
//            Cmd.CommandText = "select * from CustomerLog where CustID = @ID and Date <= @Date order by Date , SalesID";
//            Cmd.Parameters.AddWithValue("@ID", CustID);
//            Cmd.Parameters.AddWithValue("@Date", Date);
//            FillDT();
//            if (DT.Rows.Count == 0)
//            {
//                return "0";
//            }
//            else
//            {
//                return DT.Rows[DT.Rows.Count - 1]["Sum"].ToString();
//            }
//        }

//        public static string GetCustomerO2CountFromDateTillToday(string Date, string CustID)
//        {
//            NewCmd();
//            Cmd.CommandText = "select sum(O2) from Sales where Date >= @Date and CustID = @ID";
//            Cmd.Parameters.AddWithValue("@Date", Date);
//            Cmd.Parameters.AddWithValue("@ID", CustID);
//            FillDT();

//            if (DT.Rows[0][0].ToString() == "")
//            {
//                return "0";
//            }
//            else
//            {
//                return DT.Rows[0][0].ToString();
//            }
//        }

//        public static string GetCustomerASTCountFromDateTillToday(string Date, string CustID)
//        {
//            NewCmd();
//            Cmd.CommandText = "select sum(AST) from Sales where Date >= @Date and CustID = @ID";
//            Cmd.Parameters.AddWithValue("@Date", Date);
//            Cmd.Parameters.AddWithValue("@ID", CustID);
//            FillDT();

//            if (DT.Rows[0][0].ToString() == "")
//            {
//                return "0";
//            }
//            else
//            {
//                return DT.Rows[0][0].ToString();
//            }
//        }

//        public static string GetCustomerOtherCountFromDateTillToday(string Date, string CustID)
//        {
//            NewCmd();
//            Cmd.CommandText = "select sum(Argon + N2 + CO2 + Nitroz + Mix + Other) from Sales where Date >= @Date and CustID = @ID";
//            Cmd.Parameters.AddWithValue("@Date", Date);
//            Cmd.Parameters.AddWithValue("@ID", CustID);
//            FillDT();

//            if (DT.Rows[0][0].ToString() == "")
//            {
//                return "0";
//            }
//            else
//            {
//                return DT.Rows[0][0].ToString();
//            }
//        }

//        public static string GetCustomerO2TotalPriceFromDateTillToday(string Date, string CustID)
//        {
//            NewCmd();
//            Cmd.CommandText = "select sum(O2 * [O2-Price]) from Sales where Date >= @Date and CustID = @ID";
//            Cmd.Parameters.AddWithValue("@Date", Date);
//            Cmd.Parameters.AddWithValue("@ID", CustID);
//            FillDT();
//            if (DT.Rows[0][0].ToString() == "")
//            {
//                return "0";
//            }
//            else
//            {
//                return DT.Rows[0][0].ToString();
//            }

            
//        }

//        public static string GetCustomerASTTotalPriceFromDateTillToday(string Date, string CustID)
//        {
//            NewCmd();
//            Cmd.CommandText = "select sum(AST * [AST-Price]) from Sales where Date >= @Date and CustID = @ID";
//            Cmd.Parameters.AddWithValue("@Date", Date);
//            Cmd.Parameters.AddWithValue("@ID", CustID);
//            FillDT();

//            if (DT.Rows[0][0].ToString() == "")
//            {
//                return "0";
//            }
//            else
//            {
//                return DT.Rows[0][0].ToString();
//            }
//        }

//        public static string GetCustomerOtherTotalPriceFromDateTillToday(string Date, string CustID)
//        {
//            NewCmd();
//            Cmd.CommandText = "select sum((Argon * [Argon-Price]) + (N2 * [N2-Price]) + (CO2 * [CO2-Price]) + (Nitroz * [Nitroz-Price]) + (Mix * [Mix-Price]) + (Other * [Other-Price])) from Sales where Date >= @Date and CustID = @ID";
//            Cmd.Parameters.AddWithValue("@Date", Date);
//            Cmd.Parameters.AddWithValue("@ID", CustID);
//            FillDT();

//            if (DT.Rows[0][0].ToString() == "")
//            {
//                return "0";
//            }
//            else
//            {
//                return DT.Rows[0][0].ToString();
//            }
//        }

//        public static string GetCustomerTotalPaymentsFromDateTillToday(string Date, string CustID)
//        {
//            NewCmd();
//            Cmd.CommandText = "select SUM(CONVERT(float,Paid)) from Sales where Date >= @Date and CustID = @ID";
//            Cmd.Parameters.AddWithValue("@Date", Date);
//            Cmd.Parameters.AddWithValue("@ID", CustID);
//            FillDT();

//            if (DT.Rows[0][0].ToString() == "")
//            {
//                return "0";
//            }
//            else
//            {
//                return DT.Rows[0][0].ToString();
//            }
//        }

//        public static DataTable GetReportCustomerAccountData(string CustID, string Date)
//        {
//            NewCmd();
//            if (Date == "")
//            {
//                Cmd.CommandText = "select * from ViewCustomerLog where CustID = @ID order by Date, SalesID";
//            }
//            else
//            {
//                Cmd.CommandText = "select * from ViewCustomerLog where CustID = @ID and Date >= @Date order by Date, SalesID";
//                Cmd.Parameters.AddWithValue("@Date", Date);
//            }
//            Cmd.Parameters.AddWithValue("@ID", CustID);
//            FillDT();
//            return DT;
//        }

//        public static string GetLastAccountBe4Date(string CustID, string Date)
//        {
//            NewCmd();
//            if (Date == "")
//            {
//                Cmd.CommandText = "select * from ViewCustomerLog where CustID = @ID and Date = (select max(Date) from ViewCustomerLog where CustID = @ID) order by SalesID";
//            }
//            else
//            {
//                Cmd.CommandText = "select * from ViewCustomerLog where CustID = @ID and Date = (select max(Date) from ViewCustomerLog where Date < @Date and CustID = @ID) order by SalesID";
//                Cmd.Parameters.AddWithValue("@Date", Date);
//            }

//            Cmd.Parameters.AddWithValue("@ID", CustID);

//            FillDT();
//            if (DT.Rows.Count == 0)
//            {
//                return "0";
//            }
//            else
//            {
//                return DT.Rows[DT.Rows.Count - 1]["Sum"].ToString();
//            }
//        }

//        public static bool SaveAccountsRevision(string Date, string MandobID, DataTable DTRevision)
//        {
//            foreach (DataRow DRRevision in DTRevision.Rows)
//            {
//                NewCmd();
//                Cmd.CommandText = @"insert into AccountsRevision (CustID, Name, StartAccount, O2Count, O2Price, ASTCount, 
//                        ASTPrice, OtherCount, OtherPrice, Paid, CurrentAccount, Comment, TotalPrice, Date, MandobID) 
//                        values (@CustID, @Name, @StartAccount, @O2Count, @O2Price, @ASTCount, 
//                        @ASTPrice, @OtherCount, @OtherPrice, @Paid, @CurrentAccount, @Comment, @TotalPrice, @Date, @MandobID)";
//                Cmd.Parameters.AddWithValue("@CustID",DRRevision["CustID"].ToString());
//                Cmd.Parameters.AddWithValue("@Name",DRRevision["Name"].ToString());
//                Cmd.Parameters.AddWithValue("@StartAccount",DRRevision["Start"].ToString());
//                Cmd.Parameters.AddWithValue("@O2Count",DRRevision["O2"].ToString());
//                Cmd.Parameters.AddWithValue("@O2Price",DRRevision["O2Price"].ToString());
//                Cmd.Parameters.AddWithValue("@ASTCount",DRRevision["AST"].ToString());
//                Cmd.Parameters.AddWithValue("@ASTPrice",DRRevision["ASTPrice"].ToString());
//                Cmd.Parameters.AddWithValue("@OtherCount",DRRevision["Other"].ToString());
//                Cmd.Parameters.AddWithValue("@OtherPrice",DRRevision["OtherPrice"].ToString());
//                Cmd.Parameters.AddWithValue("@Paid",DRRevision["Paid"].ToString());
//                Cmd.Parameters.AddWithValue("@CurrentAccount",DRRevision["Current"].ToString());
//                Cmd.Parameters.AddWithValue("@Comment",DRRevision["Comment"].ToString());
//                Cmd.Parameters.AddWithValue("@TotalPrice",DRRevision["Total"].ToString());
//                Cmd.Parameters.AddWithValue("@Date",Date);
//                Cmd.Parameters.AddWithValue("@MandobID",MandobID);
//                try
//                {
//                    Con.Open();
//                    Cmd.ExecuteNonQuery();

//                }
//                catch (Exception)
//                {
//                    return false;
//                }
//                finally { Con.Close(); }
//            }
//            return true;
//        }

//        public static DataTable GetAccountsRevisions(string Date, string MandobID)
//        {
//            NewCmd();
//            if (Date != "" && MandobID != "")
//            {
//                Cmd.CommandText = "select distinct Mandob, [Date] from ViewAccountsRevision where Date = @Date and MandobID = @ID";
//                Cmd.Parameters.AddWithValue("@Date", Date);
//                Cmd.Parameters.AddWithValue("@ID", MandobID);
//            }
//            else
//            {
//                if (Date != "")
//                {
//                    Cmd.CommandText = "select distinct Mandob, [Date] from ViewAccountsRevision where Date = @Date";
//                    Cmd.Parameters.AddWithValue("@Date", Date);
//                }
//                if (MandobID != "")
//                {
//                    Cmd.CommandText = "select distinct Mandob, [Date] from ViewAccountsRevision where MandobID = @ID order by Date";
//                    Cmd.Parameters.AddWithValue("@ID", MandobID);
//                }
//            }
//            FillDT();
//            return DT;
//        }

//        public static DataTable GetSelectedAccountsRevision(string Mandob, string Date)
//        {
//            NewCmd();
//            Cmd.CommandText = "select * from ViewAccountsRevision where Date = @Date and Mandob = @Mandob";
//            Cmd.Parameters.AddWithValue("@Date", Date);
//            Cmd.Parameters.AddWithValue("@Mandob", Mandob);
//            FillDT();
//            return DT;
//        }

//        public static DataTable GetAllCustomersWithRaseedForMandob(string MandobID)
//        {
//            NewCmd();
//            Cmd.CommandText = @"select * from ViewAccounts where MandobID = @ID and (O2 > 0 or AST > 0 or Argon > 0 or N2 > 0 or CO2 > 0 or Nitroz > 0 or 
//                                Mix > 0 or Other > 0)";
//            Cmd.Parameters.AddWithValue("@ID", MandobID);
//            FillDT();
//            return DT;
//        }

//        public static string GetCustomerLastTransactionDate(string CustID)
//        {
//            NewCmd();
//            Cmd.CommandText = "select max(Date) from Sales where CustID = @ID";
//            Cmd.Parameters.AddWithValue("@ID", CustID);
//            FillDT();
//            if (DT.Rows.Count == 0)
//            {
//                return "";
//            }
//            else
//            {
//                return DT.Rows[0][0].ToString();
//            }
//        }

//        public static void SaveLazyCustomers(string MandobID, DataTable DTLazy)
//        {
//            foreach (DataRow DR in DTLazy.Rows)
//            {
//                NewCmd();
//                Cmd.CommandText = @"insert into LazyCustomers (CustID, Name, Raseed, LastTransactionDate, Comment, MandobID, Date) values 
//                                    (@CustID, @Name, @Raseed, @LastTransactionDate, @Comment, @MandobID, @Date)";
//                Cmd.Parameters.AddWithValue("@CustID",DR["CustID"].ToString());
//                Cmd.Parameters.AddWithValue("@Name",DR["Name"].ToString());
//                Cmd.Parameters.AddWithValue("@Raseed",DR["Raseed"].ToString());
//                Cmd.Parameters.AddWithValue("@LastTransactionDate",DR["LastTransactionDate"].ToString());
//                Cmd.Parameters.AddWithValue("@Comment",DR["Comment"].ToString());
//                Cmd.Parameters.AddWithValue("@MandobID",MandobID);
//                Cmd.Parameters.AddWithValue("@Date",DateTime.Now.ToShortDateString());
//                try
//                {
//                    Con.Open();
//                    Cmd.ExecuteNonQuery();
//                }
//                catch (Exception)
//                {
//                }
//                finally { Con.Close(); }
//            }
//        }

//        public static bool CheckIfGoodsAllowed()
//        {
//            NewCmd();
//            Cmd.CommandText = "select * from Settings";
//            FillDT();
//            if (DT.Rows[0]["AllowGoods"].ToString() == "True")
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }






















    }
}
