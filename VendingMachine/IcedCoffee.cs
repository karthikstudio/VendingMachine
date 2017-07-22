using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine {
    class IcedCoffee : Coffee {
        public new void AddIngredients() {
            Console.WriteLine("Add coffee syrup to blender..");
            Console.WriteLine("Add ingredients..");
        }

        public new void AddWaterBase() {
            Console.WriteLine("Add ice to blender..");
        }

        public new void ReadyWaterBase() {
            Console.WriteLine("Crush Ice..");
        }

        public void blend() {
            Console.WriteLine("Blend ingredients..");
        }
    }
}
