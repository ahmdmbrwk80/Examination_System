using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class Question
    {
        public string header { get; set; }
        public string body { get; set; }
        public int mark { get; set; }
        public Answers[] answerList { get; set; }
        public int CorrectAnswerId { get; set; }

        public Question(string Header, string Body, int Mark)
        {
            body = Body;
            mark = Mark;
            header = Header;

        }
        public virtual void display()
        {

            Console.WriteLine(header + "\t\t " + "Mark : " + mark);
            Console.WriteLine(body);


        }
    }

}