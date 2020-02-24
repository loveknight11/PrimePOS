using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PrimePOS
{
    class CNavigation
    {
        #region Definitions
        DataTable DT = new DataTable();

        #endregion

        public CNavigation(DataTable DTable)
        {
            DT = DTable;
        }

        public int ShowFirst()
        {
            if (DT.Rows.Count != 0)
            {
                return 0;
            }
            else
            {
                return Int16.MinValue;
            }
        }
        public int ShowNext(int Mark)
        {
            if (Mark + 1 <= DT.Rows.Count - 1)
            {
                return Mark+1;
            }
            else
            {
                return Mark;
            }
        }
        public int ShowPrevious(int Mark)
        {
            if (Mark != 0)
            {
                return Mark-1;
            }
            else
            {
                return Mark;
            }
        }
        public int ShowLast()
        {
            if (DT.Rows.Count == 0)
            {
                return Int16.MinValue;
            }
            return DT.Rows.Count - 1;
        }

        public void RefreshDataTable(DataTable DTable)
        {
            DT = DTable;
        }
    }
}
