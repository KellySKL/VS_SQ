using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 售后
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            获取单据 j = new 获取单据();
            j.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //内部维修 j = new 内部维修();
            //j.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //维修完成处理 j = new 维修完成处理();
            //j.Show();
        }
    }









     




    }
