using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Items
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int c1Quantity = 0;
            int s1Quantity = 0;
            int f1Quantity = 0;
            int n1Quantity = 0;
            int p1Quantity = 0;
            int cPrize = 40; 
            int sPrize = 80;
            int fPrize = 60;
            int nPrize = 50;
            int pPrize = 120;
            

            bool a = true;
            while (a)
            {
                Console.WriteLine("Select the items from the menu :");
                Console.WriteLine("1.Coffee");
                Console.WriteLine("2.Grilled Sandwich");
                Console.WriteLine("3.French Fries");
                Console.WriteLine("4.Noodles");
                Console.WriteLine("5.Pizza");

                int item = Convert.ToInt32(Console.ReadLine());

               
                switch (item)
                {

                    case 1:
                        Console.WriteLine("Enter Quantity :");
                       int  cQuantity = Convert.ToInt32(Console.ReadLine());
                        c1Quantity = c1Quantity+cQuantity;
                        


                        break;

                    case 2:
                        Console.WriteLine("Enter Quantity :");
                       int sQuantity = Convert.ToInt32(Console.ReadLine());
                        
                          s1Quantity = s1Quantity + sQuantity;
                       
                        break;



                    case 3:
                        Console.WriteLine("Enter Quantity :");
                       int fQuantity = Convert.ToInt32(Console.ReadLine());
                        f1Quantity = f1Quantity + fQuantity;
                       
                        break;

                    case 4:
                        Console.WriteLine("Enter Quantity :");
                       int nQuantity = Convert.ToInt32(Console.ReadLine());
                        n1Quantity = n1Quantity + nQuantity;
                       

                        break;

                    case 5:
                        Console.WriteLine("Enter Quantity :");
                       int pQuantity = Convert.ToInt32(Console.ReadLine());
                        p1Quantity = p1Quantity + pQuantity;
                       

                        break;

                }
                Console.WriteLine("You want add more items : (y/n)");

                string ans = Console.ReadLine();

                if (ans == "n") {
                    a = false;
                
                }

              
            }
            Console.WriteLine("Item selecte by you :" + " Coffee :" + c1Quantity + " Sandwitch :" + s1Quantity + " Fries :" + f1Quantity + " Noodles: " + n1Quantity + " Pizza : " + p1Quantity);


            long total = c1Quantity + s1Quantity + f1Quantity + n1Quantity + p1Quantity;
            Console.WriteLine("Toatal items is :" + total);

            cPrize = cPrize * c1Quantity;
            sPrize = sPrize * s1Quantity;
            fPrize = fPrize * f1Quantity;
            nPrize = nPrize * n1Quantity;
            pPrize = pPrize * p1Quantity;

            int tPrize = cPrize + sPrize + fPrize + nPrize + pPrize;
           

            Console.WriteLine("Total Bill is :" + tPrize);

            double cgst = tPrize * 5 / 100;

            double sgst = tPrize * 18 / 100;

            Console.WriteLine(" CGST :" + cgst);
            Console.WriteLine("SGST :" + sgst);
            double tm = tPrize + cgst + sgst;

            Console.WriteLine("Total amount to pay :" + tm);


        }
        }
    }
