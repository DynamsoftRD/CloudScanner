namespace ScanUpload
{
    partial class ScanUploadToGoogle
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
            this.cmbSource = new System.Windows.Forms.ComboBox();
            this.lblSelectSource = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdScan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dynamicDotNetTwain = new Dynamsoft.DotNet.TWAIN.DynamicDotNetTwain();
            this.cmdUpload = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.scan_to_google = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSource);
            this.groupBox1.Controls.Add(this.lblSelectSource);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(304, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // cmbSource
            // 
            this.cmbSource.FormattingEnabled = true;
            this.cmbSource.Location = new System.Drawing.Point(101, 16);
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.Size = new System.Drawing.Size(143, 20);
            this.cmbSource.TabIndex = 5;
            // 
            // lblSelectSource
            // 
            this.lblSelectSource.AutoSize = true;
            this.lblSelectSource.Location = new System.Drawing.Point(30, 18);
            this.lblSelectSource.Name = "lblSelectSource";
            this.lblSelectSource.Size = new System.Drawing.Size(41, 12);
            this.lblSelectSource.TabIndex = 4;
            this.lblSelectSource.Text = "Select";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 21);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "File Name";
            // 
            // cmdScan
            // 
            this.cmdScan.Location = new System.Drawing.Point(32, 43);
            this.cmdScan.Name = "cmdScan";
            this.cmdScan.Size = new System.Drawing.Size(75, 21);
            this.cmdScan.TabIndex = 3;
            this.cmdScan.Text = "Scan";
            this.cmdScan.UseVisualStyleBackColor = true;
            this.cmdScan.Click += new System.EventHandler(this.cmdScan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dynamicDotNetTwain);
            this.groupBox2.Location = new System.Drawing.Point(12, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 355);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View";
            // 
            // dynamicDotNetTwain
            // 
            this.dynamicDotNetTwain.AnnotationFillColor = System.Drawing.Color.White;
            this.dynamicDotNetTwain.AnnotationPen = null;
            this.dynamicDotNetTwain.AnnotationTextColor = System.Drawing.Color.Black;
            this.dynamicDotNetTwain.AnnotationTextFont = null;
            this.dynamicDotNetTwain.IfShowPrintUI = false;
            this.dynamicDotNetTwain.IfThrowException = false;
            this.dynamicDotNetTwain.Location = new System.Drawing.Point(13, 16);
            this.dynamicDotNetTwain.LogLevel = ((short)(0));
            this.dynamicDotNetTwain.Name = "dynamicDotNetTwain";
            this.dynamicDotNetTwain.PDFMarginBottom = ((uint)(0u));
            this.dynamicDotNetTwain.PDFMarginLeft = ((uint)(0u));
            this.dynamicDotNetTwain.PDFMarginRight = ((uint)(0u));
            this.dynamicDotNetTwain.PDFMarginTop = ((uint)(0u));
            this.dynamicDotNetTwain.PDFXConformance = ((uint)(0u));
            this.dynamicDotNetTwain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dynamicDotNetTwain.Size = new System.Drawing.Size(264, 334);
            this.dynamicDotNetTwain.TabIndex = 0;
            this.dynamicDotNetTwain.OnMouseClick += new Dynamsoft.DotNet.TWAIN.Delegate.OnMouseClickHandler(this.dynamicDotNetTwain_OnMouseClick);
            this.dynamicDotNetTwain.OnPreAllTransfers += new Dynamsoft.DotNet.TWAIN.Delegate.OnPreAllTransfersHandler(this.dynamicDotNetTwain_OnPreAllTransfers);
            // 
            // cmdUpload
            // 
            this.cmdUpload.Location = new System.Drawing.Point(113, 43);
            this.cmdUpload.Name = "cmdUpload";
            this.cmdUpload.Size = new System.Drawing.Size(148, 21);
            this.cmdUpload.TabIndex = 4;
            this.cmdUpload.Text = "Upload to Google Drive";
            this.cmdUpload.UseVisualStyleBackColor = true;
            this.cmdUpload.Click += new System.EventHandler(this.cmdUpload_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(304, 349);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(280, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdScan);
            this.groupBox3.Controls.Add(this.cmdUpload);
            this.groupBox3.Location = new System.Drawing.Point(304, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 91);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Scan and Upload to Google Drive";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.scan_to_google);
            this.groupBox4.Location = new System.Drawing.Point(304, 241);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 91);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Scan to Google Drive";
            // 
            // scan_to_google
            // 
            this.scan_to_google.Location = new System.Drawing.Point(74, 40);
            this.scan_to_google.Name = "scan_to_google";
            this.scan_to_google.Size = new System.Drawing.Size(155, 21);
            this.scan_to_google.TabIndex = 3;
            this.scan_to_google.Text = "Scan to Google Drive";
            this.scan_to_google.UseVisualStyleBackColor = true;
            this.scan_to_google.Click += new System.EventHandler(this.scan_to_google_Click);
            // 
            // ScanUploadToGoogle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 400);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ScanUploadToGoogle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSelectSource;
        private System.Windows.Forms.ComboBox cmbSource;
        private System.Windows.Forms.Button cmdScan;
        private System.Windows.Forms.Button cmdUpload;
        private Dynamsoft.DotNet.TWAIN.DynamicDotNetTwain dynamicDotNetTwain;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button scan_to_google;

    }
}

