using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine {
    class Coffee : IDrink {
        public void AddIngredients() {
            Console.WriteLine("Add coffee granules to cup..");
        }

        public void AddWaterBase() {
            Console.WriteLine("Add water..");
        }

        public void ReadyWaterBase() {
            Console.WriteLine("Boil water..");
        }
    }
}
