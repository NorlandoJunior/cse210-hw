using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week05
{
    public class Assignments
    {
        static void Main(string[] args)
        {
            
            MathAssignments.Math math1 = new MathAssignments.Math("Samuel Bennett", "Multiplication", "7.3", "8-19");

            
            MathAssignments.Math math2 = new MathAssignments.Math("Roberto Rodriguez", "Fractions", "7.3", "8-19");

           
            WritingAssignments.Writing writing1 = new WritingAssignments.Writing("Mary Waters", "European History", "The Causes of World War II", "Mary Waters");

            
            Console.WriteLine(math1.GetSummary());
            Console.WriteLine(math2.GetSummary());
            Console.WriteLine(writing1.GetWritingSummary());
        }
    
    
    }

}