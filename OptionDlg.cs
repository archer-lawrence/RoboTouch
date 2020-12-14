using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ScaraApp
{
    public partial class OptionDlg : Form
    {
        System.IO.Ports.SerialPort serialPort;
        public class OptionData
        {
            public string name = "COM8";
            public int[] weight = new int[10];
            public int[] milliVolt = new int[10];
        };

        static public OptionData option = new OptionData();

        public OptionDlg(System.IO.Ports.SerialPort _serialPort)
        {
            InitializeComponent();
            serialPort = _serialPort;
        }

        private void OptionDlg_Load(object sender, EventArgs e)
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string name in ports)
            {
                ComPortBox.Items.Add(name);
            }
        }

        static public void SaveOptionData(ref OptionData opData)
        {
            string json;

            json = JsonConvert.SerializeObject(opData);

            StreamWriter sw = new StreamWriter("Option.txt");
            sw.WriteLine(json);
            sw.Close();
        }

        static public OptionData LoadOptionData()
        {
            try
            {
                string tmp;
                StreamReader sr = new StreamReader("Option.txt");
                tmp = sr.ReadLine();
                sr.Close();

                option = (OptionData)JsonConvert.DeserializeObject(tmp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return option;
        }
    }
}
