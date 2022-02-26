using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using static Library.DAL.RetriveData;
using Library.DAL;
//using System.Data.SqlClient;
using Library.Reports;
namespace Library.OP
{
    public partial class Purchases : XtraForm
    {
        public Purchases()
        {
            InitializeComponent();
        }

        #region BindCombo

        private void BindCombo()
        {
            //Bind Category Name
            FillCombo.FillItemCategory(Cmb_ItemCat);

            //Bind Store Name
            FillCombo.FillStore(Cmb_StoreName);

            //Bind Vendor Name
            FillCombo.FillVendors(Cmb_VendorName);

        }

        #endregion

        #region CalcItemValue
        private void CalcItemValue()
        {
            if (Txt_PriceItem.Text == "")
            {
                Txt_PriceItem.Text = "0";
            }

            if (Txt_Quantity.Text == "")
            {
                Txt_Quantity.Text = "0";
            }

            Txt_Value.Text = (double.Parse(Txt_PriceItem.Text) * double.Parse(Txt_Quantity.Text)).ToString();
        }

        #endregion

        #region CalcTotalValue

        private void CalcTotalValue()

        {
            try
            {
                if (Txt_TotalValue.Text == "")
                {
                    Txt_TotalValue.Text = "0";
                }
                double _total = 0;
                for (int i = 0; i < Dgv_Items.Rows.Count; i++)

                {
                    _total = double.Parse(Txt_TotalValue.Text) + double.Parse(Dgv_Items.Rows[i].Cells[6].Value.ToString());
                }

                Txt_TotalValue.Text = _total.ToString();
            }
            catch (Exception)
            {

            }
        }

        #endregion

        #region CalcRemainValue

        private void CalcRemainValue()
        {
            //CalcTotalValue();

            try
            {
                if (Txt_PayedValue.Text == "")
                {
                    Txt_PayedValue.Text = "0";
                }

                if (double.Parse(Txt_PayedValue.Text) > double.Parse(Txt_TotalValue.Text))
                {
                    return;
                }

                Txt_RemainValue.Text = (double.Parse(Txt_TotalValue.Text) - double.Parse(Txt_PayedValue.Text)).ToString();
            }
            catch (Exception)
            {

            }
        }

        #endregion


        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Purchases_Load(object sender, EventArgs e)
        {
            BindCombo();
        }

        private void Cmb_ItemCat_SelectedValueChanged(object sender, EventArgs e)
        {
            #region FillItem
            if (Cmb_ItemCat.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                Cmb_ItemName.DataSource = Executequery("Sp_ItemSelectByCategoryID", CommandType.StoredProcedure,
                    new Pararmeter("@Category_ID", SqlDbType.Int, int.Parse(Cmb_ItemCat.SelectedValue.ToString())));
                Cmb_ItemName.DisplayMember = "Item_Name";
                Cmb_ItemName.ValueMember = "Item_ID";
                Cmb_ItemName.Text = "";
            }
            #endregion
        }


        private void Btn_Add_Click(object sender, EventArgs e)
        {

            #region SureData

            if (Cmb_ItemName.Text == "")
            {
                _ = XtraMessageBox.Show("Please Select Item Name");
                return;
            }

            if (Txt_Value.Text == "0")
            {
                _ = XtraMessageBox.Show("Please Add Price Or The Quantity");
                return;
            }


            #endregion

            #region AddToGrid
            DataGridViewRow Row = new DataGridViewRow();
            DataGridViewCell cel1 = new DataGridViewTextBoxCell();
            DataGridViewCell cel2 = new DataGridViewTextBoxCell();
            DataGridViewCell cel3 = new DataGridViewTextBoxCell();
            DataGridViewCell cel4 = new DataGridViewTextBoxCell();
            DataGridViewCell cel5 = new DataGridViewTextBoxCell();
            DataGridViewCell cel6 = new DataGridViewTextBoxCell();
            DataGridViewCell cel7 = new DataGridViewTextBoxCell();

            _ = Row.Cells.Add(cel1); _ = Row.Cells.Add(cel2); _ = Row.Cells.Add(cel3);
            _ = Row.Cells.Add(cel4); _ = Row.Cells.Add(cel5); _ = Row.Cells.Add(cel6); _ = Row.Cells.Add(cel7);

            Row.Cells[0].Value = Cmb_ItemCat.SelectedValue.ToString();
            Row.Cells[1].Value = Cmb_ItemName.SelectedValue.ToString();
            Row.Cells[2].Value = Cmb_ItemCat.Text;
            Row.Cells[3].Value = Cmb_ItemName.Text;
            Row.Cells[4].Value = Txt_PriceItem.Text;
            Row.Cells[5].Value = Txt_Quantity.Text;
            Row.Cells[6].Value = Txt_Value.Text;
            _ = Dgv_Items.Rows.Add(Row);
            #endregion
            CalcTotalValue();
            _Valid.TxtClear(this, Pnl_Items);


        }

