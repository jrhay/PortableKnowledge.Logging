namespace LoggingTester
{
    partial class formLoggingTester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLoggingTester));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateLogMessage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstLogMessageLevel = new System.Windows.Forms.CheckedListBox();
            this.txtLogMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstListBoxLog = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstListBoxListenerFilter = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnCreateLogMessage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lstLogMessageLevel);
            this.groupBox1.Controls.Add(this.txtLogMessage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 176);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Log Message";
            // 
            // btnCreateLogMessage
            // 
            this.btnCreateLogMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateLogMessage.Location = new System.Drawing.Point(177, 94);
            this.btnCreateLogMessage.Name = "btnCreateLogMessage";
            this.btnCreateLogMessage.Size = new System.Drawing.Size(163, 23);
            this.btnCreateLogMessage.TabIndex = 6;
            this.btnCreateLogMessage.Text = "Create New Log Message";
            this.btnCreateLogMessage.UseVisualStyleBackColor = true;
            this.btnCreateLogMessage.Click += new System.EventHandler(this.btnCreateLogMessage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Message Log Level";
            // 
            // lstLogMessageLevel
            // 
            this.lstLogMessageLevel.ColumnWidth = 120;
            this.lstLogMessageLevel.Items.AddRange(new object[] {
            "Debug",
            "Warning",
            "Info",
            "Error",
            "Fatal Error"});
            this.lstLogMessageLevel.Location = new System.Drawing.Point(9, 85);
            this.lstLogMessageLevel.MultiColumn = true;
            this.lstLogMessageLevel.Name = "lstLogMessageLevel";
            this.lstLogMessageLevel.Size = new System.Drawing.Size(97, 79);
            this.lstLogMessageLevel.TabIndex = 4;
            // 
            // txtLogMessage
            // 
            this.txtLogMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogMessage.Location = new System.Drawing.Point(9, 43);
            this.txtLogMessage.Name = "txtLogMessage";
            this.txtLogMessage.Size = new System.Drawing.Size(368, 20);
            this.txtLogMessage.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Log Message";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(12, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 182);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log Listeners";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(368, 142);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lstListBoxListenerFilter);
            this.tabPage1.Controls.Add(this.lstListBoxLog);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(360, 116);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ListBox Listener";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstListBoxLog
            // 
            this.lstListBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstListBoxLog.FormattingEnabled = true;
            this.lstListBoxLog.Location = new System.Drawing.Point(105, 3);
            this.lstListBoxLog.Name = "lstListBoxLog";
            this.lstListBoxLog.Size = new System.Drawing.Size(252, 108);
            this.lstListBoxLog.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(360, 116);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstListBoxListenerFilter
            // 
            this.lstListBoxListenerFilter.ColumnWidth = 120;
            this.lstListBoxListenerFilter.Items.AddRange(new object[] {
            "Debug",
            "Warning",
            "Info",
            "Error",
            "Fatal Error"});
            this.lstListBoxListenerFilter.Location = new System.Drawing.Point(5, 19);
            this.lstListBoxListenerFilter.MultiColumn = true;
            this.lstListBoxListenerFilter.Name = "lstListBoxListenerFilter";
            this.lstListBoxListenerFilter.Size = new System.Drawing.Size(97, 79);
            this.lstListBoxListenerFilter.TabIndex = 5;
            this.lstListBoxListenerFilter.Leave += new System.EventHandler(this.lstListBoxListenerFilter_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Level Filter";
            // 
            // formLoggingTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 388);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(422, 422);
            this.Name = "formLoggingTester";
            this.Text = "Portable Knowledge Logging Framework for .NET";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateLogMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox lstLogMessageLevel;
        private System.Windows.Forms.TextBox txtLogMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lstListBoxLog;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox lstListBoxListenerFilter;

    }
}

