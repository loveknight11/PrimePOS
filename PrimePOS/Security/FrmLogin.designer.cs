namespace PrimePOS.Security
{
    partial class FrmLogin
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
            this.TxtPassword = new DevExpress.XtraEditors.TextEdit();
            this.TxtName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtPassword
            // 
            this.TxtPassword.EditValue = "كلمة السر";
            this.TxtPassword.Location = new System.Drawing.Point(102, 287);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Properties.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.TxtPassword.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Properties.Appearance.Options.UseBackColor = true;
            this.TxtPassword.Properties.Appearance.Options.UseFont = true;
            this.TxtPassword.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtPassword.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtPassword.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TxtPassword.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtPassword.Properties.AppearanceDisabled.Options.UseFont = true;
            this.TxtPassword.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.TxtPassword.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtPassword.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TxtPassword.Properties.NullText = "كلمة السر";
            this.TxtPassword.Properties.UseSystemPasswordChar = true;
            this.TxtPassword.Size = new System.Drawing.Size(476, 30);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPassword_KeyDown);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // TxtName
            // 
            this.TxtName.EditValue = "";
            this.TxtName.Location = new System.Drawing.Point(102, 208);
            this.TxtName.Name = "TxtName";
            this.TxtName.Properties.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.TxtName.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Properties.Appearance.Options.UseBackColor = true;
            this.TxtName.Properties.Appearance.Options.UseFont = true;
            this.TxtName.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtName.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TxtName.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtName.Properties.AppearanceDisabled.Options.UseFont = true;
            this.TxtName.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.TxtName.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtName.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TxtName.Properties.NullText = "اسم المستخدم";
            this.TxtName.Size = new System.Drawing.Size(476, 30);
            this.TxtName.TabIndex = 1;
            this.TxtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtName_KeyDown);
            this.TxtName.Leave += new System.EventHandler(this.TxtName_Leave);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::PrimePOS.Properties.Resources.LogINSmall;
            this.ClientSize = new System.Drawing.Size(678, 497);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private DevExpress.XtraEditors.TextEdit TxtName;
        private DevExpress.XtraEditors.TextEdit TxtPassword;
        private DevExpress.XtraEditors.TextEdit TxtName;
    }
}