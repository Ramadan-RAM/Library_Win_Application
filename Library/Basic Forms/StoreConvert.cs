using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Library.DAL;
using static Library.DAL.RetriveData;


namespace Library.Basic_Forms
{
    public partial class StoreConvert : XtraForm
    {
        public StoreConvert()
        {
            InitializeComponent();
        }

        private bool _AddNew = false;

        private readonly Cl_Validate _Valid = new Cl_Validate();

        #region BindData
        private void BindData()
        {
            // bind Item Category
            FillCombo.FillItemCategory(Cmb_ItemCat);

            // bind Store From
            FillCombo.FillStore(Cmb_StoreFrom);

            // bind Store To
            FillCombo.FillStore(Cmb_Storeto);

            // bind Grid
            Dgv_Shearch.DataSource = Executequery("Sp_Store_ConvertSelectAll", CommandType.StoredProcedure);

        }
        #endregion

        private void StoreConvert_Load(object sender, EventArgs e)
        {

            BindData();
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

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Cmb_StoreFrom_SelectedValueChanged(object sender, EventArgs e)
        {
            #region FillItem
            if (Cmb_ItemName.Text != "" && Cmb_StoreFrom.Text != "")
            {
                DataTable dt = Executequery("Sp_Store_QuantitySelectQuantity", CommandType.StoredProcedure,
                    new Pararmeter("@Item_ID", SqlDbType.Int, int.Parse(Cmb_ItemName.SelectedValue.ToString())),
                    new Pararmeter("@Store_ID", SqlDbType.Int, int.Parse(Cmb_StoreFrom.SelectedValue.ToString())));

                Txt_QuantityFrom.Text = dt.Rows[0][0].ToString();
            }
            #endregion
        }

        private void Cmb_Storeto_SelectedValueChanged(object sender, EventArgs e)
        {
            #region FillItem
            if (Cmb_ItemName.Text != "" && Cmb_Storeto.Text != "")
            {
                DataTable dt = Executequery("Sp_Store_QuantitySelectQuantity", CommandType.StoredProcedure,
                    new Pararmeter("@Item_ID", SqlDbType.Int, int.Parse(Cmb_ItemName.SelectedValue.ToString())),
                    new Pararmeter("@Store_ID", SqlDbType.Int, int.Parse(Cmb_Storeto.SelectedValue.ToString())));

                Txt_QuantityTo.Text = dt.Rows[0][0].ToString();
            }
            #endregion
        }

        private void Btn_Convert_Click(object sender, EventArgs e)
        {
            try
            {
                if ((DAL.Help.ToDecimal(Txt_QuantityConvert.Text)
                + DAL.Help.ToDecimal(Txt_QuantityConverted.Text)) > DAL.Help.ToDecimal(Txt_QuantityFrom.Text))
                {
                    _ = XtraMessageBox.Show("Sorry The Quantity Not Enough");
                    return;
                }

                Txt_QuantityConverted.Text =
               (DAL.Help.ToDecimal(Txt_QuantityConverted.Text) + DAL.Help.ToDecimal(Txt_QuantityConvert.Text)).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do You Want Add Nwe Row", "Yse Sure",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _Valid.TxtClear(this, Pnl_BasicData);
                _AddNew = true;
                Lbl_ID.Text = "0";
                Lbl1_ID.Text = "0";
                Lbl2_ID.Text = "0";
                Lbl3_ID.Text = "0";
                BindData();
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            #region Save

            if (_AddNew == false)

            {
                _ = XtraMessageBox.Show("Please Click On New First");
                return;
            }

            {
                if (XtraMessageBox.Show("Do You Want Convert The Quantity", "Yse Sure",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (Txt_QuantityConverted.Text == "0")
                    {
                        _ = XtraMessageBox.Show("Please Compleate Data");
                        return;
                    }

                    if (Dt_Convert.Text == "")
                    {
                        _ = XtraMessageBox.Show("Please Add Date");
                        return;
                    }

                    ExecuteNonquery("Sp_Store_ConvertInsert",
                    new Pararmeter("@StoreFrom_ID", SqlDbType.Int, int.Parse(Cmb_StoreFrom.SelectedValue.ToString())),
                    new Pararmeter("@StoreTo_ID", SqlDbType.Int, int.Parse(Cmb_Storeto.SelectedValue.ToString())),
                    new Pararmeter("@StoreNameFrom", SqlDbType.NVarChar, Cmb_StoreFrom.Text),
                    new Pararmeter("@StoreNameTo", SqlDbType.NVarChar, Cmb_Storeto.Text),
                    new Pararmeter("@Item_ID", SqlDbType.Int, int.Parse(Cmb_ItemName.SelectedValue.ToString())),
                    new Pararmeter("@Item_Quantity", SqlDbType.Int, int.Parse(Txt_QuantityConverted.Text)),
                    new Pararmeter("@Con_Date", SqlDbType.Date, Dt_Convert.DateTime.Date),
                    new Pararmeter("@Cone_Notes", SqlDbType.NVarChar, Txt_Notes.Text),
                    new Pararmeter("@User_ID", SqlDbType.Int, Login.UserID));

                    _ = XtraMessageBox.Show("Successfully Converted");
                    _Valid.TxtClear(this, Pnl_BasicData);
                    _AddNew = false;
                    Lbl_ID.Text = "0";
                    Lbl1_ID.Text = "0";
                    Lbl2_ID.Text = "0";
                    Lbl3_ID.Text = "0";
                    BindData();
                }
            }
            #endregion
        }

        private void Dgd_Shearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Lbl_ID.Text = gridView1.GetFocusedRowCellValue("Con_ID").ToString();
                Lbl1_ID.Text = gridView1.GetFocusedRowCellValue("Item_ID").ToString();
                Lbl2_ID.Text = gridView1.GetFocusedRowCellValue("Category_ID").ToString();
                Cmb_ItemName.SelectedValue = gridView1.GetFocusedRowCellValue("Item_ID").ToString();
                Cmb_ItemCat.SelectedValue = gridView1.GetFocusedRowCellValue("Category_ID").ToString();
                Cmb_StoreFrom.SelectedValue = gridView1.GetFocusedRowCellValue("StoreFrom_ID").ToString();
                Cmb_Storeto.SelectedValue = gridView1.GetFocusedRowCellValue("StoreTo_ID").ToString();
                Txt_QuantityConverted.Text = gridView1.GetFocusedRowCellValue("Item_Quantity").ToString();
                Txt_Notes.Text = gridView1.GetFocusedRowCellValue("Cone_Notes").ToString();
                Dt_Convert.Text = gridView1.GetFocusedRowCellValue("Con_Date").ToString();

            }
        }
    }
}