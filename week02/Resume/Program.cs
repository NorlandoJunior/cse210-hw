    using System;
    using Resume;


    class Program {

        static void Main(string[] args)
        {

            Job job1 = new Job("Software Engineer", "Microsoft", 2019, 2022);
            Job job2 = new Job("Manager", "Apple", 2022, 2023);

            job1.DisplayJob();
            job2.DisplayJob();

            
        }
    }