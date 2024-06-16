using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Details_Without_Overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Rakesh", "Trainee ", "Male ", 23, 25000);
            Console.WriteLine("Employee Details :");
            e1.Info();

            Console.WriteLine("***************************************************************");
            Manager m1 = new Manager("Raviraj", "Manager", "Male", 29, 55000);
            Console.WriteLine("Manager Details :");
            m1.Info();
            
            

            Console.WriteLine("******************************************************************");
           Delivery_Partner p1 = new Delivery_Partner("Vinay", "Delivary Partner", "Male", 26, 38000);
            Console.WriteLine("Delivery Partnet Details :");
            p1.Info();
           

        }
    }
}
