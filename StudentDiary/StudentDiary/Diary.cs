using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Diary
    {
        public Diary()
        {
            grades = new List<double>();
        }

        private List<double> grades;

        public void AddGrades(double grade)
        {
            grades.Add(grade);
        }

        public void ShowGrades()
        {
            foreach (var grade in grades)
            {
                Console.WriteLine(grade);
            }
        }

        public double CalculateAverage()
        {
            double sum = 0;
            foreach (var grade in grades)
            {
                sum += grade;
            }

            return sum / grades.Count();
        }

        public double GetBestGrade()
        {
            return grades.Max();
        }
        public double GetWorstGrade()
        {
            return grades.Min();
        }
    }
}
