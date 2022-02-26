using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;
using Library.DAL;
using static Library.DAL.RetriveData;

namespace Library.Basic_Forms
{
    public partial class DistrubuteItems : XtraForm
    {
        public DistrubuteItems()
        {
            InitializeComponent();
        }

        private bool _addnew = false;
        private readonly Cl_Validate _Valid = new Cl_Validate();

        #region BindCombo
        private void BindCombo()
        {
            //Bind Store Name
            FillCombo.FillStore(Cmb_StoreName);

            //Bind Item Name 
            FillCombo.FillItemName(Cmb_ItemName);
        }
        #endregion

        public void DistrubuteItems_Load(object sender, EventArgs e)
        {
            BindCombo();
        }

        private DataTable Preparedatatable()
        {
            if (Dgv_Items.RowCount > 0)
            {
                DataTable dt = new DataTable();
                DataRow dr;
                _ = dt.Columns.Add("Store_ID", typeof(int));
                _ = dt.Columns.Add("Item_ID", typeof(int));
                for (int i = 0; i < Dgv_Items.Rows.Count; i++)
                {
                    dr = dt.NewRow();
                    dr[0] = Dgv_Items.Rows[i].Cells[0].Value.ToString();
                    dr[1] = Dgv_Items.Rows[i].Cells[1].Value.ToString();
                    dt.Rows.Add(dr);
                }
                return dt;
            }
            else
            {
                return null;
            }
        }

        private readonly DBConnect _con = new DBConnect();
        private void Btn_Add_Click_1(object sender, EventArgs e)
        {
            if (Cmb_ItemName.Text == "")
            {
                _ = XtraMessageBox.Show("Please Select Item");
                return;
            }
            if (Cmb_StoreName.Text == "")
            {
                _ = XtraMessageBox.Show("Please Select Store");
                return;
            }
            DataGridViewRow Row = new DataGridViewRow();
            DataGridViewCell Cel1 = new DataGridViewTextBoxCell();
            DataGridViewCell Cel2 = new DataGridViewTextBoxCell();
            DataGridViewCell Cel3 = new DataGridViewTextBoxCell();
            DataGridViewCell Cel4 = new DataGridViewTextBoxCell();

            _ = Row.Cells.Add(Cel1);
            _ = Row.Cells.Add(Cel2);
            _ = Row.Cells.Add(Cel3);
            _ = Row.Cells.Add(Cel4);
            Row.Cells[0].Value = Cmb_StoreName.SelectedValue.ToString();
            Row.Cells[1].Value = Cmb_ItemName.SelectedValue.ToString();
            Row.Cells[2].Value = Cmb_StoreName.Text;
            Row.Cells[3].Value = Cmb_ItemName.Text;
            _ = Dgv_Items.Rows.Add(Row);
            _Valid.TxtClear(this, panelControl1);
            _addnew = true;
            Lbl1_ID.Text = "0";
            Lbl2_ID.Text = "0";

        }

        private void Btn_Save_Click_1(object sender, EventArgs e)
        {
            if (_addnew == false)
            {
                _ = XtraMessageBox.Show("Please Click On Add First");
                return;
            }

            DataTable dt = Preparedatatable();
            if (dt.Rows.Count == 0)

            {
                _ = XtraMessageBox.Show("Please Enter Data");
                return;
            }

            _con.cmd.Connection = DBConnect.Conn;
            _con.cmd.CommandType = CommandType.StoredProcedure;
            _con.cmd.CommandText = "Sp_Store_QuantityInsert";
            _con.cmd.Parameters.Clear();
            _ = _con.cmd.Parameters.AddWithValue("@User_ID", Login.UserID);
            _ = _con.cmd.Parameters.AddWithValue("@DistributeItems", dt);
            _ = _con.cmd.ExecuteNonQuery();
            _ = XtraMessageBox.Show("Save Done");
            Dgv_Items.Rows.Clear();
        }

        private void SimpleButton1_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Btn_Distrub_Click(object sender, EventArgs e)
        {
            ExecuteNonquery("Sp_DistributeItemAuto",
             new Pararmeter("@User_ID", SqlDbType.Int, Login.UserID));
            _ = XtraMessageBox.Show("Distrubted Successfully");
        }
    }
}