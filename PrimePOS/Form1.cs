using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimePOS.Security;

namespace PrimePOS
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
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
    }
}
