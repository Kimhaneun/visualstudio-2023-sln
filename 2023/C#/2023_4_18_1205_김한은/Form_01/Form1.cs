using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_01
{
    public partial class Form1 : Form
    {
        private double saved; // 값 저장
        private char op = '\0'; // 현재 사용할 연산자
        private bool opFlag = false; // 연산자를 눌렀는지 여부 확인
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;

            if (txtResult.Text == "0" || opFlag == true)
            {
                txtResult.Text = s;
                opFlag = false;

            }

            else
            {
                txtResult.Text = txtResult.Text + s;
            }

            txtResult.Text = GroupSeperator(txtResult.Text);
        }

        public string GroupSeperator(string text)
        {
            int pos = 0;
            double v = Double.Parse(text);

            if (text.Contains("."))
            {
                pos = text.Length - text.IndexOf(".");
                if (pos == 1)
                    return text;

                string str = "{0:N" + (pos - 1) + "}";
                text = string.Format(str, v);
            }

            else
                text = string.Format("{0:N0}", v);

            return text;
        }

        private void op_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            saved = Double.Parse(txtResult.Text);
            txtExp.Text += txtResult.Text + " " + btn.Text + " ";

            op = btn.Text[0];
            opFlag = true;

        }

        private void button_Result_Click(object sender, EventArgs e)
        {
            Double value = Double.Parse(txtResult.Text);

            switch (op)
            {
                case '+':
                    txtResult.Text = (saved + value).ToString();
                    break;

                case '-':
                    txtResult.Text = (saved - value).ToString();
                    break;

                case '*':
                    txtResult.Text = (saved * value).ToString();
                    break;

                case '/':
                    txtResult.Text = (saved / value).ToString();
                    break;

            }

            txtResult.Text = GroupSeperator(txtResult.Text);
            txtExp.Text = "";

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            txtExp.Text = "";
            saved = 0;
            op = '\0';
            opFlag = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
            if (txtResult.Text.Length == 0)
                txtResult.Text = "0";
        }
    }
}
    

