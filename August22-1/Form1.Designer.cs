namespace August22_1
{
    partial class BasicForm1
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
            this.btnCalculatePay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHoursWorked = new System.Windows.Forms.TextBox();
            this.tbHourlyPayRate = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculatePay
            // 
            this.btnCalculatePay.Location = new System.Drawing.Point(12, 136);
            this.btnCalculatePay.Name = "btnCalculatePay";
            this.btnCalculatePay.Size = new System.Drawing.Size(75, 46);
            this.btnCalculatePay.TabIndex = 1;
            this.btnCalculatePay.Text = "Calculate Gross Pay";
            this.btnCalculatePay.UseVisualStyleBackColor = true;
            this.btnCalculatePay.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(104, 136);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 46);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClickHere_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hours Worked";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hourly Pay Rate";
            // 
            // tbHoursWorked
            // 
            this.tbHoursWorked.Location = new System.Drawing.Point(148, 26);
            this.tbHoursWorked.Name = "tbHoursWorked";
            this.tbHoursWorked.Size = new System.Drawing.Size(124, 20);
            this.tbHoursWorked.TabIndex = 3;
            // 
            // tbHourlyPayRate
            // 
            this.tbHourlyPayRate.Location = new System.Drawing.Point(148, 61);
            this.tbHourlyPayRate.Name = "tbHourlyPayRate";
            this.tbHourlyPayRate.Size = new System.Drawing.Size(124, 20);
            this.tbHourlyPayRate.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 136);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 46);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BasicForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 226);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbHourlyPayRate);
            this.Controls.Add(this.tbHoursWorked);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculatePay);
            this.Controls.Add(this.btnClear);
            this.Name = "BasicForm1";
            this.Text = "Basic Form 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalculatePay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHoursWorked;
        private System.Windows.Forms.TextBox tbHourlyPayRate;
        private System.Windows.Forms.Button btnExit;
    }
}

