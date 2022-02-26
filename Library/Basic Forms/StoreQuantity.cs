using DevExpress.XtraEditors;
using System;
using System.Data;
using Library.DAL;
using System.Windows.Forms;
using static Library.DAL.RetriveData;

namespace Library.Basic_Forms
{
    public partial class StoreQuantity : XtraForm
    {
        public StoreQuantity()
        {
            InitializeComponent();
        }

        private bool _addnew = false;
        private readonly Cl_Validate _Valid = new Cl_Validate();

        #region BindData
        private void BindData()
        {
            //Bind Item Name
            FillCombo.FillItemName(Cmb_ItemName);

            //Bind Store Name
            FillCombo.FillStore(Cmb_StoreName);

            //BindGrid
            Dgv_Shearch.DataSource = Executequery("Sp_StoreQuantityDataSelectAll", CommandType.StoredProcedure);
        }

        #endregion

        private void StoreQuantity_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            #region
            if (XtraMessageBox.Show("Are you sure to add New Quantity Item", "Done",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _Valid.TxtClear(this, Pnl_BasicData);
                _addnew = true;
                Lbl_ID.Text = "0";
                BindData();
            }
            #endregion
        }

        private void Dgv_Shearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Lbl_ID.Text = gridView1.GetFocusedRowCellValue("Quan_ID").ToString();
                Cmb_StoreName.SelectedValue = gridView1.GetFocusedRowCellValue("Store_ID").ToString();
                Cmb_ItemName.SelectedValue = gridView1.GetFocusedRowCellValue("Item_ID").ToString();
                Txt_Quantity.Text = gridView1.GetFocusedRowCellValue("Item_Quantity").ToString();

            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (_addnew == false)
            {
                _ = XtraMessageBox.Show("Please Click On New First");
                return;
            }

            if (XtraMessageBox.Show("Are you Sure to Update New Quantity Item", "Save",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                #region suredata
                if (Cmb_StoreName.Text == "")
                {
                    _ = XtraMessageBox.Show("Sorry Enter Store Name");
                    return;
                }

                if (Cmb_ItemName.Text == "")
                {
                    _ = XtraMessageBox.Show("Please Enter Item Name");
                    return;
                }

                if (Txt_Quantity.Text == "")
                {
                    _ = XtraMessageBox.Show("Please Enter Quantity Item");
                    return;
                }
                #endregion

                #region UpdateData 
                ExecuteNonquery("Sp_UpdateQuantityItems",
            new Pararmeter("@Quan_ID", SqlDbType.Int, int.Parse(Lbl_ID.Text)),
            new Pararmeter("@Store_ID", SqlDbType.Int, int.Parse(Cmb_StoreName.SelectedValue.ToString())),
            new Pararmeter("@Item_ID", SqlDbType.Int, int.Parse(Cmb_ItemName.SelectedValue.ToString())),
            new Pararmeter("@Item_Quantity", SqlDbType.Int, int.Parse(Txt_Quantity.Text)),
            new Pararmeter("@User_ID", SqlDbType.Int, Login.UserID));
                #endregion
                _ = XtraMessageBox.Show("Update Done");
                _Valid.TxtClear(this, Pnl_BasicData);
                Lbl_ID.Text = "0";
                _addnew = false;
                BindData();
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {

            if (_addnew == false)
            {
                _ = XtraMessageBox.Show("Please Click On New First");
                return;
            }

            if (XtraMessageBox.Show("Are you Sure to Delete Store Quantity Items", "Delete",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region DeleteData 
                ExecuteNonquery("Sp_DeleteStoreQuantity",
            new Pararmeter("@Quan_ID", SqlDbType.Int, int.Parse(Lbl_ID.Text)));

                #endregion
                _ = XtraMessageBox.Show("Delete Done");
                _addnew = false;
                Lbl_ID.Text = "0";
                BindData();

            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            #region suredata
            if (Cmb_StoreName.Text == "")
            {
                _ = XtraMessageBox.Show("Please Select Store Name");
                return;
            }

            if (Cmb_ItemName.Text == "")
            {
                _ = XtraMessageBox.Show("Please Select Item Name");
                return;
            }
            #endregion

            if (Cmb_StoreName.Text != "")
            {
                _ = new DataTable();
                DataTable dt = Executequery("Sp_StoreQuantitySelectAllByID", CommandType.StoredProcedure,

                    new Pararmeter("@Store_ID", SqlDbType.Int, int.Parse(Cmb_StoreName.SelectedValue.ToString())),
                    new Pararmeter("@Item_ID", SqlDbType.Int, int.Parse(Cmb_ItemName.SelectedValue.ToString())));

                Lbl_ID.Text = dt.Rows[0]["Quan_ID"].ToString();
                Cmb_StoreName.Text = dt.Rows[0]["Store_Name"].ToString();
                Cmb_ItemName.Text = dt.Rows[0]["Item_Name"].ToString();
                Txt_Quantity.Text = dt.Rows[0]["Item_Quantity"].ToString();
            }
        }
    }
}