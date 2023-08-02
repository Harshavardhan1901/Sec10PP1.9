using Phase1Section1._9;
using System;
using System.Collections.Generic;
using System.Text;

namespace Phase1Section1._9
{
    public class SubjectTeacher : Teacher
    {
        private Subject whichSubject;

        public Subject WhichSubject
        {
            get { return whichSubject; }
            set { whichSubject = value; }
        }
    }
}
