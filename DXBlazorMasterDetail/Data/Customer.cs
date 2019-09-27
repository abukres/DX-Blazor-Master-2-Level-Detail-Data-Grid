using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DXBlazorMasterDetail.Data
{
    [Table("vwCustomerAddress")]
    public class Customer
    {
        [Key]
        public int CustomerID  { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }

        [Column("StateProvince")]
        public string State { get; set; }



    }
}
