namespace PasswordResetBruteForce
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnGenerate = new Button();
            btnStart = new Button();
            btnStop = new Button();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            lblElapsed = new Label();
            lblTimeValue = new Label();
            lblFoundPassword = new Label();
            lblResult = new Label();
            lblHash = new Label();
            txtHash = new TextBox();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(80, 32);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password:";
            lblPassword.Click += label1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(180, 29);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 1;
            txtPassword.TabStop = false;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(402, 29);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(94, 29);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Generate Password";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(217, 143);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start Attack";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(334, 143);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 29);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop Attack";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 202);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 5;
            label1.Text = "Progress:";
            label1.Click += label1_Click_1;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(180, 193);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(400, 29);
            progressBar1.TabIndex = 6;
            progressBar1.Click += progressBar1_Click;
            // 
            // lblElapsed
            // 
            lblElapsed.AutoSize = true;
            lblElapsed.Location = new Point(52, 334);
            lblElapsed.Name = "lblElapsed";
            lblElapsed.Size = new Size(101, 20);
            lblElapsed.TabIndex = 7;
            lblElapsed.Text = "Elapsed Time:";
            lblElapsed.Click += label2_Click;
            // 
            // lblTimeValue
            // 
            lblTimeValue.AutoSize = true;
            lblTimeValue.Location = new Point(168, 334);
            lblTimeValue.Name = "lblTimeValue";
            lblTimeValue.Size = new Size(74, 20);
            lblTimeValue.TabIndex = 8;
            lblTimeValue.Text = "0 seconds";
            // 
            // lblFoundPassword
            // 
            lblFoundPassword.AutoSize = true;
            lblFoundPassword.Location = new Point(35, 292);
            lblFoundPassword.Name = "lblFoundPassword";
            lblFoundPassword.Size = new Size(118, 20);
            lblFoundPassword.TabIndex = 9;
            lblFoundPassword.Text = "Found Password:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(168, 292);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(79, 20);
            lblResult.TabIndex = 10;
            lblResult.Text = "Not Found";
            // 
            // lblHash
            // 
            lblHash.AutoSize = true;
            lblHash.Location = new Point(101, 96);
            lblHash.Name = "lblHash";
            lblHash.Size = new Size(52, 20);
            lblHash.TabIndex = 11;
            lblHash.Text = "HASH:";
            // 
            // txtHash
            // 
            txtHash.Location = new Point(180, 78);
            txtHash.Multiline = true;
            txtHash.Name = "txtHash";
            txtHash.ReadOnly = true;
            txtHash.Size = new Size(316, 49);
            txtHash.TabIndex = 12;
            txtHash.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(txtHash);
            Controls.Add(lblHash);
            Controls.Add(lblResult);
            Controls.Add(lblFoundPassword);
            Controls.Add(lblTimeValue);
            Controls.Add(lblElapsed);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(btnGenerate);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Reset Brute Force";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnGenerate;
        private Button btnStart;
        private Button btnStop;
        private Label label1;
        private ProgressBar progressBar1;
        private Label lblElapsed;
        private Label lblTimeValue;
        private Label lblFoundPassword;
        private Label lblResult;
        private Label lblHash;
        private TextBox txtHash;
    }
}
