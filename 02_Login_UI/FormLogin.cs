using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Login_UI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            // 绑定鼠标事件
            btnLogin.MouseEnter += Button1_MouseEnter;
            btnLogin.MouseLeave += Button1_MouseLeave;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

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

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Transparent;  // 鼠标移入时，背景保持透明
            //btnLogin.ForeColor = Color.White;        // 鼠标移入时，文字颜色为白色
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            //btnLogin.BackColor = Color.Transparent;  // 鼠标移出时，背景保持透明
            //btnLogin.ForeColor = Color.White;        // 鼠标移出时，文字颜色保持为白色
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
