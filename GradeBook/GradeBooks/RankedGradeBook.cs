using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
   public class RankedGradeBook : BaseGradeBook

    {
        public RankedGradeBook(string name, bool isWeight) : base(name, isWeight)
        {
            Type = Enums.GradeBookType.Ranked;
         }

        public RankedGradeBook(string name) : base(name)
        {
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
                throw new InvalidOperationException();
            else if (averageGrade >= 80)
                return 'A';
            else if (averageGrade >= 60)
                return 'B';
            else if (averageGrade >= 40)
                return 'C';
            else if (averageGrade >= 20)
                return 'D';
            else
                return 'F';

        }

            public override void CalculateStatistics()
             {
            if (Students.Count < 5)
                Console.WriteLine("Ranked grading requires at lest 5 students");
            else
                base.CalculateStatistics();
            }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
                Console.WriteLine("Ranked grading requires at lest 5 studenst");
            else
                base.CalculateStudentStatistics(name);
        }


    }
}
