using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class Answers
    {
        public int answerId { get; set; }
        public string answer { get; set; }

        public Answers(int answerId, string answer) // constructor
        {
            this.answerId = answerId;
            this.answer = answer;
        }

    }
}
