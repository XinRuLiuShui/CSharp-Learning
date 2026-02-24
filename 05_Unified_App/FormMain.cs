using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Unified_App
{
    public partial class FormMain : Form
    {
        // 用于保存FormSubInterface的唯一实例
        private FormSubInterface subFormInstance;

        public FormMain()
        {
            InitializeComponent();

            // 将 panel 的鼠标事件绑定到窗体的拖动方法上
            this.panelTop.MouseDown += Frm_MouseDown;
            this.panelTop.MouseMove += Frm_MouseMove;
            this.panelTop.MouseUp += Frm_MouseUp;

            this.panelLeft.MouseDown += Frm_MouseDown;
            this.panelLeft.MouseMove += Frm_MouseMove;
            this.panelLeft.MouseUp += Frm_MouseUp;

            this.panelRight.MouseDown += Frm_MouseDown;
            this.panelRight.MouseMove += Frm_MouseMove;
            this.panelRight.MouseUp += Frm_MouseUp;
        }

        //无边框的WinForm窗体，拖动位置
        private Point mouseOff;//鼠标移动位置变量
        private bool leftFlag;//标签是否为左键
        private void Frm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//判断鼠标左键是否被按下
            {
                //mouseOff = new Point(-e.X, -e.Y);//得到变量的值
                //leftFlag = true;//标记鼠标左键的状态

                // 将 sender 转换为一个控件
                Control control = sender as Control;

                // 将当前控件的坐标转换为相对于窗体的坐标
                Point controlLocationInForm = this.PointToClient(control.PointToScreen(e.Location));

                // 使用相对于窗体的坐标来计算偏移量
                mouseOff = new Point(-controlLocationInForm.X, -controlLocationInForm.Y);

                leftFlag = true;
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


        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearchPaintings_Click(object sender, EventArgs e)
        {
            // 检查实例是否存在，或者是否已经被关闭
            if (subFormInstance == null || subFormInstance.IsDisposed)
            {
                // 1. 如果不存在，就创建一个新的实例
                subFormInstance = new FormSubInterface();

                // 2. 设置子窗体为非顶级控件，这样它才能被添加到Panel中
                subFormInstance.TopLevel = false;

                // 3. 去除子窗体的边框
                //subFormInstance.FormBorderStyle = FormBorderStyle.None;

                // 4. 让子窗体填充满整个Panel
                subFormInstance.Dock = DockStyle.Fill;

                // 5. 清空Panel中的所有旧控件
                this.panelRight.Controls.Clear();

                // 6. 将子窗体实例添加到Panel中
                this.panelRight.Controls.Add(subFormInstance);

                // 7. 显示子窗体
                subFormInstance.Show();
            }
            else
            {
                // 如果实例已存在，则将其带到最前面显示
                subFormInstance.BringToFront();
            }
        }
    }
}
