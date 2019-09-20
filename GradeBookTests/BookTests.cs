using GradeBook;
using System;
using Xunit;


namespace GradeBookTests
{
    public class BookTests
    {
        [Fact]
        public void CheckForCorrectAggrecatedGrades()
        {
            var studentTest = new Book("Zhiva");

      
            var gradesOfZhiva = new double[] { 12.34, 23.34, 25.36, 5.34, 100.00, 2.45 };
            studentTest.addMultipleGrades(gradesOfZhiva);

            // Find the size of the collection 

            var checkAvrgGrade = studentTest.averageGrade();


            Assert.Equal(28,Math.Round(checkAvrgGrade));



        }

        [Fact]
        public void CheckForCorrectRefference() {

            var bookCheck1 = createBook("Ivo");
            var bookCheck2 = createBook("Ivan");

            Assert.Equal("Ivo", bookCheck1.getStudentName());
            Assert.Equal("Ivan", bookCheck2.getStudentName());

            bookCheck1 = bookCheck2;

            Assert.Same(bookCheck1,bookCheck2);




        }

        [Fact]

        public void CheckForPassByRefference() {

            var bookCheck1 = createBook("Ivo");
            var bookCheck2 = createBook("Ivan");

            setNewGrade(ref bookCheck1,12.12);
            Assert.Equal(12.12,bookCheck1.getStudentGradesSecond());


        }

        Book createBook(string name) {
            return new Book(name);
        }

        public void setNewGrade(ref Book book, double grade)
        {
            book.addSingleGrade(grade);

        }


    }
}
