namespace LeddarNetDemo
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fPBConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fTBAddress = new System.Windows.Forms.TextBox();
            this.fPBLoad = new System.Windows.Forms.Button();
            this.fLVDetections = new System.Windows.Forms.ListView();
            this.fCHSegment = new System.Windows.Forms.ColumnHeader();
            this.fCHDistance = new System.Windows.Forms.ColumnHeader();
            this.fCHAmplitude = new System.Windows.Forms.ColumnHeader();
            this.fCHFlags = new System.Windows.Forms.ColumnHeader();
            this.fPBPrevious = new System.Windows.Forms.Button();
            this.fPBNext = new System.Windows.Forms.Button();
            this.fTrackBar = new System.Windows.Forms.TrackBar();
            this.fPBRecord = new System.Windows.Forms.Button();
            this.fPBConfigure = new System.Windows.Forms.Button();
            this.fPBConfigureRecording = new System.Windows.Forms.Button();
            this.fPBList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fTBFilename = new System.Windows.Forms.TextBox();
            this.fPBBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // fPBConnect
            // 
            this.fPBConnect.Location = new System.Drawing.Point(16, 48);
            this.fPBConnect.Name = "fPBConnect";
            this.fPBConnect.Size = new System.Drawing.Size(75, 23);
            this.fPBConnect.TabIndex = 0;
            this.fPBConnect.Text = "Connect";
            this.fPBConnect.UseVisualStyleBackColor = true;
            this.fPBConnect.Click += new System.EventHandler(this.PBConnectClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Address:";
            // 
            // fTBAddress
            // 
            this.fTBAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fTBAddress.Location = new System.Drawing.Point(70, 16);
            this.fTBAddress.Name = "fTBAddress";
            this.fTBAddress.Size = new System.Drawing.Size(117, 20);
            this.fTBAddress.TabIndex = 2;
            // 
            // fPBLoad
            // 
            this.fPBLoad.Location = new System.Drawing.Point(16, 116);
            this.fPBLoad.Name = "fPBLoad";
            this.fPBLoad.Size = new System.Drawing.Size(75, 23);
            this.fPBLoad.TabIndex = 3;
            this.fPBLoad.Text = "Load";
            this.fPBLoad.UseVisualStyleBackColor = true;
            this.fPBLoad.Click += new System.EventHandler(this.PBLoadClick);
            // 
            // fLVDetections
            // 
            this.fLVDetections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.fLVDetections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fCHSegment,
            this.fCHDistance,
            this.fCHAmplitude,
            this.fCHFlags});
            this.fLVDetections.GridLines = true;
            this.fLVDetections.Location = new System.Drawing.Point(16, 204);
            this.fLVDetections.Name = "fLVDetections";
            this.fLVDetections.Size = new System.Drawing.Size(260, 224);
            this.fLVDetections.TabIndex = 4;
            this.fLVDetections.UseCompatibleStateImageBehavior = false;
            this.fLVDetections.View = System.Windows.Forms.View.Details;
            // 
            // fCHSegment
            // 
            this.fCHSegment.Text = "Segment";
            // 
            // fCHDistance
            // 
            this.fCHDistance.Text = "Distance";
            // 
            // fCHAmplitude
            // 
            this.fCHAmplitude.Text = "Amplitude";
            // 
            // fCHFlags
            // 
            this.fCHFlags.Text = "Flags";
            this.fCHFlags.Width = 52;
            // 
            // fPBPrevious
            // 
            this.fPBPrevious.Location = new System.Drawing.Point(288, 208);
            this.fPBPrevious.Name = "fPBPrevious";
            this.fPBPrevious.Size = new System.Drawing.Size(75, 23);
            this.fPBPrevious.TabIndex = 5;
            this.fPBPrevious.Text = "<<";
            this.fPBPrevious.UseVisualStyleBackColor = true;
            this.fPBPrevious.Click += new System.EventHandler(this.PBPreviousClick);
            // 
            // fPBNext
            // 
            this.fPBNext.Location = new System.Drawing.Point(288, 244);
            this.fPBNext.Name = "fPBNext";
            this.fPBNext.Size = new System.Drawing.Size(75, 23);
            this.fPBNext.TabIndex = 6;
            this.fPBNext.Text = ">>";
            this.fPBNext.UseVisualStyleBackColor = true;
            this.fPBNext.Click += new System.EventHandler(this.PBNextClick);
            // 
            // fTrackBar
            // 
            this.fTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fTrackBar.Location = new System.Drawing.Point(16, 152);
            this.fTrackBar.Name = "fTrackBar";
            this.fTrackBar.Size = new System.Drawing.Size(347, 45);
            this.fTrackBar.TabIndex = 7;
            this.fTrackBar.ValueChanged += new System.EventHandler(this.TrackBarValueChanged);
            // 
            // fPBRecord
            // 
            this.fPBRecord.Location = new System.Drawing.Point(120, 48);
            this.fPBRecord.Name = "fPBRecord";
            this.fPBRecord.Size = new System.Drawing.Size(75, 23);
            this.fPBRecord.TabIndex = 8;
            this.fPBRecord.Text = "Record";
            this.fPBRecord.UseVisualStyleBackColor = true;
            this.fPBRecord.Click += new System.EventHandler(this.PBRecordClick);
            // 
            // fPBConfigure
            // 
            this.fPBConfigure.Location = new System.Drawing.Point(201, 48);
            this.fPBConfigure.Name = "fPBConfigure";
            this.fPBConfigure.Size = new System.Drawing.Size(75, 23);
            this.fPBConfigure.TabIndex = 9;
            this.fPBConfigure.Text = "Configure";
            this.fPBConfigure.UseVisualStyleBackColor = true;
            this.fPBConfigure.Click += new System.EventHandler(this.PBConfigureClick);
            // 
            // fPBConfigureRecording
            // 
            this.fPBConfigureRecording.Location = new System.Drawing.Point(120, 116);
            this.fPBConfigureRecording.Name = "fPBConfigureRecording";
            this.fPBConfigureRecording.Size = new System.Drawing.Size(156, 23);
            this.fPBConfigureRecording.TabIndex = 10;
            this.fPBConfigureRecording.Text = "Configure Recording";
            this.fPBConfigureRecording.UseVisualStyleBackColor = true;
            this.fPBConfigureRecording.Click += new System.EventHandler(this.PBConfigureRecordingClick);
            // 
            // fPBList
            // 
            this.fPBList.Location = new System.Drawing.Point(201, 14);
            this.fPBList.Name = "fPBList";
            this.fPBList.Size = new System.Drawing.Size(75, 23);
            this.fPBList.TabIndex = 11;
            this.fPBList.Text = "List...";
            this.fPBList.UseVisualStyleBackColor = true;
            this.fPBList.Click += new System.EventHandler(this.PBListClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "File:";
            // 
            // fTBFilename
            // 
            this.fTBFilename.Location = new System.Drawing.Point(48, 88);
            this.fTBFilename.Name = "fTBFilename";
            this.fTBFilename.Size = new System.Drawing.Size(284, 20);
            this.fTBFilename.TabIndex = 13;
            // 
            // fPBBrowse
            // 
            this.fPBBrowse.Location = new System.Drawing.Point(339, 88);
            this.fPBBrowse.Name = "fPBBrowse";
            this.fPBBrowse.Size = new System.Drawing.Size(24, 20);
            this.fPBBrowse.TabIndex = 14;
            this.fPBBrowse.Text = "...";
            this.fPBBrowse.UseVisualStyleBackColor = true;
            this.fPBBrowse.Click += new System.EventHandler(this.PBBrowseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 452);
            this.Controls.Add(this.fPBBrowse);
            this.Controls.Add(this.fTBFilename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fPBList);
            this.Controls.Add(this.fPBConfigureRecording);
            this.Controls.Add(this.fPBConfigure);
            this.Controls.Add(this.fPBRecord);
            this.Controls.Add(this.fTrackBar);
            this.Controls.Add(this.fPBNext);
            this.Controls.Add(this.fPBPrevious);
            this.Controls.Add(this.fLVDetections);
            this.Controls.Add(this.fPBLoad);
            this.Controls.Add(this.fTBAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fPBConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(396, 400);
            this.Name = "MainForm";
            this.Text = "LeddarNET demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.fTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fPBConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fTBAddress;
        private System.Windows.Forms.Button fPBLoad;
        private System.Windows.Forms.ListView fLVDetections;
        private System.Windows.Forms.ColumnHeader fCHSegment;
        private System.Windows.Forms.ColumnHeader fCHDistance;
        private System.Windows.Forms.ColumnHeader fCHAmplitude;
        private System.Windows.Forms.Button fPBPrevious;
        private System.Windows.Forms.Button fPBNext;
        private System.Windows.Forms.TrackBar fTrackBar;
        private System.Windows.Forms.Button fPBRecord;
        private System.Windows.Forms.Button fPBConfigure;
        private System.Windows.Forms.ColumnHeader fCHFlags;
        private System.Windows.Forms.Button fPBConfigureRecording;
        private System.Windows.Forms.Button fPBList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fTBFilename;
        private System.Windows.Forms.Button fPBBrowse;
    }
}

