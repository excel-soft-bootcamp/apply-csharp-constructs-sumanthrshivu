using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceProgram
{
    //StudentIdCard is a Identity
    public class StudentIdCard : Identity
    {
        #region member
        string _branch;
        long _phoneNo;
        #endregion
        public StudentIdCard(string name, string branch, long phoneNo,  string dob,  int enrollmentNo, string validity) : base(name, dob, validity, enrollmentNo)
        {
            this._branch = branch;
            this._phoneNo = phoneNo;
        }
    }
}
