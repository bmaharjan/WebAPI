using System;
using System.ComponentModel.DataAnnotations;

namespace ProductListAPI.Models
{
    public class ProductCostHistory
    {
        [Key]
        public int ProductID { get; set; }

        [Key]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }
        
        [DataType(DataType.DateTime)]
        public DateTime? EndDate { get; set; }
        public decimal StandardCost { get; set; }
    }
}
