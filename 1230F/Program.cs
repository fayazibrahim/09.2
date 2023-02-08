using System;
using System.Dynamic;

namespace _1230F
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Count Engineer:");
            var counts = Console.ReadLine();
            int count = Convert.ToInt32(counts);

            Engineer[] engineers = new Engineer[count];

            for (int i = 0; i < count; i++)
            {

                Console.WriteLine("Fullname:");
                string fullname = Console.ReadLine();

                slz: Console.WriteLine("Salary:");
                string slx = Console.ReadLine();
                var sl = Convert.ToInt32(slx);
                
                
                if (sl < 1000)
                
                    goto slz;


                Engineer arr = new Engineer {Salary = sl };
                
                
                
                Console.WriteLine();
                engineers[i] = arr;
            }
                double sum = 0;
                for (int i = 0; i < engineers.Length; i++)
                {
                    sum += engineers[i].Salary;
                }
                var result = sum / engineers.Length;

                Console.WriteLine(result);

            }
    }
}
