using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {

        public static int x = 5;
        public GradeBook()
        {
            grades = new List<float>();
        }
        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach (float grade in grades)
            {

                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            if (grades.Count != 0)
                stats.AverageGrade = sum / grades.Count;


            return stats;
        }
        public void addGrade(float grade)
        {
            grades.Add(grade);
        }
        List<float> grades;
    }
}
