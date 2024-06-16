using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Details
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("sanket ","Trainee ","Male ",23,25000);
            Console.WriteLine("Employee Details :");
            e1.Info();

            Console.WriteLine("***************************************************************");
            Employee m1 = new Manager("ajay", "Manager", "Male", 29, 45000);
            Console.WriteLine("Manager Details :");
            m1.Info();
            
            Console.WriteLine("******************************************************************");
            Employee p1 = new DeliveryPartner("vijay", "Delivary Partner", "Male", 26, 28000);
            Console.WriteLine("Delivery Partnet Details :");
            p1.Info();
            
            
        }
    }
}
