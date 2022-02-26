using DevExpress.XtraEditors;
using System.Data;
using System.Windows.Forms;
using static Library.DAL.RetriveData;

namespace Library.Reports
{
    public partial class Frm_CustActionsRp : XtraForm
    {
        public Frm_CustActionsRp()
        {
            InitializeComponent();
        }

        private void Frm_Repo1tr_Load(object sender, System.EventArgs e)
        {
            Dgv_Shearch.DataSource = Executequery("Sp_ActionsCustomers", CommandType.StoredProcedure);
        }

        private void BtnPrint_Click(object sender, System.EventArgs e)
        {
            if (XtraMessageBox.Show("Do you Want Print Action", "Print", MessageBoxButtons.YesNo,
             MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dgv_Shearch.ShowPrintPreview();
            }
        }
    }
}