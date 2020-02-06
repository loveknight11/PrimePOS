using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimePOS.Security
{
    public partial class FrmUserGroups : Form
    {
        #region Definitions
        CUserGroups InstCUserGroups = new CUserGroups();
        DataTable DT = new DataTable();
        int Mark = 0;
        bool IsNew = false;
        #endregion
        #region Methods
        private void LoadGroups()
        {
            DT = InstCUserGroups.GetAllGroups();
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
                TxtName.Text = "";
                MessageBox.Show("لا يوجد مجموعات اضف جديد");
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
                MessageBox.Show("اخر مجموعة قيد العرض");
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
                MessageBox.Show("أول مجموعة قيد العرض");
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
            }
            else
            {
                IsNew = true;
                TxtName.Text = "";
                BtnNew.Text = "الغاء";
                DisableButtons();
            }
        }
        private void Save()
        {
            if (TxtName.Text.Trim() == "")
            {
                MessageBox.Show("يجب ادخال اسم المجموعة");
            }
            else
            {
                if (IsNew)
                {
                    if (InstCUserGroups.CheckNew(TxtName.Text))
                    {
                        if (InstCUserGroups.SaveGroup(TxtName.Text))
                        {
                            MessageBox.Show("تم الحفظ بنجاح");
                            AddNew();
                            LoadGroups();
                            ShowLast();

                        }
                        else
                        {
                            MessageBox.Show("لم يتم حفظ المجموعة");
                        }
                    }
                    else
                    {
                        MessageBox.Show("المجموعة موجوده من قبل");
                    }
                }
                else
                {
                    if (InstCUserGroups.CheckUpdate(TxtName.Text,DT.Rows[Mark]["ID"].ToString()))
                    {
                        if (InstCUserGroups.UpdateGroup(TxtName.Text,DT.Rows[Mark]["ID"].ToString()))
                        {
                            MessageBox.Show("تم التعديل بنجاح");
                            LoadGroups();
                            Bind();
                        }
                        else
                        {
                            MessageBox.Show("لم يتم تعديل المجموعة");
                        }
                    }
                    else
                    {
                        MessageBox.Show("المجموعة موجوده من قبل");
                    }
                }
            }
        }
        private void Delete()
        {
            DialogResult Response = MessageBox.Show("متأكد من الحذف","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (Response == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            if (InstCUserGroups.IsEmptyGroup(DT.Rows[Mark]["ID"].ToString()))
            {
                if (InstCUserGroups.DeleteGroup(DT.Rows[Mark]["ID"].ToString()))
                {
                    MessageBox.Show("تم حذف المجموعة بنجاح");
                    LoadGroups();
                    ShowFirst();
                }
                else
                {
                    MessageBox.Show("لم يتم حذف المجموعة");
                }
            }
            else
            {
                MessageBox.Show("لا يمكن حذف المجموعة بينما تحتوى على مستخدمين");
            }
        }
        #endregion
        public FrmUserGroups()
        {
            InitializeComponent();
        }

        private void FrmUserGroups_Load(object sender, EventArgs e)
        {
            LoadGroups();
            ShowFirst();
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
