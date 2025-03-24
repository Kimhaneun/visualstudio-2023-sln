using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_1205_김한은
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_BMI_Click(object sender, EventArgs e)
        {
            if(text_weight.Text == "" || text_weight.Text == "")
            {
                label_result.Text = "키와 체중을 모두 입력해 주세요.";
                return;
            }

            double h = double.Parse(text_stature.Text) / 100.0;
            double w = double.Parse(text_weight.Text);
            double bmi = w / (h * h);

            label_result.Text = string.Format($"당신의 BMI : {bmi}");

        }

    }
}
