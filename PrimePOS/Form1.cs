using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimePOS.Security;
using PrimePOS.Settings;
using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;

namespace PrimePOS
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Definitions
        DataTable DTAllowedForms = new DataTable();
        #endregion
        #region Methods
        private void SelectPage(string Name)
        {
            foreach (DevExpress.XtraTabbedMdi.XtraMdiTabPage Tab in xtraTabbedMdiManager1.Pages)
            {
                if (Tab.Text.Equals(Name))
                {
                    xtraTabbedMdiManager1.SelectedPage = Tab;
                }
            }
        }
        private bool SearchAllowedForms(string FormName)
        {
            foreach (DataRow DR in DTAllowedForms.Rows)
            {
                if (DR["FormName"].ToString().Equals(FormName))
                {
                    return true;
                }
            }
            return false;
        }
        private void SetSecurity()
        {
            if (Program.GroupID == 0)
            {
                return;
            }
            foreach (DevExpress.XtraBars.Ribbon.RibbonPage page in ribbonControl1.Pages)
            {
                foreach (DevExpress.XtraBars.Ribbon.RibbonPageGroup group in page.Groups)
                {
                    foreach (BarItemLink link in group.ItemLinks)
                    {
                        //link.Item.Enabled = false;
                        if (link.Item.Tag == null)
                        {
                            link.Item.Enabled = false;
                        }
                        else
                        {
                            link.Item.Enabled = SearchAllowedForms(link.Item.Tag.ToString());
                        }
                        
                    }
                }
            }
        }
        private void TestRptParent()
        {
            RptParent Rpt = new RptParent();
            CRptParent.PrepareReport(Rpt);
            Rpt.ShowPreview();
        }
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUsers Frm1 = new FrmUsers();
            if (Application.OpenForms[Frm1.Name] as Form != null)
            {
                SelectPage(Frm1.Text);
                Frm1.Close();
                return;
            }
            Frm1.MdiParent = this;
            Frm1.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmResetPassword Frm1 = new FrmResetPassword();
            if (Application.OpenForms[Frm1.Name] as Form != null)
            {
                SelectPage(Frm1.Text);
                Frm1.Close();
                return;
            }
            Frm1.MdiParent = this;
            Frm1.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUserGroups Frm1 = new FrmUserGroups();
            if (Application.OpenForms[Frm1.Name] as Form != null)
            {
                SelectPage(Frm1.Text);
                Frm1.Close();
                return;
            }
            Frm1.MdiParent = this;
            Frm1.Show();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUserGroupForms Frm1 = new FrmUserGroupForms();
            if (Application.OpenForms[Frm1.Name] as Form != null)
            {
                SelectPage(Frm1.Text);
                Frm1.Close();
                return;
            }
            Frm1.MdiParent = this;
            Frm1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DTAllowedForms = CSecurity.GetAllowedForms();
            SetSecurity();
            //TestRptParent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CLog.AddLog("Logout", "UserID " + Program.UserID + " log out");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmRptHeaderFooter Frm1 = new FrmRptHeaderFooter();
            if (Application.OpenForms[Frm1.Name] as Form != null)
            {
                SelectPage(Frm1.Text);
                Frm1.Close();
                return;
            }
            Frm1.MdiParent = this;
            Frm1.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmRptGroupForms Frm1 = new FrmRptGroupForms();
            if (Application.OpenForms[Frm1.Name] as Form != null)
            {
                SelectPage(Frm1.Text);
                Frm1.Close();
                return;
            }
            Frm1.MdiParent = this;
            Frm1.Show();
        }
    }
}
