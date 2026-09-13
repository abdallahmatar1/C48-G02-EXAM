using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system
{
    internal class answers
    {
        #region Attribute
        private int answerId;
        private string answerText;

        #endregion

        #region ctor
        public answers(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }
        #endregion

        #region prop
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        #endregion

    }
}
