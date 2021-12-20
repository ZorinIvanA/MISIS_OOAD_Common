using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISIS.OOAD.COMMON.Foods
{
    public class Cola : FoodBase
    {
        public float Volume { get; }

        public Cola(float volume, decimal price, string name) : base(price, name)
        {
            Volume = volume;
        }
    }
}
