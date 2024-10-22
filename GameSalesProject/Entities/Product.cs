using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Entities
{
    public class Product
    {
        public int Product_Id { get; set; }
        public string ProductName { get; set; }
        public int Product_Price { get; set; }
        public string Product_Description { get; set; }
        public string Product_Category { get; set; }

    }
}
