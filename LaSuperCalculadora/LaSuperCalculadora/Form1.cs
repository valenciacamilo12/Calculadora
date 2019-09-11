using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaSuperCalculadora
{
    public partial class fMain : Form
    {
        private decimal _Operand;
        private string _OperandTxt;
        private string _Operator;

        public fMain()
        {
            InitializeComponent();
            Reset();

        }

        private void SetOperandTxt(string value)
        {
            //Las validaciones se hacen en estas partes

            // if value is numeric
            if (value == "9" || value == "8" || value == "7" || value == "6" || value == "5" || value == "4" || value == "3" || value == "2" || value == "1")
            {
                if (_OperandTxt == "0")
                    _OperandTxt = "";

                _OperandTxt += value;
                txtResult.Text = _OperandTxt;
            }

            //if value is operator
            else if (value == "+" || value == "-" || value == "*" || value == "/")
            {
                _Operator = value;
                _Operand = decimal.Parse(_OperandTxt);
                _OperandTxt = "";
            }

            // if value is delete

            else if (value == "\b")
            {
                Delete();
            }

            //if value is reset ESC
            else if (value == "\u001b")
            {
                Reset();
            }
        }

        private void DoOperation()
        {
            decimal result = 0;

            if(_Operator == "+")
            {
                result += decimal.Parse(_OperandTxt); 
            }

            else if (_Operator == "-")
            {
                result -= decimal.Parse(_OperandTxt);
            }

            else if (_Operator == "*")
            {
                result *= decimal.Parse(_OperandTxt);
            }

            else if (_Operator == "/")
            {
                result /= decimal.Parse(_OperandTxt);
            }

            txtResult.Text = result.ToString();
            
        }

        private void Delete()
        {
            if(_OperandTxt.Length > 1)
            {
                _OperandTxt = _OperandTxt.Substring(0, _OperandTxt.Length - 1);
            }
            else
            {
                _OperandTxt = "0";
            }
            
            txtResult.Text = _OperandTxt;
        }

        private void Reset()
        {
            _OperandTxt = "";
            _Operand = 0;
            txtResult.Text = "0";
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void btnNumber7_Click(object sender, EventArgs e)
        {
            SetOperandTxt("7"); 
        }

        
        private void btnNumber9_Click(object sender, EventArgs e)
        {
            SetOperandTxt("9");

        }

        private void btnNumber6_Click(object sender, EventArgs e)
        {
            SetOperandTxt("6");

        }

        private void btnNumber8_Click(object sender, EventArgs e)
        {
            SetOperandTxt("8");

        }

        private void btnNumber4_Click(object sender, EventArgs e)
        {
            SetOperandTxt("4");

        }

        private void btnNumber5_Click(object sender, EventArgs e)
        {
            SetOperandTxt("5");

        }

        private void btnNumber1_Click(object sender, EventArgs e)
        {
            SetOperandTxt("1");

        }

        private void btnNumber2_Click(object sender, EventArgs e)
        {
            SetOperandTxt("2");

        }

        private void btnNumber3_Click(object sender, EventArgs e)
        {
            SetOperandTxt("3");

        }

        private void btnNumber0_Click(object sender, EventArgs e)
        {
            SetOperandTxt("0");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            DoOperation();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetOperandTxt("+");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetOperandTxt(e.KeyChar.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
