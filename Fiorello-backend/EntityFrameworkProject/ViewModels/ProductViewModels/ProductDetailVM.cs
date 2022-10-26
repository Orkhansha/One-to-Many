using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkProject.ViewModels.ProductViewModels
{
    public class ProductDetailVM
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Description { get; set; }
        public string CategoryName { get; set; }
    }
}
