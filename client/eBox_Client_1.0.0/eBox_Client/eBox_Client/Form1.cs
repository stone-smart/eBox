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
    public partial class MainForm : Form
    {
        eBox_Client.ChildFrom_Postman childform_postman ;
        eBox_Client.ChildForm_GetKD child ;

        
        public MainForm()
        {
            InitializeComponent();
            IsMdiContainer = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            child = new ChildForm_GetKD();
            child.MdiParent = this;                     
            child.Show();
            if(childform_postman!=null)
                 childform_postman.Close();
            child.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            childform_postman = new ChildFrom_Postman();
            childform_postman.MdiParent = this;
            childform_postman.Show();
            if(child!=null)
                child.Close();
            childform_postman.Dock = DockStyle.Fill;
        }
    }
}
