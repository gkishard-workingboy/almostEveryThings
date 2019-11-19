using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessScheduling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public LinkedList<PCB> l = null;
        PCB temp = null;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            l = new LinkedList<PCB>();
            for (int i = 0; i < 5; i++)
                l.AddLast(new PCB("Process"+i));
            l = new LinkedList<PCB>(l.OrderByDescending(PCB => PCB.priority).ThenBy(PCB => PCB.timeNeeded));


            
            //for(int i = 1; i < 5; i++)
            //{
            //    temp = new PCB();
            //    for(int j = l.Count;j>0;j--)
            //    {
            //        if(temp.priority> )
            //        {

            //        }
            //    }
            //}

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if(l is null)
            {
                textBox1.AppendText("请先初始化进程。。。\r\n");
                return;
            }
            temp = l.First();
            if (temp.status != Status.R)
            {
                textBox1.AppendText("进程都已执行完毕。。。\r\n");
                return;
            }
            l.RemoveFirst();

            textBox1.AppendText(string.Format("当前执行: {0}-Priority:{1} TimeNeeded:{2} --> {0}-Priority:{3} TimeNeeded:{4}\r\n",temp.Pname,temp.priority,temp.timeNeeded,--temp.priority,--temp.timeNeeded));
            
            if(temp.timeNeeded <= 0)
            {
                temp.status = Status.E;
                l.AddLast(temp);
                return;
            }
            PCB t = null;
            foreach(var it in l)
            {
                if (it.priority < temp.priority || it.status == Status.E)
                {
                    t = it;
                    break;
                }
            }
            if (t is null)
                l.AddLast(temp);
            else
                l.AddBefore(l.Find(t), temp);

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(l is null)
            {
                textBox1.AppendText("请先初始化进程。。。\r\n");
                return;
            }
            string s = "  Process Name   Priority   TimeNeeded \r\n";
            string seperateLine = null;
            string dataLine = null;
            for (int i = 0; i < s.Length+8; i++)
                seperateLine += "-";
            seperateLine += "\r\n";
            foreach (var i in l)
            {
                dataLine += string.Format("  {0,11}   {1,8}   {2,10} \r\n",i.Pname,i.priority,i.timeNeeded);
            }

            textBox1.AppendText(s + seperateLine + dataLine);
        }
    }
}
