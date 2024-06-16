using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Details_Without_Overriding
{
    internal class Employee
    {
        public string name { get; set; }

        public string title { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public double baseSalary { get; set; }


        public Employee()
        {


        }

        public Employee(string name, string title, string gender, int age, double baseSalary)
        {

            this.name = name;
            this.title = title;
            this.gender = gender;
            this.age = age;
            this.baseSalary = baseSalary;
        }
        public  void Info()
        {
            Console.WriteLine("Name :" + name + " Title :" + title + " Gender :" + gender + " age : " + age + " baseSalary :" + baseSalary);
        }
    
}
}
