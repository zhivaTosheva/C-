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

        public Book(string studentName)
        {
            this.studentName = studentName;
            grades = new List<double>();
        }

        public void addSingleGrade(double singleGrade)
        {

            grades.Add(singleGrade);

        }

        public void addMultipleGrades(double[] multipleGrades)
        {
            grades.AddRange(multipleGrades);
        }

        public void getStudentGrades()
        {
            foreach (var grade in grades)
            {
                Console.WriteLine(grade);
            }
        }

        public void getStudentName()
        {
            Console.WriteLine(studentName);
        }

        public void reverseGrades()
        {
            grades.Reverse();
        }

        public void averageGrade()
        {
            var sumOfList = 0.0;
            var averageList = 0.0;
            var countOfList = grades.Count;

            foreach (var grade in grades)
            {
                sumOfList += grade;
            }
            averageList = sumOfList / countOfList;

            Console.WriteLine(averageList);


        }

        private void sortList()
        {
            grades.Sort();
        }


        public double maxGrade()
        {

            sortList();
            return grades.Last();

        }

        public double minGrade()
        {
            sortList();
            return grades.First();

        }

        public void manualSortOfList()
        {

            double temp = 0.0;
            for (var i = 0; i <= grades.Count - 1; i++)
            {

                for (var j = 0; j < grades.Count - 1; j++)
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
        public void binarySearch(double number)
        {
            
            var min = 0;
            var max = grades.Count -1;
            var mid = min + (max - min) / 2; 
            //Console.WriteLine(mid);
           // var newMid = mid + (max - mid) / 2;

            while (mid <= max && mid >= min) {


                if (number < grades[min] || number > grades[max]) {

                    Console.WriteLine("The item is not in the collection");
                    break;

                } else if (number == grades[mid]) {

                    Console.WriteLine($"The {number} is in the collection under number {mid}");
                    break;
                }
                else if (number > grades[mid])
                {
                    mid = mid + 1;

                    // Check if the grade is less than the next. If it is, this means it does not exist in the collection
                    if (number < grades[mid]) {

                        Console.WriteLine("The item is not in the collection");
                        break;
                    }
                    //Console.WriteLine(grades[mid]);

                } else if (number < grades[mid])
                {
                    mid = mid - 1;

                    // Check if the grade is more than the next one. If it is, this means it does not exist in the collection
                    if (number > grades[mid]) {
                        Console.WriteLine("The item is not in the collection");
                        break;
                    }

                } else if (number == grades[mid]) {

                    Console.WriteLine($"The {number} is in the collection under number {mid}");
                    break;
                }
            }
            
                
                

            }


        }

    }     
      
    //}

