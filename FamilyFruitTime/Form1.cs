using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyFruitTime
{
    public partial class Form1 : Form
    {
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            form2.ShowDialog();
            if (MessageBox.Show("你确认要退出程序吗\r\n点击是退出 点击否推出到托盘", "最终确认", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                Application.Exit();
            }
            else
            {
                form2.WindowState = FormWindowState.Minimized;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            form2 = new Form2();
            form2.ShowDialog();
            DialogResult dialogResult = MessageBox.Show("你确认要退出程序吗\r\n点击是退出 点击否推出到托盘", "最终确认", MessageBoxButtons.YesNo);
            if (dialogResult.Equals(DialogResult.Yes))
            {
                Application.Exit();
            }else {

                form2.WindowState = FormWindowState.Minimized;
            }
            
        }
    }
}
