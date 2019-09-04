using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    class Book
    {
        private string studentName;
        private List<double> grades;

        public Book(string studentName) {
            this.studentName = studentName;
            grades = new List<double>();
        }

        public void addSingleGrade(double singleGrade) {

            grades.Add(singleGrade);

        }

        public void addMultipleGrades(double[] multipleGrades) {
            grades.AddRange(multipleGrades);
        }

        public void getStudentGrades() {
            foreach (var grade in grades) {
                Console.WriteLine(grade);
            }
        }

        public void getStudentName() {
            Console.WriteLine(studentName);
        }
    }
}
