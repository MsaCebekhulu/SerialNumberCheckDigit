using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace SerialNumberCheckDigit
{
    public partial class SerialNumberCheck : Form
    {
        public SerialNumberCheck()
        {
            InitializeComponent();
            txtSerial.Focus();

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lstIterations.Items.Clear();
            lblResult.Text = "Check Digit:";

            string input = txtSerial.Text.Trim();

            if (input.Length != 8 || !input.All(char.IsDigit))
            {
                MessageBox.Show("Please enter exactly 8 numeric digits.", "Invalid Input",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pnlStatus.BackColor = Color.Red;

                return;
            }


            List<int> digits = input.Select(c => int.Parse(c.ToString())).ToList();


            lstIterations.Items.Add(string.Join("", digits));

            int result = CalculateCheckDigit(digits);

            lblResult.Text = "Check Digit: " + result;
        }

        private int CalculateCheckDigit(List<int> digits)
        {
            pnlStatus.BackColor = Color.Green;

            while (digits.Count > 1)
            {
                List<int> newDigits = new List<int>();

                for (int i = 0; i < digits.Count - 1; i++)
                {
                    int sum = digits[i] + digits[i + 1];

                    if (sum >= 10)
                        sum = sum % 10;

                    newDigits.Add(sum);
                }

                digits = newDigits;
                lstIterations.Items.Add(string.Join("", digits));
            }

            return digits[0];
        }

        private void txtSerial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtSerial_TextChanged(object sender, EventArgs e)
        {
            if (txtSerial.Text.Length == 8)
            {
                btnCalculate.PerformClick();
            }
        }


        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSerial.Clear();
            lblResult.Text = "Check Digit:";
            lstIterations.Items.Clear();
            pnlStatus.BackColor = Color.LightGray;
            txtSerial.Focus();
        }

        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDarkMode.Checked)
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                lblResult.ForeColor = Color.White;
                lstIterations.BackColor = Color.FromArgb(45, 45, 45);
                lstIterations.ForeColor = Color.White;
                lblFooter.ForeColor = Color.White;
                chkDarkMode.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                lblResult.ForeColor = Color.Black;
                lstIterations.BackColor = Color.WhiteSmoke;
                lstIterations.ForeColor = Color.Black;
                lblFooter.ForeColor = Color.Black;
                chkDarkMode.ForeColor = Color.Black;
            }
        }
    }
}
