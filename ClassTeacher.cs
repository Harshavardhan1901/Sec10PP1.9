﻿using Phase1Section1._9;
using System;
using System.Collections.Generic;
using System.Text;

namespace Phase1Section1._9
{
    public class ClassTeacher : Teacher
    {
        private CClass whichClass;

        public CClass WhichClass
        {
            get { return whichClass; }
            set { whichClass = value; }
        }
    }
}
