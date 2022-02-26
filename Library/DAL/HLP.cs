using System.Windows.Forms;
namespace Library.DAL
{
    internal static class Help
    {
        /// <summary>
        /// To make TextBox Allow Decimal Format Only
        /// </summary>
        /// <param name="sender">Sender Object Paramter For TextBox Event Keypress</param>
        /// <param name="e">e KeyPressEventArgs Paramter For TextBox Event Keypress</param>
        /// <returns></returns>
        public static bool TextDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                return true;
            }

            // only allow one decimal point
            return (e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1);
        }


        public static int ToInt(TextBox txt)
        {
            return txt.Text.Trim() == "" ? 0 : int.Parse(txt.Text.Trim());
        }
        public static int ToInt(string str)
        {
            return str.Trim() == "" ? 0 : int.Parse(str.Trim());
        }

        public static decimal ToDecimal(TextBox txt)
        {
            return txt.Text.Trim() == "" ? 0 : decimal.Parse(txt.Text.Trim());
        }
        public static decimal ToDecimal(string str)
        {
            return str.Trim() == "" ? 0 : decimal.Parse(str.Trim());
        }
        public static int ComboBoxSelectedValue(ComboBox cmb)
        {
            return cmb.SelectedValue != null ? cmb.SelectedValue.ToString() != "-1" ? int.Parse(cmb.SelectedValue.ToString()) : 0 : 0;

        }
    }
}
