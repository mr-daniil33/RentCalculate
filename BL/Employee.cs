using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class Employee
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        private string middleName;

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }
        private DateTime dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Employee() {}
        public Employee(string firstName, string surname, string middleName, int id)
        {
            this.firstName = firstName;
            this.surname = surname;
            this.middleName = middleName;
            this.id = id;
        }
        public string GetSurnameAndFirstLetterOfNameAndFirstLetterOfPatronimic() 
        {

            string first = firstName.Substring(0, 1);
            string middle = middleName.Substring(0, 1);
            return surname + " " + first + "." + middle;
        }

        public int CalculateSalary(int a, int b)
        {
            return 2 * a + 3 * b + 1;
        }
    }
}
