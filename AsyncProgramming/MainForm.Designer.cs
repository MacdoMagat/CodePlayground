namespace AsyncProgramming
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
            this.pbrProgress = new System.Windows.Forms.ProgressBar();
            this.btnStartProcess = new System.Windows.Forms.Button();
            this.btnCancelProcess = new System.Windows.Forms.Button();
            this.txtTextArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pbrProgress
            // 
            this.pbrProgress.Location = new System.Drawing.Point(12, 12);
            this.pbrProgress.Name = "pbrProgress";
            this.pbrProgress.Size = new System.Drawing.Size(582, 42);
            this.pbrProgress.TabIndex = 0;
            // 
            // btnStartProcess
            // 
            this.btnStartProcess.Location = new System.Drawing.Point(12, 60);
            this.btnStartProcess.Name = "btnStartProcess";
            this.btnStartProcess.Size = new System.Drawing.Size(104, 23);
            this.btnStartProcess.TabIndex = 1;
            this.btnStartProcess.Text = "Start Process";
            this.btnStartProcess.UseVisualStyleBackColor = true;
            this.btnStartProcess.Click += new System.EventHandler(this.btnStartProcess_Click);
            // 
            // btnCancelProcess
            // 
            this.btnCancelProcess.Location = new System.Drawing.Point(12, 89);
            this.btnCancelProcess.Name = "btnCancelProcess";
            this.btnCancelProcess.Size = new System.Drawing.Size(104, 23);
            this.btnCancelProcess.TabIndex = 2;
            this.btnCancelProcess.Text = "Cancel Process";
            this.btnCancelProcess.UseVisualStyleBackColor = true;
            this.btnCancelProcess.Click += new System.EventHandler(this.btnCancelProcess_Click);
            // 
            // txtTextArea
            // 
            this.txtTextArea.Location = new System.Drawing.Point(122, 60);
            this.txtTextArea.Multiline = true;
            this.txtTextArea.Name = "txtTextArea";
            this.txtTextArea.Size = new System.Drawing.Size(472, 52);
            this.txtTextArea.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 127);
            this.Controls.Add(this.txtTextArea);
            this.Controls.Add(this.btnCancelProcess);
            this.Controls.Add(this.btnStartProcess);
            this.Controls.Add(this.pbrProgress);
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbrProgress;
        private System.Windows.Forms.Button btnStartProcess;
        private System.Windows.Forms.Button btnCancelProcess;
        private System.Windows.Forms.TextBox txtTextArea;
    }
}

