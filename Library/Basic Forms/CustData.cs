using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Library.DAL;
using static Library.DAL.RetriveData;


namespace Library.Basic_Forms
{
    public partial class CustData : Inherit
    {
        public CustData()
        {
            InitializeComponent();
        }

        private bool _addnew = false;
        private readonly Cl_Validate _Valid = new Cl_Validate();

        #region BindCombo

        private void BindData()

        {
            //Bind Customers
            FillCombo.FillCustomer(Cmb_Shearch);

            //BindGrid
            Dgv_Shearch.DataSource = Executequery("Sp_CustomersSelectAll", CommandType.StoredProcedure);
        }
        #endregion


        private void Btn_New_Click(object sender, EventArgs e)
        {
            #region
            if (XtraMessageBox.Show("Are you sure to add Customer", "Done",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _Valid.TxtClear(this, Pnl_BasicData);
                _addnew = true;
                Lbl_ID.Text = "0";
                BindData();
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

            if (XtraMessageBox.Show("Are you Sure to Save New Customer", "Save",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                #region suredata
                if (Txt_Name.Text == "")
                {
                    _ = XtraMessageBox.Show("Sorry Enter Customer Name");
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
                ExecuteNonquery("Sp_CustomersInsert",
            new Pararmeter("@Cust_Name", SqlDbType.NVarChar, Txt_Name.Text),
            new Pararmeter("@Cust_Address", SqlDbType.NVarChar, Txt_Address.Text),
            new Pararmeter("@Cust_Mobaile", SqlDbType.NVarChar, Txt_Mob.Text),
            new Pararmeter("@Cust_Phone", SqlDbType.NVarChar, Txt_Phone.Text),
            new Pararmeter("@Cust_Notes", SqlDbType.NVarChar, Txt_Notes.Text),
            new Pararmeter("@User_ID", SqlDbType.Int, Login.UserID));
                #endregion
                _Valid.TxtClear(this, Pnl_BasicData);
                _addnew = false;
                _ = XtraMessageBox.Show("Save Done");
                BindData();
            }

        }

        private void CustData_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (Cmb_Shearch.Text != "")
            {
                _ = new DataTable();
                DataTable dt = Executequery("Sp_CustomersSelectByID", CommandType.StoredProcedure, new Pararmeter
                     ("@Cust_ID", SqlDbType.Int, int.Parse(Cmb_Shearch.SelectedValue.ToString())));

                Lbl_ID.Text = dt.Rows[0]["Cust_ID"].ToString();
                Txt_Name.Text = dt.Rows[0]["Cust_Name"].ToString();
                Txt_Address.Text = dt.Rows[0]["Cust_Address"].ToString();
                Txt_Phone.Text = dt.Rows[0]["Cust_Phone"].ToString();
                Txt_Mob.Text = dt.Rows[0]["Cust_Mobaile"].ToString();
                Txt_Notes.Text = dt.Rows[0]["Cust_Notes"].ToString();

            }
        }


        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (Lbl_ID.Text != "0")
            {
                if (XtraMessageBox.Show("Are you Sure to Update Customer", "Save",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    #region suredata
                    if (Txt_Name.Text == "")
                    {
                        _ = XtraMessageBox.Show("Sorry Enter Customer Name");
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
                    ExecuteNonquery("Sp_CustomersUpdate",
                new Pararmeter("@Cust_ID", SqlDbType.Int, DAL.Help.ToInt(Lbl_ID.Text)),
                new Pararmeter("@Cust_Name", SqlDbType.NVarChar, Txt_Name.Text),
                new Pararmeter("@Cust_Address", SqlDbType.NVarChar, Txt_Address.Text),
                new Pararmeter("@Cust_Mobaile", SqlDbType.NVarChar, Txt_Mob.Text),
                new Pararmeter("@Cust_Phone", SqlDbType.NVarChar, Txt_Phone.Text),
                new Pararmeter("@Cust_Notes", SqlDbType.NVarChar, Txt_Notes.Text),
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
                if (XtraMessageBox.Show("Are you Sure to Delete Customer", "Delete",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ExecuteNonquery("Sp_CustomersDelete",
                new Pararmeter("@Cust_ID", SqlDbType.Int, int.Parse(Lbl_ID.Text)));
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
                Lbl_ID.Text = gridView1.GetFocusedRowCellValue("Cust_ID").ToString();
                Txt_Name.Text = gridView1.GetFocusedRowCellValue("Cust_Name").ToString();
                Txt_Address.Text = gridView1.GetFocusedRowCellValue("Cust_Address").ToString();
                Txt_Phone.Text = gridView1.GetFocusedRowCellValue("Cust_Phone").ToString();
                Txt_Mob.Text = gridView1.GetFocusedRowCellValue("Cust_Mobaile").ToString();
                Txt_Notes.Text = gridView1.GetFocusedRowCellValue("Cust_Notes").ToString();
                Cmb_Shearch.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("Cust_ID").ToString());
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

