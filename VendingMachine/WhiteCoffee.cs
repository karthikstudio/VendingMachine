using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine {
    class WhiteCoffee : Coffee{

        private int numOfSugar = 0;

        public WhiteCoffee(int numOfSugar) {
            this.numOfSugar = numOfSugar;
        }

        public new void AddIngredients() {
            Console.WriteLine("Adding " + numOfSugar + "x sugar..");
            Console.WriteLine("Add coffee granules to cup..");
        }

        public void addMilk() {
            Console.WriteLine("Add milk..");
        }
    }
}
