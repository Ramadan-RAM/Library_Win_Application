using DevExpress.XtraEditors;
using System;
using static Library.DAL.RetriveData;
using System.Data;
using System.Windows.Forms;
using Library.DAL;
using MaterialSkin.Controls;

namespace Library.Basic_Forms
{
    public partial class UsersData : XtraForm
    {
        public UsersData()
        {
            InitializeComponent();
        }

        private bool _addnew = false;
        private readonly Cl_Validate _Valid = new Cl_Validate();

        #region BindData
        private void BindData()
        {
            //Bind Users Name
            FillCombo.FillUsers(Cmb_User);

            //BindGrid
            Dgv_Shearch.DataSource = Executequery("Sp_UserInfoSelectAll", CommandType.StoredProcedure);
        }

        #endregion

        private void UsersData_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            #region
            if (XtraMessageBox.Show("Are you sure to add New User", "Done",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _Valid.TxtClear(this, Pnl_BasicData);
                _addnew = true;
                BindData();
            }
            #endregion

            foreach (Control c in Pnl_BasicData.Controls)
            {
                if (c is MaterialCheckBox cb)
                {
                    if (cb.Checked == true)
                    {
                        cb.Checked = false;
                    }
                }
            }
        }

        private void Btn_Save_Click_1(object sender, EventArgs e)
        {
            if (_addnew == false)
            {
                _ = XtraMessageBox.Show("Please Click On New First");
                return;
            }

            if (XtraMessageBox.Show("Are you Sure to Save New Item", "Save",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                #region suredata
                if (Txt_UserName.Text == "")
                {
                    _ = XtraMessageBox.Show("Sorry Enter User Name");
                    return;
                }

                if (Txt_Password.Text == "")
                {
                    _ = XtraMessageBox.Show("Please Enter Password");
                    return;
                }

                #endregion

                #region SaveData 
                ExecuteNonquery("Sp_UserInfoInsert",
                _ = new Pararmeter("@User_Name", SqlDbType.NVarChar, Txt_UserName.Text),
                _ = new Pararmeter("@User_Password", SqlDbType.NVarChar, Txt_Password.Text),
                _ = new Pararmeter("@IsAdmin", SqlDbType.Bit, chek_IsAdmin.Checked),
                _ = new Pararmeter("@AddCustomers", SqlDbType.Bit, chek_AddCust.Checked),
                _ = new Pararmeter("@AddVendors", SqlDbType.Bit, chek_AddVen.Checked),
                _ = new Pararmeter("@AddEmployee_Jobs", SqlDbType.Bit, chek_Emp_job.Checked),
                _ = new Pararmeter("@AddPayedCustomer", SqlDbType.Bit, chek_PayedCust.Checked),
                _ = new Pararmeter("@AddPayedVendor", SqlDbType.Bit, chek_AddVen.Checked),
                _ = new Pararmeter("@AddItems_Category", SqlDbType.Bit, chek_Item_Cat.Checked),
                _ = new Pararmeter("@AddStoreData_Qun_Conv", SqlDbType.Bit, chek_Stor_Qun.Checked),
                _ = new Pararmeter("@AddDisRp", SqlDbType.Bit, chek_DesignRp.Checked));
                #endregion
                _ = XtraMessageBox.Show("Save Done");
                _Valid.TxtClear(this, Pnl_BasicData);
                Lbl_ID.Text = "0";
                _addnew = false;
                BindData();

                foreach (Control c in Pnl_BasicData.Controls)
                {
                    if (c is MaterialCheckBox cb)
                    {
                        if (cb.Checked == true)
                        {
                            cb.Checked = false;
                        }
                    }
                }
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (_addnew == false)
            {
                _ = XtraMessageBox.Show("Please Click On New First");
                return;
            }

            if (XtraMessageBox.Show("Are you Sure to Update User", "Update",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                #region suredata

                if (Cmb_User.Text == "")
                {
                    _ = XtraMessageBox.Show("Please Select User");
                    return;
                }

                #endregion

                #region UpdateData 
                ExecuteNonquery("Sp_UserInfoUpdate",
                _ = new Pararmeter("@User_Name", SqlDbType.NVarChar, Txt_UserName.Text),
                _ = new Pararmeter("@User_Password", SqlDbType.NVarChar, Txt_Password.Text),
                _ = new Pararmeter("@IsAdmin", SqlDbType.Bit, chek_IsAdmin.Checked),
                _ = new Pararmeter("@AddCustomers", SqlDbType.Bit, chek_AddCust.Checked),
                _ = new Pararmeter("@AddVendors", SqlDbType.Bit, chek_AddVen.Checked),
                _ = new Pararmeter("@AddEmployee_Jobs", SqlDbType.Bit, chek_Emp_job.Checked),
                _ = new Pararmeter("@AddPayedCustomer", SqlDbType.Bit, chek_PayedCust.Checked),
                _ = new Pararmeter("@AddPayedVendor", SqlDbType.Bit, chek_AddVen.Checked),
                _ = new Pararmeter("@AddItems_Category", SqlDbType.Bit, chek_Item_Cat.Checked),
                _ = new Pararmeter("@AddStoreData_Qun_Conv", SqlDbType.Bit, chek_Stor_Qun.Checked),
                _ = new Pararmeter("@AddDisRp", SqlDbType.Bit, chek_DesignRp.Checked),
                _ = new Pararmeter("@User_ID", SqlDbType.Int, int.Parse(Lbl_ID.Text)));
                #endregion
                _ = XtraMessageBox.Show("Updated Done");
                _Valid.TxtClear(this, Pnl_BasicData);
                Lbl_ID.Text = "0";
                _addnew = false;
                BindData();

                foreach (Control c in Pnl_BasicData.Controls)
                {
                    if (c is MaterialCheckBox cb)
                    {
                        if (cb.Checked == true)
                        {
                            cb.Checked = false;
                        }
                    }
                }
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (Cmb_User.Text != "")
            {
                _ = new DataTable();
                DataTable dt = Executequery("Sp_UserInfoSelectAllByID", CommandType.StoredProcedure, new Pararmeter
                     ("@User_ID", SqlDbType.Int, int.Parse(Cmb_User.SelectedValue.ToString())));

                Lbl_ID.Text = dt.Rows[0]["User_ID"].ToString();
                Txt_UserName.Text = dt.Rows[0]["User_Name"].ToString();
                Txt_Password.Text = dt.Rows[0]["User_Password"].ToString();
                chek_IsAdmin.Checked = dt.Rows[0]["IsAdmin"].Equals(true);
                chek_AddCust.Checked = dt.Rows[0]["AddCustomers"].Equals(true);
                chek_AddVen.Checked = dt.Rows[0]["AddVendors"].Equals(true);
                chek_Emp_job.Checked = dt.Rows[0]["AddEmployee_Jobs"].Equals(true);
                chek_PayedCust.Checked = dt.Rows[0]["AddPayedCustomer"].Equals(true);
                chek_PayedVen.Checked = dt.Rows[0]["AddPayedVendor"].Equals(true);
                chek_Item_Cat.Checked = dt.Rows[0]["AddItems_Category"].Equals(true);
                chek_Stor_Qun.Checked = dt.Rows[0]["AddStoreData_Qun_Conv"].Equals(true);
                chek_DesignRp.Checked = dt.Rows[0]["AddDisRp"].Equals(true);

            }
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you Sure to Delete User", "Delete",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region DeleteData 
                ExecuteNonquery("Sp_UserInfoDelete",
            new Pararmeter("@User_ID", SqlDbType.Int, int.Parse(Lbl_ID.Text)));

                #endregion
                _ = XtraMessageBox.Show("Delete Done");
                _addnew = false;
                Lbl_ID.Text = "0";
                BindData();

                foreach (Control c in Pnl_BasicData.Controls)
                {
                    if (c is MaterialCheckBox cb)
                    {
                        if (cb.Checked == true)
                        {
                            cb.Checked = false;
                        }
                    }
                }

            }
        }

        private void Btn_SelectAll_Click(object sender, EventArgs e)
        {
            foreach (Control c in Pnl_BasicData.Controls)
            {
                if (c is MaterialCheckBox cb)
                {
                    if (cb.Checked == false)
                    {
                        cb.Checked = true;
                    }
                    else
                        if (cb.Checked == true)
                    {
                        cb.Checked = false;
                    }
                }
            }
        }
    }
}