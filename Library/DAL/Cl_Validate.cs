
using System.Windows.Forms;

namespace Library.DAL
{
    internal class Cl_Validate
    {
        public void TxtClear(Form frm, DevExpress.XtraEditors.PanelControl pnl)
        {
            foreach (Control item in frm.Controls)

            {
                if (item is DevExpress.XtraEditors.PanelControl)
                {
                    foreach (Control itemGroup in pnl.Controls)
                    {
                        if (itemGroup is DevExpress.XtraEditors.TextEdit)
                        {
                            itemGroup.Text = "";
                        }

                        if (itemGroup is DevExpress.XtraEditors.ComboBoxEdit)
                        {
                            itemGroup.Text = "";
                        }

                        if (itemGroup is ComboBox)
                        {
                            itemGroup.Text = "";
                        }

                        if (itemGroup is DataGrid)
                        {
                            itemGroup.Text = "";
                        }

                    }

                }
            }
        }
    }
}
