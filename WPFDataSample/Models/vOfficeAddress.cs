using System;
using System.Collections.Generic;

namespace WPFDataSample.Models
{
    public partial class vOfficeAddress
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int addressID { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string CountryRegion { get; set; }
        public string PostalCode { get; set; }
        public string AddressType { get; set; }
        public int ContactID { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}
