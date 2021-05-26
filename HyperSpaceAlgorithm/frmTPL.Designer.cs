namespace TPL
{
    partial class frmTPL
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
            this.cmdCheck = new System.Windows.Forms.Button();
            this.lstData0 = new System.Windows.Forms.ListBox();
            this.lstData1 = new System.Windows.Forms.ListBox();
            this.lstData2 = new System.Windows.Forms.ListBox();
            this.txtCheckTask = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdCheck
            // 
            this.cmdCheck.Location = new System.Drawing.Point(41, 30);
            this.cmdCheck.Name = "cmdCheck";
            this.cmdCheck.Size = new System.Drawing.Size(107, 23);
            this.cmdCheck.TabIndex = 0;
            this.cmdCheck.Text = "Check System";
            this.cmdCheck.UseVisualStyleBackColor = true;
            this.cmdCheck.Click += new System.EventHandler(this.cmdCheck_Click);
            // 
            // lstData0
            // 
            this.lstData0.FormattingEnabled = true;
            this.lstData0.HorizontalScrollbar = true;
            this.lstData0.Location = new System.Drawing.Point(41, 70);
            this.lstData0.Name = "lstData0";
            this.lstData0.ScrollAlwaysVisible = true;
            this.lstData0.Size = new System.Drawing.Size(958, 199);
            this.lstData0.TabIndex = 1;
            // 
            // lstData1
            // 
            this.lstData1.FormattingEnabled = true;
            this.lstData1.HorizontalScrollbar = true;
            this.lstData1.Location = new System.Drawing.Point(41, 275);
            this.lstData1.Name = "lstData1";
            this.lstData1.ScrollAlwaysVisible = true;
            this.lstData1.Size = new System.Drawing.Size(958, 199);
            this.lstData1.TabIndex = 2;
            // 
            // lstData2
            // 
            this.lstData2.FormattingEnabled = true;
            this.lstData2.HorizontalScrollbar = true;
            this.lstData2.Location = new System.Drawing.Point(41, 480);
            this.lstData2.Name = "lstData2";
            this.lstData2.ScrollAlwaysVisible = true;
            this.lstData2.Size = new System.Drawing.Size(958, 199);
            this.lstData2.TabIndex = 3;
            // 
            // txtCheckTask
            // 
            this.txtCheckTask.Location = new System.Drawing.Point(1015, 70);
            this.txtCheckTask.Multiline = true;
            this.txtCheckTask.Name = "txtCheckTask";
            this.txtCheckTask.Size = new System.Drawing.Size(258, 126);
            this.txtCheckTask.TabIndex = 4;
            // 
            // frmTPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 741);
            this.Controls.Add(this.txtCheckTask);
            this.Controls.Add(this.lstData2);
            this.Controls.Add(this.lstData1);
            this.Controls.Add(this.lstData0);
            this.Controls.Add(this.cmdCheck);
            this.Name = "frmTPL";
            this.Text = "Processat de tasques en paral·lel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCheck;
        private System.Windows.Forms.ListBox lstData0;
        private System.Windows.Forms.ListBox lstData1;
        private System.Windows.Forms.ListBox lstData2;
        private System.Windows.Forms.TextBox txtCheckTask;
    }
}