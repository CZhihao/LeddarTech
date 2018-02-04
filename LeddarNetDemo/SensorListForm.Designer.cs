namespace LeddarNetDemo
{
    partial class SensorListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SensorListForm));
            this.fListView = new System.Windows.Forms.ListView();
            this.fCHAddress = new System.Windows.Forms.ColumnHeader();
            this.fPBOK = new System.Windows.Forms.Button();
            this.fPBCancel = new System.Windows.Forms.Button();
            this.fPBScan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fListView
            // 
            this.fListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fCHAddress});
            this.fListView.GridLines = true;
            this.fListView.Location = new System.Drawing.Point(16, 16);
            this.fListView.Name = "fListView";
            this.fListView.Size = new System.Drawing.Size(240, 191);
            this.fListView.TabIndex = 0;
            this.fListView.UseCompatibleStateImageBehavior = false;
            this.fListView.View = System.Windows.Forms.View.Details;
            // 
            // fCHAddress
            // 
            this.fCHAddress.Text = "Address";
            this.fCHAddress.Width = 120;
            // 
            // fPBOK
            // 
            this.fPBOK.Location = new System.Drawing.Point(100, 224);
            this.fPBOK.Name = "fPBOK";
            this.fPBOK.Size = new System.Drawing.Size(72, 23);
            this.fPBOK.TabIndex = 1;
            this.fPBOK.Text = "OK";
            this.fPBOK.UseVisualStyleBackColor = true;
            this.fPBOK.Click += new System.EventHandler(this.PBOKClick);
            // 
            // fPBCancel
            // 
            this.fPBCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fPBCancel.Location = new System.Drawing.Point(184, 224);
            this.fPBCancel.Name = "fPBCancel";
            this.fPBCancel.Size = new System.Drawing.Size(72, 23);
            this.fPBCancel.TabIndex = 2;
            this.fPBCancel.Text = "Cancel";
            this.fPBCancel.UseVisualStyleBackColor = true;
            // 
            // fPBScan
            // 
            this.fPBScan.Location = new System.Drawing.Point(16, 224);
            this.fPBScan.Name = "fPBScan";
            this.fPBScan.Size = new System.Drawing.Size(72, 23);
            this.fPBScan.TabIndex = 4;
            this.fPBScan.Text = "Scan";
            this.fPBScan.UseVisualStyleBackColor = true;
            this.fPBScan.Click += new System.EventHandler(this.PBScanClick);
            // 
            // SensorListForm
            // 
            this.AcceptButton = this.fPBOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fPBCancel;
            this.ClientSize = new System.Drawing.Size(274, 262);
            this.Controls.Add(this.fPBScan);
            this.Controls.Add(this.fPBCancel);
            this.Controls.Add(this.fPBOK);
            this.Controls.Add(this.fListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SensorListForm";
            this.Text = "Available Sensors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView fListView;
        private System.Windows.Forms.ColumnHeader fCHAddress;
        private System.Windows.Forms.Button fPBOK;
        private System.Windows.Forms.Button fPBCancel;
        private System.Windows.Forms.Button fPBScan;
    }
}