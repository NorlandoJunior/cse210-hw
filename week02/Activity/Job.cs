using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity
{
    public class Job
    { 
        public string _jobtitle;
        public string _company;
        public int _startYear;
        public int _endYear;

        public void Display()
        {
            Console.WriteLine($"{_jobtitle} {_company} {_startYear}-{_endYear}");
        }


    }
}       