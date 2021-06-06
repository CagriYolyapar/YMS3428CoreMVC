using CoreMVCIntro.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCIntro.VMClasses
{
    public class ProductVM
    {
        public Product Product { get; set; }
        public List<Product> Products { get; set; }

    }
}
