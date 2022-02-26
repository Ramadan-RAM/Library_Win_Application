using DevExpress.XtraEditors;
using System.Data;
using Library.DAL;
using System.Windows.Forms;
using System;

namespace Library.Account
{
    public partial class CustAccountData : XtraForm
    {
        public CustAccountData()
        {
            InitializeComponent();
        }

        #region BindData

        private void BindData()

        {
            //Bind Customers
            FillCombo.FillCustomer(Cmb_Shearch);

            //BindGrid
            Dgv_Shearch.DataSource = RetriveData.Executequery("Sp_CustAccountSelectAll", CommandType.StoredProcedure);
        }
        #endregion

        private void Btn_Search_Click(object sender, EventArgs e)
        {

            if (Cmb_Shearch.Text == "")
            {
                _ = XtraMessageBox.Show("Please Select Client");
                return;
            }

            if (Cmb_Shearch.Text != "")
            {
                DataTable dt = RetriveData.Executequery("Sp_CustomersSelectByID", CommandType.StoredProcedure,
                       new RetriveData.Pararmeter("@Cust_ID", SqlDbType.Int, int.Parse(Cmb_Shearch.SelectedValue.ToString())));
                Txt_RemainValue.Text = dt.Rows[0]["Cust_Debit"].ToString();
            }
        }

        private bool _AddNew = false;
        private readonly Cl_Validate _Val = new Cl_Validate();


        private void Btn_New_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you want Pay a Client", "Yes Sure",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _AddNew = true;
                _Val.TxtClear(this, Pnl_BasicData);
                BindData();
            }
        }


        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (_AddNew == true)
            {
                if (XtraMessageBox.Show("Do you want Save", "Yes Sure",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    #region SureData

                    if (Txt_PayedValue.Text != "")
                    {
                        try
                        {
                            if (double.Parse(Txt_PayedValue.Text) > double.Parse(Txt_RemainValue.Text))
                            {
                                _ = XtraMessageBox.Show("Sorry the amount paid is greater thean the remaining amount");
                                return;
                            }
                        }
                        catch (Exception)
                        {

                        }

                        if (Txt_PayedValue.Text == "")
                        {
                            _ = XtraMessageBox.Show("Please Add the amount paid");
                            return;
                        }

                        if (Txt_RemainValue.Text == "0")
                        {
                            _ = XtraMessageBox.Show("Not Exisit remain amount for a Client");
                            return;
                        }

                        if (Dt_Date.Text == "")
                        {
                            _ = XtraMessageBox.Show("Please Add Date Pay");
                            return;
                        }

                    }
                    #endregion

                    #region SaveData
                    RetriveData.ExecuteNonquery("Sp_CustAccountInsert",
                        new RetriveData.Pararmeter("@Cust_ID", SqlDbType.Int, int.Parse(Cmb_Shearch.SelectedValue.ToString())),
                        new RetriveData.Pararmeter("@Payed_Value", SqlDbType.Decimal, decimal.Parse(Txt_PayedValue.Text)),
                        new RetriveData.Pararmeter("@Date_Payed", SqlDbType.Date, Dt_Date.DateTime.Date),
                        new RetriveData.Pararmeter("@Account_Notes", SqlDbType.NVarChar, Txt_Notes.Text),
                        new RetriveData.Pararmeter("@User_ID", SqlDbType.Int, Login.UserID));
                    #endregion

                    _ = XtraMessageBox.Show("Successfully Saved");
                    _AddNew = false;
                    _Val.TxtClear(this, Pnl_BasicData);
                    BindData();
                }
            }
        }

        private void CustAccountData_Load(object sender, EventArgs e)
        {

            BindData();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        [Obsolete]
        private void Btn_Rollback_Click(object sender, EventArgs e)
        {
            if (Cmb_Shearch.Text == "")
            {
                _ = XtraMessageBox.Show("Please Select Client");
                return;
            }

            if (XtraMessageBox.Show("Do you Want Rollback", "Yes", MessageBoxButtons.YesNo,
             MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Cmb_Shearch.Text != "")
                {
                    #region Rollback
                    RetriveData.ExecuteNonquery("Sp_CustAccountRollback",
                       new RetriveData.Pararmeter("@Cust_ID", SqlDbType.Int, int.Parse(Cmb_Shearch.SelectedValue.ToString())));
                    _ = XtraMessageBox.Show("Rollback Successfully");
                    #endregion
                }
                _AddNew = false;
                _Val.TxtClear(this, Pnl_BasicData);
                BindData();
            }
        }
    }
}