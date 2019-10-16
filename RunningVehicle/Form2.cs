using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_Car : Form
    {
        private int offset = 10;
        public Form_Car()
        {
            InitializeComponent();
        }

        private void Form_Car_Load(object sender, EventArgs e)
        {
        }
       

        private void Form_Car_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult a = MessageBox.Show("你是否确定要关闭程序", "退出确认", buttons: MessageBoxButtons.OKCancel);
            if (a.Equals(DialogResult.OK))
            {
                e.Cancel = false;
            }
            else if(a.Equals(DialogResult.Cancel))
            {
                this.Close();
            }
        }
        private void Form_Car_FormClosed(Object sender,FormClosedEventArgs e)
        {

        }

        private void notifyIcon2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Maximized;
            }
        }


        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Start();
            if (pictureBox1.Left < 2560)
            {
                pictureBox1.Top += offset / 2;
                pictureBox1.Left += offset;
            }else {
                pictureBox1.Top = -217;
                pictureBox1.Left = -394;
            }
            
            
            
        }

        private void Form_Car_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //快速
        {
            offset = 20;
        }

        private void button2_Click(object sender, EventArgs e) //慢速
        {
            offset = 10;
        }

        private void button3_Click(object sender, EventArgs e) //停止
        {
            offset = 0;
        }
    }

}
