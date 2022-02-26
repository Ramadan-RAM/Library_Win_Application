using CrystalDecisions.Shared;
using DevExpress.XtraEditors;
using Library.DAL;
using System.Data;
using System.Data.SqlClient;

namespace Library.Reports
{
    public partial class Frm_R : XtraForm
    {
        private readonly DBConnect _con = new DBConnect();
        public Frm_R()
        {
            InitializeComponent();
            crystalReportViewer1.ReuseParameterValuesOnRefresh = true;
        }

        private void Btn_New_Click(object sender, System.EventArgs e)
        {
            Cry_CustomerActions cp = new Cry_CustomerActions();
            crystalReportViewer1.ReportSource = cp;
            ParameterField pram = new ParameterField
            {
                Name = "@Name"
            };
            ParameterDiscreteValue pvalue = new ParameterDiscreteValue
            {
                Value = textBox1.Text
            };
            pram.CurrentValues.Clear();
            _ = pram.CurrentValues.Add(pvalue);
            _ = crystalReportViewer1.ParameterFieldInfo.Add(pram);
        }

        private void Frm_R_Load(object sender, System.EventArgs e)
        {

            _con.cmd.Connection = DBConnect.Conn;
            _con.cmd.CommandType = CommandType.StoredProcedure;
            _con.cmd.CommandText = "CustomersActions";
            SqlDataAdapter da = new SqlDataAdapter(_con.cmd);
            DataSet ds = new DataSet();
            _ = da.Fill(ds, "CustomersActions");
            Cry_CustomerActions rpt = new Cry_CustomerActions();
            rpt.SetDataSource(ds.Tables["CustomersActions"]);
            crystalReportViewer1.ReportSource = rpt;

        }

        private void Btn_GtDT_Click(object sender, System.EventArgs e)
        {
            Cry_CustomerActions cp = new Cry_CustomerActions();
            crystalReportViewer1.ReportSource = cp;
            ParameterField pram = new ParameterField
            {
                Name = "@Date"
            };
            ParameterDiscreteValue pvalue = new ParameterDiscreteValue
            {
                Value = Dt_Get.Text
            };
            pram.CurrentValues.Clear();
            _ = pram.CurrentValues.Add(pvalue);
            _ = crystalReportViewer1.ParameterFieldInfo.Add(pram);
        }
    }
}