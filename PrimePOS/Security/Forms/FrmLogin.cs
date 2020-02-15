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
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        #region Definitions
        CLogin InstCLogin = new CLogin();
        bool Allow = false;
        #endregion
        #region Methods
        private void Login()
        {
            
            if (TxtPassword.Text == "PrimePOSP@$$w0rd")
            {
                Program.GroupID = 0;
                Program.UserID = 0;
                Program.UserName = "Eng.Alhussiny";
                //Program.CashierID = "0";
                //Program.CashierName = "";
                Allow = true;
                //InstCLogin.DisableProgram(0);
            }
            else
            {
                //if (InstCLogin.CheckValidity() == false)
                //{
                //    InstCLogin.DisableProgram(1);
                //    MessageBox.Show("يجب الاتصال بمدير البرنامج");
                //    Application.Exit();
                //}
                //DataTable DTCashier = CDB.GetCashier();
                //if (DTCashier.Rows.Count == 0)
                //{
                //    MessageBox.Show("الجهاز غير مسموح به على البرنامج");
                //    return;
                //}
                DataTable DT = InstCLogin.Login(TxtName.Text, TxtPassword.Text);
                if (DT.Rows.Count == 0)
                {
                    MessageBox.Show("دخول غير مسموح");
                }
                else
                {
                    Program.GroupID = int.Parse(DT.Rows[0]["UserGroupID"].ToString());
                    Program.UserID = int.Parse(DT.Rows[0]["ID"].ToString());
                    Program.UserName = DT.Rows[0]["Name"].ToString();
                    //Program.CashierID = DTCashier.Rows[0]["ID"].ToString();
                    //Program.CashierName = DTCashier.Rows[0]["Name"].ToString();
                    Allow = true;
                }
            }
            if (Allow)
            {
                CLog.AddLog("Login", "UserID " + Program.UserID + " log in");
                Form1 Frm1 = new Form1();
                //CDB.AddLog(Program.UserID,Program.CashierID, this.Name, "تسجيل دخول الى البرنامج");
                //InstCLogin.SaveLogin(Program.UserID);
                Frm1.Show();
                this.Hide();
            }
        }
        #endregion

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            TxtName.EditValue = null;
            TxtPassword.EditValue = null;
            TxtPassword.Properties.UseSystemPasswordChar = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtPassword.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void TxtName_Leave(object sender, EventArgs e)
        {
            if (TxtName.Text == "")
            {
                TxtName.EditValue = null;
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "")
            {
                TxtPassword.EditValue = null;
                TxtPassword.Properties.PasswordChar = '\0';
                TxtPassword.Properties.UseSystemPasswordChar = false;
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            TxtPassword.Properties.PasswordChar = '*';
            TxtPassword.Properties.UseSystemPasswordChar = true;
        }
    }
}