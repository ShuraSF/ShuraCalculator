using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETCalculator
{
    public partial class Form1 : Form
    {
        #region variables
        // простой калькулятор поддерживает только эти операции
        string[] _operatorList = new string[] { "+", "-", "/", "*" };

        // reservedNumber1 до ввода оператора, 2 будет установлено после =
        double? _reservedNumber1 = null, _reservedNumber2 = null;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // здесь находятся все кнопки калькулятора
            
            var text = ((Button)sender).Text;
            
            txtInput.Text += text;

            // если кнопка является оператором то нам нужно сохранить первое значение

            var isOperator = _operatorList.Any(p => p == text);
            if (isOperator)
            {
                if(double.TryParse(txtInput.Text, out double temp))
                {
                    _reservedNumber1 = temp;
                    txtInput.Clear();
                    lblResult.Text = $"{_reservedNumber1} {text}";
                }
            }
            else
            {
                txtInput.Text += text;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
        }
    }
}
