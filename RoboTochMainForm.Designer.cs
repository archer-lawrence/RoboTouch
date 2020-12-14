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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GrprNumBox = new System.Windows.Forms.NumericUpDown();
            this.GrprForceModeBtn = new System.Windows.Forms.RadioButton();
            this.GrprRawDataBtn = new System.Windows.Forms.RadioButton();
            this.SendBtn = new System.Windows.Forms.Button();
            this.ZAxisAccelUpDwn = new System.Windows.Forms.NumericUpDown();
            this.SpeedUpDwn = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.ZAxisGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZAxisNumUpDwn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrprNumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZAxisAccelUpDwn)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(372, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // ZAxisGrpBox
            // 
            this.ZAxisGrpBox.Controls.Add(this.ZAxisNumUpDwn);
            this.ZAxisGrpBox.Location = new System.Drawing.Point(16, 23);
            this.ZAxisGrpBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ZAxisGrpBox.Name = "ZAxisGrpBox";
            this.ZAxisGrpBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ZAxisGrpBox.Size = new System.Drawing.Size(177, 82);
            this.ZAxisGrpBox.TabIndex = 1;
            this.ZAxisGrpBox.TabStop = false;
            this.ZAxisGrpBox.Text = "Z=Axis Position";
            this.ZAxisGrpBox.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // ZAxisNumUpDwn
            // 
            this.ZAxisNumUpDwn.Location = new System.Drawing.Point(36, 38);
            this.ZAxisNumUpDwn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ZAxisNumUpDwn.Maximum = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            this.ZAxisNumUpDwn.Name = "ZAxisNumUpDwn";
            this.ZAxisNumUpDwn.Size = new System.Drawing.Size(105, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(16, 109);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(177, 85);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Z-Axis Accel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GrprNumBox);
            this.groupBox2.Controls.Add(this.GrprForceModeBtn);
            this.groupBox2.Controls.Add(this.GrprRawDataBtn);
            this.groupBox2.Location = new System.Drawing.Point(207, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(149, 179);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gripper";
            // 
            // GrprNumBox
            // 
            this.GrprNumBox.Location = new System.Drawing.Point(25, 147);
            this.GrprNumBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrprNumBox.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.GrprNumBox.Name = "GrprNumBox";
            this.GrprNumBox.Size = new System.Drawing.Size(80, 20);
            this.GrprNumBox.TabIndex = 6;
            // 
            // GrprForceModeBtn
            // 
            this.GrprForceModeBtn.AutoSize = true;
            this.GrprForceModeBtn.Location = new System.Drawing.Point(11, 83);
            this.GrprForceModeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrprForceModeBtn.Name = "GrprForceModeBtn";
            this.GrprForceModeBtn.Size = new System.Drawing.Size(82, 17);
            this.GrprForceModeBtn.TabIndex = 2;
            this.GrprForceModeBtn.TabStop = true;
            this.GrprForceModeBtn.Text = "Force Mode";
            this.GrprForceModeBtn.UseVisualStyleBackColor = true;
            // 
            // GrprRawDataBtn
            // 
            this.GrprRawDataBtn.AutoSize = true;
            this.GrprRawDataBtn.Location = new System.Drawing.Point(11, 55);
            this.GrprRawDataBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrprRawDataBtn.Name = "GrprRawDataBtn";
            this.GrprRawDataBtn.Size = new System.Drawing.Size(103, 17);
            this.GrprRawDataBtn.TabIndex = 1;
            this.GrprRawDataBtn.TabStop = true;
            this.GrprRawDataBtn.Text = "Raw Data Mode";
            this.GrprRawDataBtn.UseVisualStyleBackColor = true;
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(232, 258);
            this.SendBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(80, 25);
            this.SendBtn.TabIndex = 4;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // ZAxisAccelUpDwn
            // 
            this.ZAxisAccelUpDwn.Location = new System.Drawing.Point(36, 32);
            this.ZAxisAccelUpDwn.Margin = new System.Windows.Forms.Padding(2);
            this.ZAxisAccelUpDwn.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.ZAxisAccelUpDwn.Name = "ZAxisAccelUpDwn";
            this.ZAxisAccelUpDwn.Size = new System.Drawing.Size(105, 20);
            this.ZAxisAccelUpDwn.TabIndex = 1;
            // 
            // SpeedUpDwn
            // 
            this.SpeedUpDwn.Location = new System.Drawing.Point(36, 32);
            this.SpeedUpDwn.Margin = new System.Windows.Forms.Padding(2);
            this.SpeedUpDwn.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.SpeedUpDwn.Name = "SpeedUpDwn";
            this.SpeedUpDwn.Size = new System.Drawing.Size(105, 20);
            this.SpeedUpDwn.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SpeedUpDwn);
            this.groupBox3.Location = new System.Drawing.Point(16, 198);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(177, 85);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Z-Axis Speed";
            // 
            // RoboTochMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 307);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ZAxisGrpBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RoboTochMainForm";
            this.Text = "RoboTouch";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ZAxisGrpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ZAxisNumUpDwn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrprNumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZAxisAccelUpDwn)).EndInit();
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
        private System.Windows.Forms.RadioButton GrprRawDataBtn;
        private System.Windows.Forms.NumericUpDown GrprNumBox;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.NumericUpDown ZAxisAccelUpDwn;
        private System.Windows.Forms.NumericUpDown SpeedUpDwn;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

