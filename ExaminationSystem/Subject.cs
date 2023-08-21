using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class Subject
    {
        public int id { get; set; }
        public string name { get; set; }
        public Exam ExamOfTheSubject { get; set; }
        public Question[] questions;
        public Subject(int subjectId, string subjectName)
        {
            id = subjectId;
            name = subjectName;
        }

        public void CreatExam()
        {
            Console.Write("Please Enter The Type Of Exam You Want To Create( 1 For Practical and 2 For Final) : ");
            int examType = int.Parse(Console.ReadLine());



            Console.Write("Please Enter The Time Of Exam in Minutes : ");
            string timeOfExam = (Console.ReadLine());

            Console.Write("Please Enter The Number Of Question you wanted to create : ");
            int numberOfQuestions = int.Parse(Console.ReadLine());
            questions = new Question[numberOfQuestions];
            if (examType == 2)
            {
                ExamOfTheSubject = new FinalExam(timeOfExam, numberOfQuestions, this);
            }
            else if (examType == 1)
            {
                ExamOfTheSubject = new PracticeExam(timeOfExam, numberOfQuestions, this);
            }



            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.Clear();
                Console.Write($"Please Choose The Type Of Question Number({i + 1}) ( 1 For True or False || 2 For MCQ) : ");
                int questionType = int.Parse(Console.ReadLine());

                if (questionType == 1)

                {
                    Console.Clear();
                    Console.WriteLine("True OR False Question :- ");

                    Console.WriteLine("Please Enter The Body of The Question : ");
                    string Body = Console.ReadLine();

                    Console.WriteLine("Please Enter The Mark of The Question : ");
                    int Mark = int.Parse(Console.ReadLine());
                    questions[i] = new TruFalse("True OR False Question :- ", Body, Mark);
                    Console.WriteLine($"Please Enter The Right Answer Of Question ( 1 For True and 2 For False) : ");
                    questions[i].CorrectAnswerId = int.Parse(Console.ReadLine());


                }
                else if (questionType == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Choose One Answer Question :- ");

                    Console.WriteLine("Please Enter The Body of The Question : ");
                    string Body = Console.ReadLine();

                    Console.WriteLine("Please Enter The Mark of The Question : ");
                    int Mark = int.Parse(Console.ReadLine());
                    Answers[] answers = new Answers[4];
                    Console.WriteLine("Please Enter The Choices of The Question : ");
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write($"Please Enter The Choices number ({j + 1}) : ");
                        answers[j] = new Answers(j + 1, Console.ReadLine());
                    }
                    questions[i] = new MCQ("MCQ Question :- ", Body, Mark, answers);
                    Console.WriteLine("Please Specify The Right Choice of The Question : ");

                    questions[i].CorrectAnswerId = int.Parse(Console.ReadLine());



                }



            }





        }
    }
}
