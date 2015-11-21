using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //初始化对象
            eBox_WebServices.ebox_serviceSoapClient webClient= new eBox_WebServices.ebox_serviceSoapClient();
            int a,b;
            a=int.Parse(textBox1.Text);
            b=int.Parse(textBox2.Text);
            //调用web服务
            label1.Text = webClient.add(a, b).ToString();           
        }
    }
}
