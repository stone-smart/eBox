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
            eBox_Client.ChildForm_GetKD child = new ChildForm_GetKD();
            child.MdiParent = this;                     
            child.Show();
            child.Dock = DockStyle.Fill;
        }
    }
}
