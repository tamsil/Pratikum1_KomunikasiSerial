namespace Pratikum1_KomunikasiSerial
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonSendData = new System.Windows.Forms.Button();
            this.comboBoxSerial = new System.Windows.Forms.ComboBox();
            this.richTextBoxSendData = new System.Windows.Forms.RichTextBox();
            this.richTextBoxReceiveData = new System.Windows.Forms.RichTextBox();
            this.serialPortRS232 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Out";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data In";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(243, 8);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(324, 8);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 4;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonSendData
            // 
            this.buttonSendData.Location = new System.Drawing.Point(324, 136);
            this.buttonSendData.Name = "buttonSendData";
            this.buttonSendData.Size = new System.Drawing.Size(75, 23);
            this.buttonSendData.TabIndex = 5;
            this.buttonSendData.Text = "Send";
            this.buttonSendData.UseVisualStyleBackColor = true;
            this.buttonSendData.Click += new System.EventHandler(this.buttonSendData_Click);
            // 
            // comboBoxSerial
            // 
            this.comboBoxSerial.FormattingEnabled = true;
            this.comboBoxSerial.Location = new System.Drawing.Point(97, 10);
            this.comboBoxSerial.Name = "comboBoxSerial";
            this.comboBoxSerial.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSerial.TabIndex = 6;
            this.comboBoxSerial.SelectedIndexChanged += new System.EventHandler(this.comboBoxSerial_SelectedIndexChanged);
            // 
            // richTextBoxSendData
            // 
            this.richTextBoxSendData.Location = new System.Drawing.Point(15, 57);
            this.richTextBoxSendData.Name = "richTextBoxSendData";
            this.richTextBoxSendData.Size = new System.Drawing.Size(384, 69);
            this.richTextBoxSendData.TabIndex = 7;
            this.richTextBoxSendData.Text = "";
            // 
            // richTextBoxReceiveData
            // 
            this.richTextBoxReceiveData.Location = new System.Drawing.Point(12, 165);
            this.richTextBoxReceiveData.Name = "richTextBoxReceiveData";
            this.richTextBoxReceiveData.Size = new System.Drawing.Size(387, 78);
            this.richTextBoxReceiveData.TabIndex = 8;
            this.richTextBoxReceiveData.Text = "";
            // 
            // serialPortRS232
            // 
            this.serialPortRS232.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortRS232_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 273);
            this.Controls.Add(this.richTextBoxReceiveData);
            this.Controls.Add(this.richTextBoxSendData);
            this.Controls.Add(this.comboBoxSerial);
            this.Controls.Add(this.buttonSendData);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pratikum 1 - Komunikasi Serial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonSendData;
        private System.Windows.Forms.ComboBox comboBoxSerial;
        private System.Windows.Forms.RichTextBox richTextBoxSendData;
        private System.Windows.Forms.RichTextBox richTextBoxReceiveData;
        private System.IO.Ports.SerialPort serialPortRS232;
    }
}

