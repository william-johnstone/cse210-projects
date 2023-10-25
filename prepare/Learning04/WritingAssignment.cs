using System;

namespace library_demo
{
    public class WritingAssignment : Assignment
    {
        private string _title;

        public string GetWritingInformation()
        {
            string studentName = GetStudentName();

            return $"{_title} by {studentName}";
        }
        
        public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
        {
            _title = title;
        }

    }
}