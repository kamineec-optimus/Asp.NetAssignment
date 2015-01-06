namespace FileExtractionUtility
{
    partial class FileExtractionUtility
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
            this.selectDate = new System.Windows.Forms.DateTimePicker();
            this.lblChooseSourceFolder = new System.Windows.Forms.Label();
            this.lblChooseDestinationFolder = new System.Windows.Forms.Label();
            this.lblmsg = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.sourceFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.destinationFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.txtDestinationFolder = new System.Windows.Forms.TextBox();
            this.btnSourceBrowse = new System.Windows.Forms.Button();
            this.btnDestinationBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectDate
            // 
            this.selectDate.Location = new System.Drawing.Point(23, 194);
            this.selectDate.Name = "selectDate";
            this.selectDate.Size = new System.Drawing.Size(200, 20);
            this.selectDate.TabIndex = 0;
            // 
            // lblChooseSourceFolder
            // 
            this.lblChooseSourceFolder.AutoSize = true;
            this.lblChooseSourceFolder.Location = new System.Drawing.Point(20, 29);
            this.lblChooseSourceFolder.Name = "lblChooseSourceFolder";
            this.lblChooseSourceFolder.Size = new System.Drawing.Size(112, 13);
            this.lblChooseSourceFolder.TabIndex = 1;
            this.lblChooseSourceFolder.Text = "Choose Source Folder";
            // 
            // lblChooseDestinationFolder
            // 
            this.lblChooseDestinationFolder.AutoSize = true;
            this.lblChooseDestinationFolder.Location = new System.Drawing.Point(20, 99);
            this.lblChooseDestinationFolder.Name = "lblChooseDestinationFolder";
            this.lblChooseDestinationFolder.Size = new System.Drawing.Size(131, 13);
            this.lblChooseDestinationFolder.TabIndex = 2;
            this.lblChooseDestinationFolder.Text = "Choose Destination Folder";
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(20, 158);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(286, 13);
            this.lblmsg.TabIndex = 3;
            this.lblmsg.Text = "Select a Date after which files modified should be displayed";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(76, 231);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.Location = new System.Drawing.Point(23, 45);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(175, 20);
            this.txtSourceFolder.TabIndex = 5;
            // 
            // txtDestinationFolder
            // 
            this.txtDestinationFolder.Location = new System.Drawing.Point(23, 115);
            this.txtDestinationFolder.Name = "txtDestinationFolder";
            this.txtDestinationFolder.Size = new System.Drawing.Size(175, 20);
            this.txtDestinationFolder.TabIndex = 6;
            // 
            // btnSourceBrowse
            // 
            this.btnSourceBrowse.Location = new System.Drawing.Point(219, 43);
            this.btnSourceBrowse.Name = "btnSourceBrowse";
            this.btnSourceBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnSourceBrowse.TabIndex = 7;
            this.btnSourceBrowse.Text = "Browse";
            this.btnSourceBrowse.UseVisualStyleBackColor = true;
            this.btnSourceBrowse.Click += new System.EventHandler(this.btnSourceBrowse_Click);
            // 
            // btnDestinationBrowse
            // 
            this.btnDestinationBrowse.Location = new System.Drawing.Point(219, 112);
            this.btnDestinationBrowse.Name = "btnDestinationBrowse";
            this.btnDestinationBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnDestinationBrowse.TabIndex = 8;
            this.btnDestinationBrowse.Text = "Browse";
            this.btnDestinationBrowse.UseVisualStyleBackColor = true;
            this.btnDestinationBrowse.Click += new System.EventHandler(this.btnDestinationBrowse_Click);
            // 
            // FileExtractionUtility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 301);
            this.Controls.Add(this.btnDestinationBrowse);
            this.Controls.Add(this.btnSourceBrowse);
            this.Controls.Add(this.txtDestinationFolder);
            this.Controls.Add(this.txtSourceFolder);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.lblChooseDestinationFolder);
            this.Controls.Add(this.lblChooseSourceFolder);
            this.Controls.Add(this.selectDate);
            this.Name = "FileExtractionUtility";
            this.Text = "File Extraction Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker selectDate;
        private System.Windows.Forms.Label lblChooseSourceFolder;
        private System.Windows.Forms.Label lblChooseDestinationFolder;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.FolderBrowserDialog sourceFolder;
        private System.Windows.Forms.FolderBrowserDialog destinationFolder;
        private System.Windows.Forms.TextBox txtSourceFolder;
        private System.Windows.Forms.TextBox txtDestinationFolder;
        private System.Windows.Forms.Button btnSourceBrowse;
        private System.Windows.Forms.Button btnDestinationBrowse;
    }
}

