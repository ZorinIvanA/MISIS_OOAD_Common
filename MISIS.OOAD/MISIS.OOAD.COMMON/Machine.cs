using MISIS.OOAD.COMMON.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISIS.OOAD.COMMON
{
    public class Machine
    {
        public List<FoodBase> Foods { get; set; }

        public IDictionary<Banknotes, int> Banknotes { get; private set; }
        public IDictionary<Coins, int> Coins { get; private set; }

        public Machine()
        {
            Foods = new List<FoodBase>();
        }

        public void Load(FoodBase item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            (Foods as List<FoodBase>).Add(item);
        }

        public void Load(IEnumerable<FoodBase> foods)
        {
            if (foods == null)
                throw new ArgumentNullException(nameof(foods));

            if (foods.Count() == 0)
                throw new ArgumentException("Foods array is empty", nameof(foods));

            foreach (var item in foods)
                Load(item);
        }

        public void FillWithMoney(Dictionary<Banknotes, int> banknotes, Dictionary<Coins, int> coins)
        {
            if ((banknotes is null || banknotes.Count == 0) && (coins is null || coins.Count == 0))
                throw new ArgumentException("You haven't loaded the money");

            Banknotes = banknotes;
            Coins = coins;
        }

        public void Buy<TFood>(
            int number,
            Dictionary<Banknotes, int> banknotes,
            Dictionary<Coins, int> coins)
            where TFood : FoodBase
        {
            for (int i = 0; i < number; i++)
            {
                Foods.Remove(Foods.First(x => x.GetType() == typeof(TFood)));
            }

            foreach (var kvp in banknotes)
                Banknotes.Add(kvp);

            foreach (var kvp in coins)
                Coins.Add(kvp);
        }
    }
}
