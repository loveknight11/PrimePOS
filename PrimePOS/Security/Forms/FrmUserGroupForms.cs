using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PrimePOS.Security
{
    public partial class FrmUserGroupForms : DevExpress.XtraEditors.XtraForm
    {
        #region Definitions
        CGroupForms InstCGroupForms = new CGroupForms();
        DataTable DTSecurity = new DataTable();
        #endregion
        #region Methods
        private void FillGrid()
        {
            if (xtraTabControl1.SelectedTabPage == TabSecurity)
            {
                FillSecurity();
            }
        }
        private void FillSecurity()
        {
            InstCGroupForms.CheckGroupForms(LUGroup.EditValue.ToString());
            DTSecurity = new DataTable();
            DTSecurity = InstCGroupForms.GetGroupForms(LUGroup.EditValue.ToString(), "Security");
            GCSecurity.DataSource = DTSecurity;
            GCSecurity.Refresh();
        }
        private void Save()
        {
            if (xtraTabControl1.SelectedTabPage == TabSecurity)
            {
                SaveSecurity();
            }
        }
        private void SaveSecurity()
        {
            foreach (DataRow DR in DTSecurity.Rows)
            {
                if (!(InstCGroupForms.SaveGroupForm(DR["ID"].ToString(),bool.Parse(DR["AllowOpen"].ToString()),
                    bool.Parse(DR["AllowSave"].ToString()),bool.Parse(DR["AllowEdit"].ToString()),bool.Parse(DR["AllowDelete"].ToString()))))
                {
                    MessageBox.Show("حدث خطأ أثناء الحفظ");
                    break;
                }
            }
            MessageBox.Show("تم الحفظ");
        }
        #endregion
        public FrmUserGroupForms()
        {
            InitializeComponent();
        }

        private void FrmUserGroupForms_Load(object sender, EventArgs e)
        {
            CDB.FillLookUpEdit(LUGroup, "TblUserGroups", "Name", "ID");
        }

        private void LUGroup_EditValueChanged(object sender, EventArgs e)
        {
            if (LUGroup.EditValue != null && LUGroup.EditValue.ToString() != "")
            {
                FillGrid();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            FillGrid();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}