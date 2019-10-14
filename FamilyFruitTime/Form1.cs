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
            if (MessageBox.Show("你确认要退出程序吗", "最终确认", MessageBoxButtons.OKCancel).Equals(DialogResult.OK))
            {
                Application.Exit();
            }
            else
            {
                form2.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.ShowDialog();
            if (MessageBox.Show("你确认要退出程序吗", "最终确认", MessageBoxButtons.OKCancel).Equals(DialogResult.OK))
            {
                Application.Exit();
            }
            else
            {
                form2.Close();
            }
        }
    }
}
