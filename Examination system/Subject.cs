using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system
{
    internal class Subject
    {

        #region Attr

        private int subjectId;
        private string subjectName;
        private Exam exam;



        #endregion

        #region Ctor

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        #endregion

        #region Prop
        public int SubjectId {  get;  set; }
        public string SubjectName {  get;  set; }

        public Exam Exam { get; set; }



        #endregion

        #region Method

        public void CreateExam(Exam newExam)
        {
            //if (newExam == null) { throw new ArgumentNullException(""); }
            Exam= newExam;
        }


        #endregion
    }
}
