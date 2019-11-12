using System;
using System.Windows.Forms;

namespace BankerAlgorithm
{

    public partial class Form1 : Form
    {
        public static Processes processes;
        static int a1 = 0;                        //进程数
        static int a2 = 0;                        //资源数

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //foreach( var a in dataGridView1.SelectedRows)
            //Console.WriteLine("" + a + " , ");

            //Console.WriteLine("" + dataGridView1.SelectedRows[0].Index);
            //Console.WriteLine("" + dataGridView1.SelectedColumns[0].Index);
            //Console.WriteLine("" + dataGridView1.SelectedCells[0].Value);

            if (dataGridView1.SelectedCells.Count >= 1)
            {
                Console.WriteLine("" + dataGridView1.SelectedCells[0].Value);
                Console.WriteLine("" + dataGridView1.SelectedCells[0].RowIndex);
                Console.WriteLine("" + dataGridView1.SelectedCells[0].ColumnIndex);
            }



            //foreach (var a in dataGridView1.SelectedCells)
            //{
            //    Console.WriteLine("" + a);
            //    Console.WriteLine(a.ToString());               
            //}

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if (!(textBox1.Text.Equals("")) && !(textBox2.Text.Equals("")))
            {
                a1 = int.Parse(textBox1.Text);
                a2 = int.Parse(textBox2.Text);
                if (a1 >= 0 && a2 >= 0)              
                    processes = new Processes(a1, a2);
                else
                {
                    MessageBox.Show("输入不能出现负数", "错误", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                MessageBox.Show("请输入数据", "错误", MessageBoxButtons.OK);
                return;
            }
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Rows.Clear();

            for (var i = 0; i < int.Parse(textBox1.Text); i++)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = "P" + index;
                dataGridView1.Rows[index].Cells[1].Value = processes.max[index].ToString();
                dataGridView1.Rows[index].Cells[2].Value = processes.allocation[index].ToString();
                dataGridView1.Rows[index].Cells[3].Value = processes.need[index].ToString();

                if (i == 0)
                {
                    dataGridView1.Rows[index].Cells[4].Value = processes.available.ToString();
                }
            }
            txtStatus.Clear();
            if (processes.bankerAlgorithm(0))
            {
                txtStatus.AppendText(processes.status + "\r\n");
                txtStatus.AppendText("安全序列 " + processes.p);
            }
            else
            {
                txtStatus.AppendText(processes.status + "\r\n");
            }

            lstProcess.Items.Clear();
            for(var i = 0; i< a1; i++ )
            {
                lstProcess.Items.Add("P" + i);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lstProcess.SelectedIndex < 0)
            {
                MessageBox.Show("请选择进程", "错误", MessageBoxButtons.OK);
                return;
            }
            if(textBox3.Text.Trim().Split().Length == processes.request.m.Count)
                processes.request = new M(textBox3.Text);
            else
            {
                MessageBox.Show("请正确填写请求向量", "错误", MessageBoxButtons.OK);
                return;
            }

            txtStatus.Clear();
            if (processes.bankerAlgorithm(lstProcess.SelectedIndex))
            {
                txtStatus.AppendText(processes.status + "\r\n");
                txtStatus.AppendText("安全序列 " + processes.p);
            }
            else
            {
                txtStatus.AppendText(processes.status + "\r\n");
            }
            dataGridView1.Rows.Clear();

            for (var i = 0; i < int.Parse(textBox1.Text); i++)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = "P" + index;
                dataGridView1.Rows[index].Cells[1].Value = processes.max[index].ToString();
                dataGridView1.Rows[index].Cells[2].Value = processes.allocation[index].ToString();
                dataGridView1.Rows[index].Cells[3].Value = processes.need[index].ToString();

                if (i == 0)
                {
                    dataGridView1.Rows[index].Cells[4].Value = processes.available.ToString();
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = 0;
            int column = 0;
            string value = "";
            if (dataGridView1.SelectedCells.Count >= 1)
            {
                value = dataGridView1.SelectedCells[0].Value.ToString();
                row = dataGridView1.SelectedCells[0].RowIndex;
                column = dataGridView1.SelectedCells[0].ColumnIndex;
            }
            if (value.Trim().Split().Length != a2)
                MessageBox.Show("修改向量维度应与原向量保持一致", "错误", MessageBoxButtons.OK);
            else
            {
                M temp = new M(value);                

                switch (char.Parse(column.ToString()))
                {
                    case '1':                           //max
                        if (MUtil.isPositive(MUtil.SubM(temp, processes.allocation[row])))
                        {
                            processes.max[row] = temp;
                        }
                        else
                        {
                            MessageBox.Show("修改向量数值错误：最大需求不能比已分配要小", "错误", MessageBoxButtons.OK);
                        }
                        break;
                    case '2':                           //allocation
                        if (MUtil.isPositive(MUtil.SubM(processes.max[row], temp)))
                        {
                            processes.allocation[row] = temp;
                        }
                        else
                        {
                            MessageBox.Show("修改向量数值错误：已分配不能比最大需求要大", "错误", MessageBoxButtons.OK);

                        }
                        break;               

                }
                processes.need[row] = MUtil.SubM(processes.max[row],processes.allocation[row]);
            }

            dataGridView1.Rows.Clear();
            for (var i = 0; i < int.Parse(textBox1.Text); i++)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = "P" + index;
                dataGridView1.Rows[index].Cells[1].Value = processes.max[index].ToString();
                dataGridView1.Rows[index].Cells[2].Value = processes.allocation[index].ToString();
                dataGridView1.Rows[index].Cells[3].Value = processes.need[index].ToString();

                if (i == 0)
                {
                    dataGridView1.Rows[index].Cells[4].Value = processes.available.ToString();
                }
            }

        }
    }

    
}
