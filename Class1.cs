using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWPF14T1
{
    public enum Category
    {
        Продукты,
        Бытовая_техника
    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
