/*Avigayil Sperka
 * T00386137
 * In class Lab 2
 */

using System;
using InclassLab2;


public class Program
{
    public static void Main(string[] args)
    {
        var student1 = new StudentClass();
        student1.StudentName = "Sam";
        student1.StudentId = "123abc";
        student1.MathScore = -90;
        Console.WriteLine($"-90 set as student math score. Student math score is: {student1.MathScore}");
        student1.MathScore = 80m;
        student1.ScienceScore = 95.50m;
        student1.HistoryScore = 88.75m;
        Console.WriteLine($"Student's name: {student1.StudentName}");
        Console.WriteLine($"Student's ID: {student1.StudentId}");
        Console.WriteLine($"Math score: {student1.MathScore}");
        Console.WriteLine($"Science score: {student1.ScienceScore}");
        Console.WriteLine($"History score: {student1.HistoryScore}");
        Console.WriteLine($"Aggregate score: {student1.getAggregate()}");
        Console.WriteLine($"Percentage: {student1.getPercentage()}");

    }

}
    
   

 


