using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume
{
    public class Job
    { 
        public string JobTitle { get; set; }
        public string Company{ get; set;}
        public int StartYear{ get; set; }
        public int EndYear{ get; set; }

        public Job(string jobTitle, string company, int startYear, int endYear)
        {
            JobTitle = jobTitle;
            Company = company;
            StartYear = startYear;
            EndYear = endYear;
        }

        public void DisplayJob()
        {
            Console.WriteLine($"Job Title: {JobTitle}");
            Console.WriteLine($"Company: {Company}");
            Console.WriteLine($"{StartYear}");
            Console.WriteLine($"{EndYear}");

        }
    }
}