using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

        public void reverseGrades() {
            grades.Reverse();
        }

        public void averageGrade() {
            var sumOfList = 0.0;
            var averageList = 0.0;
            var countOfList = grades.Count;

            foreach (var grade in grades) {
                sumOfList += grade;
            }
            averageList = sumOfList / countOfList;

            Console.WriteLine(averageList);


        }

        private void sortList() {
            grades.Sort();
        }
        

        public double maxGrade() {

            sortList();
            return grades.Last();
            
        }

        public double minGrade() {
            sortList();
            return grades.First();

        }
    }
}
