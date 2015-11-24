using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eBox_Client
{
    public partial class ChildFrom_Postman : Form
    {
        public string Postman_No;//快递员编号
        public Boolean IsLoged;  //是否登录
        public ChildFrom_Postman()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string PhoneNo = txtbox_PhoneNo.Text.Trim();
            string PSW = txtBox_Psw.Text.Trim();
            if ((PhoneNo != "") & (PSW != ""))
            {
                ebox_WebServer.ebox_serviceSoapClient eBox_Server = new ebox_WebServer.ebox_serviceSoapClient();
                //验证身份
                Boolean pass= false;
                pass= eBox_Server.Postman_Verify(PhoneNo, PSW);
                if (pass)
                {
                    IsLoged = true;
                    label3.Text = "登录成功";                    //
                    
                    tabPage2.Parent = tabControl1;                    
                    tabPage1.Parent = null;

                }
                else
                {
                    label3.Text = "登录失败";
                    IsLoged = false;
                }
            }
                

        }

        private void ChildFrom_Postman_Load(object sender, EventArgs e)
        {
            tabPage2.Parent = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Tabpage实现控件切换，隐藏某tabpage效果
            tabPage1.Parent = tabControl1;
            tabPage2.Parent = null;
        }

    }
}
