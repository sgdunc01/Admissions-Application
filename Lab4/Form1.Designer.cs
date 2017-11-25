namespace Lab4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.decisionLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numberAccepted = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gpaTxt = new System.Windows.Forms.TextBox();
            this.testTxt = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.numberRejected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "High School GPA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admissions Test Score:";
            // 
            // decisionLbl
            // 
            this.decisionLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decisionLbl.Location = new System.Drawing.Point(12, 99);
            this.decisionLbl.Name = "decisionLbl";
            this.decisionLbl.Size = new System.Drawing.Size(268, 23);
            this.decisionLbl.TabIndex = 2;
            this.decisionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Running Total Accepted:";
            // 
            // numberAccepted
            // 
            this.numberAccepted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberAccepted.Location = new System.Drawing.Point(180, 142);
            this.numberAccepted.Name = "numberAccepted";
            this.numberAccepted.Size = new System.Drawing.Size(100, 23);
            this.numberAccepted.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Running Total Rejected:";
            // 
            // gpaTxt
            // 
            this.gpaTxt.Location = new System.Drawing.Point(180, 12);
            this.gpaTxt.Name = "gpaTxt";
            this.gpaTxt.Size = new System.Drawing.Size(100, 20);
            this.gpaTxt.TabIndex = 6;
            // 
            // testTxt
            // 
            this.testTxt.Location = new System.Drawing.Point(180, 38);
            this.testTxt.Name = "testTxt";
            this.testTxt.Size = new System.Drawing.Size(100, 20);
            this.testTxt.TabIndex = 7;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(86, 228);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(120, 23);
            this.calculateBtn.TabIndex = 8;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // numberRejected
            // 
            this.numberRejected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberRejected.Location = new System.Drawing.Point(180, 173);
            this.numberRejected.Name = "numberRejected";
            this.numberRejected.Size = new System.Drawing.Size(100, 23);
            this.numberRejected.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.numberRejected);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.testTxt);
            this.Controls.Add(this.gpaTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numberAccepted);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.decisionLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label decisionLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label numberAccepted;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox gpaTxt;
        private System.Windows.Forms.TextBox testTxt;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label numberRejected;
    }
}