        private void Txt_PriceItem_EditValueChanged(object sender, EventArgs e)
        {
            CalcItemValue();
        }

        private void Txt_Quantity_EditValueChanged(object sender, EventArgs e)
        {
            CalcItemValue();
        }

        private void Txt_PayedValue_EditValueChanged(object sender, EventArgs e)
        {
            CalcRemainValue();
        }

        private void Txt_TotalValue_EditValueChanged(object sender, EventArgs e)
        {
            CalcRemainValue();
        }

        #region RetriveDataTable
        private DataTable PreparData()
        {
            if (Dgv_Items.Rows.Count > 0)
            {
                DataTable dt = new DataTable();
                DataRow dr;
                _ = dt.Columns.Add("Category_ID", typeof(int));
                _ = dt.Columns.Add("Item_ID", typeof(int));
                _ = dt.Columns.Add("Purchases_Price", typeof(decimal));
                _ = dt.Columns.Add("Item_Quantity", typeof(int));
                _ = dt.Columns.Add("Item_Value", typeof(decimal));

                for (int i = 0; i < Dgv_Items.Rows.Count; i++)
                {
                    dr = dt.NewRow();
                    dr[0] = Dgv_Items.Rows[i].Cells[0].Value.ToString();
                    dr[1] = Dgv_Items.Rows[i].Cells[1].Value.ToString();
                    dr[2] = Dgv_Items.Rows[i].Cells[4].Value.ToString();
                    dr[3] = Dgv_Items.Rows[i].Cells[5].Value.ToString();
                    dr[4] = Dgv_Items.Rows[i].Cells[6].Value.ToString();
                    dt.Rows.Add(dr);
                }
                return dt;
            }
            else
            {
                return null;
            }

            #endregion

        }
        private bool _AddNew = false;
        private readonly Cl_Validate _Valid = new Cl_Validate();

