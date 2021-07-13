using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorSensorEventDrivenProgram
{
    public delegate void DoorSensorstatusHandler(string status);
   
    public class DoorSensor
    {

        string DoorSensorstatus;
        public event DoorSensorstatusHandler OnDoorSensorStatusChanged;
        public void Open()
        {
            DoorSensorstatus = "DoorOpened";
            OnDoorSensorStatusChanged.Invoke(this.DoorSensorstatus);
        }
        public void Close()
        {
            DoorSensorstatus = "DoorClosed";
            OnDoorSensorStatusChanged.Invoke(this.DoorSensorstatus);
        }
       
    }
}
