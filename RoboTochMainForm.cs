using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScaraApp
{
    public partial class RoboTochMainForm : Form
    {
        public RoboTochMainForm()
        {
            InitializeComponent();
            OptionDlg.OptionData option = OptionDlg.LoadOptionData();

            SerialPort.PortName = option.name;           // "COM8"; // needs to be in the option dialog
            SerialPort.Open();
            SerialPort.BaudRate = 115200;
           
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            int zAccell = (int)ZAxisAccelUpDwn.Value;
            int zPos    = (int)ZAxisNumUpDwn.Value;
            int gripper = (int)GrprNumBox.Value;
            int speed = (int)SpeedUpDwn.Value;

            /**********************
            data[0] - SAVE button status
            data[1] - RUN button status
            data[2] - Joint 1 angle
            data[3] -Joint 2 angle
            data[4] -Joint 3 angle
            data[5] -Z position
            data[6] -Gripper value
            data[7] -Speed value
            data[8] -Acceleration value
            ***************/

            string msg = string.Format("<0, 0, 0, 0, 0, {0}, {1}, {2}, {3}>", zPos, gripper, speed, zAccell);
            SerialPort.Write(msg);
        }
    }
}
