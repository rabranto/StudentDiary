using System;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new();

            diary.AddGrades(5);
            diary.AddGrades(3.5);
            diary.AddGrades(4);
            diary.AddGrades(6);
            diary.AddGrades(1);

            Console.WriteLine($"Your best grade is: {diary.GetBestGrade()}");
            Console.WriteLine($"Your best grade is: {diary.GetWorstGrade()}");
            Console.WriteLine($"Your average is: {diary.CalculateAverage()}");
        }
    }
}
