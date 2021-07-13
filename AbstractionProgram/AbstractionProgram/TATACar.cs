using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionProgram
{
    public class TATACar
    {
        IEngine _engine =null;

        public TATACar(IEngine engine)
        {
             this._engine= engine;
        }
        public void Drive()
        {

            _engine.Start();
        }
        public void Halt()
        {

            _engine.Stop();
        }
    }
}
