using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _07事件执行所需要的参数
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //Label btn = (Label)sender; //出现异常
            //sender就是触发事件的对象
            //e就是执行这个事件所需要的数据资源
            MessageBox.Show("转换成功");
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
