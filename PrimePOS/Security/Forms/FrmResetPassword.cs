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
    public partial class FrmResetPassword : DevExpress.XtraEditors.XtraForm
    {
        #region Definitions
        CUsers InstCUsers = new CUsers();
        #endregion
        #region Methods
        private bool Check()
        {
            if (LUUsers.EditValue == null || LUUsers.EditValue.ToString() == "")
            {
                MessageBox.Show("يجب اختيار المستخدم");
                return false;
            }
            if (TxtNewPassword.Text != TxtConfirm.Text)
            {
                MessageBox.Show("كلمة السر الجديدة غير متطابقة");
                return false;
            }
            if (TxtNewPassword.Text.Length < 6)
            {
                MessageBox.Show("كلمة السر يجب أن تكون 6 أحرف أو أرقام على الاقل");
                return false;
            }
            return true;
        }
        #endregion
        public FrmResetPassword()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmResetPassword_Load(object sender, EventArgs e)
        {
            CDB.FillLookUpEdit(LUUsers, "TblUsers", "UserName", "ID");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                if (InstCUsers.ResetPassword(LUUsers.EditValue.ToString(),TxtOldPassword.Text,TxtNewPassword.Text))
                {
                    MessageBox.Show("تم تغيير كلمة السر");
                }
                else
                {
                    MessageBox.Show("لم يتم تغيير كلمة السر");
                }
            }
        }
    }
}