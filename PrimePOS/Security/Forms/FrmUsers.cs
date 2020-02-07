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
    public partial class FrmUsers : DevExpress.XtraEditors.XtraForm
    {
        #region Definitions
        CUsers InstCUsers = new CUsers();
        DataTable DT = new DataTable();
        int Mark = 0;
        bool IsNew = false;
        #endregion
        #region Methods
        private void LoadUsers()
        {
            DT = InstCUsers.GetAllUsers();
        }
        private void DisableNavigation()
        {
            BtnFirst.Enabled = false;
            BtnNext.Enabled = false;
            BtnPrevious.Enabled = false;
            BtnLast.Enabled = false;
        }
        private void EnableNavigation()
        {
            BtnFirst.Enabled = true;
            BtnNext.Enabled = true;
            BtnPrevious.Enabled = true;
            BtnLast.Enabled = true;
        }
        private void Bind()
        {
            if (Mark < DT.Rows.Count)
            {
                TxtName.Text = DT.Rows[Mark]["Name"].ToString();
                TxtUserName.Text = DT.Rows[Mark]["UserName"].ToString();
                TxtPassword.Text = DT.Rows[Mark]["Password"].ToString();
                LUGroup.EditValue = DT.Rows[Mark]["UserGroupID"].ToString();
                if (DT.Rows[Mark]["AllowLogin"].ToString() == "True")
                {
                    BtnDelete.Text = "تعطيل الحساب";
                }
                else
                {
                    BtnDelete.Text = "تفعيل الحساب";
                }
            }
        }
        private void ShowFirst()
        {
            if (DT.Rows.Count != 0)
            {
                Mark = 0;
                Bind();
            }
            else
            {
                MessageBox.Show("لا يوجد مستخدمين اضف جديد");
                DisableNavigation();
            }
        }
        private void ShowNext()
        {
            if (Mark + 1 <= DT.Rows.Count - 1)
            {
                Mark++;
                Bind();
            }
            else
            {
                MessageBox.Show("اخر مستخدم قيد العرض");
            }
        }
        private void ShowPrevious()
        {
            if (Mark != 0)
            {
                Mark--;
                Bind();
            }
            else
            {
                MessageBox.Show("أول مستخدم قيد العرض");
            }
        }
        private void ShowLast()
        {
            Mark = DT.Rows.Count - 1;
            Bind();
        }
        private void DisableButtons()
        {
            BtnDelete.Enabled = false;
            DisableNavigation();
        }
        private void EnableButtons()
        {
            BtnDelete.Enabled = true;
            EnableNavigation();
        }
        private void AddNew()
        {
            if (IsNew)
            {
                IsNew = false;
                Bind();
                BtnNew.Text = "جديد";
                EnableButtons();
                TxtPassword.Enabled = false;
            }
            else
            {
                IsNew = true;
                TxtName.Text = "";
                TxtPassword.Text = "";
                TxtUserName.Text = "";
                LUGroup.EditValue = null;
                BtnNew.Text = "الغاء";
                DisableButtons();
                TxtPassword.Enabled = true;
            }
        }
        private bool Check()
        {
            if (TxtName.Text.Trim() == "")
            {
                MessageBox.Show("يجب ادخال اسم");
                return false;
            }
            if (TxtUserName.Text.Trim() == "")
            {
                MessageBox.Show("يجب ادخال اسم المستخدم");
                return false;
            }
            if (TxtPassword.Text.Length < 6)
            {
                MessageBox.Show("كلمة السر يجب أن تكون 6 أحرف أو أرقام على الاقل");
                return false;
            }
            if (LUGroup.EditValue == null || LUGroup.EditValue.ToString() == "")
            {
                MessageBox.Show("يجب اختيار مجموعة للمستخدم");
                return false;
            }
            return true;
        }
        private void Save()
        {
            if (Check())
            {
                if (IsNew)
                {
                    if (InstCUsers.CheckNew(TxtUserName.Text))
                    {
                        if (InstCUsers.SaveUser(TxtName.Text,TxtUserName.Text,TxtPassword.Text,LUGroup.EditValue.ToString()))
                        {
                            MessageBox.Show("تم الحفظ بنجاح");
                            AddNew();
                            LoadUsers();
                            ShowLast();

                        }
                        else
                        {
                            MessageBox.Show("لم يتم حفظ المستخدم");
                        }
                    }
                    else
                    {
                        MessageBox.Show("اسم المستخدم مستخدم من قبل");
                    }
                }
                else
                {
                    if (InstCUsers.CheckUpdate(TxtUserName.Text, DT.Rows[Mark]["ID"].ToString()))
                    {
                        if (InstCUsers.UpdateUser(TxtName.Text,TxtUserName.Text,LUGroup.EditValue.ToString(), DT.Rows[Mark]["ID"].ToString()))
                        {
                            MessageBox.Show("تم التعديل بنجاح");
                            LoadUsers();
                            Bind();
                        }
                        else
                        {
                            MessageBox.Show("لم يتم تعديل المستخدم");
                        }
                    }
                    else
                    {
                        MessageBox.Show("اسم المستخدم مستخدم من قبل");
                    }
                }
            }
        }
        private void Delete()
        {
            DialogResult Response;
            if (DT.Rows[Mark]["AllowLogin"].ToString() == "True")
            {
                Response = MessageBox.Show("هل تريد تعطيل حساب المستخدم؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                Response = MessageBox.Show("هل تريد تفعيل حساب المستخدم", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            
            if (Response == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            if (DT.Rows[Mark]["AllowLogin"].ToString() == "True")
            {

                if (InstCUsers.DisableUser(DT.Rows[Mark]["ID"].ToString()))
                {
                    MessageBox.Show("تم تعطيل حساب المستخدم");
                    LoadUsers();
                    Bind();
                }
                else
                {
                    MessageBox.Show("لم يتم تعطيل حساب المستخدم");
                }
            }
            else
            {
                if (InstCUsers.EnableUser(DT.Rows[Mark]["ID"].ToString()))
                {
                    MessageBox.Show("تم تفعيل حساب المستخدم");
                    LoadUsers();
                    Bind();
                }
                else
                {
                    MessageBox.Show("لم يتم تفعيل حساب المستخدم");
                }
            }
            
        }
        #endregion
        public FrmUsers()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            ShowLast();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            ShowNext();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            ShowPrevious();
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            ShowFirst();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            CDB.FillLookUpEdit(LUGroup, "TblUserGroups", "Name", "ID");
            LoadUsers();
            ShowFirst();
        }
    }
}