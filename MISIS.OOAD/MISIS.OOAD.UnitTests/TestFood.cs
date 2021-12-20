using MISIS.OOAD.COMMON.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISIS.OOAD.UnitTests
{
    public class TestFood : FoodBase
    {
        public TestFood(decimal price, string name) : base(price, name)
        {
        }
    }
}
