using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DXBlazorMasterDetail.Data
{
    [Table("vwProductOrderLine")]
    public class ProductOrderLine
    {
        [Key]
        public int SalesOrderDetailID { get; set; }
        public int SalesOrderID { get; set; }
        public string Name { get; set; }
        public string ThumbnailPhotoFileName { get; set; }
        public string CategoryName { get; set; }
        public decimal OrderQty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }
    }
}
