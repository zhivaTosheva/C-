using System;
using Xunit;
using GradeBook;

namespace GradeBookTests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            var studentTest = new Book("Zhiva");

      
            var gradesOfZhiva = new double[] { 12.34, 23.34, 25.36, 5.34, 100.00, 2.45 };
            studentTest.addMultipleGrades(gradesOfZhiva);

            // Find the size of the collection 

            var checkAvrgGrade = studentTest.averageGrade();


            Assert.Equal(28,Math.Round(checkAvrgGrade));
        }
    }
}
