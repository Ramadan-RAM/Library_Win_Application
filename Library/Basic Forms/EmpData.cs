using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Library.DAL;
using static Library.DAL.RetriveData;

namespace Library.Basic_Forms
{
    public partial class EmpData : Inherit
    {
        public EmpData()
        {
            InitializeComponent();
        }

        private bool _addnew = false;
        private readonly Cl_Validate _Valid = new Cl_Validate();

        #region BindData
        private void BindData()
        {
            //Bind Type Job
            FillCombo.FillTypeJob(Cmb_JobTyp);

            //Bind Employee
            FillCombo.FillEmployees(Cmb_Shearch);

            //BindGrid
            Dgv_Shearch.DataSource = Executequery("Sp_EmployeesSelectAll", CommandType.StoredProcedure);
        }

        #endregion

        private void EmpData_Load(object sender, EventArgs e)
        {

            BindData();
        }

        [Obsolete]
        private void Btn_New_Click(object sender, EventArgs e)
        {
            #region
            if (XtraMessageBox.Show("Are you sure to add New Employee", "Done",
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

            if (XtraMessageBox.Show("Are you Sure to Save New Employee", "Save",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                #region suredata
                if (Txt_Name.Text == "")
                {
                    _ = XtraMessageBox.Show("Sorry Enter Employee Name");
                    return;
                }

                if (TxtID_No.Text == "")
                {
                    _ = XtraMessageBox.Show("Sorry Enter Employee NumberID");
                    return;
                }

                if (Txt_Salry.Text == "")
                {
                    _ = XtraMessageBox.Show("Sorry Enter Employee Salry");
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
                ExecuteNonquery("Sp_EmployeesInsert",
            new Pararmeter("@Emp_Name", SqlDbType.NVarChar, Txt_Name.Text),
            new Pararmeter("@Job_ID", SqlDbType.Int, DAL.Help.ToInt(Cmb_JobTyp.SelectedValue.ToString())),
            new Pararmeter("@Emp_Address", SqlDbType.NVarChar, Txt_Address.Text),
            new Pararmeter("@Emp_Mobaile", SqlDbType.NVarChar, Txt_Mob.Text),
            new Pararmeter("@Emp_Phone", SqlDbType.NVarChar, Txt_Phone.Text),
            new Pararmeter("@Persoanal_ID", SqlDbType.NVarChar, TxtID_No.Text),
            new Pararmeter("@Basic_Salary", SqlDbType.Decimal, DAL.Help.ToDecimal(Txt_Salry.Text)),
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
                DataTable dt = Executequery("Sp_EmployeesSelectAllByID", CommandType.StoredProcedure, new Pararmeter
                     ("@Emp_ID", SqlDbType.Int, int.Parse(Cmb_Shearch.SelectedValue.ToString())));

                Lbl_ID.Text = dt.Rows[0]["Emp_ID"].ToString();
                Txt_Name.Text = dt.Rows[0]["Emp_Name"].ToString();
                Txt_Address.Text = dt.Rows[0]["Emp_Address"].ToString();
                Txt_Phone.Text = dt.Rows[0]["Emp_Phone"].ToString();
                Txt_Mob.Text = dt.Rows[0]["Emp_Mobaile"].ToString();
                TxtID_No.Text = dt.Rows[0]["Persoanal_ID"].ToString();
                Txt_Salry.Text = dt.Rows[0]["Basic_Salary"].ToString();
                Cmb_JobTyp.Text = dt.Rows[0]["Job_Name"].ToString();


            }
        }

        [Obsolete]
        private void Btn_Edit_Click(object sender, EventArgs e)
        {

            if (Lbl_ID.Text != "0")
            {
                if (XtraMessageBox.Show("Are you Sure to Update Employee", "Save",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    #region suredata
                    if (Txt_Name.Text == "")
                    {
                        _ = XtraMessageBox.Show("Sorry Enter Employee Name");
                        return;
                    }

                    if (TxtID_No.Text == "")
                    {
                        _ = XtraMessageBox.Show("Sorry Enter Employee NumberID");
                        return;
                    }

                    if (Txt_Salry.Text == "")
                    {
                        _ = XtraMessageBox.Show("Sorry Enter Employee BasicSalry");
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
                    ExecuteNonquery("Sp_EmployeesUpdate",
                new Pararmeter("@Emp_ID", SqlDbType.Int, DAL.Help.ToInt(Lbl_ID.Text)),
                new Pararmeter("@Job_ID", SqlDbType.Int, DAL.Help.ToInt(Cmb_JobTyp.SelectedValue.ToString())),
                new Pararmeter("@Emp_Name", SqlDbType.NVarChar, Txt_Name.Text),
                new Pararmeter("@Emp_Address", SqlDbType.NVarChar, Txt_Address.Text),
                new Pararmeter("@Emp_Mobaile", SqlDbType.NVarChar, Txt_Mob.Text),
                new Pararmeter("@Emp_Phone", SqlDbType.NVarChar, Txt_Phone.Text),
                new Pararmeter("@Persoanal_ID", SqlDbType.NVarChar, TxtID_No.Text),
                new Pararmeter("@Basic_Salary", SqlDbType.Decimal, DAL.Help.ToDecimal(Txt_Salry.Text)),
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
                if (XtraMessageBox.Show("Are you Sure to Delete Employee", "Delete",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ExecuteNonquery("Sp_EmployeesDelete",
                new Pararmeter("@Emp_ID", SqlDbType.Int, int.Parse(Lbl_ID.Text)));
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
                Lbl_ID.Text = gridView1.GetFocusedRowCellValue("Emp_ID").ToString();
                Txt_Name.Text = gridView1.GetFocusedRowCellValue("Emp_Name").ToString();
                Txt_Address.Text = gridView1.GetFocusedRowCellValue("Emp_Address").ToString();
                Txt_Phone.Text = gridView1.GetFocusedRowCellValue("Emp_Phone").ToString();
                Txt_Mob.Text = gridView1.GetFocusedRowCellValue("Emp_Mobaile").ToString();
                TxtID_No.Text = gridView1.GetFocusedRowCellValue("Persoanal_ID").ToString();
                Txt_Salry.Text = gridView1.GetFocusedRowCellValue("Basic_Salary").ToString();
                Cmb_JobTyp.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("Job_ID").ToString());
                Cmb_Shearch.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("Emp_ID").ToString());
            }
        }

        private void Cmb_Shearch_MouseClick(object sender, MouseEventArgs e)
        {

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

        private void TxtID_No_EditValueChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxtID_No.Text, "[^0-9]"))
            {
                _ = XtraMessageBox.Show("Please enter only numbers.");
                TxtID_No.Text = TxtID_No.Text.Remove(TxtID_No.Text.Length - 1);
            }
        }
    }
}