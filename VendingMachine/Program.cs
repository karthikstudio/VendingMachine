using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Please enter your choice of drink.. \n" +
                "====================\n" +
                "1: Hot Chocolate\n" +
                "2: White Coffee\n" +
                "3: Lemon Tea\n" +
                "4: Iced Coffee\n" +
                "====================\n");
            string input = Console.ReadLine();
            makeDrink(input);
            Console.Read();

        }

        static void makeDrink(string choice) {
            switch (choice) {
                case "1":
                    HotChocolate hotChocolate = new HotChocolate();
                    hotChocolate.ReadyWaterBase();
                    hotChocolate.AddIngredients();
                    hotChocolate.AddWaterBase();
                    break;
                case "2":
                    Console.Write("How many cubes of sugar? :");
                    String sugarQuantity = Console.ReadLine();
                    try {
                        WhiteCoffee whiteCoffee = new WhiteCoffee(int.Parse(sugarQuantity));
                        whiteCoffee.ReadyWaterBase();
                        whiteCoffee.AddIngredients();
                        whiteCoffee.AddWaterBase();
                        whiteCoffee.addMilk();
                    }
                    catch(FormatException) {
                        Console.Write("You entered an incorrect amount..");
                    }
                    break;
                case "3":
                    LemonTea lemonTea = new LemonTea();
                    lemonTea.ReadyWaterBase();
                    lemonTea.AddWaterBase();
                    lemonTea.addTeaBag();
                    lemonTea.AddIngredients();
                    break;
                case "4":
                    IcedCoffee icedCoffee = new IcedCoffee();
                    icedCoffee.ReadyWaterBase();
                    icedCoffee.AddWaterBase();
                    icedCoffee.AddIngredients();
                    icedCoffee.blend();
                    break;
            }
        }
    }
}

