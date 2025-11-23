namespace SerialNumberCheckDigit
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
            txtSerial = new TextBox();
            btnCalculate = new Button();
            lblResult = new Label();
            lstIterations = new ListBox();
            btnClear = new Button();
            pnlStatus = new Panel();
            lblFooter = new Label();
            chkDarkMode = new CheckBox();
            SuspendLayout();
            // 
            // txtSerial
            // 
            txtSerial.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSerial.Location = new Point(263, 38);
            txtSerial.Margin = new Padding(3, 5, 3, 5);
            txtSerial.MaxLength = 8;
            txtSerial.Name = "txtSerial";
            txtSerial.PlaceholderText = "Enter 8-digit Serial Number";
            txtSerial.Size = new Size(397, 38);
            txtSerial.TabIndex = 0;
            txtSerial.TextAlign = HorizontalAlignment.Center;
            txtSerial.TextChanged += txtSerial_TextChanged;
            txtSerial.KeyPress += txtSerial_KeyPress;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.DodgerBlue;
            btnCalculate.Cursor = Cursors.Hand;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(263, 139);
            btnCalculate.Margin = new Padding(3, 5, 3, 5);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(188, 59);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "Calculate Check Digit";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(263, 225);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(121, 28);
            lblResult.TabIndex = 2;
            lblResult.Text = "Check Digit";
            lblResult.Click += lblResult_Click;
            // 
            // lstIterations
            // 
            lstIterations.BackColor = Color.WhiteSmoke;
            lstIterations.BorderStyle = BorderStyle.FixedSingle;
            lstIterations.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstIterations.FormattingEnabled = true;
            lstIterations.ItemHeight = 22;
            lstIterations.Location = new Point(263, 294);
            lstIterations.Margin = new Padding(3, 5, 3, 5);
            lstIterations.Name = "lstIterations";
            lstIterations.Size = new Size(259, 178);
            lstIterations.TabIndex = 3;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DodgerBlue;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(495, 139);
            btnClear.Margin = new Padding(3, 5, 3, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(165, 59);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // pnlStatus
            // 
            pnlStatus.Location = new Point(263, 87);
            pnlStatus.Margin = new Padding(3, 5, 3, 5);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(397, 28);
            pnlStatus.TabIndex = 5;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Location = new Point(203, 494);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(479, 23);
            lblFooter.TabIndex = 6;
            lblFooter.Text = "Created by Msawakhe Cebekhulu | Full Stack Developer | 2025";
            // 
            // chkDarkMode
            // 
            chkDarkMode.AutoSize = true;
            chkDarkMode.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkDarkMode.Location = new Point(12, 12);
            chkDarkMode.Name = "chkDarkMode";
            chkDarkMode.Size = new Size(105, 24);
            chkDarkMode.TabIndex = 7;
            chkDarkMode.Text = "Dark Mode";
            chkDarkMode.UseVisualStyleBackColor = true;
            chkDarkMode.CheckedChanged += chkDarkMode_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 516);
            Controls.Add(chkDarkMode);
            Controls.Add(lblFooter);
            Controls.Add(pnlStatus);
            Controls.Add(btnClear);
            Controls.Add(lstIterations);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtSerial);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Serial Number Validation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSerial;
        private Button btnCalculate;
        private Label lblResult;
        private ListBox lstIterations;
        private Button btnClear;
        private Panel pnlStatus;
        private Label lblFooter;
        private CheckBox chkDarkMode;
    }
}