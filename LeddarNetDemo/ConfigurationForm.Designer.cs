namespace LeddarNetDemo
{
    partial class ConfigurationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fNUDThreshold = new System.Windows.Forms.NumericUpDown();
            this.fNUDLedIntensity = new System.Windows.Forms.NumericUpDown();
            this.fNUDPointCount = new System.Windows.Forms.NumericUpDown();
            this.fDUDOversampling = new System.Windows.Forms.DomainUpDown();
            this.fDUDAccumulations = new System.Windows.Forms.DomainUpDown();
            this.fPBWrite = new System.Windows.Forms.Button();
            this.fPBRestore = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.fTBName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fNUDThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNUDLedIntensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNUDPointCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oversampling:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Accumulations:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Base Point Count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "LED Intensity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Threshold Offset:";
            // 
            // fNUDThreshold
            // 
            this.fNUDThreshold.DecimalPlaces = 2;
            this.fNUDThreshold.Location = new System.Drawing.Point(112, 156);
            this.fNUDThreshold.Name = "fNUDThreshold";
            this.fNUDThreshold.Size = new System.Drawing.Size(60, 20);
            this.fNUDThreshold.TabIndex = 5;
            this.fNUDThreshold.ValueChanged += new System.EventHandler(this.NUDThresholdValueChanged);
            // 
            // fNUDLedIntensity
            // 
            this.fNUDLedIntensity.Location = new System.Drawing.Point(112, 128);
            this.fNUDLedIntensity.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.fNUDLedIntensity.Name = "fNUDLedIntensity";
            this.fNUDLedIntensity.Size = new System.Drawing.Size(60, 20);
            this.fNUDLedIntensity.TabIndex = 6;
            this.fNUDLedIntensity.ValueChanged += new System.EventHandler(this.NUDLedIntensityValueChanged);
            // 
            // fNUDPointCount
            // 
            this.fNUDPointCount.Location = new System.Drawing.Point(112, 100);
            this.fNUDPointCount.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.fNUDPointCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fNUDPointCount.Name = "fNUDPointCount";
            this.fNUDPointCount.Size = new System.Drawing.Size(60, 20);
            this.fNUDPointCount.TabIndex = 7;
            this.fNUDPointCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fNUDPointCount.ValueChanged += new System.EventHandler(this.NUDPointCountValueChanged);
            // 
            // fDUDOversampling
            // 
            this.fDUDOversampling.Items.Add("1");
            this.fDUDOversampling.Items.Add("2");
            this.fDUDOversampling.Items.Add("4");
            this.fDUDOversampling.Items.Add("8");
            this.fDUDOversampling.Location = new System.Drawing.Point(112, 44);
            this.fDUDOversampling.Name = "fDUDOversampling";
            this.fDUDOversampling.Size = new System.Drawing.Size(60, 20);
            this.fDUDOversampling.TabIndex = 8;
            this.fDUDOversampling.SelectedItemChanged += new System.EventHandler(this.DUDOversamplingSelectedItemChanged);
            // 
            // fDUDAccumulations
            // 
            this.fDUDAccumulations.Items.Add("1");
            this.fDUDAccumulations.Items.Add("2");
            this.fDUDAccumulations.Items.Add("4");
            this.fDUDAccumulations.Items.Add("8");
            this.fDUDAccumulations.Items.Add("16");
            this.fDUDAccumulations.Items.Add("32");
            this.fDUDAccumulations.Items.Add("64");
            this.fDUDAccumulations.Items.Add("128");
            this.fDUDAccumulations.Items.Add("256");
            this.fDUDAccumulations.Location = new System.Drawing.Point(112, 72);
            this.fDUDAccumulations.Name = "fDUDAccumulations";
            this.fDUDAccumulations.Size = new System.Drawing.Size(60, 20);
            this.fDUDAccumulations.TabIndex = 9;
            this.fDUDAccumulations.SelectedItemChanged += new System.EventHandler(this.DUDAccumulationsSelectedItemChanged);
            // 
            // fPBWrite
            // 
            this.fPBWrite.Location = new System.Drawing.Point(24, 196);
            this.fPBWrite.Name = "fPBWrite";
            this.fPBWrite.Size = new System.Drawing.Size(75, 23);
            this.fPBWrite.TabIndex = 10;
            this.fPBWrite.Text = "Write";
            this.fPBWrite.UseVisualStyleBackColor = true;
            this.fPBWrite.Click += new System.EventHandler(this.PBWriteClick);
            // 
            // fPBRestore
            // 
            this.fPBRestore.Location = new System.Drawing.Point(180, 196);
            this.fPBRestore.Name = "fPBRestore";
            this.fPBRestore.Size = new System.Drawing.Size(75, 23);
            this.fPBRestore.TabIndex = 11;
            this.fPBRestore.Text = "Restore";
            this.fPBRestore.UseVisualStyleBackColor = true;
            this.fPBRestore.Click += new System.EventHandler(this.PBRestoreClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Name:";
            // 
            // fTBName
            // 
            this.fTBName.Location = new System.Drawing.Point(112, 16);
            this.fTBName.MaxLength = 31;
            this.fTBName.Name = "fTBName";
            this.fTBName.Size = new System.Drawing.Size(152, 20);
            this.fTBName.TabIndex = 13;
            this.fTBName.TextChanged += new System.EventHandler(this.TBNameTextChanged);
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 232);
            this.Controls.Add(this.fTBName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fPBRestore);
            this.Controls.Add(this.fPBWrite);
            this.Controls.Add(this.fDUDAccumulations);
            this.Controls.Add(this.fDUDOversampling);
            this.Controls.Add(this.fNUDPointCount);
            this.Controls.Add(this.fNUDLedIntensity);
            this.Controls.Add(this.fNUDThreshold);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigurationForm";
            this.Text = "ConfigurationForm";
            ((System.ComponentModel.ISupportInitialize)(this.fNUDThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNUDLedIntensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNUDPointCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown fNUDThreshold;
        private System.Windows.Forms.NumericUpDown fNUDLedIntensity;
        private System.Windows.Forms.NumericUpDown fNUDPointCount;
        private System.Windows.Forms.DomainUpDown fDUDOversampling;
        private System.Windows.Forms.DomainUpDown fDUDAccumulations;
        private System.Windows.Forms.Button fPBWrite;
        private System.Windows.Forms.Button fPBRestore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fTBName;
    }
}