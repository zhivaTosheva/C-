using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GradeBook
{
    public class Book
    {
        //You can put event and call the delegate in the setter ! Look for examples. By default it is empty string. 

        private string _studentName;
        //(1)private readonly string _studentName;
        private List<double> grades;

        public string LastName {get; private set;} // it will be accest for the getter and will not be available for set(readonly)

        public string studentName
        {
            get { return _studentName; }
            set { _studentName = value; } //<-- You cannot assign value to read only
        }
        // constructor
        public Book(string studentName)
        {
            this.studentName = studentName;
            grades = new List<double>();
        }

        public Book(string studentName, string lastName)
        {
            this._studentName = studentName;
            grades = new List<double>();
            this.LastName = lastName;
        }

        // getter and setter on the fields 

      
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

        public double getStudentGradesSecond()
        {
            foreach (var grade in grades)
            {
                return grade;
            }
            return 0;
        }

        public string getStudentName()
        {
            return studentName;
        }

        public void reverseGrades()
        {
            grades.Reverse();
        }

        public double averageGrade()
        {
            var sumOfList = 0.0;
            var averageList = 0.0;
            var countOfList = grades.Count;

            foreach (var grade in grades)
            {
                sumOfList += grade;
            }
            averageList = sumOfList / countOfList;

            return averageList;


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

        public void checkRef(int refType)
        {
            refType++;
            Console.WriteLine(refType);
           // return refType;
        }

        public void checkRefTest(ref int refType)
        {

            refType++;

        }


        // Make sure you have sorted list !
        public void binarySearch(double number)
        {

            var min = 0;
            var max = grades.Count - 1;
            var mid = min + (max - min) / 2;
            //Console.WriteLine(mid);
            // var newMid = mid + (max - mid) / 2;

            while (mid <= max && mid >= min)
            {


                if (number < grades[min] || number > grades[max])
                {

                    Console.WriteLine("The item is not in the collection");
                    break;

                }
                else if (number == grades[mid])
                {

                    Console.WriteLine($"The {number} is in the collection under number {mid}");
                    break;
                }
                else if (number > grades[mid])
                {
                    mid = mid + 1;

                    // Check if the grade is less than the next. If it is, this means it does not exist in the collection
                    if (number < grades[mid])
                    {

                        Console.WriteLine("The item is not in the collection");
                        break;
                    }
                    //Console.WriteLine(grades[mid]);

                }
                else if (number < grades[mid])
                {
                    mid = mid - 1;

                    // Check if the grade is more than the next one. If it is, this means it does not exist in the collection
                    if (number > grades[mid])
                    {
                        Console.WriteLine("The item is not in the collection");
                        break;
                    }

                }
                else if (number == grades[mid])
                {

                    Console.WriteLine($"The {number} is in the collection under number {mid}");
                    break;
                }
            }




        }


    }

}

//}

