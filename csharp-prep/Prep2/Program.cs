using System;
using System.ComponentModel;
//This is Prep2
class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade %? ");
        string grade = Console.ReadLine();
        int gradePercent = int.Parse(grade);
        string letterGrade = "";
        string signGrade = "";
        int modGrade;

        if (gradePercent >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercent >= 80) 
        {
            letterGrade = "B";
        }
        else if (gradePercent >= 70) 
        {
            letterGrade = "C";
        }
        else if (gradePercent >= 60) 
        {
            letterGrade = "D";
        }
        else 
        {
            letterGrade = "F";
        }

        modGrade = gradePercent % 10;
        //Console.WriteLine($"Mod = {gradeMod}");
        if (modGrade >= 7) 
        {
            signGrade = letterGrade + "+";
        }
        else if (modGrade < 3)
        {
            signGrade = letterGrade + "-";
        }
        else 
        {
            signGrade = letterGrade;
        }
        if (gradePercent >= 97)
        {
            signGrade = letterGrade;
        }
        else if (gradePercent < 60)
        {
            signGrade = letterGrade;
        }

        Console.WriteLine($"Your Grade is: {signGrade}");
    }
}