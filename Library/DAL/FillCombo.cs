using System.Data;
using System.Windows.Forms;

namespace Library.DAL
{
    internal class FillCombo
    {
        public static void FillStore(ComboBox cmb)
        {
            cmb.DataSource = RetriveData.Executequery("Sp_Store_DataSelectAll", CommandType.StoredProcedure);
            cmb.DisplayMember = "Store_Name";
            cmb.ValueMember = "Store_ID";
            cmb.Text = "";
        }

        public static void FillVendors(ComboBox cmb)
        {
            cmb.DataSource = RetriveData.Executequery("Sp_VendorsSelectAll", CommandType.StoredProcedure);
            cmb.DisplayMember = "Ven_Name";
            cmb.ValueMember = "Ven_ID";
            cmb.Text = "";
        }

        public static void FillItemCategory(ComboBox cmb)
        {
            cmb.DataSource = RetriveData.Executequery("Sp_Item_CategorySelectAll", CommandType.StoredProcedure);
            cmb.DisplayMember = "Category_Name";
            cmb.ValueMember = "Category_ID";
            cmb.Text = "";
        }

        public static void FillItemName(ComboBox cmb)
        {
            cmb.DataSource = RetriveData.Executequery("Sp_ItemsSelectAll", CommandType.StoredProcedure);
            cmb.DisplayMember = "Item_Name";
            cmb.ValueMember = "Item_ID";
            cmb.Text = "";
        }

        public static void FillCustomer(ComboBox cmb)
        {
            cmb.DataSource = RetriveData.Executequery("Sp_CustomersSelectAll", CommandType.StoredProcedure);
            cmb.DisplayMember = "Cust_Name";
            cmb.ValueMember = "Cust_ID";
            cmb.Text = "";
        }

        public static void FillTypeJob(ComboBox cmb)
        {
            cmb.DataSource = RetriveData.Executequery("Sp_Job_TypeSelectAll", CommandType.StoredProcedure);
            cmb.DisplayMember = "Job_Name";
            cmb.ValueMember = "Job_ID";
            cmb.Text = "";
        }

        public static void FillEmployees(ComboBox cmb)
        {
            cmb.DataSource = RetriveData.Executequery("Sp_EmployeesSelectAll", CommandType.StoredProcedure);
            cmb.DisplayMember = "Emp_Name";
            cmb.ValueMember = "Emp_ID";
            cmb.Text = "";
        }

        public static void FillUsers(ComboBox cmb)
        {
            cmb.DataSource = RetriveData.Executequery("Sp_UserInfoSelectAll", CommandType.StoredProcedure);
            cmb.DisplayMember = "User_Name";
            cmb.ValueMember = "User_ID";
            cmb.Text = "";
        }
    }
}
