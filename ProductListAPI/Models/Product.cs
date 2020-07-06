using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductListAPI.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get;  set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public decimal ListPrice { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
    }
}
