using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceProgram
{
    //TeacherIdCard is a Identity
    public class TeacherIdCard : Identity
    {
        #region member
        int _employeeNo;
        string _qualification;
        #endregion

        public TeacherIdCard(int employeeNo, string qualification, string name, string dob, string validity) : base(name, dob, validity)
        {
            this._employeeNo = employeeNo;
            this._qualification = qualification;
        }
    }
}
