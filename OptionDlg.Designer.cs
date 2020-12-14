namespace ScaraApp
{
    partial class OptionDlg
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComPortBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SensorCalibrationOLV = new BrightIdeasSoftware.ObjectListView();
            this.olvWeight = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvVoltage = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SensorCalibrationOLV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComPortBox);
            this.groupBox1.Location = new System.Drawing.Point(230, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Port";
            // 
            // ComPortBox
            // 
            this.ComPortBox.FormattingEnabled = true;
            this.ComPortBox.Location = new System.Drawing.Point(7, 30);
            this.ComPortBox.Name = "ComPortBox";
            this.ComPortBox.Size = new System.Drawing.Size(121, 21);
            this.ComPortBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SensorCalibrationOLV);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 225);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sensor Calibration";
            // 
            // SensorCalibrationOLV
            // 
            this.SensorCalibrationOLV.AllColumns.Add(this.olvWeight);
            this.SensorCalibrationOLV.AllColumns.Add(this.olvVoltage);
            this.SensorCalibrationOLV.CellEditUseWholeCell = false;
            this.SensorCalibrationOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvWeight,
            this.olvVoltage});
            this.SensorCalibrationOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.SensorCalibrationOLV.HideSelection = false;
            this.SensorCalibrationOLV.Location = new System.Drawing.Point(6, 45);
            this.SensorCalibrationOLV.Name = "SensorCalibrationOLV";
            this.SensorCalibrationOLV.Size = new System.Drawing.Size(188, 174);
            this.SensorCalibrationOLV.TabIndex = 0;
            this.SensorCalibrationOLV.UseCompatibleStateImageBehavior = false;
            this.SensorCalibrationOLV.View = System.Windows.Forms.View.Details;
            // 
            // olvWeight
            // 
            this.olvWeight.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvWeight.Text = "Weight";
            // 
            // olvVoltage
            // 
            this.olvVoltage.Text = "Volt";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(230, 155);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(140, 23);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(230, 208);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(140, 23);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Close";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // OptionDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 288);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OptionDlg";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionDlg_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SensorCalibrationOLV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComPortBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private BrightIdeasSoftware.ObjectListView SensorCalibrationOLV;
        private BrightIdeasSoftware.OLVColumn olvWeight;
        private BrightIdeasSoftware.OLVColumn olvVoltage;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}