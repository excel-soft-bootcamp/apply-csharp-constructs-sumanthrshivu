using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceProgram
{
    //GuestIdCard is a Identity
    public class GuestIdCard : Identity
    {
        #region members
        string _designation;
        string _state;
        #endregion

        public GuestIdCard(string name, string designation, string state) : base(name)
        {
            this._designation = designation;
            this._state = state;
         
        }
    }
}
