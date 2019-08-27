using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _09自己写事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //动态创建按钮 给按钮注册单击事件
            //location 95, 40 size 75, 23
            Button btn = new Button();
            btn.Location = new Point(95,40);
            btn.Size     = new Size(175,23);
            btn.Text     = "我是被动态创建出来的";

            btn.Click += new EventHandler(btn_Click);
            btn.Click += new EventHandler(btn1_Click);
            //btn.Click -= btn1_Click;
            //btn.Click += btn1_Click;
            this.Controls.Add(btn);
        }

        void btn_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            MessageBox.Show("我被点击了");
        }
        void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我被点击了1");
        }
    }
}
