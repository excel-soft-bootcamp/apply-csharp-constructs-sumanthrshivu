using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceProgram
{
    //StaffIdCard is a Identity
    public class StaffIdCard : Identity
    {
        #region member
        string _department;
        #endregion

        public StaffIdCard(string department, string name, string dob, string validity) : base(name, dob, validity)
        {
            this._department = department;
        }
    }
}
