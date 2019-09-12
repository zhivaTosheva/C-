using System;
using System.Collections.Generic;


namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
                var student1 = new Book("Ivan");
            student1.addSingleGrade(10.23);
            var gradesOfIvan = new double[]{ 12.34,23.34,25.36,5.34,100.00,2.45};
            student1.addMultipleGrades(gradesOfIvan);
            student1.getStudentGrades();

            Console.WriteLine("-------------------------");

            student1.manualSortOfList();
            student1.reverseGrades();
            student1.getStudentGrades();
            student1.binarySearch(150);

            /*
            student1.getStudentGrades();
            student1.getStudentName();
            student1.reverseGrades();
            student1.getStudentGrades();

            student1.averageGrade();

            var maxGrade = student1.maxGrade();
            
            var minGrade = student1.minGrade();

            Console.WriteLine(maxGrade + "," + minGrade);
            */


            /*
            // Arrays: calculate the average

            double[] gradesArray = new double[3] { 12.3, 23.4, 34.54 };
            var sumOfArray = 0.0;
            var average = 0.0;
            var countOfArray = gradesArray.Length;

            for (var i =0; i <= gradesArray.Length -1; i++) {
                Console.WriteLine(gradesArray[i]);
                sumOfArray += gradesArray[i];

            }
            average = sumOfArray / countOfArray;
            Console.WriteLine(average);

            // List : Average price 

            List<double>  gradesList = new List<double>(gradesArray) { 23.87, 12.76, 23.90};
            gradesList.Add(43.45);

            var sumOfList = 0.0;
            var averageList = 0.0;
            var countOfList = gradesList.Count;

            for (var i = 0; i<=gradesList.Count-1; i++) {
                Console.WriteLine(gradesList[i]);
                sumOfList += gradesList[i];

            }

            // There is exception that double cannot be converted to int and i dont know why 
            //foreach (var grade in gradesList)
            //{
            //    Console.WriteLine(gradesList[grade]); 
            //    //Console.WriteLine(gradesList[k]);
            //    //sumOfList += gradesList[k];  <-- "Грешка е защото е лист, не е арр => Грешен запис"
            //}

            averageList = sumOfList / countOfList;

            Console.WriteLine(averageList);

            // Dictionary 
            */

            var dictionaryStudents = new Dictionary<int,string>();
            dictionaryStudents.Add(1,"Ivan");
            dictionaryStudents.Add(2, "Peter");
            dictionaryStudents.Add(3, "Georgy");

            foreach (var k in dictionaryStudents.Keys) {
                Console.WriteLine(k);
                Console.WriteLine(dictionaryStudents[k]);


            }


     
        }
    }
}
