using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch5_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp;
            temp = Convert.ToInt32(txtTemp.Text);
            lblOutput.Text = "今天氣溫：" + temp + "\n";
            if (temp <= 22 && temp >= 20)
            {
                lblOutput.Text += "加一件薄外套！";
            }
        }
    }
}
