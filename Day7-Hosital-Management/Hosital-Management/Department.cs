using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hosital_Management
{
    internal class Department
    {
        public string Name { get; }
        public int Fee { get; }

        public Department(string name, int fee)
        {
            Name = name;
            Fee = fee;
        }

        public static Department SelectDepartment()
        {
            Console.WriteLine("Select the Department for treatment:");
            Console.WriteLine("1. General : 400");
            Console.WriteLine("2. ENT : 800");
            Console.WriteLine("3. Cardiology : 1200");
            Console.WriteLine("4. Operation Theater : 5000");
            Console.WriteLine("5. Intensive care Unit : 6000");
           
            int departmentChoice = int.Parse(Console.ReadLine());

            switch (departmentChoice)
            {
                case 1:
                    return new Department("General", 400);
                case 2:
                    return new Department("ENT", 800);
                case 3:
                    return new Department("Cardiology", 1200);
                case 4:
                    return new Department("Operation Theater", 5000);
                case 5:
                    return new Department("Intensive care Unit", 6000);
                default:
                    Console.WriteLine("Invalid choice. Assigning General by default.");
                    return new Department("General", 400);
            }
        }

        public Patient[] AddPatients()
        {
            Console.Write("Enter number of patients: ");
            int numberOfPatients = int.Parse(Console.ReadLine());

            Patient[] patients = new Patient[numberOfPatients];

            for (int i = 0; i < numberOfPatients; i++)
            {
                Console.WriteLine($"\nEnter details for Patient {i + 1}:");

                Console.Write("First Name: ");
                string firstName = Console.ReadLine();

                Console.Write("Last Name: ");
                string lastName = Console.ReadLine();

                Console.Write("Gender: ");
                string gender = Console.ReadLine();

                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Phone Number: ");
                string phoneNumber = Console.ReadLine();

                Console.Write("State: ");
                string state = Console.ReadLine();

                Console.Write("Pincode: ");
                string pincode = Console.ReadLine();

                patients[i] = new Patient(firstName, lastName, gender, age, phoneNumber, state, pincode, Name);
            }

            return patients;
        }

    }
}
