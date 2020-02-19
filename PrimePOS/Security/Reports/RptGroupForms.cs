using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace PrimePOS.Security
{
    public partial class RptGroupForms : PrimePOS.RptParent
    {
        public RptGroupForms()
        {
            InitializeComponent();
        }

        private void TblOpen_TextChanged(object sender, EventArgs e)
        {
            if (TblOpen.Text == "False")
            {
                TblOpen.Text = "غير مسموح";
            }
            else if (TblOpen.Text == "True")
            {
                TblOpen.Text = "مسموح";
            }
        }

        private void TblSave_TextChanged(object sender, EventArgs e)
        {
            if (TblSave.Text == "False")
            {
                TblSave.Text = "غير مسموح";
            }
            else if (TblSave.Text == "True")
            {
                TblSave.Text = "مسموح";
            }
        }

        private void TblEdit_TextChanged(object sender, EventArgs e)
        {
            if (TblEdit.Text == "False")
            {
                TblEdit.Text = "غير مسموح";
            }
            else if (TblEdit.Text == "True")
            {
                TblEdit.Text = "مسموح";
            }
        }

        private void TblDelete_TextChanged(object sender, EventArgs e)
        {
            if (TblDelete.Text == "False")
            {
                TblDelete.Text = "غير مسموح";
            }
            else if (TblDelete.Text == "True")
            {
                TblDelete.Text = "مسموح";
            }
        }

    }
}
