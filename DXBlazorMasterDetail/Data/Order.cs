using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DXBlazorMasterDetail.Data
{
    
    [Table("SalesOrderHeader")]
    public class Order
    {
        [Key]
        public int SalesOrderID { get; set; }

        public int CustomerID { get; set; }
        public string SalesOrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TaxAmt { get; set; }
        public decimal Freight { get; set; }
        public decimal TotalDue { get; set; }

        
    }
}
