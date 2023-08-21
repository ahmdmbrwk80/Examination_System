using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class PracticeExam : Exam
    {
        public PracticeExam(string time, int numOfQuestion, Subject subject) : base(time, numOfQuestion, subject)
        {

        }


        public override void show()
        {
            Console.Clear();

            base.show();
            for (int i = 0; i < NumOfQuestion; i++)
            {
                subject.questions[i].display();

                int ans = int.Parse(Console.ReadLine());
                if (ans == subject.questions[i].CorrectAnswerId) result += subject.questions[i].mark;

            }
            Console.Clear();
            for (int i = 0; i < NumOfQuestion; i++)
            {
                subject.questions[i].display();
                Console.WriteLine(subject.questions[i].CorrectAnswerId);


            }

        }
    }
}
