using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Provide Student details :");
            Console.WriteLine("Enter First Name :");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name :");
            string lastName = Console.ReadLine();

           
            Console.WriteLine("Enter age :");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  Address 1 :");
            string a1 = Console.ReadLine();

            Console.WriteLine("Enter Address 2:");
            string a2 = Console.ReadLine();

            Console.WriteLine("Enter city:");
            string city = Console.ReadLine();

            Console.WriteLine("Enter state :");
            string state = Console.ReadLine();

            Console.WriteLine("Enter Email Id :");
            string email = Console.ReadLine();

            Console.WriteLine("Enter Phone Number :");
            int phoneNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Gender :");
            string gender = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Student details entered by you is :");

            Console.WriteLine("First Name is : " + firstName);
            Console.WriteLine("Last Name is  : " + lastName);
            Console.WriteLine("Age is  : " + age);
            Console.WriteLine("Address 1 is: " + a1);
            Console.WriteLine("Address 2 is: " + a2);
            Console.WriteLine("City is: " + city);
            Console.WriteLine("State  is: " + state);
            Console.WriteLine("Email id  is: " + email);
            Console.WriteLine("Phone Number is: " + phoneNumber);
            Console.WriteLine("Gender is: " + firstName);
            


        }
    }
}
