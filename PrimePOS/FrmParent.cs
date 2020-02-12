using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PrimePOS
{
    public partial class FrmParent : DevExpress.XtraEditors.XtraForm
    {
        #region Definitions
        private DataTable DTSecurity = new DataTable();
        #endregion
        #region Methods
        private bool AllowSave()
        {
            if (DTSecurity.Rows.Count == 0)
            {
                return false;
            }

            return bool.Parse(DTSecurity.Rows[0]["AllowSave"].ToString());
        }
        #endregion
        public FrmParent()
        {
            InitializeComponent();
        }

        private void FrmParent_Load(object sender, EventArgs e)
        {
            DTSecurity = Security.CSecurity.GetFormSecurity(this.Name);
        }
    }
}