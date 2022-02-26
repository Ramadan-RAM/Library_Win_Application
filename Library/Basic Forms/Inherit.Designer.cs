namespace Library.Basic_Forms
{
    partial class Inherit
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
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Lbl_ID = new DevExpress.XtraEditors.LabelControl();
            this.Panel_Buttons = new DevExpress.XtraEditors.PanelControl();
            this.Btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Del = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.Panel_Search = new DevExpress.XtraEditors.PanelControl();
            this.Cmb_Shearch = new System.Windows.Forms.ComboBox();
            this.Btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Buttons)).BeginInit();
            this.Panel_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Search)).BeginInit();
            this.Panel_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Lbl_ID.Appearance.Options.UseFont = true;
            this.Lbl_ID.Location = new System.Drawing.Point(52, 93);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(7, 13);
            this.Lbl_ID.TabIndex = 6;
            this.Lbl_ID.Text = "0";
            this.Lbl_ID.Visible = false;
            // 
            // Panel_Buttons
            // 
            this.Panel_Buttons.AutoSize = true;
            this.Panel_Buttons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.Panel_Buttons.Controls.Add(this.Btn_Exit);
            this.Panel_Buttons.Controls.Add(this.Btn_Del);
            this.Panel_Buttons.Controls.Add(this.Btn_Edit);
            this.Panel_Buttons.Controls.Add(this.Btn_Save);
            this.Panel_Buttons.Controls.Add(this.Btn_New);
            this.Panel_Buttons.Location = new System.Drawing.Point(26, 417);
            this.Panel_Buttons.Name = "Panel_Buttons";
            this.Panel_Buttons.Size = new System.Drawing.Size(570, 54);
            this.Panel_Buttons.TabIndex = 8;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Exit.Appearance.Options.UseFont = true;
            this.Btn_Exit.ImageOptions.Image = global::Library.Properties.Resources.cancel_32x323;
            this.Btn_Exit.Location = new System.Drawing.Point(418, 8);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(92, 39);
            this.Btn_Exit.TabIndex = 6;
            this.Btn_Exit.Text = "Exit";
            // 
            // Btn_Del
            // 
            this.Btn_Del.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Del.Appearance.Options.UseFont = true;
            this.Btn_Del.ImageOptions.Image = global::Library.Properties.Resources.saveandclose_32x32;
            this.Btn_Del.Location = new System.Drawing.Point(320, 8);
            this.Btn_Del.Name = "Btn_Del";
            this.Btn_Del.Size = new System.Drawing.Size(92, 39);
            this.Btn_Del.TabIndex = 5;
            this.Btn_Del.Text = "Delete";
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Edit.Appearance.Options.UseFont = true;
            this.Btn_Edit.ImageOptions.Image = global::Library.Properties.Resources.saveas_32x32;
            this.Btn_Edit.Location = new System.Drawing.Point(222, 8);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(92, 39);
            this.Btn_Edit.TabIndex = 4;
            this.Btn_Edit.Text = "Update";
            // 
            // Btn_Save
            // 
            this.Btn_Save.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Save.Appearance.Options.UseFont = true;
            this.Btn_Save.ImageOptions.Image = global::Library.Properties.Resources.saveto_32x32;
            this.Btn_Save.Location = new System.Drawing.Point(124, 8);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(92, 39);
            this.Btn_Save.TabIndex = 3;
            this.Btn_Save.Text = "Save";
            // 
            // Btn_New
            // 
            this.Btn_New.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_New.Appearance.Options.UseFont = true;
            this.Btn_New.ImageOptions.Image = global::Library.Properties.Resources.newcustomers_32x32;
            this.Btn_New.Location = new System.Drawing.Point(26, 8);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(92, 39);
            this.Btn_New.TabIndex = 2;
            this.Btn_New.Text = "New";
            // 
            // Panel_Search
            // 
            this.Panel_Search.AutoSize = true;
            this.Panel_Search.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.Panel_Search.Controls.Add(this.Cmb_Shearch);
            this.Panel_Search.Controls.Add(this.Btn_Search);
            this.Panel_Search.Controls.Add(this.labelControl1);
            this.Panel_Search.Location = new System.Drawing.Point(26, 27);
            this.Panel_Search.Name = "Panel_Search";
            this.Panel_Search.Size = new System.Drawing.Size(543, 45);
            this.Panel_Search.TabIndex = 7;
            // 
            // Cmb_Shearch
            // 
            this.Cmb_Shearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_Shearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_Shearch.FormattingEnabled = true;
            this.Cmb_Shearch.Location = new System.Drawing.Point(58, 13);
            this.Cmb_Shearch.Name = "Cmb_Shearch";
            this.Cmb_Shearch.Size = new System.Drawing.Size(363, 21);
            this.Cmb_Shearch.TabIndex = 3;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Search.Appearance.Options.UseFont = true;
            this.Btn_Search.ImageOptions.Image = global::Library.Properties.Resources.find_16x16;
            this.Btn_Search.Location = new System.Drawing.Point(427, 13);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(81, 25);
            this.Btn_Search.TabIndex = 2;
            this.Btn_Search.Text = "Search";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Search:";
            // 
            // Inherit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 493);
            this.Controls.Add(this.Panel_Buttons);
            this.Controls.Add(this.Panel_Search);
            this.Controls.Add(this.Lbl_ID);
            this.KeyPreview = true;
            this.Name = "Inherit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inherit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inherit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Buttons)).EndInit();
            this.Panel_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Search)).EndInit();
            this.Panel_Search.ResumeLayout(false);
            this.Panel_Search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        public DevExpress.XtraEditors.LabelControl Lbl_ID;
        public DevExpress.XtraEditors.PanelControl Panel_Buttons;
        public DevExpress.XtraEditors.SimpleButton Btn_Exit;
        public DevExpress.XtraEditors.SimpleButton Btn_Del;
        public DevExpress.XtraEditors.SimpleButton Btn_Edit;
        public DevExpress.XtraEditors.SimpleButton Btn_Save;
        public DevExpress.XtraEditors.SimpleButton Btn_New;
        public DevExpress.XtraEditors.PanelControl Panel_Search;
        public System.Windows.Forms.ComboBox Cmb_Shearch;
        public DevExpress.XtraEditors.SimpleButton Btn_Search;
        public DevExpress.XtraEditors.LabelControl labelControl1;
    }
}