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

        public void manualSortOfList() {

            double temp = 0.0;
            for (var i =0; i<=grades.Count -1; i++) {

                for (var j=0; j<grades.Count - 1;j++)
                {  
                   // Console.WriteLine(i + "," + j);
                    
                    if (grades[i] > grades[j])
                    {
                       // Console.Write(grades[i] + "," + grades[j]);
                        temp = grades[j];
                        grades[j] = grades[i];
                        grades[i] = temp;

                    }

                    temp = 0.0;
                }
                    
                    
                }
            }

        // Make sure you have sorted list !
        public string binarySearch(double number) {

            int firstDevision =(int)grades.Count / 2;
            int secondDevisionUnder = firstDevision / 2;
            int thirdDevisionAbove = (firstDevision / 2) + firstDevision;

             if (grades[firstDevision] > number) {

                if (grades[secondDevisionUnder] > number)
                {
                    for (var i = 0; i < secondDevisionUnder; i++)
                    {
                        if (number == grades[i])
                        {
                            return $"The {number} is in the collection on index place";
                        }
                        else
                        {
                            return "The number is not found in the collection";
                        }
                    }
                }
                else {
                    for (var j = secondDevisionUnder; j < firstDevision; j++) {
                        if (number == grades[j])
                        {
                            return $"The {number} is in the collection on index place";
                        }
                        else
                        {
                            return "The number is not found in the collection";
                        }
                    }
                }
            } else {

                if (grades[thirdDevisionAbove] < number)
                {
                    for (var k = thirdDevisionAbove; k <= grades.Count; k++)
                    {
                        if (number == grades[k])
                        {
                            return $"The {number} is in the collection on index place";
                        }
                        else
                        {
                            return "The number is not found in the collection";
                        }
                    }

                }
                else {
                    for (var t=firstDevision; t<= thirdDevisionAbove; t++) {
                        if (number == grades[t])
                        {
                            return $"The {number} is in the collection on index place";
                        }
                        else
                        {

                            return "The number is not found in the collection";
                        }
                    }
                }
            }
   
        }
    }
      
    }

