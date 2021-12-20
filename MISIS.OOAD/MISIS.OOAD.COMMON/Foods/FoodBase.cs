using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISIS.OOAD.COMMON.Foods
{
    public abstract class FoodBase
    {
        public decimal Price { get; }
        public string Name { get; }

        public FoodBase(decimal price, string name)
        {
            Price = price;
            Name = !string.IsNullOrWhiteSpace(name) ? name : throw new ArgumentNullException(nameof(name));
        }
    }
}
