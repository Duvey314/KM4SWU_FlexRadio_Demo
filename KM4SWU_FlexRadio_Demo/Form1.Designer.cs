namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.callsignTextBox = new System.Windows.Forms.TextBox();
            this.nickameTextBox = new System.Windows.Forms.TextBox();
            this.serialTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioIPAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFreq = new System.Windows.Forms.Label();
            this.slicefreqTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUSB = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lblBand = new System.Windows.Forms.Label();
            this.btnMute = new System.Windows.Forms.Button();
            this.lblMute = new System.Windows.Forms.Label();
            this.btnUnMute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // callsignTextBox
            // 
            this.callsignTextBox.Location = new System.Drawing.Point(137, 49);
            this.callsignTextBox.Name = "callsignTextBox";
            this.callsignTextBox.Size = new System.Drawing.Size(100, 20);
            this.callsignTextBox.TabIndex = 1;
            // 
            // nickameTextBox
            // 
            this.nickameTextBox.Location = new System.Drawing.Point(329, 49);
            this.nickameTextBox.Name = "nickameTextBox";
            this.nickameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nickameTextBox.TabIndex = 2;
            // 
            // serialTextBox
            // 
            this.serialTextBox.Location = new System.Drawing.Point(138, 108);
            this.serialTextBox.Name = "serialTextBox";
            this.serialTextBox.Size = new System.Drawing.Size(121, 20);
            this.serialTextBox.TabIndex = 3;
            this.serialTextBox.TextChanged += new System.EventHandler(this.serialTextBox_TextChanged);
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(329, 108);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Callsign";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Serial Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Model";
            // 
            // radioIPAddress
            // 
            this.radioIPAddress.Location = new System.Drawing.Point(137, 205);
            this.radioIPAddress.Name = "radioIPAddress";
            this.radioIPAddress.Size = new System.Drawing.Size(151, 20);
            this.radioIPAddress.TabIndex = 9;
            this.radioIPAddress.TextChanged += new System.EventHandler(this.radioIPAddress_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "RADIO IP ADDRESS:";
            // 
            // lblFreq
            // 
            this.lblFreq.AutoSize = true;
            this.lblFreq.Location = new System.Drawing.Point(406, 285);
            this.lblFreq.Name = "lblFreq";
            this.lblFreq.Size = new System.Drawing.Size(0, 13);
            this.lblFreq.TabIndex = 11;
            // 
            // slicefreqTextbox
            // 
            this.slicefreqTextbox.Location = new System.Drawing.Point(335, 205);
            this.slicefreqTextbox.Name = "slicefreqTextbox";
            this.slicefreqTextbox.Size = new System.Drawing.Size(94, 20);
            this.slicefreqTextbox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Current Slice Freq";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Connect";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(478, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Mode Select";
            // 
            // btnUSB
            // 
            this.btnUSB.Location = new System.Drawing.Point(474, 95);
            this.btnUSB.Name = "btnUSB";
            this.btnUSB.Size = new System.Drawing.Size(75, 23);
            this.btnUSB.TabIndex = 29;
            this.btnUSB.Text = "USB";
            this.btnUSB.UseVisualStyleBackColor = true;
            this.btnUSB.Click += new System.EventHandler(this.btnUSB_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(470, 235);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 16);
            this.label14.TabIndex = 36;
            this.label14.Text = " Current Band";
            // 
            // lblBand
            // 
            this.lblBand.AutoSize = true;
            this.lblBand.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBand.Location = new System.Drawing.Point(449, 251);
            this.lblBand.Name = "lblBand";
            this.lblBand.Size = new System.Drawing.Size(76, 29);
            this.lblBand.TabIndex = 37;
            this.lblBand.Text = "         ";
            // 
            // btnMute
            // 
            this.btnMute.Location = new System.Drawing.Point(473, 153);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(75, 23);
            this.btnMute.TabIndex = 39;
            this.btnMute.Text = "MUTE";
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // lblMute
            // 
            this.lblMute.AutoSize = true;
            this.lblMute.Location = new System.Drawing.Point(482, 212);
            this.lblMute.Name = "lblMute";
            this.lblMute.Size = new System.Drawing.Size(63, 13);
            this.lblMute.TabIndex = 40;
            this.lblMute.Text = "Mute or Not";
            // 
            // btnUnMute
            // 
            this.btnUnMute.Location = new System.Drawing.Point(474, 182);
            this.btnUnMute.Name = "btnUnMute";
            this.btnUnMute.Size = new System.Drawing.Size(75, 23);
            this.btnUnMute.TabIndex = 41;
            this.btnUnMute.Text = "UnMute";
            this.btnUnMute.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 396);
            this.Controls.Add(this.btnUnMute);
            this.Controls.Add(this.lblMute);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.lblBand);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnUSB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.slicefreqTextbox);
            this.Controls.Add(this.lblFreq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioIPAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.serialTextBox);
            this.Controls.Add(this.nickameTextBox);
            this.Controls.Add(this.callsignTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "K1PGV\'s Test Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox callsignTextBox;
        private System.Windows.Forms.TextBox nickameTextBox;
        private System.Windows.Forms.TextBox serialTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox radioIPAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFreq;
        private System.Windows.Forms.TextBox slicefreqTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnUSB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblBand;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Label lblMute;
        private System.Windows.Forms.Button btnUnMute;
    }
}

