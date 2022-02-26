using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;
using Library.DAL;
namespace Library.Reports
{
    public partial class Frm_VenActionsRp : XtraForm
    {
        public Frm_VenActionsRp()
        {
            InitializeComponent();
        }

        private void Frm_Repo2tr_Load(object sender, EventArgs e)
        {
            Dgv_Shearch.DataSource = RetriveData.Executequery("VendorsActions", CommandType.StoredProcedure);
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you Want Print Action", "Print", MessageBoxButtons.YesNo,
             MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dgv_Shearch.ShowPrintPreview();
            }
        }
    }
}