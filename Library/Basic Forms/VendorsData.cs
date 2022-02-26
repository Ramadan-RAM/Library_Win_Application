using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Library.DAL;
using static Library.DAL.RetriveData;


namespace Library.Basic_Forms
{
    public partial class VendorsData : Inherit
    {
        public VendorsData()
        {
            InitializeComponent();
        }

        private bool _addnew = false;
        private readonly Cl_Validate _Valid = new Cl_Validate();

        #region BindCombo

        private void BindData()

        {
            //Bind Vendor Name
            FillCombo.FillVendors(Cmb_Shearch);

            //BindGrid
            Dgv_Shearch.DataSource = Executequery("Sp_VendorsSelectAll", CommandType.StoredProcedure);
        }
        #endregion


        private void Btn_New_Click(object sender, EventArgs e)
        {
            #region
            if (XtraMessageBox.Show("Are you sure to add New Vendor", "Done",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _Valid.TxtClear(this, Pnl_BasicData);
                _addnew = true;

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

            if (XtraMessageBox.Show("Are you Sure to Save New Vendor", "Save",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                #region suredata
                if (Txt_Name.Text == "")
                {
                    _ = XtraMessageBox.Show("Sorry Enter Vendor Name");
                    return;
                }

                if (Txt_Mob.Text == "")
                {
                    Txt_Mob.Text = "0";
                }

                if (Txt_Phone.Text == "")
                {
                    Txt_Phone.Text = "0";
                }
                #endregion

                #region SaveData 
                ExecuteNonquery("Sp_VendorsInsert",
            new Pararmeter("@Ven_Name", SqlDbType.NVarChar, Txt_Name.Text),
            new Pararmeter("@Ven_Address", SqlDbType.NVarChar, Txt_Address.Text),
            new Pararmeter("@Ven_Mobaile", SqlDbType.NVarChar, Txt_Mob.Text),
                new Pararmeter("@Ven_Phone", SqlDbType.NVarChar, Txt_Phone.Text),
            new Pararmeter("@Ven_Notes", SqlDbType.NVarChar, Txt_Notes.Text),
            new Pararmeter("@User_ID", SqlDbType.Int, Login.UserID));
                #endregion
                _ = XtraMessageBox.Show("Save Done");
                _Valid.TxtClear(this, Pnl_BasicData);
                _addnew = false;
                Lbl_ID.Text = "0";
                BindData();
            }
        }

        private void VendorsData_Load(object sender, EventArgs e)
        {

            BindData();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (Cmb_Shearch.Text != "")
            {
                _ = new DataTable();
                DataTable dt = Executequery("Sp_VendorsSelectAllByID", CommandType.StoredProcedure, new Pararmeter
                     ("@Ven_ID", SqlDbType.Int, int.Parse(Cmb_Shearch.SelectedValue.ToString())));

                Lbl_ID.Text = dt.Rows[0]["Ven_ID"].ToString();
                Txt_Name.Text = dt.Rows[0]["Ven_Name"].ToString();
                Txt_Address.Text = dt.Rows[0]["Ven_Address"].ToString();
                Txt_Phone.Text = dt.Rows[0]["Ven_Phone"].ToString();
                Txt_Mob.Text = dt.Rows[0]["Ven_Mobaile"].ToString();
                Txt_Notes.Text = dt.Rows[0]["Ven_Notes"].ToString();

            }
        }


        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (Lbl_ID.Text != "0")
            {
                if (XtraMessageBox.Show("Are you Sure to Update Vendor", "Save",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    #region suredata
                    if (Txt_Name.Text == "")
                    {
                        _ = XtraMessageBox.Show("Sorry Enter Vendor Name");
                        return;
                    }

                    if (Txt_Mob.Text == "")
                    {
                        Txt_Mob.Text = "0";
                    }

                    if (Txt_Phone.Text == "")
                    {
                        Txt_Phone.Text = "0";
                    }
                    #endregion

                    #region UpdateData 
                    ExecuteNonquery("Sp_VendorsUpdate",
                new Pararmeter("@Ven_ID", SqlDbType.Int, int.Parse(Lbl_ID.Text)),
                new Pararmeter("@Ven_Name", SqlDbType.NVarChar, Txt_Name.Text),
                new Pararmeter("@Ven_Address", SqlDbType.NVarChar, Txt_Address.Text),
                new Pararmeter("@Ven_Mobaile", SqlDbType.NVarChar, Txt_Mob.Text),
                new Pararmeter("@Ven_Phone", SqlDbType.NVarChar, Txt_Phone.Text),
                new Pararmeter("@Ven_Notes", SqlDbType.NVarChar, Txt_Notes.Text),
                new Pararmeter("@User_ID", SqlDbType.Int, Login.UserID));
                    #endregion
                    _ = XtraMessageBox.Show("Update Done");
                    _Valid.TxtClear(this, Pnl_BasicData);
                    Lbl_ID.Text = "0";
                    BindData();
                }
            }
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            if (Lbl_ID.Text != "0")
            {
                if (XtraMessageBox.Show("Are you Sure to Delete Vendor", "Delete",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ExecuteNonquery("Sp_VendorsDelete",
                new Pararmeter("@Ven_ID", SqlDbType.Int, int.Parse(Lbl_ID.Text)));
                }

                _ = XtraMessageBox.Show("Delete Done");
                _Valid.TxtClear(this, Pnl_BasicData);
                Lbl_ID.Text = "0";
                BindData();
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Dgv_Shearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Lbl_ID.Text = gridView1.GetFocusedRowCellValue("Ven_ID").ToString();
                Txt_Name.Text = gridView1.GetFocusedRowCellValue("Ven_Name").ToString();
                Txt_Address.Text = gridView1.GetFocusedRowCellValue("Ven_Address").ToString();
                Txt_Phone.Text = gridView1.GetFocusedRowCellValue("Ven_Phone").ToString();
                Txt_Mob.Text = gridView1.GetFocusedRowCellValue("Ven_Mobaile").ToString();
                Txt_Notes.Text = gridView1.GetFocusedRowCellValue("Ven_Notes").ToString();
                Cmb_Shearch.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("Ven_ID").ToString());
            }
        }

        private void Txt_Mob_EditValueChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Txt_Mob.Text, "[^0-9]"))
            {
                _ = XtraMessageBox.Show("Please enter only numbers.");
                Txt_Mob.Text = Txt_Mob.Text.Remove(Txt_Mob.Text.Length - 1);
            }
        }

        private void Txt_Phone_EditValueChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Txt_Phone.Text, "[^0-9]"))
            {
                _ = XtraMessageBox.Show("Please enter only numbers.");
                Txt_Phone.Text = Txt_Phone.Text.Remove(Txt_Phone.Text.Length - 1);
            }
        }
    }
}