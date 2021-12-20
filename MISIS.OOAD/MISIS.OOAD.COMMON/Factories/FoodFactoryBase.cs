using MISIS.OOAD.COMMON.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISIS.OOAD.COMMON.Factories
{
    public abstract class FoodFactoryBase
    {
        public abstract Cola CreateCola(float bottleVolume);
        public abstract SandwichBase CreateSandwich(Meats meat);
    }
}
