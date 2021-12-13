using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISIS.OOAD.COMMON
{
    public class Machine
    {
        public IEnumerable<Food> Foods { get; set; }

        public Machine()
        {
            Foods = new List<Food>();
        }

        public void Load(Food item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            (Foods as List<Food>).Add(item);
        }

        public void Load(IEnumerable<Food> foods)
        {
            if (foods == null)
                throw new ArgumentNullException(nameof(foods));

            if (foods.Count() == 0)
                throw new ArgumentException("Foods array is empty", nameof(foods));

            foreach (var item in foods)
                Load(item);
        }
    }
}
