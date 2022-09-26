namespace Schedules.Logic.Classes
{
    public class Teacher
    {
        private readonly int _id;
        private readonly int _schoolClassId;
        private readonly string _name;
        private readonly string _birthdate;
        private readonly string _mail;
        private readonly int _phone;

        public int Id { get { return _id; } }
        public int SchoolClassId { get { return _schoolClassId; } }
        public string Name { get { return _name; } }
        public string Birthdate { get { return _birthdate; } }
        public string Mail { get { return _mail; } }
        public int Phone { get { return _phone; } }

        public Teacher(int schoolClassId, string name, string birthdate, string mail, int phone)
        {
            _schoolClassId = schoolClassId;
            _name = name;
            _birthdate = birthdate;
            _mail = mail;
            _phone = phone;
        }

        public Teacher(int id, int schoolClassId, string name, string birthdate, string mail, int phone)
        {
            _id = id;
            _schoolClassId = schoolClassId;
            _name = name;
            _birthdate = birthdate;
            _mail = mail;
            _phone = phone;
        }
    }
}
