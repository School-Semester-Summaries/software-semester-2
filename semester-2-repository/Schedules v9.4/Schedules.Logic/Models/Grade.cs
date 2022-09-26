namespace Schedules.Logic.Classes
{
    public class Grade
    {
        private readonly int _studentId;
        private readonly int _testId;
        private readonly decimal _grade;
        private readonly string _submissionDate;

        public int StudentId { get { return _studentId; } }
        public int TestId { get { return _testId; } }
        public decimal GradeProp{ get { return _grade; } }
        public string SubmissionDate{ get { return _submissionDate; } }

        public Grade(int studentId, int testId, decimal grade, string submissionDate)
        {
            _studentId = studentId;
            _testId = testId;
            _grade = grade;
            _submissionDate = submissionDate;
        }
    }
}