        [Obsolete]
        private void Btn_New_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you Want Make Purchase", "Yes Sure", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _AddNew = true;
                _Valid.TxtClear(this, Pnl_VendorData);
                _Valid.TxtClear(this, Pnl_Items);
                _Valid.TxtClear(this, Pnl_Mony);
                _Valid.TxtClear(this, Pnl_BasicData);
                Dgv_Items.Rows.Clear();
                Refresh();
            }
        }

        private readonly DBConnect _con = new DBConnect();

        private void Btn_Save_Click(object sender, EventArgs e)
        {

            #region SureData

            if (_AddNew == false)
            {
                _ = XtraMessageBox.Show("Please Click On New First");
                return;
            }

            if (Cmb_VendorName.Text == "")
            {
                _ = XtraMessageBox.Show("Please Select Vendor Name");
                return;
            }

            if (Dt_Purchases.Text == "")
            {
                _ = XtraMessageBox.Show("Please Select Date Purchases");
                return;
            }

            if (Cmb_StoreName.Text == "")
            {
                _ = XtraMessageBox.Show("Please Select Store Name");
                return;
            }
            #endregion

            #region SaveData
            try
            {
                DataTable dt = PreparData();
                _con.cmd.Connection = DBConnect.Conn;
                _con.cmd.CommandType = CommandType.StoredProcedure;
                _con.cmd.CommandText = "Sp_Main_PurchasesInsert";
                _con.cmd.Parameters.Clear();
                _ = _con.cmd.Parameters.AddWithValue("@Ven_ID", int.Parse(Cmb_VendorName.SelectedValue.ToString()));
                _ = _con.cmd.Parameters.AddWithValue("@Purchases_Date", Dt_Purchases.DateTime.Date);
                _ = _con.cmd.Parameters.AddWithValue("@Total_Value", Txt_TotalValue.Text);
                _ = _con.cmd.Parameters.AddWithValue("@Payed_Value", Txt_PayedValue.Text);
                _ = _con.cmd.Parameters.AddWithValue("@Remain_Value", Txt_RemainValue.Text);
                _ = _con.cmd.Parameters.AddWithValue("@Purchases_Notes", Txt_Notes.Text);
                _ = _con.cmd.Parameters.AddWithValue("@User_ID", Login.UserID);
                _ = _con.cmd.Parameters.AddWithValue("@Store_ID", int.Parse(Cmb_StoreName.SelectedValue.ToString()));
                _ = _con.cmd.Parameters.AddWithValue("@PurchasDataTable", dt);
                _ = _con.cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }

            #endregion
            _ = XtraMessageBox.Show("Successfully Saved");
            _AddNew = false;
            _Valid.TxtClear(this, Pnl_VendorData);
            _Valid.TxtClear(this, Pnl_Items);
            _Valid.TxtClear(this, Pnl_Mony);
            _Valid.TxtClear(this, Pnl_BasicData);
            Dgv_Items.Rows.Clear();
            Refresh();


        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you Want Print  a Purchases Order", "Print", MessageBoxButtons.YesNo,
             MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //_con.cmd.Connection = DBConnect.Conn;
                //_con.cmd.CommandType = CommandType.StoredProcedure;
                //_con.cmd.CommandText = "Sp_MainPurchasesSelectMax";
                //SqlDataAdapter da = new SqlDataAdapter(_con.cmd);
                //DataSet ds = new DataSet();
                //_ = da.Fill(ds, "BillPurchases");
                //Cry_BillPurchases rpt = new Cry_BillPurchases();
                //rpt.SetDataSource(ds.Tables["BillPurchases"]);
                //Frm_Report frm = new Frm_Report();
                //frm.crystalReportViewer1.ReportSource = rpt;
                //_ = frm.ShowDialog();
                //Refresh();
                ReportPurchases_Frm frm = new ReportPurchases_Frm();
                _ = frm.ShowDialog();
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (Cmb_VendorName.Text == "")
            {
                _ = XtraMessageBox.Show("Please Select Client");
                return;
            }

            if (Cmb_VendorName.Text != "")
            {
                DataTable dt = Executequery("Sp_VendorsSelectAllByID", CommandType.StoredProcedure,
                       new Pararmeter("@Ven_ID", SqlDbType.Int, int.Parse(Cmb_VendorName.SelectedValue.ToString())));
                Txt_RemainValue.Text = dt.Rows[0]["Ven_Debit"].ToString();
            }
        }

        private void RollBack_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you Want Rollback", "Yes", MessageBoxButtons.YesNo,
             MessageBoxIcon.Question) == DialogResult.Yes)
            {

                ExecuteNonquery("Sp_DeletPurchases",
                _ = new Pararmeter("@Ven_ID1", SqlDbType.Int, int.Parse(Cmb_VendorName.SelectedValue.ToString())));
                _ = XtraMessageBox.Show("Rollback Successfully");
                _Valid.TxtClear(this, Pnl_VendorData);
                _Valid.TxtClear(this, Pnl_Items);
                _Valid.TxtClear(this, Pnl_Mony);
                _Valid.TxtClear(this, Pnl_BasicData);
            }
        }
    }
}