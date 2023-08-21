using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class MCQ : Question
    {
        public Answers[] answerList { get; set; }


        public MCQ(string header, string Body, int Mark, Answers[] answerList) : base(header, Body, Mark)
        {
            this.answerList = answerList;
        }
        public override void display() // To Display The Question
        {
            Console.WriteLine("===============================");
            base.display();
            for (int i = 0; i < answerList.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {answerList[i].answer}");

            }
        }

    }
}

