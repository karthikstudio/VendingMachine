using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine {
    class Chocolate : IDrink {
        public void AddIngredients() {
            Console.WriteLine("Add drinking chocolate to cup..");
        }

        public void AddWaterBase() {
            Console.WriteLine("Add water..");
        }

        public void ReadyWaterBase() {
            Console.WriteLine("Boil water..");
        }
    }
}
