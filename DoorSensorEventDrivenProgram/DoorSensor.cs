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
            this.Notify();
        }
        public void Close()
        {
            DoorSensorstatus = "DoorClosed";
            this.Notify();
        }
        void Notify()
        {
            string message = $"{this.DoorSensorstatus} and Time : {System.DateTime.Now.ToString()}";
            OnDoorSensorStatusChanged.Invoke(this.DoorSensorstatus);
            OnDoorSensorStatusChanged.Invoke(message);
        }


    }
}
