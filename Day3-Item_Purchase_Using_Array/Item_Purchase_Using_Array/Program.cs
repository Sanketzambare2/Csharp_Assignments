using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item_Purchase_Using_Array
{
    internal class Program
    {
        public static void ShowMenu() { 
        
        }
        public static void PurchaseItemAndQuantity() { 
        
        }
        public static void CalculateBill() { 
        
        
        }

        static void Main(string[] args)
        {

            bool run = true;
            while (run) {
                Console.WriteLine("Enter a choice ");
                Console.WriteLine("1.ShowMenu ");
                Console.WriteLine("2.Purchace item and Quantity");
                Console.WriteLine("3.Calculate bill ");

                int ch = int.Parse(Console.ReadLine());

                switch (ch) {

                    case 1: ShowMenu();
                        break;
                    case 2:
                        PurchaseItemAndQuantity();
                        break;
                    case 3:
                        CalculateBill();
                        break;
                }

                Console.WriteLine("Purchace item :(y/n)");
                string s = Console.ReadLine();
                if (s == "n") {
                    run = false;
                }
            }
        }
    }
}
