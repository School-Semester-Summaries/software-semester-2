namespace Schedules.Logic.Classes
{
    public enum Subjects
    {
        Taal,
        Rekenen,
        Biologie,
        Geschiedenis,
        Aardrijkskunde
    }

    public class Test
    {
        private readonly int _id;
        private readonly Subjects _subject;
        private readonly string _name;
        private readonly int _weight;

        public int Id { get { return _id; } }
        public Subjects Subject { get { return _subject; } }
        public string Name { get { return _name; } }
        public int Weight { get { return _weight; } }

        public Test(int id, Subjects subject, string name, int weight)
        {   
            _id = id;
            _subject = subject;
            _name = name;
            _weight = weight;
        }
    }
}
