using System.Diagnostics;

namespace Examination_system
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("ُEnter number of Questions: ");
            int numberOFQuestions=int.Parse(Console.ReadLine());
            Question[] questions=new Question[numberOFQuestions];
            for (int i = 0; i < numberOFQuestions; i++) 
            {
                Console.WriteLine($"\n ==== Question{i + 1}====");
                Console.WriteLine("Enter question type (1:True/False, 2:MCQ)");
                int typeChoice = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Header:");
                string header= Console.ReadLine();
                Console.WriteLine("Enter Body:");
                string body= Console.ReadLine();
                Console.WriteLine("Enter Mark:");
                int mark=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number of answer:");
                int numberOfAnswers=int.Parse(Console.ReadLine());

                answers[] answerList=new answers[numberOfAnswers];
                for (int j = 0; j < numberOfAnswers; j++)
                {
                    Console.Write($"Enter text for Answer {j + 1}: ");
                    string answerText= Console.ReadLine();
                    answerList[j]=new answers(j+1,answerText);
                }
                Console.Write("Enter the number of the correct answer: ");
                int correctIndex=int.Parse(Console.ReadLine());
                answers rightAnswer=answerList[correctIndex-1];

                if (typeChoice == 1)
                {
                    questions[i] = new TrueFalseQuestion(header, body, mark, answerList, rightAnswer);
                }
                else
                {
                    questions[i] = new MCQQuestion(header, body, mark, answerList, rightAnswer);
                }

            }

            Console.WriteLine("\nEnter Subject Id:");
            int subjectId=int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter Subject Name:");
            string subjectName=Console.ReadLine();

            Console.WriteLine("Enter Exam Time:");
            int time=int.Parse(Console.ReadLine());

            Console.Write("Enter exam type (1 = Final, 2 = Practical): ");
            int examType=int.Parse(Console.ReadLine());

            Exam exam=new Exam(time,numberOFQuestions);

            if (examType == 1)
            {
                exam=new FinalExam(time,numberOFQuestions,questions);
            }
            else
            {
                exam = new PracticalExam(time,numberOFQuestions,questions);
            }

            Subject subject = new(subjectId, subjectName);
            subject.CreateExam(exam);
            Console.WriteLine("\nShowing Exam");
            DateTime startTime = DateTime.Now;
            subject.Exam.ShowExam();
            DateTime endTime = DateTime.Now;
            TimeSpan duration=endTime - startTime;

            
            Console.WriteLine($"\nExamFinished: {duration.TotalSeconds} seconds");




        }
    }
}
