using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system
{
    internal class PracticalExam:Exam
    {

        #region atrr
        //private Question[] questions;
        #endregion

        #region ctor
        public PracticalExam(int time,int numberOfQuestions,Question[] questions)
            : base(time, numberOfQuestions)
        {
            Questions = questions;
        }

        #endregion

        #region prop
        public Question[] Questions{ get; set; }

        #endregion

        #region method
        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam");
            foreach (Question question in Questions) 
            {

                Console.WriteLine(question.Header);
                Console.WriteLine(question.Body);
                Console.WriteLine($"Right Answer:{question.RightAnswer.AnswerText}");





            }
        }
        #endregion
    }
}
