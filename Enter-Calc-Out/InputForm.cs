using System;
using System.Windows.Forms;

namespace Enter_Calc_Out
{
    public partial class InputForm : Form
    {
        public double Number1 { get; private set; }
        public double Number2 { get; private set; }

        public bool CalculateSum => sumCheckBox.Checked;
        public bool CalculateGcd => gcdCheckBox.Checked;
        public bool CalculateProduct => productCheckBox.Checked;

        public InputForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(number1TextBox.Text, out double n1) ||
                !double.TryParse(number2TextBox.Text, out double n2))
            {
                MessageBox.Show("Введите корректные числа.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Number1 = n1;
            Number2 = n2;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}