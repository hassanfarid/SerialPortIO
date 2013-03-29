namespace SerialPortIO
{
    partial class Form1
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
            this.inputPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputPort = new System.Windows.Forms.TextBox();
            this.inputMessage = new System.Windows.Forms.TextBox();
            this.outputMessage = new System.Windows.Forms.TextBox();
            this.inputData = new System.Windows.Forms.TextBox();
            this.outputData = new System.Windows.Forms.TextBox();
            this.outputSend = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.inputCheck = new System.Windows.Forms.CheckBox();
            this.outputCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // inputPort
            // 
            this.inputPort.Location = new System.Drawing.Point(74, 41);
            this.inputPort.Name = "inputPort";
            this.inputPort.Size = new System.Drawing.Size(100, 20);
            this.inputPort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "INPUT                                                           OUTPUT\r\n\r\n\r\nCOM: " +
                "                                                           COM:";
            // 
            // outputPort
            // 
            this.outputPort.Location = new System.Drawing.Point(292, 41);
            this.outputPort.Name = "outputPort";
            this.outputPort.Size = new System.Drawing.Size(100, 20);
            this.outputPort.TabIndex = 2;
            // 
            // inputMessage
            // 
            this.inputMessage.Location = new System.Drawing.Point(74, 85);
            this.inputMessage.Name = "inputMessage";
            this.inputMessage.Size = new System.Drawing.Size(100, 20);
            this.inputMessage.TabIndex = 3;
            // 
            // outputMessage
            // 
            this.outputMessage.Location = new System.Drawing.Point(292, 85);
            this.outputMessage.Name = "outputMessage";
            this.outputMessage.Size = new System.Drawing.Size(100, 20);
            this.outputMessage.TabIndex = 4;
            // 
            // inputData
            // 
            this.inputData.Location = new System.Drawing.Point(74, 125);
            this.inputData.Multiline = true;
            this.inputData.Name = "inputData";
            this.inputData.Size = new System.Drawing.Size(100, 76);
            this.inputData.TabIndex = 5;
            // 
            // outputData
            // 
            this.outputData.Location = new System.Drawing.Point(292, 125);
            this.outputData.Multiline = true;
            this.outputData.Name = "outputData";
            this.outputData.Size = new System.Drawing.Size(100, 76);
            this.outputData.TabIndex = 6;
            // 
            // outputSend
            // 
            this.outputSend.Location = new System.Drawing.Point(292, 222);
            this.outputSend.Name = "outputSend";
            this.outputSend.Size = new System.Drawing.Size(100, 23);
            this.outputSend.TabIndex = 7;
            this.outputSend.Text = "Send";
            this.outputSend.UseVisualStyleBackColor = true;
            this.outputSend.Click += new System.EventHandler(this.outputSend_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(74, 222);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(100, 23);
            this.clear.TabIndex = 8;
            this.clear.Text = "Refresh";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // inputCheck
            // 
            this.inputCheck.AutoSize = true;
            this.inputCheck.Location = new System.Drawing.Point(159, 9);
            this.inputCheck.Name = "inputCheck";
            this.inputCheck.Size = new System.Drawing.Size(15, 14);
            this.inputCheck.TabIndex = 9;
            this.inputCheck.UseVisualStyleBackColor = true;
            this.inputCheck.CheckedChanged += new System.EventHandler(this.inputCheck_CheckedChanged);
            // 
            // outputCheck
            // 
            this.outputCheck.AutoSize = true;
            this.outputCheck.Checked = true;
            this.outputCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.outputCheck.Location = new System.Drawing.Point(377, 12);
            this.outputCheck.Name = "outputCheck";
            this.outputCheck.Size = new System.Drawing.Size(15, 14);
            this.outputCheck.TabIndex = 10;
            this.outputCheck.UseVisualStyleBackColor = true;
            this.outputCheck.CheckedChanged += new System.EventHandler(this.outputCheck_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 272);
            this.Controls.Add(this.outputCheck);
            this.Controls.Add(this.inputCheck);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.outputSend);
            this.Controls.Add(this.outputData);
            this.Controls.Add(this.inputData);
            this.Controls.Add(this.outputMessage);
            this.Controls.Add(this.inputMessage);
            this.Controls.Add(this.outputPort);
            this.Controls.Add(this.inputPort);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Serial Port IO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputPort;
        private System.Windows.Forms.TextBox inputMessage;
        private System.Windows.Forms.TextBox outputMessage;
        private System.Windows.Forms.TextBox inputData;
        private System.Windows.Forms.TextBox outputData;
        private System.Windows.Forms.Button outputSend;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.CheckBox inputCheck;
        private System.Windows.Forms.CheckBox outputCheck;
    }
}

