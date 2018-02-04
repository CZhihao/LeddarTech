namespace LeddarNetDemo
{
    partial class RecordSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordSettingsForm));
            this.fPBOK = new System.Windows.Forms.Button();
            this.fPBCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fTBDirectory = new System.Windows.Forms.TextBox();
            this.fPBBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fNUDSize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.fNUDSize)).BeginInit();
            this.SuspendLayout();
            // 
            // fPBOK
            // 
            this.fPBOK.Location = new System.Drawing.Point(32, 120);
            this.fPBOK.Name = "fPBOK";
            this.fPBOK.Size = new System.Drawing.Size(75, 23);
            this.fPBOK.TabIndex = 0;
            this.fPBOK.Text = "OK";
            this.fPBOK.UseVisualStyleBackColor = true;
            this.fPBOK.Click += new System.EventHandler(this.PBOKClick);
            // 
            // fPBCancel
            // 
            this.fPBCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fPBCancel.Location = new System.Drawing.Point(262, 120);
            this.fPBCancel.Name = "fPBCancel";
            this.fPBCancel.Size = new System.Drawing.Size(75, 23);
            this.fPBCancel.TabIndex = 1;
            this.fPBCancel.Text = "Cancel";
            this.fPBCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Directory:";
            // 
            // fTBDirectory
            // 
            this.fTBDirectory.Location = new System.Drawing.Point(24, 36);
            this.fTBDirectory.Name = "fTBDirectory";
            this.fTBDirectory.Size = new System.Drawing.Size(300, 20);
            this.fTBDirectory.TabIndex = 3;
            // 
            // fPBBrowse
            // 
            this.fPBBrowse.Location = new System.Drawing.Point(330, 35);
            this.fPBBrowse.Name = "fPBBrowse";
            this.fPBBrowse.Size = new System.Drawing.Size(24, 20);
            this.fPBBrowse.TabIndex = 4;
            this.fPBBrowse.Text = "...";
            this.fPBBrowse.UseVisualStyleBackColor = true;
            this.fPBBrowse.Click += new System.EventHandler(this.PBBrowseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max File Size:";
            // 
            // fNUDSize
            // 
            this.fNUDSize.Location = new System.Drawing.Point(96, 72);
            this.fNUDSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.fNUDSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fNUDSize.Name = "fNUDSize";
            this.fNUDSize.Size = new System.Drawing.Size(60, 20);
            this.fNUDSize.TabIndex = 6;
            this.fNUDSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RecordSettingsForm
            // 
            this.AcceptButton = this.fPBOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fPBCancel;
            this.ClientSize = new System.Drawing.Size(374, 164);
            this.Controls.Add(this.fNUDSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fPBBrowse);
            this.Controls.Add(this.fTBDirectory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fPBCancel);
            this.Controls.Add(this.fPBOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecordSettingsForm";
            this.Text = "Record Settings";
            ((System.ComponentModel.ISupportInitialize)(this.fNUDSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fPBOK;
        private System.Windows.Forms.Button fPBCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fTBDirectory;
        private System.Windows.Forms.Button fPBBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown fNUDSize;
    }
}