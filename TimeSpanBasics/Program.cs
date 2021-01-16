using System;

namespace TimeSpanBasics
{
    class Program
    {
        static void Main(string[] args)
        {
           //Time span = length of time
           //three ways of making timespan
           //1
           var timeSpan1 = new TimeSpan(1, 2, 3); //1-hr, 2-min , 3-sec
           //2
           var timespan2 = TimeSpan.FromHours(1);
           //3
           var start = DateTime.Now;
           var end = DateTime.Now.AddMinutes(2);
           var duration = end - start;

           Console.WriteLine("Duration: " + duration);

           // Properties Paired properties (Total******)
           Console.WriteLine(".Minutes: " + timeSpan1.Minutes);// only returns minute component of time span
           Console.WriteLine(".TotalMinutes: " + timeSpan1.TotalMinutes);//returns all minutes(even from hours). Converts whole Stimespan to mins.

            //Add to TS
            Console.WriteLine("Add Examples: " + timeSpan1.Add(TimeSpan.FromMinutes(9)));
            Console.WriteLine("Sub Examples: " + timeSpan1.Subtract(TimeSpan.FromMinutes(6)));


            //Conversion too a string
            Console.WriteLine("To String: " + timeSpan1.ToString());

            //conversion from a string
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));


        }
    }
}
