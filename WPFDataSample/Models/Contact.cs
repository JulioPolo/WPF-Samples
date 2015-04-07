using System;
using System.Collections.Generic;

namespace WPFDataSample.Models
{
    public partial class Contact
    {
        public Contact()
        {
            this.Addresses = new List<Address>();
        }

        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public System.DateTime AddDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
