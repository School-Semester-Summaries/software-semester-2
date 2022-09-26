using Schedules.Logic.Classes;
using System.Collections.Generic;

namespace Schedules.Presentation.Models
{
    public class TeacherViewModel
    {
        public List<Teacher> TeacherList { get; set; }
        public List<SchoolClass> SchoolClassList { get; set; }
        public int TeacherId{ get; set; }
        public int SchoolClassId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get { return (FirstName + " " + LastName); } }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string Birthdate { get { return CreateBirthDate(Day, Month, Year); } }
        public int Phone { get; set; }
        public string Mail { get { return CreateMail(FirstName, LastName); } }

        string CreateBirthDate(int day, int month, int year)
        {
            string birthdate = null;
            birthdate = AddToBirthdate(birthdate, year);
            birthdate += "-";
            birthdate = AddToBirthdate(birthdate, month);
            birthdate += "-";
            birthdate = AddToBirthdate(birthdate, day);
            return birthdate;
        }

        string AddToBirthdate(string birthdate, int num)
        {
            string digits = num.ToString();
            if (digits.Length == 1)
            {
                birthdate += 0 + digits;
            }
            else if (digits.Length >= 2)
            {
                birthdate += digits;
            }
            return birthdate;
        }

        string CreateMail(string firstName, string lastName)
        {
            string mail = null;
            mail = firstName.ToLower() + lastName.ToLower() + "@schedules.com";
            return mail;
        }
    }
}
