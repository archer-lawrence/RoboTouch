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
            SerialPort.ReadTimeout = 5000;
           
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
            System.Threading.Thread.Sleep(1000);

            ReadBtn_Click(sender, e);
        }

       
        private void ReadBtn_Click(object sender, EventArgs e)
        {
            string rdVolts = "";
            string rdForce = "";
            string[] tok;
            int cnt;
            char[] charsToTrim = { ' ', '\n', '\t', '<', '>' };

            try
            {
                string msg = string.Format("<{0}, 0, 0, 0, 0, 0, 0, 0, 0>", (int)Cmds.CMD_READ_VOLT);
                SerialPort.Write(msg);

                for (cnt = 0; cnt < 50; cnt++)
                {
                    rdVolts = SerialPort.ReadLine();
                    if ((rdVolts.Contains('<')) && (rdVolts.Contains('>')))
                        break;
                }

                msg = string.Format("<{0}, 0, 0, 0, 0, 0, 0, 0, 0>", (int)Cmds.CMD_READ_WEIGHT);
                SerialPort.Write(msg);

                for (cnt = 0; cnt < 50; cnt++)
                {
                    rdForce = SerialPort.ReadLine();
                    if ((rdForce.Contains('<')) && (rdForce.Contains('>')))
                        break;
                }
                if (!string.IsNullOrWhiteSpace(rdVolts))
                {
                    rdVolts = rdVolts.Trim(charsToTrim);
                    tok = rdVolts.Split(',');
                    VoltSensor1Text.Text = tok[0];
                    VoltSensor2Text.Text = tok[1];
                    VoltSensorAvg.Text = tok[2];
                }
                else
                {
                    VoltSensor1Text.Text = " ";
                    VoltSensor2Text.Text = " ";
                    VoltSensorAvg.Text = " ";
                }

                if (!string.IsNullOrWhiteSpace(rdForce))
                {
                    rdForce = rdForce.Trim(charsToTrim);
                    tok = rdForce.Split(',');
                    ForceSensor1.Text = tok[0];
                    ForceSensor2.Text = tok[1];
                    ForceSensorAvg.Text = tok[2];
                }
                else
                {
                    ForceSensor1.Text = " ";
                    ForceSensor2.Text = " ";
                    ForceSensorAvg.Text = " ";
                }
            }
            catch (Exception ex)
            {
                VoltSensor1Text.Text = " ";
                VoltSensor2Text.Text = " ";
                VoltSensorAvg.Text = " ";
                ForceSensor1.Text = " ";
                ForceSensor2.Text = " ";
                ForceSensorAvg.Text = " ";
                // MessageBox.Show(ex.Message);
            }
        }
    }
}
