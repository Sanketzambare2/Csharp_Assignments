using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Details
{
    public class Manager : Employee {

        public Manager(string name, string title, string gender, int age, double baseSalary) : base(name, title, gender, age, baseSalary) { 
        
        }

        public double mbonus;
        public void CalculateBonus() {

            mbonus = baseSalary * 10 /100;
            Console.WriteLine("Manager Bonus :" + mbonus);
        }
        public override void Info() {
            base.Info();
            CalculateBonus();
        
        }


    
    
    }
}
