using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system
{
    internal class Question
    {
        #region Attribute

        private string header;
        private string body;
        private int mark;

        private answers[] answerList;
        private answers rightAnswer;




        #endregion

        #region ctor
        public Question(string header, string body, int mark, answers[] answerList,answers rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = answerList;
            RightAnswer = rightAnswer;


        }

 

        #endregion

        #region prop

        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public answers[] AnswerList { get; set; }
        public answers RightAnswer { get; set; }

        #endregion

        #region method
        public override string ToString()
        {
            return $"header: {header}\n:Body:{body}\n:Mark:{mark}";
        }


        #endregion




    }
}
