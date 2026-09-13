using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system
{
    internal class FinalExam:Exam
    {

        #region Attr
        //private Question[] questions;

        #endregion

        #region ctor
        public FinalExam(int time, int numberOfQuestions, Question[] questions)
         : base(time, numberOfQuestions)
        {
            Questions = questions;
        }
        #endregion

        #region prop
        public Question[] Questions { get; set; }
        #endregion

        #region method
        public override void ShowExam()
        {
            Console.WriteLine("Final Exam");
            Console.WriteLine($"Time:{Time}");
            int totalGrade= 0;
            foreach (Question question in Questions)
            {
                Console.WriteLine(question.Header);
                Console.WriteLine(question.Body);
                Console.WriteLine("Ansers:");
                foreach (answers answer in question.AnswerList)
                {
                    if (answer.AnswerId== question.RightAnswer.AnswerId) 
                    {
                        Console.WriteLine($"{answer.AnswerText}=> Correct Answer");

                    }
                    Console.WriteLine(answer.AnswerText);
                }
                totalGrade+=question.Mark;
                Console.WriteLine();
            }
            Console.WriteLine($"TotalGrade:{totalGrade}");
        }

        #endregion


    }
}
