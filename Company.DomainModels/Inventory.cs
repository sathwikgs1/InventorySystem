using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.DomainModels
{
    [Table("Inventory", Schema = "dbo")]
    public class Inventory
    {
        [Key]
        [Display(Name = "Product ID")]
        public long ProductID { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Price")]
        public Nullable<decimal> Price { get; set; }


        [Display(Name = "Availability Status")]
        public string AvailabilityStatus { get; set; }
    }
}
