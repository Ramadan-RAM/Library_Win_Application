using System;
using System.Data;
using Library.DAL;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using static Library.DAL.RetriveData;

namespace Library.Basic_Forms

{
    public partial class StoreData : Inherit
    {
        public StoreData()
        {
            InitializeComponent();
        }

        private bool _addnew = false;
        private readonly Cl_Validate _Valid = new Cl_Validate();

        #region BindData

        private void BindData()
        {

            //Bind Store
            FillCombo.FillStore(Cmb_Shearch);

            //Bind Employee
            FillCombo.FillEmployees(Cmb_MangName);

            //BindGrid
            Dgv_Shearch.DataSource = Executequery("Sp_Store_DataSelectAll", CommandType.StoredProcedure);
        }

        #endregion

        private void StoreData_Load(object sender, EventArgs e)
        {
            BindData();
        }

        [Obsolete]
        private void Btn_New_Click(object sender, EventArgs e)
        {
            #region
            if (XtraMessageBox.Show("Are you sure to add New Store", "Done",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _Valid.TxtClear(this, Pnl_BasicData);
                _addnew = true;
                Lbl_ID.Text = "0";
            }
            #endregion
        }

        [Obsolete]
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (_addnew == false)
            {
                _ = XtraMessageBox.Show("Please Click On New First");
                return;
            }

            if (XtraMessageBox.Show("Are you Sure to Save New Store", "Save",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                #region suredata
                if (Txt_Name.Text == "")
                {
                    _ = XtraMessageBox.Show("Sorry Enter Store Name");
                    return;
                }

                #endregion

                #region SaveData 
                ExecuteNonquery("Sp_Store_DataInsert",
            new Pararmeter("@Store_Name", SqlDbType.NVarChar, Txt_Name.Text),
            new Pararmeter("@Emp_ID", SqlDbType.Int, int.Parse(Cmb_MangName.SelectedValue.ToString())),
            new Pararmeter("@Store_Address", SqlDbType.NVarChar, Txt_Address.Text),
            new Pararmeter("@Store_Notes", SqlDbType.NVarChar, Txt_Notes.Text),
            new Pararmeter("@User_ID", SqlDbType.Int, Login.UserID));
                #endregion
                _ = XtraMessageBox.Show("Save Done");
                _Valid.TxtClear(this, Pnl_BasicData);
                _addnew = false;
                BindData();
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (Cmb_Shearch.Text != "")
            {
                _ = new DataTable();
                DataTable dt = Executequery("Sp_Store_DataSelectAllByID", CommandType.StoredProcedure, new Pararmeter
                     ("@Store_ID", SqlDbType.Int, int.Parse(Cmb_Shearch.SelectedValue.ToString())));

                Lbl_ID.Text = dt.Rows[0]["Store_ID"].ToString();
                Txt_Name.Text = dt.Rows[0]["Store_Name"].ToString();
                Txt_Address.Text = dt.Rows[0]["Store_Address"].ToString();
                Txt_Notes.Text = dt.Rows[0]["Store_Notes"].ToString();
                Cmb_MangName.Text = dt.Rows[0]["Emp_Name"].ToString();


            }
        }

        [Obsolete]
        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (Lbl_ID.Text != "0")
            {
                if (XtraMessageBox.Show("Are you Sure to Update Store", "Save",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    #region suredata
                    if (Txt_Name.Text == "")
                    {
                        _ = XtraMessageBox.Show("Sorry Enter Store Name");
                        return;
                    }

                    #endregion

                    #region UpdateData 
                    ExecuteNonquery("Sp_Store_DataUpdate",
                new Pararmeter("@Store_ID", SqlDbType.Int, int.Parse(Lbl_ID.Text)),
                new Pararmeter("@Emp_ID", SqlDbType.Int, int.Parse(Cmb_MangName.SelectedValue.ToString())),
                new Pararmeter("@Store_Name", SqlDbType.NVarChar, Txt_Name.Text),
                new Pararmeter("@Store_Address", SqlDbType.NVarChar, Txt_Address.Text),
                new Pararmeter("@Store_Notes", SqlDbType.NVarChar, Txt_Notes.Text),
                new Pararmeter("@User_ID", SqlDbType.Int, Login.UserID));
                    #endregion
                    _ = XtraMessageBox.Show("Update Done");
                    _Valid.TxtClear(this, Pnl_BasicData);
                    Lbl_ID.Text = "0";
                    BindData();
                }
            }
        }

        [Obsolete]
        private void Btn_Del_Click(object sender, EventArgs e)
        {
            if (Lbl_ID.Text != "0")
            {
                if (XtraMessageBox.Show("Are you Sure to Delete Store", "Delete",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ExecuteNonquery("Sp_Store_DataDelete",
                new Pararmeter("@Store_ID", SqlDbType.Int, int.Parse(Lbl_ID.Text)));
                }

                _ = XtraMessageBox.Show("Delete Done");
                _Valid.TxtClear(this, Pnl_BasicData);
                Lbl_ID.Text = "0";
                BindData();
            }
        }

        private void Dgv_Shearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Lbl_ID.Text = gridView1.GetFocusedRowCellValue("Store_ID").ToString();
                Txt_Name.Text = gridView1.GetFocusedRowCellValue("Store_Name").ToString();
                Txt_Address.Text = gridView1.GetFocusedRowCellValue("Store_Address").ToString();
                Txt_Notes.Text = gridView1.GetFocusedRowCellValue("Store_Notes").ToString();
                Cmb_MangName.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("Emp_ID").ToString());
                Cmb_Shearch.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("Store_ID").ToString());
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }

}