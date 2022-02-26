
using System;

namespace Library.DAL
{
    public class Orders
    {
        public int OrderID { get; set; }

        public string CustomersID { get; set; }
        [Display(Name = "Contact Name")]
        public string CuntactName { get; set; }

        public string Adreess { get; set; }
        [Display(Name = "Postal Code")]

        public string PostalCode { get; set; }

        public string City { get; set; }

        public string Phone { get; set; }

        public DateTime OrderDate { get; set; }

    }

    internal class DisplayAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
