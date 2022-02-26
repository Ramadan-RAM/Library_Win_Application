using DevExpress.XtraEditors;
//using Library.DAL;
//using static Library.DAL.RetriveData;
//using System.Threading;
using System.Windows.Forms;
using System;

//using System.Windows;

namespace Library.Basic_Forms
{
    public partial class Frm_login : XtraForm
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {

        }

        //private readonly DBConnect _con = new DBConnect();
        private void Btn_log_Click(object sender, EventArgs e)
        {

            if (Txt_User.TextInput == "" || Txt_Pass.TextInput == "")
            {
                _ = XtraMessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                Dispose();
            }
            catch (Exception ex)
            {
                _ = XtraMessageBox.Show(ex.Message);
            }

        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Txt_User_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                _ = Txt_Pass.Focus();
            }
        }

        private void Txt_Pass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _ = Btn_log.Focus();
            }
        }
    }
}
