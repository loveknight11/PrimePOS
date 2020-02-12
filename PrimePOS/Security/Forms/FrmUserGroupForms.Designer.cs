namespace PrimePOS.Security
{
    partial class FrmUserGroupForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserGroupForms));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.TabSecurity = new DevExpress.XtraTab.XtraTabPage();
            this.GCSecurity = new DevExpress.XtraGrid.GridControl();
            this.GVSecurity = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ClmnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClmnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClmnCaption = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClmnOpen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.ClmnSave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.ClmnEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.ClmnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.LUGroup = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.TabSecurity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCSecurity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVSecurity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.xtraTabControl1);
            this.layoutControl1.Controls.Add(this.LUGroup);
            this.layoutControl1.Controls.Add(this.BtnClose);
            this.layoutControl1.Controls.Add(this.BtnSave);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(760, 453);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.xtraTabControl1.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.Blue;
            this.xtraTabControl1.AppearancePage.HeaderActive.Options.UseFont = true;
            this.xtraTabControl1.AppearancePage.HeaderActive.Options.UseForeColor = true;
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 44);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.TabSecurity;
            this.xtraTabControl1.Size = new System.Drawing.Size(736, 300);
            this.xtraTabControl1.TabIndex = 6;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabSecurity,
            this.xtraTabPage2});
            this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
            // 
            // TabSecurity
            // 
            this.TabSecurity.Controls.Add(this.GCSecurity);
            this.TabSecurity.Name = "TabSecurity";
            this.TabSecurity.Size = new System.Drawing.Size(730, 266);
            this.TabSecurity.Text = "الأمان والصلاحيات";
            // 
            // GCSecurity
            // 
            this.GCSecurity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCSecurity.Location = new System.Drawing.Point(0, 0);
            this.GCSecurity.MainView = this.GVSecurity;
            this.GCSecurity.Name = "GCSecurity";
            this.GCSecurity.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemCheckEdit3,
            this.repositoryItemCheckEdit4});
            this.GCSecurity.Size = new System.Drawing.Size(730, 266);
            this.GCSecurity.TabIndex = 0;
            this.GCSecurity.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVSecurity});
            // 
            // GVSecurity
            // 
            this.GVSecurity.ColumnPanelRowHeight = 30;
            this.GVSecurity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ClmnID,
            this.ClmnName,
            this.ClmnCaption,
            this.ClmnOpen,
            this.ClmnSave,
            this.ClmnEdit,
            this.ClmnDelete});
            this.GVSecurity.GridControl = this.GCSecurity;
            this.GVSecurity.Name = "GVSecurity";
            this.GVSecurity.OptionsView.ShowGroupPanel = false;
            // 
            // ClmnID
            // 
            this.ClmnID.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ClmnID.AppearanceCell.Options.UseFont = true;
            this.ClmnID.AppearanceCell.Options.UseTextOptions = true;
            this.ClmnID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ClmnID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ClmnID.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.ClmnID.AppearanceHeader.Options.UseFont = true;
            this.ClmnID.AppearanceHeader.Options.UseTextOptions = true;
            this.ClmnID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ClmnID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ClmnID.Caption = "ID";
            this.ClmnID.FieldName = "ID";
            this.ClmnID.Name = "ClmnID";
            this.ClmnID.OptionsColumn.AllowEdit = false;
            this.ClmnID.OptionsColumn.ReadOnly = true;
            // 
            // ClmnName
            // 
            this.ClmnName.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ClmnName.AppearanceCell.Options.UseFont = true;
            this.ClmnName.AppearanceCell.Options.UseTextOptions = true;
            this.ClmnName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ClmnName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ClmnName.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.ClmnName.AppearanceHeader.Options.UseFont = true;
            this.ClmnName.AppearanceHeader.Options.UseTextOptions = true;
            this.ClmnName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ClmnName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ClmnName.Caption = "Name";
            this.ClmnName.FieldName = "FormName";
            this.ClmnName.Name = "ClmnName";
            this.ClmnName.OptionsColumn.AllowEdit = false;
            this.ClmnName.OptionsColumn.ReadOnly = true;
            // 
            // ClmnCaption
            // 
            this.ClmnCaption.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ClmnCaption.AppearanceCell.Options.UseFont = true;
            this.ClmnCaption.AppearanceCell.Options.UseTextOptions = true;
            this.ClmnCaption.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ClmnCaption.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ClmnCaption.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.ClmnCaption.AppearanceHeader.Options.UseFont = true;
            this.ClmnCaption.AppearanceHeader.Options.UseTextOptions = true;
            this.ClmnCaption.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ClmnCaption.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ClmnCaption.Caption = "الاسم";
            this.ClmnCaption.FieldName = "FormCaption";
            this.ClmnCaption.Name = "ClmnCaption";
            this.ClmnCaption.OptionsColumn.AllowEdit = false;
            this.ClmnCaption.OptionsColumn.ReadOnly = true;
            this.ClmnCaption.Visible = true;
            this.ClmnCaption.VisibleIndex = 0;
            this.ClmnCaption.Width = 276;
            // 
            // ClmnOpen
            // 
            this.ClmnOpen.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ClmnOpen.AppearanceCell.Options.UseFont = true;
            this.ClmnOpen.AppearanceCell.Options.UseTextOptions = true;
            this.ClmnOpen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ClmnOpen.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ClmnOpen.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.ClmnOpen.AppearanceHeader.Options.UseFont = true;
            this.ClmnOpen.AppearanceHeader.Options.UseTextOptions = true;
            this.ClmnOpen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ClmnOpen.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ClmnOpen.Caption = "الفتح";
            this.ClmnOpen.ColumnEdit = this.repositoryItemCheckEdit1;
            this.ClmnOpen.FieldName = "AllowOpen";
            this.ClmnOpen.Name = "ClmnOpen";
            this.ClmnOpen.Visible = true;
            this.ClmnOpen.VisibleIndex = 1;
            this.ClmnOpen.Width = 96;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // ClmnSave
            // 
            this.ClmnSave.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ClmnSave.AppearanceCell.Options.UseFont = true;
            this.ClmnSave.AppearanceCell.Options.UseTextOptions = true;
            this.ClmnSave.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ClmnSave.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ClmnSave.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.ClmnSave.AppearanceHeader.Options.UseFont = true;
            this.ClmnSave.AppearanceHeader.Options.UseTextOptions = true;
            this.ClmnSave.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ClmnSave.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ClmnSave.Caption = "الحفظ";
            this.ClmnSave.ColumnEdit = this.repositoryItemCheckEdit2;
            this.ClmnSave.FieldName = "AllowSave";
            this.ClmnSave.Name = "ClmnSave";
            this.ClmnSave.Visible = true;
            this.ClmnSave.VisibleIndex = 2;
            this.ClmnSave.Width = 120;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // ClmnEdit
            // 
            this.ClmnEdit.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ClmnEdit.AppearanceCell.Options.UseFont = true;
            this.ClmnEdit.AppearanceCell.Options.UseTextOptions = true;
            this.ClmnEdit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ClmnEdit.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ClmnEdit.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.ClmnEdit.AppearanceHeader.Options.UseFont = true;
            this.ClmnEdit.AppearanceHeader.Options.UseTextOptions = true;
            this.ClmnEdit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ClmnEdit.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ClmnEdit.Caption = "التعديل";
            this.ClmnEdit.ColumnEdit = this.repositoryItemCheckEdit3;
            this.ClmnEdit.FieldName = "AllowEdit";
            this.ClmnEdit.Name = "ClmnEdit";
            this.ClmnEdit.Visible = true;
            this.ClmnEdit.VisibleIndex = 3;
            this.ClmnEdit.Width = 104;
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            // 
            // ClmnDelete
            // 
            this.ClmnDelete.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ClmnDelete.AppearanceCell.Options.UseFont = true;
            this.ClmnDelete.AppearanceCell.Options.UseTextOptions = true;
            this.ClmnDelete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ClmnDelete.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ClmnDelete.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.ClmnDelete.AppearanceHeader.Options.UseFont = true;
            this.ClmnDelete.AppearanceHeader.Options.UseTextOptions = true;
            this.ClmnDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ClmnDelete.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ClmnDelete.Caption = "الحذف";
            this.ClmnDelete.ColumnEdit = this.repositoryItemCheckEdit4;
            this.ClmnDelete.FieldName = "AllowDelete";
            this.ClmnDelete.Name = "ClmnDelete";
            this.ClmnDelete.Visible = true;
            this.ClmnDelete.VisibleIndex = 4;
            this.ClmnDelete.Width = 100;
            // 
            // repositoryItemCheckEdit4
            // 
            this.repositoryItemCheckEdit4.AutoHeight = false;
            this.repositoryItemCheckEdit4.Name = "repositoryItemCheckEdit4";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(730, 266);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // LUGroup
            // 
            this.LUGroup.Location = new System.Drawing.Point(12, 12);
            this.LUGroup.Name = "LUGroup";
            this.LUGroup.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LUGroup.Properties.Appearance.Options.UseFont = true;
            this.LUGroup.Properties.Appearance.Options.UseTextOptions = true;
            this.LUGroup.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LUGroup.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.LUGroup.Properties.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LUGroup.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Blue;
            this.LUGroup.Properties.AppearanceFocused.Options.UseFont = true;
            this.LUGroup.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.LUGroup.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.LUGroup.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LUGroup.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.LUGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUGroup.Properties.NullText = "";
            this.LUGroup.Properties.View = this.gridView1;
            this.LUGroup.Size = new System.Drawing.Size(674, 28);
            this.LUGroup.StyleController = this.layoutControl1;
            this.LUGroup.TabIndex = 5;
            this.LUGroup.EditValueChanged += new System.EventHandler(this.LUGroup_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // BtnClose
            // 
            this.BtnClose.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.Image = global::PrimePOS.Properties.Resources.Close_icon;
            this.BtnClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnClose.Location = new System.Drawing.Point(12, 348);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(361, 93);
            this.BtnClose.StyleController = this.layoutControl1;
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "خروج";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnSave.Appearance.Options.UseFont = true;
            this.BtnSave.Image = global::PrimePOS.Properties.Resources.Floppy_Save_Small_icon;
            this.BtnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnSave.Location = new System.Drawing.Point(377, 348);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(371, 93);
            this.BtnSave.StyleController = this.layoutControl1;
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "حفظ";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem9,
            this.layoutControlItem12,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(760, 453);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.BtnSave;
            this.layoutControlItem7.Location = new System.Drawing.Point(365, 336);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(375, 97);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.BtnClose;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 336);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(365, 97);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.layoutControlItem12.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem12.Control = this.LUGroup;
            this.layoutControlItem12.CustomizationFormText = "المجموعة";
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(740, 32);
            this.layoutControlItem12.Text = "المجموعة";
            this.layoutControlItem12.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem12.TextSize = new System.Drawing.Size(57, 21);
            this.layoutControlItem12.TextToControlDistance = 5;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.xtraTabControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 32);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(740, 304);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // FrmUserGroupForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 453);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUserGroupForms";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "صلاحيات المجموعة";
            this.Load += new System.EventHandler(this.FrmUserGroupForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.TabSecurity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCSecurity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVSecurity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage TabSecurity;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SearchLookUpEdit LUGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl GCSecurity;
        private DevExpress.XtraGrid.Views.Grid.GridView GVSecurity;
        private DevExpress.XtraGrid.Columns.GridColumn ClmnID;
        private DevExpress.XtraGrid.Columns.GridColumn ClmnName;
        private DevExpress.XtraGrid.Columns.GridColumn ClmnCaption;
        private DevExpress.XtraGrid.Columns.GridColumn ClmnOpen;
        private DevExpress.XtraGrid.Columns.GridColumn ClmnSave;
        private DevExpress.XtraGrid.Columns.GridColumn ClmnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn ClmnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit4;
    }
}