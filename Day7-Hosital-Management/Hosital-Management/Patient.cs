using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hosital_Management
{
    internal class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }
        public string Department { get; set; }

        public Patient(string firstName, string lastName, string gender, int age, string phoneNumber, string state, string pincode, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Age = age;
            PhoneNumber = phoneNumber;
            State = state;
            Pincode = pincode;
            Department = department;
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}\nGender: {Gender}\nAge: {Age}\nPhone: {PhoneNumber}\nState: {State}\nPincode: {Pincode}\nDepartment: {Department}";
        }
    }
}
