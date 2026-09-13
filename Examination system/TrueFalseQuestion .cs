using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system
{
    internal class TrueFalseQuestion:Question
    {
        public TrueFalseQuestion(string header,string body,int mark, answers[] answerList,answers rightAnswer) : base(header, body, mark,answerList,rightAnswer) { }

    }
}
