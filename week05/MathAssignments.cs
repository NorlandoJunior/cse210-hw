using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week05
{
    public class MathAssignments
    {
        public class Math
        {
            protected string _studentName = "";
            protected string _topic = "";
            private string _textbookSection = "";
            private string _problems = "";

            public Math(string studentName, string topic, string textbookSection, string problems)
            {
                _studentName = studentName;
                _topic = topic;
                _textbookSection = textbookSection;
                _problems = problems;
            }

            public string GetStudentName()
            {
                return _studentName;
            }

            public void SetStudentName(string studentName)
            {
                _studentName = studentName;
            }
            
            public string GetTopic()
            {
                return _topic;
            }

            public void SetTopic(string topic)
            {
                _topic = topic;
            }

            public string GetTextbookSection()
            {
                return _textbookSection;
            }

            public void SetTextbookSection(string textbookSection)
            {
                _textbookSection = textbookSection;
            }

            public string GetProblems()
            {
                return _problems;
            }

            public void SetProblems(string problems)
            {
                _problems = problems;
            }
            
            
            public string GetSummary()
            {
                return $"{_studentName} - {_topic} \nSection {_textbookSection} Problems {_problems}";

            }
        }
    }
}