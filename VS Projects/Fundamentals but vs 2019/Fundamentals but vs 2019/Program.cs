using System;

namespace Fundamentals_but_vs_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.addGrade(91);
            book.addGrade(89.5f);
            book.addGrade(75);

            int z = 1654;
            GradeBook.x = z;
            Console.WriteLine(GradeBook.x);
            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
        }
    }
}
