
namespace Library.Basic_Forms
{
    partial class DistrubuteItems
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
            this.Pnl_BasicData = new DevExpress.XtraEditors.PanelControl();
            this.Dgv_Items = new System.Windows.Forms.DataGridView();
            this.Col_StoreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.Lbl2_ID = new DevExpress.XtraEditors.LabelControl();
            this.Lbl1_ID = new DevExpress.XtraEditors.LabelControl();
            this.Btn_Distrub = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.Cmb_ItemName = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Cmb_StoreName = new System.Windows.Forms.ComboBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Pnl_BasicData)).BeginInit();
            this.Pnl_BasicData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_BasicData
            // 
            this.Pnl_BasicData.Controls.Add(this.Dgv_Items);
            this.Pnl_BasicData.Controls.Add(this.panelControl1);
            this.Pnl_BasicData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_BasicData.Location = new System.Drawing.Point(0, 0);
            this.Pnl_BasicData.Name = "Pnl_BasicData";
            this.Pnl_BasicData.Size = new System.Drawing.Size(596, 431);
            this.Pnl_BasicData.TabIndex = 5;
            // 
            // Dgv_Items
            // 
            this.Dgv_Items.AllowUserToAddRows = false;
            this.Dgv_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_StoreID,
            this.Col_ItemID,
            this.Col_StoreName,
            this.Col_ItemName});
            this.Dgv_Items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Items.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Dgv_Items.Location = new System.Drawing.Point(2, 111);
            this.Dgv_Items.Name = "Dgv_Items";
            this.Dgv_Items.ReadOnly = true;
            this.Dgv_Items.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Dgv_Items.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_Items.Size = new System.Drawing.Size(592, 318);
            this.Dgv_Items.TabIndex = 0;
            // 
            // Col_StoreID
            // 
            this.Col_StoreID.HeaderText = "";
            this.Col_StoreID.Name = "Col_StoreID";
            this.Col_StoreID.ReadOnly = true;
            this.Col_StoreID.Visible = false;
            // 
            // Col_ItemID
            // 
            this.Col_ItemID.HeaderText = "";
            this.Col_ItemID.Name = "Col_ItemID";
            this.Col_ItemID.ReadOnly = true;
            this.Col_ItemID.Visible = false;
            // 
            // Col_StoreName
            // 
            this.Col_StoreName.HeaderText = "Store Name";
            this.Col_StoreName.Name = "Col_StoreName";
            this.Col_StoreName.ReadOnly = true;
            this.Col_StoreName.Width = 660;
            // 
            // Col_ItemName
            // 
            this.Col_ItemName.HeaderText = "Item Name";
            this.Col_ItemName.Name = "Col_ItemName";
            this.Col_ItemName.ReadOnly = true;
            this.Col_ItemName.Width = 660;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.Lbl2_ID);
            this.panelControl1.Controls.Add(this.Lbl1_ID);
            this.panelControl1.Controls.Add(this.Btn_Distrub);
            this.panelControl1.Controls.Add(this.Btn_Save);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.Btn_Add);
            this.panelControl1.Controls.Add(this.Cmb_ItemName);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.Cmb_StoreName);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(592, 109);
            this.panelControl1.TabIndex = 6;
            // 
            // Lbl2_ID
            // 
            this.Lbl2_ID.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Lbl2_ID.Appearance.Options.UseFont = true;
            this.Lbl2_ID.Location = new System.Drawing.Point(375, 6);
            this.Lbl2_ID.Name = "Lbl2_ID";
            this.Lbl2_ID.Size = new System.Drawing.Size(7, 13);
            this.Lbl2_ID.TabIndex = 34;
            this.Lbl2_ID.Text = "0";
            this.Lbl2_ID.Visible = false;
            // 
            // Lbl1_ID
            // 
            this.Lbl1_ID.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Lbl1_ID.Appearance.Options.UseFont = true;
            this.Lbl1_ID.Location = new System.Drawing.Point(79, 5);
            this.Lbl1_ID.Name = "Lbl1_ID";
            this.Lbl1_ID.Size = new System.Drawing.Size(7, 13);
            this.Lbl1_ID.TabIndex = 33;
            this.Lbl1_ID.Text = "0";
            this.Lbl1_ID.Visible = false;
            // 
            // Btn_Distrub
            // 
            this.Btn_Distrub.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Distrub.Appearance.Options.UseFont = true;
            this.Btn_Distrub.ImageOptions.Image = global::Library.Properties.Resources.autoexpand_32x321;
            this.Btn_Distrub.Location = new System.Drawing.Point(398, 64);
            this.Btn_Distrub.Name = "Btn_Distrub";
            this.Btn_Distrub.Size = new System.Drawing.Size(183, 39);
            this.Btn_Distrub.TabIndex = 32;
            this.Btn_Distrub.Text = "Distrubeute Automatic";
            this.Btn_Distrub.Click += new System.EventHandler(this.Btn_Distrub_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Save.Appearance.Options.UseFont = true;
            this.Btn_Save.ImageOptions.Image = global::Library.Properties.Resources.save_32x32;
            this.Btn_Save.Location = new System.Drawing.Point(186, 64);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(100, 39);
            this.Btn_Save.TabIndex = 30;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click_1);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = global::Library.Properties.Resources.cancel_32x325;
            this.simpleButton1.Location = new System.Drawing.Point(292, 64);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 39);
            this.simpleButton1.TabIndex = 29;
            this.simpleButton1.Text = "Close";
            this.simpleButton1.Click += new System.EventHandler(this.SimpleButton1_Click_1);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Add.Appearance.Options.UseFont = true;
            this.Btn_Add.ImageOptions.Image = global::Library.Properties.Resources.newsales_32x321;
            this.Btn_Add.Location = new System.Drawing.Point(79, 64);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(100, 39);
            this.Btn_Add.TabIndex = 28;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click_1);
            // 
            // Cmb_ItemName
            // 
            this.Cmb_ItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_ItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_ItemName.FormattingEnabled = true;
            this.Cmb_ItemName.Location = new System.Drawing.Point(375, 25);
            this.Cmb_ItemName.Name = "Cmb_ItemName";
            this.Cmb_ItemName.Size = new System.Drawing.Size(206, 21);
            this.Cmb_ItemName.TabIndex = 27;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(302, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 13);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "Item Name:";
            // 
            // Cmb_StoreName
            // 
            this.Cmb_StoreName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_StoreName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_StoreName.FormattingEnabled = true;
            this.Cmb_StoreName.Location = new System.Drawing.Point(79, 25);
            this.Cmb_StoreName.Name = "Cmb_StoreName";
            this.Cmb_StoreName.Size = new System.Drawing.Size(207, 21);
            this.Cmb_StoreName.TabIndex = 25;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(6, 28);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(69, 13);
            this.labelControl6.TabIndex = 24;
            this.labelControl6.Text = "Store Name:";
            // 
            // DistrubuteItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 431);
            this.Controls.Add(this.Pnl_BasicData);
            this.IconOptions.LargeImage = global::Library.Properties.Resources.pielabelsdatalabels2_32x321;
            this.KeyPreview = true;
            this.Name = "DistrubuteItems";
            this.RightToLeftLayout = true;
            this.ShowMdiChildCaptionInParentTitle = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distrubuting items to Stores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DistrubuteItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pnl_BasicData)).EndInit();
            this.Pnl_BasicData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl Pnl_BasicData;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridView Dgv_Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_StoreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ItemName;
        public DevExpress.XtraEditors.SimpleButton Btn_Save;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        public DevExpress.XtraEditors.SimpleButton Btn_Add;
        public System.Windows.Forms.ComboBox Cmb_ItemName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public System.Windows.Forms.ComboBox Cmb_StoreName;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        public DevExpress.XtraEditors.SimpleButton Btn_Distrub;
        public DevExpress.XtraEditors.LabelControl Lbl2_ID;
        public DevExpress.XtraEditors.LabelControl Lbl1_ID;
    }
}