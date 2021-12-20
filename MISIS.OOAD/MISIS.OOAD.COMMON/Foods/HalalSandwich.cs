using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISIS.OOAD.COMMON.Foods
{
    public class HalalSandwich : SandwichBase
    {
        public HalalSandwich(Meats meat, decimal price, string name) : base(meat, price, name)
        {
            if (meat == Meats.Pork)
                throw new ArgumentException("This kind of food can't be sold in this region", nameof(meat));
        }
    }
}
