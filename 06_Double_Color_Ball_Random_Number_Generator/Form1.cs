using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Double_Color_Ball_Random_Number_Generator
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        int rollCount = 0;      // 当前滚动次数
        int maxRoll = 100;       // 最大滚动次数（20 * 50ms = 1秒）

        public Form1()
        {
            InitializeComponent();
        }

        private void MakeCircle(Label lbl, Color color)
        {
            lbl.BackColor = color;

            System.Drawing.Drawing2D.GraphicsPath path =
                new System.Drawing.Drawing2D.GraphicsPath();

            path.AddEllipse(0, 0, lbl.Width, lbl.Height);

            lbl.Region = new Region(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<int> redBalls = new List<int>();

            //while (redBalls.Count < 6)
            //{
            //    int num=random.Next(1, 34);

            //    if (!redBalls.Contains(num))
            //    {
            //        redBalls.Add(num);
            //    }
            //}

            //redBalls.Sort();

            //int blueBall = random.Next(1, 17);

            //string result = "红球:";

            //foreach (int num in redBalls)
            //{
            //    result += num.ToString("D2") + " ";
            //}

            //result += "蓝球:" + blueBall.ToString("D2");

            //textBox1.Text = result;

            //// 显示红球
            //label1.Text = redBalls[0].ToString("D2");
            //label2.Text = redBalls[1].ToString("D2");
            //label3.Text = redBalls[2].ToString("D2");
            //label4.Text = redBalls[3].ToString("D2");
            //label5.Text = redBalls[4].ToString("D2");
            //label6.Text = redBalls[5].ToString("D2");

            //label7.Text = blueBall.ToString("D2");

            rollCount = 0;
            timer1.Start();  // 启动动画
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MakeCircle(label1, Color.Red);
            MakeCircle(label2, Color.Red);
            MakeCircle(label3, Color.Red);
            MakeCircle(label4, Color.Red);
            MakeCircle(label5, Color.Red);
            MakeCircle(label6, Color.Red);

            MakeCircle(label7, Color.Blue);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //rollCount++;

            // 每次都生成随机数
            List<int> redBalls = new List<int>();

            while (redBalls.Count < 6)
            {
                int num = random.Next(1, 34);
                if (!redBalls.Contains(num))
                    redBalls.Add(num);
            }

            redBalls.Sort();
            int blueBall = random.Next(1, 17);

            // 显示到球上
            label1.Text = redBalls[0].ToString("D2");
            label2.Text = redBalls[1].ToString("D2");
            label3.Text = redBalls[2].ToString("D2");
            label4.Text = redBalls[3].ToString("D2");
            label5.Text = redBalls[4].ToString("D2");
            label6.Text = redBalls[5].ToString("D2");

            label7.Text = blueBall.ToString("D2");

            // 到达最大次数停止
            //if (rollCount >= maxRoll)
            //{
            //    timer1.Stop();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
