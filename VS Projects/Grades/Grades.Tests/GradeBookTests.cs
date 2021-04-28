using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {

        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.addGrade(10);
            book.addGrade(90);
            GradeStatistics res = book.ComputeStatistics();
            Assert.AreEqual(90, res.HighestGrade);
        }
        [TestMethod]
        public void ComputesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.addGrade(10);
            book.addGrade(90);
            GradeStatistics res = book.ComputeStatistics();
            Assert.AreEqual(10, res.LowestGrade);
        }
        [TestMethod]
        public void ComputesAvg()
        {
            GradeBook book = new GradeBook();
            book.addGrade(91);
            book.addGrade(89.5f);
            book.addGrade(75);
            GradeStatistics res = book.ComputeStatistics();
            Assert.AreEqual(85.16f, res.AverageGrade, 0.01);
        }
    }
}
