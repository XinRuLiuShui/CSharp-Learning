using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Main_UI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        //无边框的WinForm窗体，拖动位置
        private Point mouseOff;//鼠标移动位置变量
        private bool leftFlag;//标签是否为左键
        private void Frm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//判断鼠标左键是否被按下
            {
                mouseOff = new Point(-e.X, -e.Y);//得到变量的值
                leftFlag = true;//标记鼠标左键的状态
            }
        }

        private void Frm_MouseMove(object sender, MouseEventArgs e)//鼠标移动触发MouseMove事件
        {
            if (leftFlag)//判断鼠标左键有没有被按下
            {
                Point mouseSet = Control.MousePosition;//获取屏幕中鼠标所在的位置
                mouseSet.Offset(mouseOff.X, mouseOff.Y);//设置移动后的位置
                Location = mouseSet;
            }
        }

        private void Frm_MouseUp(object sender, MouseEventArgs e)//鼠标左键抬起后触发MouseUp事件
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false；
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
