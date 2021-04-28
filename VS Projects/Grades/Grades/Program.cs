using System;
using System.Speech.Synthesis;
namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello! this Kamal Saad");
            GradeBook book = new GradeBook();
            book.addGrade(91);
            book.addGrade(89.5f);
            book.addGrade(75);

            Console.WriteLine(GradeBook.x);
            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
        }
    }
}
