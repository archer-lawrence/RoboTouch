namespace ScaraApp
{
    partial class RoboTochMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZAxisGrpBox = new System.Windows.Forms.GroupBox();
            this.ZAxisNumUpDwn = new System.Windows.Forms.NumericUpDown();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ZAxisAccelUpDwn = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ForceSensor2 = new System.Windows.Forms.TextBox();
            this.VoltSensor2Text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ForceSensor1 = new System.Windows.Forms.TextBox();
            this.VoltSensor1Text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GrprNumBox = new System.Windows.Forms.NumericUpDown();
            this.GrprForceModeBtn = new System.Windows.Forms.RadioButton();
            this.SendBtn = new System.Windows.Forms.Button();
            this.SpeedUpDwn = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.VoltSensorAvg = new System.Windows.Forms.TextBox();
            this.ForceSensorAvg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.ZAxisGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZAxisNumUpDwn)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZAxisAccelUpDwn)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrprNumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedUpDwn)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // ZAxisGrpBox
            // 
            this.ZAxisGrpBox.Controls.Add(this.ZAxisNumUpDwn);
            this.ZAxisGrpBox.Location = new System.Drawing.Point(24, 35);
            this.ZAxisGrpBox.Name = "ZAxisGrpBox";
            this.ZAxisGrpBox.Size = new System.Drawing.Size(266, 126);
            this.ZAxisGrpBox.TabIndex = 1;
            this.ZAxisGrpBox.TabStop = false;
            this.ZAxisGrpBox.Text = "Z=Axis Position";
            this.ZAxisGrpBox.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // ZAxisNumUpDwn
            // 
            this.ZAxisNumUpDwn.Location = new System.Drawing.Point(54, 58);
            this.ZAxisNumUpDwn.Maximum = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            this.ZAxisNumUpDwn.Name = "ZAxisNumUpDwn";
            this.ZAxisNumUpDwn.Size = new System.Drawing.Size(158, 26);
            this.ZAxisNumUpDwn.TabIndex = 0;
            // 
            // SerialPort
            // 
            this.SerialPort.BaudRate = 115200;
            this.SerialPort.PortName = "COM3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ZAxisAccelUpDwn);
            this.groupBox1.Location = new System.Drawing.Point(24, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 131);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Z-Axis Accel";
            // 
            // ZAxisAccelUpDwn
            // 
            this.ZAxisAccelUpDwn.Location = new System.Drawing.Point(54, 49);
            this.ZAxisAccelUpDwn.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.ZAxisAccelUpDwn.Name = "ZAxisAccelUpDwn";
            this.ZAxisAccelUpDwn.Size = new System.Drawing.Size(158, 26);
            this.ZAxisAccelUpDwn.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ForceSensorAvg);
            this.groupBox2.Controls.Add(this.VoltSensorAvg);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ForceSensor2);
            this.groupBox2.Controls.Add(this.VoltSensor2Text);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ForceSensor1);
            this.groupBox2.Controls.Add(this.VoltSensor1Text);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.GrprNumBox);
            this.groupBox2.Controls.Add(this.GrprForceModeBtn);
            this.groupBox2.Location = new System.Drawing.Point(310, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 323);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gripper";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sensor 2";
            // 
            // ForceSensor2
            // 
            this.ForceSensor2.Location = new System.Drawing.Point(205, 268);
            this.ForceSensor2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ForceSensor2.Name = "ForceSensor2";
            this.ForceSensor2.ReadOnly = true;
            this.ForceSensor2.Size = new System.Drawing.Size(90, 26);
            this.ForceSensor2.TabIndex = 14;
            // 
            // VoltSensor2Text
            // 
            this.VoltSensor2Text.Location = new System.Drawing.Point(205, 220);
            this.VoltSensor2Text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VoltSensor2Text.Name = "VoltSensor2Text";
            this.VoltSensor2Text.ReadOnly = true;
            this.VoltSensor2Text.Size = new System.Drawing.Size(90, 26);
            this.VoltSensor2Text.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sensor 1";
            // 
            // ForceSensor1
            // 
            this.ForceSensor1.Location = new System.Drawing.Point(80, 269);
            this.ForceSensor1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ForceSensor1.Name = "ForceSensor1";
            this.ForceSensor1.ReadOnly = true;
            this.ForceSensor1.Size = new System.Drawing.Size(90, 26);
            this.ForceSensor1.TabIndex = 11;
            // 
            // VoltSensor1Text
            // 
            this.VoltSensor1Text.Location = new System.Drawing.Point(80, 220);
            this.VoltSensor1Text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VoltSensor1Text.Name = "VoltSensor1Text";
            this.VoltSensor1Text.ReadOnly = true;
            this.VoltSensor1Text.Size = new System.Drawing.Size(90, 26);
            this.VoltSensor1Text.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Force";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Volt";
            // 
            // GrprNumBox
            // 
            this.GrprNumBox.Location = new System.Drawing.Point(158, 51);
            this.GrprNumBox.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.GrprNumBox.Name = "GrprNumBox";
            this.GrprNumBox.Size = new System.Drawing.Size(120, 26);
            this.GrprNumBox.TabIndex = 6;
            // 
            // GrprForceModeBtn
            // 
            this.GrprForceModeBtn.AutoSize = true;
            this.GrprForceModeBtn.Location = new System.Drawing.Point(6, 51);
            this.GrprForceModeBtn.Name = "GrprForceModeBtn";
            this.GrprForceModeBtn.Size = new System.Drawing.Size(112, 24);
            this.GrprForceModeBtn.TabIndex = 2;
            this.GrprForceModeBtn.TabStop = true;
            this.GrprForceModeBtn.Text = "Force Mode";
            this.GrprForceModeBtn.UseVisualStyleBackColor = true;
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(610, 387);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(120, 38);
            this.SendBtn.TabIndex = 4;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // SpeedUpDwn
            // 
            this.SpeedUpDwn.Location = new System.Drawing.Point(54, 49);
            this.SpeedUpDwn.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.SpeedUpDwn.Name = "SpeedUpDwn";
            this.SpeedUpDwn.Size = new System.Drawing.Size(158, 26);
            this.SpeedUpDwn.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SpeedUpDwn);
            this.groupBox3.Location = new System.Drawing.Point(24, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 131);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Z-Axis Speed";
            // 
            // ReadBtn
            // 
            this.ReadBtn.Location = new System.Drawing.Point(389, 387);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(120, 38);
            this.ReadBtn.TabIndex = 6;
            this.ReadBtn.Text = "Read";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // VoltSensorAvg
            // 
            this.VoltSensorAvg.Location = new System.Drawing.Point(330, 217);
            this.VoltSensorAvg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VoltSensorAvg.Name = "VoltSensorAvg";
            this.VoltSensorAvg.ReadOnly = true;
            this.VoltSensorAvg.Size = new System.Drawing.Size(90, 26);
            this.VoltSensorAvg.TabIndex = 16;
            // 
            // ForceSensorAvg
            // 
            this.ForceSensorAvg.Location = new System.Drawing.Point(330, 265);
            this.ForceSensorAvg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ForceSensorAvg.Name = "ForceSensorAvg";
            this.ForceSensorAvg.ReadOnly = true;
            this.ForceSensorAvg.Size = new System.Drawing.Size(90, 26);
            this.ForceSensorAvg.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Average";
            // 
            // RoboTochMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 444);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ZAxisGrpBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RoboTochMainForm";
            this.Text = "RoboTouch";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ZAxisGrpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ZAxisNumUpDwn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ZAxisAccelUpDwn)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrprNumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedUpDwn)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox ZAxisGrpBox;
        private System.Windows.Forms.NumericUpDown ZAxisNumUpDwn;
        private System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton GrprForceModeBtn;
        private System.Windows.Forms.NumericUpDown GrprNumBox;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.NumericUpDown ZAxisAccelUpDwn;
        private System.Windows.Forms.NumericUpDown SpeedUpDwn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ForceSensor1;
        private System.Windows.Forms.TextBox VoltSensor1Text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ForceSensor2;
        private System.Windows.Forms.TextBox VoltSensor2Text;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ForceSensorAvg;
        private System.Windows.Forms.TextBox VoltSensorAvg;
    }
}

