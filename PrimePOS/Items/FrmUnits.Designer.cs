namespace PrimePOS.Items
{
    partial class FrmUnits
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNew = new DevExpress.XtraEditors.SimpleButton();
            this.BtnFirst = new DevExpress.XtraEditors.SimpleButton();
            this.BtnPrevious = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNext = new DevExpress.XtraEditors.SimpleButton();
            this.BtnLast = new DevExpress.XtraEditors.SimpleButton();
            this.TxtName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.BtnClose);
            this.layoutControl1.Controls.Add(this.BtnDelete);
            this.layoutControl1.Controls.Add(this.BtnSave);
            this.layoutControl1.Controls.Add(this.BtnNew);
            this.layoutControl1.Controls.Add(this.BtnFirst);
            this.layoutControl1.Controls.Add(this.BtnPrevious);
            this.layoutControl1.Controls.Add(this.BtnNext);
            this.layoutControl1.Controls.Add(this.BtnLast);
            this.layoutControl1.Controls.Add(this.TxtName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(809, 498);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // BtnClose
            // 
            this.BtnClose.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.Image = global::PrimePOS.Properties.Resources.Close_icon;
            this.BtnClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnClose.Location = new System.Drawing.Point(12, 44);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(95, 93);
            this.BtnClose.StyleController = this.layoutControl1;
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "خروج";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.Image = global::PrimePOS.Properties.Resources.symbol_delete_icon;
            this.BtnDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnDelete.Location = new System.Drawing.Point(111, 44);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(95, 93);
            this.BtnDelete.StyleController = this.layoutControl1;
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "حذف";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnSave.Appearance.Options.UseFont = true;
            this.BtnSave.Image = global::PrimePOS.Properties.Resources.Floppy_Save_Small_icon;
            this.BtnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnSave.Location = new System.Drawing.Point(210, 44);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(94, 93);
            this.BtnSave.StyleController = this.layoutControl1;
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "حفظ";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnNew.Appearance.Options.UseFont = true;
            this.BtnNew.Image = global::PrimePOS.Properties.Resources.Add_icon;
            this.BtnNew.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnNew.Location = new System.Drawing.Point(308, 44);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(95, 93);
            this.BtnNew.StyleController = this.layoutControl1;
            this.BtnNew.TabIndex = 2;
            this.BtnNew.Text = "جديد";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnFirst
            // 
            this.BtnFirst.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnFirst.Appearance.Options.UseFont = true;
            this.BtnFirst.Image = global::PrimePOS.Properties.Resources.Button_First_icon;
            this.BtnFirst.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnFirst.Location = new System.Drawing.Point(407, 44);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(94, 93);
            this.BtnFirst.StyleController = this.layoutControl1;
            this.BtnFirst.TabIndex = 2;
            this.BtnFirst.Text = "الأول";
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnPrevious.Appearance.Options.UseFont = true;
            this.BtnPrevious.Image = global::PrimePOS.Properties.Resources.Previous_icon;
            this.BtnPrevious.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnPrevious.Location = new System.Drawing.Point(505, 44);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(95, 93);
            this.BtnPrevious.StyleController = this.layoutControl1;
            this.BtnPrevious.TabIndex = 2;
            this.BtnPrevious.Text = "السابق";
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnNext.Appearance.Options.UseFont = true;
            this.BtnNext.Image = global::PrimePOS.Properties.Resources.Button_Next_icon;
            this.BtnNext.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnNext.Location = new System.Drawing.Point(604, 44);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(94, 93);
            this.BtnNext.StyleController = this.layoutControl1;
            this.BtnNext.TabIndex = 2;
            this.BtnNext.Text = "التالى";
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnLast
            // 
            this.BtnLast.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnLast.Appearance.Options.UseFont = true;
            this.BtnLast.Image = global::PrimePOS.Properties.Resources.Button_Last_icon;
            this.BtnLast.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnLast.Location = new System.Drawing.Point(702, 44);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(95, 93);
            this.BtnLast.StyleController = this.layoutControl1;
            this.BtnLast.TabIndex = 2;
            this.BtnLast.Text = "الأخير";
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(12, 12);
            this.TxtName.Name = "TxtName";
            this.TxtName.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtName.Properties.Appearance.Options.UseFont = true;
            this.TxtName.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtName.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TxtName.Properties.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtName.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Blue;
            this.TxtName.Properties.AppearanceFocused.Options.UseFont = true;
            this.TxtName.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.TxtName.Size = new System.Drawing.Size(745, 28);
            this.TxtName.StyleController = this.layoutControl1;
            this.TxtName.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(809, 498);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.TxtName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(789, 32);
            this.layoutControlItem1.Text = "الوحدة";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(37, 21);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.BtnLast;
            this.layoutControlItem2.Location = new System.Drawing.Point(690, 32);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(99, 446);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.BtnNext;
            this.layoutControlItem3.Location = new System.Drawing.Point(592, 32);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(98, 446);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.BtnPrevious;
            this.layoutControlItem4.Location = new System.Drawing.Point(493, 32);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(99, 446);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.BtnFirst;
            this.layoutControlItem5.Location = new System.Drawing.Point(395, 32);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(98, 446);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.BtnNew;
            this.layoutControlItem6.Location = new System.Drawing.Point(296, 32);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(99, 446);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.BtnSave;
            this.layoutControlItem7.Location = new System.Drawing.Point(198, 32);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(98, 446);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.BtnDelete;
            this.layoutControlItem8.Location = new System.Drawing.Point(99, 32);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(99, 446);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.BtnClose;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 32);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(99, 446);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // FrmUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 498);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmUnits";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الوحدات";
            this.Load += new System.EventHandler(this.FrmUnits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.SimpleButton BtnNew;
        private DevExpress.XtraEditors.SimpleButton BtnFirst;
        private DevExpress.XtraEditors.SimpleButton BtnPrevious;
        private DevExpress.XtraEditors.SimpleButton BtnNext;
        private DevExpress.XtraEditors.SimpleButton BtnLast;
        private DevExpress.XtraEditors.TextEdit TxtName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
    }
}