using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class FinalExam : Exam
    {
        public FinalExam(string time, int numOfQuestion, Subject subject) : base(time, numOfQuestion, subject)
        {

        }

        public override void show() // To Print The Exam To User And Grading it
        {
            Console.Clear();
            base.show();
            for (int i = 0; i < NumOfQuestion; i++)
            {
                subject.questions[i].display();

                int ans = int.Parse(Console.ReadLine());
                sum += subject.questions[i].mark;
                if (ans == subject.questions[i].CorrectAnswerId) result += subject.questions[i].mark;

            }
            Console.Clear();
            for (int i = 0; i < NumOfQuestion; i++)
            {
                subject.questions[i].display();
                Console.WriteLine("The Right Answer is :" + subject.questions[i].CorrectAnswerId);

            }

            GradeExam();
        }
        public void GradeExam()
        {

            Console.WriteLine("Grading the final exam...");


            Console.WriteLine($"Your result is {result} from {sum}");

        }


    }
}
