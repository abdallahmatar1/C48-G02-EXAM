using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system
{
    internal class Exam
    {
        #region attr
        private int time;
        private int numberOfQuestions;


        #endregion

        #region Ctor
        public Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
        }


        #endregion

        #region Prop
        public int Time { get; private set; }
        public int NumberOfQuestions { get; private set; }

        #endregion

        #region Method

        public virtual void ShowExam()
        {
            Console.WriteLine("Showing exam..");
        }
        #endregion


    }
}
