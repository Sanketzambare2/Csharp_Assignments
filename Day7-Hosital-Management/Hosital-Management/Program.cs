using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hosital_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to ABC Hospital");

            List<Patient> allPatients = new List<Patient>();
            bool addMoreDepartments = true;

            while (addMoreDepartments)
            {
                Department department = Department.SelectDepartment();
                Patient[] patients = department.AddPatients();
                allPatients.AddRange(patients);

                Console.Write("Do you want to add details for another department? (yes/no): ");
                string addAnotherDepartmentInput = Console.ReadLine();
                addMoreDepartments = addAnotherDepartmentInput.ToLower() == "yes";

                if (addMoreDepartments)
                {
                    Console.WriteLine(); 
                }
            }

            Console.WriteLine("\nSearch for a patient by Phone Number:");
            Console.Write("Enter Phone Number: ");
            string searchPhoneNumber = Console.ReadLine();

            Patient searchedPatient = allPatients.Find(p => p.PhoneNumber == searchPhoneNumber);

            if (searchedPatient != null)
            {
                Console.WriteLine("\nPatient Details:");
                Console.WriteLine(searchedPatient);
            }
            else
            {
                Console.WriteLine("Patient not found.");
            }
        }
    }
}
