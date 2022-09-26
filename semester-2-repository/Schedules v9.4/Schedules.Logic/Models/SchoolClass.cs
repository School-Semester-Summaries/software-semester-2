namespace Schedules.Logic.Classes
{
    public class SchoolClass
    {
        private readonly int _id;
        private readonly string _name;
        private readonly int _year;
        private readonly string _suffix;

        public int ID { get { return _id; } }
        public string Name { get { return _name; } }
        public int Year { get { return _year; } }
        public string Suffix { get { return _suffix; } }

        public SchoolClass(string name, int year, string suffix)
        {
            _name = name;
            _year = year;
            _suffix = suffix.ToLower();
        }

        public SchoolClass(int id, string name, int year, string suffix)
        {
            _id = id;
            _name = name;
            _year = year;
            _suffix = suffix;
        }
    }
}
