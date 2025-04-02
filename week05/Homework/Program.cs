using System;

class Program
{
    static void Main(string[] args)
    {
        
        MathAssignment mathAssignment = new MathAssignment("john", "math", "section 5", "problems 9 - 9000");

        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("carl", "writing", "The excistence of frogs");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInfo());
    }
}