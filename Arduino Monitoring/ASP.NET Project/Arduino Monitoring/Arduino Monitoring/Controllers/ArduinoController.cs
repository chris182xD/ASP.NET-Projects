using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Arduino_Monitoring.Controllers
{
    public class ArduinoController : Controller
    {

        System.IO.Ports.SerialPort ArduinoPort;
        
        public System.IO.Ports.SerialPort Conexionarduino()
        {
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM3";  //change por your port
            ArduinoPort.BaudRate = 9600;

            return ArduinoPort;
        }

        // GET: Arduino
        public ActionResult Index()
        {
            return View();
        }

        public void switchLed()
        {
            ArduinoPort = Conexionarduino();
            ArduinoPort.Open();
            ArduinoPort.Write("l");
            ArduinoPort.Close();
        }

        public void switchMotor()
        {
            ArduinoPort = Conexionarduino();
            ArduinoPort.Open();
            ArduinoPort.Write("m");
            ArduinoPort.Close();
        }


        public string getLM35()
        {
            ArduinoPort = Conexionarduino();
            ArduinoPort.Open();
            ArduinoPort.Write("t");
            var temperatura = ArduinoPort.ReadLine();
            ArduinoPort.Close();
            var encode = System.Text.Encoding.UTF8.GetBytes(temperatura);
            return System.Text.Encoding.UTF8.GetString(encode);
        }
    }
}