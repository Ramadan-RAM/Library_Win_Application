using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;
using Library.DAL;

namespace Library.Account
{
    public partial class VenAccountData : XtraForm
    {
        public VenAccountData()
        {
            InitializeComponent();
        }

        #region BindData

        private void BindData()

        {
            //Bind Vendors
            FillCombo.FillVendors(Cmb_Shearch);

            //BindGrid
            Dgv_Shearch.DataSource = RetriveData.Executequery("Sp_Ven_AccountSelectAll", CommandType.StoredProcedure);
        }

        #endregion

        private void VenAccountData_Load(object sender, EventArgs e)
        {

            BindData();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (Cmb_Shearch.Text == "")
            {
                _ = XtraMessageBox.Show("Please Select Vendor");
                return;
            }

            if (Cmb_Shearch.Text != "")
            {

                DataTable dt = RetriveData.Executequery("Sp_VendorsSelectAllByID", CommandType.StoredProcedure,
                        new RetriveData.Pararmeter("@Ven_ID", SqlDbType.Int, int.Parse(Cmb_Shearch.SelectedValue.ToString())));
                Txt_RemainValue.Text = dt.Rows[0]["Ven_Debit"].ToString();
            }
        }

        private bool _AddNew = false;
        private readonly Cl_Validate _Val = new Cl_Validate();

        [Obsolete]
        private void Btn_New_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you want Pay a Vendor", "Yes Sure",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _AddNew = true;
                _Val.TxtClear(this, Pnl_BasicData);
                BindData();
            }
        }

        [Obsolete]
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
                            _ = XtraMessageBox.Show("Not Exisit remain amount for a Vendor");
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
                    RetriveData.ExecuteNonquery("Sp_Ven_AccountInsert",
                        new RetriveData.Pararmeter("@Ven_ID", SqlDbType.Int, int.Parse(Cmb_Shearch.SelectedValue.ToString())),
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

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        [Obsolete]
        private void Btn_Rollback_Click(object sender, EventArgs e)
        {
            if (Cmb_Shearch.Text == "")
            {
                _ = XtraMessageBox.Show("Please Select Vendor");
                return;
            }

            if (XtraMessageBox.Show("Do you Want Rollback", "Yes", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Cmb_Shearch.Text != "")
                {
                    #region Rollback
                    RetriveData.ExecuteNonquery("Sp_Ven_AccountRollback",
                       new RetriveData.Pararmeter("@Ven_ID", SqlDbType.Int, int.Parse(Cmb_Shearch.SelectedValue.ToString())));
                    _ = XtraMessageBox.Show("Rollback Successfully");
                    #endregion
                    _AddNew = false;
                    _Val.TxtClear(this, Pnl_BasicData);
                    BindData();
                }
            }
        }
    }
}