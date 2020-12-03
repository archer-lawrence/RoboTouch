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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ZAxisRawDataBtn = new System.Windows.Forms.RadioButton();
            this.ZAsixPercentBtn = new System.Windows.Forms.RadioButton();
            this.ZAxisHScrolBar = new System.Windows.Forms.HScrollBar();
            this.ZAxisNumUpDwn = new System.Windows.Forms.NumericUpDown();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GrprForceModeBtn = new System.Windows.Forms.RadioButton();
            this.GrprRawDataBtn = new System.Windows.Forms.RadioButton();
            this.GrprPercentModeBtn = new System.Windows.Forms.RadioButton();
            this.GrprHScrlBar = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GrprNumBox = new System.Windows.Forms.NumericUpDown();
            this.SendBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.ZAxisGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZAxisNumUpDwn)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrprNumBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
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
            this.ZAxisGrpBox.Controls.Add(this.label2);
            this.ZAxisGrpBox.Controls.Add(this.label1);
            this.ZAxisGrpBox.Controls.Add(this.ZAxisRawDataBtn);
            this.ZAxisGrpBox.Controls.Add(this.ZAsixPercentBtn);
            this.ZAxisGrpBox.Controls.Add(this.ZAxisHScrolBar);
            this.ZAxisGrpBox.Controls.Add(this.ZAxisNumUpDwn);
            this.ZAxisGrpBox.Location = new System.Drawing.Point(24, 36);
            this.ZAxisGrpBox.Name = "ZAxisGrpBox";
            this.ZAxisGrpBox.Size = new System.Drawing.Size(265, 239);
            this.ZAxisGrpBox.TabIndex = 1;
            this.ZAxisGrpBox.TabStop = false;
            this.ZAxisGrpBox.Text = "Z=Axis Position";
            this.ZAxisGrpBox.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Down";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Up";
            // 
            // ZAxisRawDataBtn
            // 
            this.ZAxisRawDataBtn.AutoSize = true;
            this.ZAxisRawDataBtn.Location = new System.Drawing.Point(18, 85);
            this.ZAxisRawDataBtn.Name = "ZAxisRawDataBtn";
            this.ZAxisRawDataBtn.Size = new System.Drawing.Size(142, 24);
            this.ZAxisRawDataBtn.TabIndex = 3;
            this.ZAxisRawDataBtn.TabStop = true;
            this.ZAxisRawDataBtn.Text = "Raw Data Mode";
            this.ZAxisRawDataBtn.UseVisualStyleBackColor = true;
            // 
            // ZAsixPercentBtn
            // 
            this.ZAsixPercentBtn.AutoSize = true;
            this.ZAsixPercentBtn.Location = new System.Drawing.Point(18, 45);
            this.ZAsixPercentBtn.Name = "ZAsixPercentBtn";
            this.ZAsixPercentBtn.Size = new System.Drawing.Size(126, 24);
            this.ZAsixPercentBtn.TabIndex = 2;
            this.ZAsixPercentBtn.TabStop = true;
            this.ZAsixPercentBtn.Text = "Percent Mode";
            this.ZAsixPercentBtn.UseVisualStyleBackColor = true;
            // 
            // ZAxisHScrolBar
            // 
            this.ZAxisHScrolBar.Location = new System.Drawing.Point(45, 128);
            this.ZAxisHScrolBar.Name = "ZAxisHScrolBar";
            this.ZAxisHScrolBar.Size = new System.Drawing.Size(158, 30);
            this.ZAxisHScrolBar.TabIndex = 1;
            // 
            // ZAxisNumUpDwn
            // 
            this.ZAxisNumUpDwn.Location = new System.Drawing.Point(56, 178);
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
            this.groupBox1.Location = new System.Drawing.Point(24, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 131);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Z-Axis Accel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GrprNumBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.GrprHScrlBar);
            this.groupBox2.Controls.Add(this.GrprForceModeBtn);
            this.groupBox2.Controls.Add(this.GrprRawDataBtn);
            this.groupBox2.Controls.Add(this.GrprPercentModeBtn);
            this.groupBox2.Location = new System.Drawing.Point(311, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 275);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gripper";
            // 
            // GrprForceModeBtn
            // 
            this.GrprForceModeBtn.AutoSize = true;
            this.GrprForceModeBtn.Location = new System.Drawing.Point(16, 128);
            this.GrprForceModeBtn.Name = "GrprForceModeBtn";
            this.GrprForceModeBtn.Size = new System.Drawing.Size(112, 24);
            this.GrprForceModeBtn.TabIndex = 2;
            this.GrprForceModeBtn.TabStop = true;
            this.GrprForceModeBtn.Text = "Force Mode";
            this.GrprForceModeBtn.UseVisualStyleBackColor = true;
            // 
            // GrprRawDataBtn
            // 
            this.GrprRawDataBtn.AutoSize = true;
            this.GrprRawDataBtn.Location = new System.Drawing.Point(16, 84);
            this.GrprRawDataBtn.Name = "GrprRawDataBtn";
            this.GrprRawDataBtn.Size = new System.Drawing.Size(142, 24);
            this.GrprRawDataBtn.TabIndex = 1;
            this.GrprRawDataBtn.TabStop = true;
            this.GrprRawDataBtn.Text = "Raw Data Mode";
            this.GrprRawDataBtn.UseVisualStyleBackColor = true;
            // 
            // GrprPercentModeBtn
            // 
            this.GrprPercentModeBtn.AutoSize = true;
            this.GrprPercentModeBtn.Location = new System.Drawing.Point(16, 44);
            this.GrprPercentModeBtn.Name = "GrprPercentModeBtn";
            this.GrprPercentModeBtn.Size = new System.Drawing.Size(126, 24);
            this.GrprPercentModeBtn.TabIndex = 0;
            this.GrprPercentModeBtn.TabStop = true;
            this.GrprPercentModeBtn.Text = "Percent Mode";
            this.GrprPercentModeBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.GrprPercentModeBtn.UseVisualStyleBackColor = true;
            // 
            // GrprHScrlBar
            // 
            this.GrprHScrlBar.Location = new System.Drawing.Point(62, 184);
            this.GrprHScrlBar.Name = "GrprHScrlBar";
            this.GrprHScrlBar.Size = new System.Drawing.Size(104, 24);
            this.GrprHScrlBar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Open";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Close";
            // 
            // GrprNumBox
            // 
            this.GrprNumBox.Location = new System.Drawing.Point(38, 226);
            this.GrprNumBox.Name = "GrprNumBox";
            this.GrprNumBox.Size = new System.Drawing.Size(120, 26);
            this.GrprNumBox.TabIndex = 6;
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(349, 331);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(120, 38);
            this.SendBtn.TabIndex = 4;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            // 
            // RoboTochMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ZAxisGrpBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RoboTochMainForm";
            this.Text = "RoboTouch";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ZAxisGrpBox.ResumeLayout(false);
            this.ZAxisGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZAxisNumUpDwn)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrprNumBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox ZAxisGrpBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton ZAxisRawDataBtn;
        private System.Windows.Forms.RadioButton ZAsixPercentBtn;
        private System.Windows.Forms.HScrollBar ZAxisHScrolBar;
        private System.Windows.Forms.NumericUpDown ZAxisNumUpDwn;
        private System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton GrprForceModeBtn;
        private System.Windows.Forms.RadioButton GrprRawDataBtn;
        private System.Windows.Forms.RadioButton GrprPercentModeBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar GrprHScrlBar;
        private System.Windows.Forms.NumericUpDown GrprNumBox;
        private System.Windows.Forms.Button SendBtn;
    }
}

