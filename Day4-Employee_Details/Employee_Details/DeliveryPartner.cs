using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Details
{
    internal class DeliveryPartner : Employee 
    {
        public DeliveryPartner(string name, string title, string gender, int age, double baseSalary) : base(name, title, gender, age, baseSalary)
        {

        }

        public double pbonus;
        public void CalculateBonus()
        {

            pbonus = baseSalary * 20/ 100;
            Console.WriteLine("Delivery Partner Bonus :" + pbonus);

        }
        public override void Info()
        {
            base.Info();
            CalculateBonus();
        }
    }
}
