using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PrimePOS.Items
{
    public partial class FrmUnits : DevExpress.XtraEditors.XtraForm
    {
        #region Definitions
        Cunits InstCUnits = new Cunits();
        DataTable DT = new DataTable();
        int Mark = 0;
        bool IsNew = false;
        //DataTable DTSecurity = new DataTable();
        CNavigation InstCNavigation = new CNavigation(null);
        CSecurity InstCSecurity;
        #endregion
        #region Methods
        private void LoadUnits()
        {
            DT = InstCUnits.GetAllUnits();
            InstCNavigation.RefreshDataTable(DT);
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
            if (Mark.Equals(Int16.MinValue))
            {
                TxtName.Text = "";
            }
            else if (Mark < DT.Rows.Count)
            {
                TxtName.Text = DT.Rows[Mark]["Name"].ToString();
            }
        }
        //private void ShowFirst()
        //{
        //    if (DT.Rows.Count != 0)
        //    {
        //        Mark = 0;
        //        Bind();
        //    }
        //    else
        //    {
        //        TxtName.Text = "";
        //        MessageBox.Show("لا يوجد وحدات اضف جديد");
        //        DisableNavigation();
        //    }
        //}
        //private void ShowNext()
        //{
        //    if (Mark + 1 <= DT.Rows.Count - 1)
        //    {
        //        Mark++;
        //        Bind();
        //    }
        //    else
        //    {
        //        MessageBox.Show("اخر وحدة قيد العرض");
        //    }
        //}
        //private void ShowPrevious()
        //{
        //    if (Mark != 0)
        //    {
        //        Mark--;
        //        Bind();
        //    }
        //    else
        //    {
        //        MessageBox.Show("أول وحدة قيد العرض");
        //    }
        //}
        //private void ShowLast()
        //{
        //    Mark = DT.Rows.Count - 1;
        //    Bind();
        //}
        private void DisableButtons()
        {
            BtnDelete.Enabled = false;
            DisableNavigation();
        }
        private void EnableButtons()
        {
            BtnDelete.Enabled = InstCSecurity.AllowDelete();
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
                BtnSave.Enabled = InstCSecurity.AllowEdit();
            }
            else
            {
                IsNew = true;
                TxtName.Text = "";
                BtnNew.Text = "الغاء";
                DisableButtons();
                BtnSave.Enabled = true;
            }
        }
        private void Save()
        {
            if (TxtName.Text.Trim() == "")
            {
                MessageBox.Show("يجب ادخال اسم الوحدة");
            }
            else
            {
                if (IsNew)
                {
                    if (InstCUnits.CheckNew(TxtName.Text))
                    {
                        if (InstCUnits.SaveUnit(TxtName.Text))
                        {
                            MessageBox.Show("تم الحفظ بنجاح");
                            AddNew();
                            LoadUnits();
                            Mark = InstCNavigation.ShowLast();
                            Bind();

                        }
                        else
                        {
                            MessageBox.Show("لم يتم حفظ الوحدة");
                        }
                    }
                    else
                    {
                        MessageBox.Show("الوحدة موجوده من قبل");
                    }
                }
                else
                {
                    if (InstCUnits.CheckUpdate(TxtName.Text, DT.Rows[Mark]["ID"].ToString()))
                    {
                        if (InstCUnits.UpdateGroup(TxtName.Text, DT.Rows[Mark]["ID"].ToString()))
                        {
                            MessageBox.Show("تم التعديل بنجاح");
                            LoadUnits();
                            Bind();
                        }
                        else
                        {
                            MessageBox.Show("لم يتم تعديل الوحدة");
                        }
                    }
                    else
                    {
                        MessageBox.Show("الوحدة موجوده من قبل");
                    }
                }
            }
        }
        private void Delete()
        {
            DialogResult Response = MessageBox.Show("متأكد من الحذف", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Response == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            if (InstCUnits.IsEmptyUnit(DT.Rows[Mark]["ID"].ToString()))
            {
                if (InstCUnits.DeleteUnit(DT.Rows[Mark]["ID"].ToString()))
                {
                    MessageBox.Show("تم حذف الوحدة بنجاح");
                    LoadUnits();
                    Mark = InstCNavigation.ShowFirst();
                    Bind();
                }
                else
                {
                    MessageBox.Show("لم يتم حذف الوحدة");
                }
            }
            else
            {
                MessageBox.Show("لا يمكن حذف الوحدة بينما تحتوى على أصناف");
            }
        }
        //private bool AllowSave()
        //{
        //    if (DTSecurity.Rows.Count == 0)
        //    {
        //        return false;
        //    }

        //    return bool.Parse(DTSecurity.Rows[0]["AllowSave"].ToString());
        //}
        //private bool AllowEdit()
        //{
        //    if (DTSecurity.Rows.Count == 0)
        //    {
        //        return false;
        //    }

        //    return bool.Parse(DTSecurity.Rows[0]["AllowEdit"].ToString());
        //}
        //private bool AllowDelete()
        //{
        //    if (DTSecurity.Rows.Count == 0)
        //    {
        //        return false;
        //    }

        //    return bool.Parse(DTSecurity.Rows[0]["AllowDelete"].ToString());
        //}
        #endregion
        public FrmUnits()
        {
            InitializeComponent();
        }

        private void FrmUnits_Load(object sender, EventArgs e)
        {
            LoadUnits();
            
            Mark = InstCNavigation.ShowFirst();
            Bind();
            //DTSecurity = PrimePOS.Security.CSecurity.GetFormSecurity(this.Name);
            InstCSecurity = new CSecurity(this.Name);
            BtnNew.Enabled = InstCSecurity.AllowSave();
            BtnSave.Enabled = InstCSecurity.AllowEdit();
            BtnDelete.Enabled = InstCSecurity.AllowDelete();
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            Mark = InstCNavigation.ShowLast();
            Bind();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            Mark = InstCNavigation.ShowNext(Mark);
            Bind();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            Mark = InstCNavigation.ShowPrevious(Mark);
            Bind();
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            Mark = InstCNavigation.ShowFirst();
            Bind();
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}