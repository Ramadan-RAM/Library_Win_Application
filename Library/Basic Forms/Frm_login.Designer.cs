
namespace Library.Basic_Forms
{
    partial class Frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_login));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.Btn_Cancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Library.Basic_Forms.WaitForm1), true, true);
            this.Btn_log = new MaterialSkin.Controls.MaterialFlatButton();
            this.Txt_User = new JTextBox.JText_Box();
            this.Txt_Pass = new JTextBox.JText_Box();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(14, 101);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(92, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "User Name: ";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(23, 151);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(83, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Password: ";
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.AutoSize = true;
            this.Btn_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Cancel.Depth = 0;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Icon = null;
            this.Btn_Cancel.Location = new System.Drawing.Point(194, 238);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Btn_Cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Primary = false;
            this.Btn_Cancel.Size = new System.Drawing.Size(73, 36);
            this.Btn_Cancel.TabIndex = 5;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(169, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 50;
            // 
            // Btn_log
            // 
            this.Btn_log.AutoSize = true;
            this.Btn_log.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_log.Depth = 0;
            this.Btn_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_log.Icon = null;
            this.Btn_log.Location = new System.Drawing.Point(196, 190);
            this.Btn_log.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Btn_log.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_log.Name = "Btn_log";
            this.Btn_log.Primary = false;
            this.Btn_log.Size = new System.Drawing.Size(61, 36);
            this.Btn_log.TabIndex = 4;
            this.Btn_log.Text = "Login";
            this.Btn_log.UseVisualStyleBackColor = true;
            this.Btn_log.Click += new System.EventHandler(this.Btn_log_Click);
            // 
            // Txt_User
            // 
            this.Txt_User.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_User.BorderThickness = 3;
            this.Txt_User.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_User.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_User.FontStyles = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_User.ForeColor = System.Drawing.Color.White;
            this.Txt_User.Location = new System.Drawing.Point(106, 89);
            this.Txt_User.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Txt_User.MaxLength = 32767;
            this.Txt_User.Name = "Txt_User";
            this.Txt_User.onFocusBorderColor = System.Drawing.Color.Gold;
            this.Txt_User.PasswordChar = '\0';
            this.Txt_User.RoundedBorder = 15;
            this.Txt_User.Size = new System.Drawing.Size(259, 40);
            this.Txt_User.TabIndex = 7;
            this.Txt_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_User.TextColor = System.Drawing.Color.White;
            this.Txt_User.TextInput = "";
            this.Txt_User.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_User_KeyUp);
            // 
            // Txt_Pass
            // 
            this.Txt_Pass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_Pass.BorderThickness = 3;
            this.Txt_Pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Pass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Pass.FontStyles = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Pass.ForeColor = System.Drawing.Color.White;
            this.Txt_Pass.Location = new System.Drawing.Point(106, 139);
            this.Txt_Pass.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Txt_Pass.MaxLength = 32767;
            this.Txt_Pass.Name = "Txt_Pass";
            this.Txt_Pass.onFocusBorderColor = System.Drawing.Color.Gold;
            this.Txt_Pass.PasswordChar = '*';
            this.Txt_Pass.RoundedBorder = 15;
            this.Txt_Pass.Size = new System.Drawing.Size(259, 40);
            this.Txt_Pass.TabIndex = 8;
            this.Txt_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Pass.TextColor = System.Drawing.Color.White;
            this.Txt_Pass.TextInput = "";
            this.Txt_Pass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Pass_KeyUp);
            // 
            // Frm_login
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 280);
            this.Controls.Add(this.Txt_Pass);
            this.Controls.Add(this.Txt_User);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_log);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Frm_login.IconOptions.Image")));
            this.IconOptions.LargeImage = global::Library.Properties.Resources.bouser_32x322;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sing UP";
            this.Load += new System.EventHandler(this.Frm_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        public MaterialSkin.Controls.MaterialFlatButton Btn_Cancel;
        public MaterialSkin.Controls.MaterialFlatButton Btn_log;
        public JTextBox.JText_Box Txt_User;
        public JTextBox.JText_Box Txt_Pass;
    }
}