namespace Hello_user
{
    partial class frmHellouser
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
            this.lblqusetion = new System.Windows.Forms.Label();
            this.lblDispaly = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtOutput1 = new System.Windows.Forms.TextBox();
            this.lblInput1 = new System.Windows.Forms.Label();
            this.txtOutput2 = new System.Windows.Forms.TextBox();
            this.lblinput2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblqusetion
            // 
            this.lblqusetion.AutoSize = true;
            this.lblqusetion.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqusetion.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblqusetion.Location = new System.Drawing.Point(186, 27);
            this.lblqusetion.Name = "lblqusetion";
            this.lblqusetion.Size = new System.Drawing.Size(340, 33);
            this.lblqusetion.TabIndex = 0;
            this.lblqusetion.Text = "How much money do you have?";
            // 
            // lblDispaly
            // 
            this.lblDispaly.Location = new System.Drawing.Point(218, 163);
            this.lblDispaly.Name = "lblDispaly";
            this.lblDispaly.Size = new System.Drawing.Size(277, 133);
            this.lblDispaly.TabIndex = 1;
            this.lblDispaly.Click += new System.EventHandler(this.lblDispaly_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(280, 299);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(141, 53);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Click it";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtOutput1
            // 
            this.txtOutput1.Location = new System.Drawing.Point(395, 77);
            this.txtOutput1.Name = "txtOutput1";
            this.txtOutput1.Size = new System.Drawing.Size(100, 20);
            this.txtOutput1.TabIndex = 3;
            this.txtOutput1.TextChanged += new System.EventHandler(this.txtOutput1_TextChanged);
            // 
            // lblInput1
            // 
            this.lblInput1.AutoSize = true;
            this.lblInput1.Location = new System.Drawing.Point(218, 77);
            this.lblInput1.Name = "lblInput1";
            this.lblInput1.Size = new System.Drawing.Size(78, 13);
            this.lblInput1.TabIndex = 4;
            this.lblInput1.Text = "Monthly wages";
            // 
            // txtOutput2
            // 
            this.txtOutput2.Location = new System.Drawing.Point(395, 123);
            this.txtOutput2.Name = "txtOutput2";
            this.txtOutput2.Size = new System.Drawing.Size(100, 20);
            this.txtOutput2.TabIndex = 5;
            // 
            // lblinput2
            // 
            this.lblinput2.AutoSize = true;
            this.lblinput2.Location = new System.Drawing.Point(218, 123);
            this.lblinput2.Name = "lblinput2";
            this.lblinput2.Size = new System.Drawing.Size(93, 13);
            this.lblinput2.TabIndex = 6;
            this.lblinput2.Text = "Year-end bonuses";
            // 
            // frmHellouser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 364);
            this.Controls.Add(this.lblinput2);
            this.Controls.Add(this.txtOutput2);
            this.Controls.Add(this.lblInput1);
            this.Controls.Add(this.txtOutput1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblDispaly);
            this.Controls.Add(this.lblqusetion);
            this.Name = "frmHellouser";
            this.Text = "Hello user program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblqusetion;
        private System.Windows.Forms.Label lblDispaly;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtOutput1;
        private System.Windows.Forms.Label lblInput1;
        private System.Windows.Forms.TextBox txtOutput2;
        private System.Windows.Forms.Label lblinput2;
    }
}

