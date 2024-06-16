using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Details_Without_Overriding
{
    internal class Delivery_Partner : Employee
    {
        public Delivery_Partner(string name, string title, string gender, int age, double baseSalary) : base(name, title, gender, age, baseSalary)
        {

        }

        public double pbonus;
        public void CalculateBonus()
        {

            pbonus = baseSalary * 20 / 100;
            Console.WriteLine("Delivery Partner Bonus :" + pbonus);

        }
        public new void Info() {

            base.Info();
            CalculateBonus();
        } 

    }
}