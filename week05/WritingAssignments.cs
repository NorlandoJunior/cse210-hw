using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week05
{
    public class WritingAssignments : MathAssignments
    {
        public class Writing : Math 
        {
            private string _title = "";
            private string _author = "";

             public Writing(string studentName, string topic, string title, string author) : base(studentName, topic, "", "")
            {
            
                _title = title;
                _author = author;
                
            }


            public string GetTitle()
            {
                return _title;
            }

            public void SetTitle(string title)
            {
                _title = title;
            }

            public string GetAuthor()
            {
                return _author;
            }

            public void SetAuthor(string author)
            {
                _author = author;
            }

            public string GetWritingSummary()
            {
                return $"{_studentName} - {_topic}\n{_title} by {_author}";
            }

        
        }
    }
}