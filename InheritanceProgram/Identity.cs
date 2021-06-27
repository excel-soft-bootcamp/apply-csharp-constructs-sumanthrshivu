using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceProgram
{
    public abstract class Identity  //CollegeInformation
    {
        private string _name, _dob, _validity;
        private int _enrollmentNo;

        public Identity(string name)
        {
            this._name = name;
        }
        public Identity(string name, string dob) : this(name)
        {
            this._dob = dob;
        }
        public Identity(string name, string dob, string validity) : this(name, dob)
        {
            this._validity = validity;
        }
        public Identity(string name, string dob, string validity, int enrollmentNo) : this(name, dob, validity)
        {
            this._enrollmentNo = enrollmentNo;
        }
    }
}



