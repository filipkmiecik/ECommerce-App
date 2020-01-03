using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.ViewModels
{
    public class HomeVM
    {
        public string Title { get; set; }
        public List<Product> Products { get; set; }
    }
}
