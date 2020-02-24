using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PrimePOS
{
    class CSecurity
    {
        #region Definitions
        DataTable DTSecurity = new DataTable();
        #endregion

        public CSecurity(string FormName)
        {
            DTSecurity = Security.CSecurity.GetFormSecurity(FormName);
        }

        public bool AllowSave()
        {
            if (Program.UserID == 0)
            {
                return true;
            }
            if (DTSecurity.Rows.Count == 0)
            {
                return false;
            }

            return bool.Parse(DTSecurity.Rows[0]["AllowSave"].ToString());
        }
        public bool AllowEdit()
        {
            if (Program.UserID == 0)
            {
                return true;
            }
            if (DTSecurity.Rows.Count == 0)
            {
                return false;
            }

            return bool.Parse(DTSecurity.Rows[0]["AllowEdit"].ToString());
        }
        public bool AllowDelete()
        {
            if (Program.UserID == 0)
            {
                return true;
            }
            if (DTSecurity.Rows.Count == 0)
            {
                return false;
            }

            return bool.Parse(DTSecurity.Rows[0]["AllowDelete"].ToString());
        }
    }
}
