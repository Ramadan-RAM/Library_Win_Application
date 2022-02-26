using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Library.DAL;
using static Library.DAL.RetriveData;

namespace Library.Basic_Forms
{
    public partial class JobType : XtraForm
    {
        public JobType()
        {
            InitializeComponent();
        }

        private bool _addnew = false;

        private void JobType_Load(object sender, EventArgs e)
        {

            BindGrid();
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            #region
            if (XtraMessageBox.Show("Are you Sure to add new Job Type", "Done",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Txt_Job.Text = "";
                _addnew = true;
                Lbl_ID.Text = "0";
            }
            #endregion
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (_addnew == false)
            {
                _ = XtraMessageBox.Show("Please Click On New First");
                return;
            }

            if (XtraMessageBox.Show("Are you Sure to Save new Job Type", "Save",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                #region suredata
                if (Txt_Job.Text == "")
                {
                    _ = XtraMessageBox.Show("Please Inter Job Type");
                }
                #endregion

                #region SaveData 
                ExecuteNonquery("Sp_Job_TypeInsert",
            new Pararmeter("@Job_Name", SqlDbType.NVarChar, Txt_Job.Text),
            new Pararmeter("@User_ID", SqlDbType.Int, Login.UserID));
                #endregion
                _ = XtraMessageBox.Show("Save Done");
                _addnew = false;
                Txt_Job.Text = "";
                BindGrid();
            }
        }

        #region BindGrid
        private void BindGrid()
        {
            Dgd_Shearch.DataSource = Executequery("Sp_Job_TypeSelectAll", CommandType.StoredProcedure);
        }
        #endregion

        private void Dgd_Shearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                Lbl_ID.Text = gridView1.GetFocusedRowCellValue("Job_ID").ToString();
                Txt_Job.Text = gridView1.GetFocusedRowCellValue("Job_Name").ToString();
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (Lbl_ID.Text != "0")
            {
                if (XtraMessageBox.Show("Are you Sure to Update Job Type", "Save",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    #region suredata
                    if (Txt_Job.Text == "")
                    {
                        _ = XtraMessageBox.Show("Sorry Enter Job Type");
                        return;
                    }
                    #endregion

                    #region UpdateData 
                    ExecuteNonquery("Sp_Job_TypeUpdate",
                new Pararmeter("@Job_ID", SqlDbType.Int, int.Parse(Lbl_ID.Text)),
                new Pararmeter("@Job_Name", SqlDbType.NVarChar, Txt_Job.Text),
                new Pararmeter("@User_ID", SqlDbType.Int, Login.UserID));
                    #endregion
                    _ = XtraMessageBox.Show("Update Done");
                    Lbl_ID.Text = "0";
                    Txt_Job.Text = "";
                    BindGrid();
                }
            }
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            if (Lbl_ID.Text != "0")
            {
                if (XtraMessageBox.Show("Are you Sure to Delete Job Type", "Delete",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ExecuteNonquery("Sp_Job_TypeDelete",
                new Pararmeter("@Job_ID", SqlDbType.Int, int.Parse(Lbl_ID.Text)));
                }

                _ = XtraMessageBox.Show("Delete Done");
                Lbl_ID.Text = "0";
                Txt_Job.Text = "";
                BindGrid();
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}