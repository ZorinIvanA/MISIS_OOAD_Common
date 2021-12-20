using MISIS.OOAD.COMMON.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISIS.OOAD.COMMON.Factories
{
    public class CommonFoodFactory : FoodFactoryBase
    {
        public override Cola CreateCola(float bottleVolume)
        {
            return new Cola(bottleVolume, 50, "Coca-cola");
        }

        public override SandwichBase CreateSandwich(Meats meat)
        {
            return new CommonSandwich(meat, 100, "Common sandwich");
        }
    }
}
