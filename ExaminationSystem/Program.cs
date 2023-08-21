using System.Diagnostics;

namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region Examination System

            Subject FirstSubject = new Subject(1, "C#");
            FirstSubject.CreatExam();

            Console.Clear();

            Console.Write("Do You Want To Start The Exam (Y | N) :  ");

            if (char.Parse(Console.ReadLine().ToUpper()) == 'Y')
            {
                Stopwatch sw = Stopwatch.StartNew();
                sw.Start();
                FirstSubject.ExamOfTheSubject.show();
                Console.WriteLine($"The Elapsed Time = {sw.Elapsed}. ");
            }
            else
            {

                Console.WriteLine("Well , We are waiting for you when you are ready!");

            }
            #endregion


        }
    }
}