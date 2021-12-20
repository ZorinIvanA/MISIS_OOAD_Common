using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISIS.OOAD.COMMON.Foods
{
    public class CommonSandwich : SandwichBase
    {
        public CommonSandwich(Meats meat, decimal price, string name) : base(meat, price, name)
        {
        }
    }
}
