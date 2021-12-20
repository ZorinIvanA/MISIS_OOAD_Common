using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISIS.OOAD.COMMON.Foods
{
    public abstract class SandwichBase : FoodBase
    {
        public Meats Meat { get; }

        public SandwichBase(Meats meat, decimal price, string name) : base(price, name)
        {
            Meat = meat;
        }
    }
}
