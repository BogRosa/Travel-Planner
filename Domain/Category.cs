using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Category
    {
        public int CategoryId { get; private set; }
        public string Name { get; private set; }

        public Category(int categoryId, string name)
        {
            CategoryId = categoryId;
            Name = name;
        }
    }
}
