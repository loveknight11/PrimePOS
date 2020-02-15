using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PrimePOS.Settings
{
    public partial class FrmRptHeaderFooter : DevExpress.XtraEditors.XtraForm
    {
        #region Definitions
        DataTable DTSettings = new DataTable();
        CRptHeaderFooter InstC = new CRptHeaderFooter();
        #endregion
        #region Methods
        private void Bind()
        {
            if (DTSettings.Rows.Count > 0)
            {
                TxtRHdr1.Text = DTSettings.Rows[0]["RHdr1"].ToString();
                TxtRHdr2.Text = DTSettings.Rows[0]["RHdr2"].ToString();
                TxtRHdr3.Text = DTSettings.Rows[0]["RHdr3"].ToString();
                TxtLHdr1.Text = DTSettings.Rows[0]["LHdr1"].ToString();
                TxtLHdr2.Text = DTSettings.Rows[0]["LHdr2"].ToString();
                TxtLHdr3.Text = DTSettings.Rows[0]["LHdr3"].ToString();
                TxtFooter.Text = DTSettings.Rows[0]["Footer"].ToString();
                PictureHdr.Image = CImage.ArrayTextToImage(DTSettings.Rows[0]["PictureHdr"]);
            }
            else
            {
                TxtRHdr1.Text = "";
                TxtRHdr2.Text = "";
                TxtRHdr3.Text = "";
                TxtLHdr1.Text = "";
                TxtLHdr2.Text = "";
                TxtLHdr3.Text = "";
                TxtFooter.Text = "";
                PictureHdr.Image = null;
            }
        }
        private void Save()
        {
            byte[] ImageArr = null;
            Image image = PictureHdr.Image;

            if (image != null)
            {
                ImageArr = CImage.ImageToArray(image);
            }
            bool Result = InstC.UpdateSettings(TxtRHdr1.Text, TxtRHdr2.Text, TxtRHdr3.Text, TxtLHdr1.Text, TxtLHdr2.Text,
                TxtLHdr3.Text, ImageArr, TxtFooter.Text);
            if (Result)
            {
                MessageBox.Show("تم حفظ الاعدادت بنجاح");
            }
            else
            {
                MessageBox.Show("لم يتم حفظ الاعدادات");
            }
        }
        #endregion
        public FrmRptHeaderFooter()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRptHeaderFooter_Load(object sender, EventArgs e)
        {
            DTSettings = InstC.GetSettings();
            Bind();
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void PictureHdr_Click(object sender, EventArgs e)
        {
            //if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
                
            //}
            PictureHdr.LoadImage();
        }
    }
}