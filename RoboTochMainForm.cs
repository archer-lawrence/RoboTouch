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
        private enum Cmds
        {
            CMD_MOVE = 0,
            CMD_READ_VOLT = 1,
            CMD_READ_WEIGHT = 2,
            CMD_MOVE_FORCE = 100
        };

        public RoboTochMainForm()
        {
            InitializeComponent();
            
            SerialPort.PortName = "COM8";           // "COM8"; needs to be in the option dialog, but machine it is always COM8
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
            int cmd = (int)Cmds.CMD_MOVE;

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

            if (GrprForceModeBtn.Checked)
                cmd = (int)Cmds.CMD_MOVE_FORCE;

            string msg = string.Format("<{0}, 0, 0, 0, 0, {1}, {2}, {3}, {4}>", cmd, zPos, gripper, speed, zAccell);
            SerialPort.Write(msg);
        }

       
        private void ReadBtn_Click(object sender, EventArgs e)
        {
            char[] charsToTrim = { ' ', '\n', '\t', '<', '>' };

            string msg = string.Format("<{0}, 0, 0, 0, 0, 0, 0, 0, 0>", (int)Cmds.CMD_READ_VOLT);
            SerialPort.Write(msg);

            string rdVolts = SerialPort.ReadLine();

            msg = string.Format("<{0}, 0, 0, 0, 0, 0, 0, 0, 0>", (int)Cmds.CMD_READ_WEIGHT);
            SerialPort.Write(msg);

            string rdForce = SerialPort.ReadLine();

            rdVolts = rdVolts.Trim(charsToTrim);
            rdForce = rdForce.Trim(charsToTrim);

            string[] tok = rdVolts.Split(',');
            VoltSensor1Text.Text = tok[0];
            VoltSensor2Text.Text = tok[1];

            tok = rdForce.Split(',');
            ForceSensor1.Text = tok[0];
            ForceSensor2.Text = tok[1];
        }
    }
}
