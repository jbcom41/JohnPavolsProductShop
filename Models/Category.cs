using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JohnPavolsProductShop.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        
        [Required(ErrorMessage ="Please enter category name")]
        public String Name { get; set; }
    }
}
