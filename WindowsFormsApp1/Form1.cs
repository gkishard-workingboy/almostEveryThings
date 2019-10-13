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
    public partial class Main_Form : Form
    {
        Form_Car form;
        public Main_Form()
        {
            InitializeComponent();
            form   = new Form_Car();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            
            form.ShowDialog();
            if (MessageBox.Show("真的要退出吗", "最终确认", MessageBoxButtons.OKCancel).Equals(DialogResult.OK))
            {
                Application.Exit();
            }
                
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            form.ShowDialog();
            if (MessageBox.Show("真的要退出吗", "最终确认", MessageBoxButtons.OKCancel).Equals(DialogResult.OK))
            {
                Application.Exit();
            }
        }
    }
}
