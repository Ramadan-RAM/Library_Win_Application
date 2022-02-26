using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Library.DAL;
using static Library.DAL.RetriveData;

namespace Library.Basic_Forms
{
    public partial class ItemsData : XtraForm
    {
        public ItemsData()
        {
            InitializeComponent();
        }

        private bool _addnew = false;
        private readonly Cl_Validate _Valid = new Cl_Validate();

        #region BindData
        private void BindData()
        {
            //Bind Category Name
            FillCombo.FillItemCategory(Cmb_Cat);

            //Bind Store Name
            FillCombo.FillStore(Cmb_BasicStore);

            //BindGrid
            Dgv_Shearch.DataSource = Executequery("Sp_ItemsSelectAll", CommandType.StoredProcedure);
        }

        #endregion

        private void Itemscs_Load(object sender, EventArgs e)
        {

            BindData();
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            #region
            if (XtraMessageBox.Show("Are you sure to add New Item", "Done",
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

            if (XtraMessageBox.Show("Are you Sure to Save New Item", "Save",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                #region suredata
                if (Txt_ItemName.Text == "")
                {
                    _ = XtraMessageBox.Show("Sorry Enter Item Name");
                    return;
                }

                if (Txt_Minimum.Text == "")
                {
                    _ = XtraMessageBox.Show("Please Enter Minimum");
                    return;
                }

                if (Cmb_Cat.Text == "")
                {
                    _ = XtraMessageBox.Show("Please Select Item Category");
                    return;
                }
                #endregion

                #region SaveData 
                ExecuteNonquery("Sp_ItemsInsert",
            new Pararmeter("@Item_Name", SqlDbType.NVarChar, Txt_ItemName.Text),
            new Pararmeter("@Category_ID", SqlDbType.Int, int.Parse(Cmb_Cat.SelectedValue.ToString())),
            new Pararmeter("@Store_ID", SqlDbType.Int, int.Parse(Cmb_BasicStore.SelectedValue.ToString())),
            new Pararmeter("@Item_Minimum", SqlDbType.Int, int.Parse(Txt_Minimum.Text)),
            new Pararmeter("@User_ID", SqlDbType.Int, Login.UserID));
                #endregion
                _ = XtraMessageBox.Show("Save Done");
                _Valid.TxtClear(this, Pnl_BasicData);
                Lbl_ID.Text = "0";
                _addnew = false;
                BindData();
            }
        }

        private void Dgv_Shearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Lbl_ID.Text = gridView1.GetFocusedRowCellValue("Item_ID").ToString();
                Txt_ItemName.Text = gridView1.GetFocusedRowCellValue("Item_Name").ToString();
                Txt_Minimum.Text = gridView1.GetFocusedRowCellValue("Item_Minimum").ToString();
                Cmb_Cat.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("Category_ID").ToString());
                Cmb_Cat.Text = gridView1.GetFocusedRowCellValue("Category_Name").ToString();
                Cmb_BasicStore.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("Store_ID").ToString());
                Cmb_BasicStore.Text = gridView1.GetFocusedRowCellValue("Store_Name").ToString();
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {

            if (XtraMessageBox.Show("Are you Sure to Update New Item", "Save",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {

                #region suredata
                if (Txt_ItemName.Text == "")
                {
                    _ = XtraMessageBox.Show("Sorry Enter Item Name");
                    return;
                }

                if (Txt_Minimum.Text == "")
                {
                    _ = XtraMessageBox.Show("Please Enter Minimum");
                    return;
                }

                if (Cmb_Cat.Text == "")
                {
                    _ = XtraMessageBox.Show("Please Select Item Category");
                    return;
                }
                #endregion

                #region UpdateData 
                ExecuteNonquery("Sp_ItemsUpdate",
            new Pararmeter("@Item_ID", SqlDbType.Int, int.Parse(Lbl_ID.Text)),
            new Pararmeter("@Item_Name", SqlDbType.NVarChar, Txt_ItemName.Text),
            new Pararmeter("@Category_ID", SqlDbType.Int, int.Parse(Cmb_Cat.SelectedValue.ToString())),
            new Pararmeter("@Store_ID", SqlDbType.Int, int.Parse(Cmb_BasicStore.SelectedValue.ToString())),
            new Pararmeter("@Item_Minimum", SqlDbType.Int, int.Parse(Txt_Minimum.Text)),
            new Pararmeter("@User_ID", SqlDbType.Int, Login.UserID));
                #endregion
                _ = XtraMessageBox.Show("Update Done");
                _Valid.TxtClear(this, Pnl_BasicData);
                _addnew = false;
                Lbl_ID.Text = "0";
                BindData();
            }
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you Sure to Delete Item", "Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region DeleteData 
                ExecuteNonquery("Sp_ItemsDelete",
            new Pararmeter("@Item_ID", SqlDbType.Int, int.Parse(Lbl_ID.Text)));

                #endregion
                _ = XtraMessageBox.Show("Delete Done");
                _addnew = false;
                Lbl_ID.Text = "0";
                BindData();

            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Pnl_BasicData_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}