using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace PrimePOS.Security
{
    public partial class FrmRptGroupForms : DevExpress.XtraEditors.XtraForm
    {
        #region Definitions
        CRptGroupForms InstC = new CRptGroupForms();
        DataTable DTRpt = new DataTable();
        #endregion
        #region Methods
        private void ShowReport()
        {
            DTRpt = InstC.GetRptData(LUGroup.EditValue.ToString());
            if (DTRpt.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد بيانات لعرضها");
                return;
            }

            RptGroupForms Rpt = new RptGroupForms();
            Rpt.DataSource = DTRpt;

            Rpt.LblRptHeader.Text = "صلاحيات المجموعة " + LUGroup.Text;

            Rpt.TblDelete.DataBindings.Add("Text", DTRpt, "AllowDelete");
            Rpt.TblEdit.DataBindings.Add("Text", DTRpt, "AllowEdit");
            Rpt.TblFormName.DataBindings.Add("Text", DTRpt, "FormCaption");
            Rpt.TblOpen.DataBindings.Add("Text", DTRpt, "AllowOpen");
            Rpt.TblSave.DataBindings.Add("Text", DTRpt, "AllowSave");

            Rpt.ShowPreview();
        }
        #endregion
        public FrmRptGroupForms()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            if (LUGroup.EditValue == null || LUGroup.EditValue.ToString() == "")
            {
                MessageBox.Show("يجب اختيار مجموعة لعرض صلاحياتها");
                return;
            }

            ShowReport();
        }

        private void FrmRptGroupForms_Load(object sender, EventArgs e)
        {
            CDB.FillLookUpEdit(LUGroup, "TblUserGroups", "Name", "ID");
        }
    }
}