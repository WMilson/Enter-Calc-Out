using System;
using System.Windows.Forms;

namespace Enter_Calc_Out
{
    public partial class Form1 : Form
    {
        private double _number1;
        private double _number2;
        private bool _sumChecked;
        private bool _gcdChecked;
        private bool _productChecked;

        public Form1()
        {
            InitializeComponent();
        }

        // Команда "Ввод"
        private void inputMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new InputForm())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _number1 = dialog.Number1;
                    _number2 = dialog.Number2;
                    _sumChecked = dialog.CalculateSum;
                    _gcdChecked = dialog.CalculateGcd;
                    _productChecked = dialog.CalculateProduct;

                    // После ввода команда "Посчитать" становится доступной
                    calculateMenuItem.Enabled = true;
                }
            }
        }

        // Команда "Посчитать"
        private void calculateMenuItem_Click(object sender, EventArgs e)
        {
            string result = Calculator.Calculate(
                _number1, _number2, _sumChecked, _gcdChecked, _productChecked);

            MessageBox.Show(result, "Результаты",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Команда "Выход"
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}