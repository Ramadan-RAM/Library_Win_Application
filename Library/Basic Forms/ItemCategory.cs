using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Library.DAL;
using static Library.DAL.RetriveData;

namespace Library.Basic_Forms
{
    public partial class ItemCategory : XtraForm
    {
        public ItemCategory()
        {
            InitializeComponent();
        }

        private bool _addnew = false;

        private void ItemCategory_Load(object sender, EventArgs e)
        {

            BindGrid();
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            #region
            if (XtraMessageBox.Show("Are you Sure to add new Item", "Done",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Txt_ItemCat.Text = "";
                _addnew = true;
                Lbl_ID.Text = "0";
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

            if (XtraMessageBox.Show("Are you Sure to Save new Item", "Save",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                #region suredata
                if (Txt_ItemCat.Text == "")
                {
                    _ = XtraMessageBox.Show("Please Inter Category Item");
                }
                #endregion

                #region SaveData 
                ExecuteNonquery("Sp_Item_CategoryInsert",
            new Pararmeter("@Category_Name", SqlDbType.NVarChar, Txt_ItemCat.Text),
            new Pararmeter("@User_ID", SqlDbType.Int, Login.UserID));
                #endregion
                _ = XtraMessageBox.Show("Save Done");
                _addnew = false;
                Txt_ItemCat.Text = "";
                BindGrid();
            }
        }

        #region BindGrid
        private void BindGrid()
        {
            Dgv_Shearch.DataSource = Executequery("Sp_Item_CategorySelectAll", CommandType.StoredProcedure);
        }
        #endregion

        private void Dgv_Shearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Lbl_ID.Text = gridView1.GetFocusedRowCellValue("Category_ID").ToString();
                Txt_ItemCat.Text = gridView1.GetFocusedRowCellValue("Category_Name").ToString();
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (Lbl_ID.Text != "0")
            {
                if (XtraMessageBox.Show("Are you Sure to Update Category", "Save",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    #region suredata
                    if (Txt_ItemCat.Text == "")
                    {
                        _ = XtraMessageBox.Show("Sorry Enter Category Name");
                        return;
                    }
                    #endregion

                    #region UpdateData 
                    ExecuteNonquery("Sp_Item_CategoryUpdate",
                new Pararmeter("@Category_ID", SqlDbType.Int, int.Parse(Lbl_ID.Text)),
                new Pararmeter("@Category_Name", SqlDbType.NVarChar, Txt_ItemCat.Text),
                new Pararmeter("@User_ID", SqlDbType.Int, Login.UserID));
                    #endregion
                    _ = XtraMessageBox.Show("Update Done");
                    Lbl_ID.Text = "0";
                    Txt_ItemCat.Text = "";
                    BindGrid();
                }
            }
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            if (Lbl_ID.Text != "0")
            {
                if (XtraMessageBox.Show("Are you Sure to Delete Category", "Delete",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ExecuteNonquery("Sp_Item_CategoryDelete",
                new Pararmeter("@Category_ID", SqlDbType.Int, int.Parse(Lbl_ID.Text)));
                }

                _ = XtraMessageBox.Show("Delete Done");
                Lbl_ID.Text = "0";
                Txt_ItemCat.Text = "";
                BindGrid();
            }
        }
    }
}