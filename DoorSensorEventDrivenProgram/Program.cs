using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorSensorEventDrivenProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            SecuritySystem _observer_security = new SecuritySystem();
            DoorSensorstatusHandler _addressOfUpateInfo = new DoorSensorstatusHandler(_observer_security.UpateInfo);

            DoorSensor _door = new DoorSensor();
            _door.OnDoorSensorStatusChanged += _addressOfUpateInfo;
            _door.Open();
            _door.Close();

        }
    }
}
