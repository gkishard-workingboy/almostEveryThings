using System;
using System.Threading;
using System.Windows.Forms;

namespace FamilyFruitTime
{
    public partial class Form2 : Form
    {

        private static int totalFruitNum = 0;  //盘子里水果总数 = 梨子总数 + 苹果总数
        private static int appleNum = 0;       //盘子里苹果总数
        private static int pearNum = 0;        //盘子里梨子总数

        //以下是三把锁，用以保证线程安全
        private object _appleLock = new object();              //苹果锁 ： 用于兄弟间的争抢，例如在最后剩一个苹果时，兄弟两线程同时进入吃动作，都拿到苹果。
        private object _pearLock = new object();               //梨子锁 ： 道理同上，解决姐妹间的争抢问题
        private object _addLock = new object();                //增加锁 ： 既用于父母间，以防止同时进入放水果动作，致使盘子中的水果数超额。


        private int offset = 8;         //行动位移量， 既步长

        private bool tflag = false;      //并发标志位，用来暂停和启动并发效果

        private bool flagf = true;       //动作标志位，用于各种行为标志判断，为了线程安全，需要为每一个线程准备一个私有的标志位
        private bool flagm = true;
        private bool flagb1 = true;
        private bool flagb2 = true;
        private bool flags1 = true;
        private bool flags2 = true;

        //  private bool getFruit = false;  //水果标志位，记录是否拿到水果
        private bool fgetFruit = false;
        private bool mgetFruit = false;
        private bool b1getFruit = false;
        private bool b2getFruit = false;
        private bool s1getFruit = false;
        private bool s2getFruit = false;

        private int delay = 0;          //时延记号位，用于制造各种时延效果

        


        public enum FruitFlag
        {
            APPLE,
            PEAR
        };

        public Form2()
        {
            InitializeComponent();
        }


        public bool BeforeAddInPlate(FruitFlag fruit)
        {
                if (totalFruitNum < 4)
                {
                    lock (_addLock)
                    {
                        if (fruit.Equals(FruitFlag.APPLE) && totalFruitNum < 4)
                        {
                            AddAppleInPlate();
                            return true;
                        }
                        else if (fruit.Equals(FruitFlag.PEAR) && totalFruitNum < 4)
                        {
                            AddPearInPlate();
                            return true;
                        }
                    return false;
                    }
                }
                else
                {
                    textBox1.AppendText("盘子里水果是满的。\r\n");
                    return false;
                }

        }
        public bool BeforeEatInPlate(FruitFlag fruit)
        {
            if (totalFruitNum > 0)                          //如果盘子里有水果
            {
                if (fruit.Equals(FruitFlag.APPLE))          //如果是苹果
                {
                    lock (_appleLock) 
                    {
                        if (appleNum > 0)
                        {                     //如果盘子里有苹果->吃苹果->返回true
                            EatAppleInPlate();
                            return true;
                        }
                        else
                        {
                            textBox1.AppendText("盘子里没有苹果。\r\n");
                            return false;
                        }
                    }
                    
                }                                           //如果是梨子
                else
                {
                    lock (_pearLock)
                    {

                        if (pearNum > 0)                        //如果盘子里有梨子->吃梨子->返回true
                        {
                            EatPearInPlate();
                            return true;
                        }
                        else
                        {
                            textBox1.AppendText("盘子里没有梨子。\r\n");
                            return false;
                        }
                    }
                }
            }
            else                                            //如果盘子里没水果
            {

                textBox1.AppendText("盘子里没有水果。\r\n");

                return false;
            }

        }

        public void AddAppleInPlate()
        {
            if(picPear1.Visible == false && picApple1.Visible == false)
            {
                picApple1.Visible = true;

            }else if(picPear2.Visible == false && picApple2.Visible == false)
            {
                picApple2.Visible = true;

            }
            else if(picPear3.Visible == false && picApple3.Visible == false)
            {
                picApple3.Visible = true;

            }
            else if(picPear4.Visible == false && picApple4.Visible == false)
            {
                picApple4.Visible = true;

            }
            appleNum += 1;
            totalFruitNum = appleNum + pearNum;

        }


        public void AddPearInPlate()
        {
            if (picPear1.Visible == false && picApple1.Visible == false)
            {
                picPear1.Visible = true;

            }
            else if (picPear2.Visible == false && picApple2.Visible == false)
            {
                picPear2.Visible = true;

            }
            else if (picPear3.Visible == false && picApple3.Visible == false)
            {
                picPear3.Visible = true;

            }
            else if(picApple4.Visible == false && picApple4.Visible == false)
            {
                picPear4.Visible = true;

            }
            pearNum += 1;
            totalFruitNum = appleNum + pearNum;
        }

        public void EatAppleInPlate()
        {
            if (picApple4.Visible == true)
            {
                picApple4.Visible = false;

            }
            else if (picApple3.Visible == true)
            {
                picApple3.Visible = false;
                
            }
            else if (picApple2.Visible == true)
            {
                picApple2.Visible = false;

            }
            else
            {
                picApple1.Visible = false;

            }
            appleNum -= 1;
            totalFruitNum = appleNum + pearNum;

        }


        public void EatPearInPlate()
        {
            if (picPear4.Visible == true)
            {
                picPear4.Visible = false;

            }
            else if (picPear3.Visible == true)
            {
                picPear3.Visible = false;

            }
            else if (picPear2.Visible == true)
            {
                picPear2.Visible = false;

            }
            else
            {
                picPear1.Visible = false;

            }
            pearNum -= 1;
            totalFruitNum = appleNum + pearNum;
        }

 
        private void tmrFather_Tick(object sender, EventArgs e)
        {
            
            if (flagf && picFather.Left == 242)
            {
                textBox1.AppendText("爸爸开始放苹果。\r\n");
            }
            if (flagf && picFather.Left < 330) {
                picFather.Left += offset;
                picFather.Top += offset/2;
                picApple.Left += offset;
                picApple.Top += offset/2;
            }
            if (flagf && picFather.Left == 330)
            {
                fgetFruit = BeforeAddInPlate(FruitFlag.APPLE);
                if (fgetFruit)
                { 
                    picApple.Visible = false;
                    textBox1.AppendText("爸爸放进一个苹果。\r\n");
                }
                flagf = false;
            }
            if (!flagf && picFather.Left > 242) 
            {
                picFather.Left -= offset;
                picFather.Top -= offset/2;
                picApple.Left -= offset;
                picApple.Top -= offset/2;
            }
            if (picFather.Left == 242 && !flagf) 
            {                
                picApple.Visible = true;
                flagf = true;
                fgetFruit = false;
                tmrFather.Stop();
            }
            
        }


        private void tmrMother_Tick(object sender, EventArgs e)
        {
            
            if (flagm && picMother.Left == 608)
            {
                textBox1.AppendText("妈妈开始放梨子。\r\n");
            }
            if (flagm && picMother.Left > 528)
            {
                picMother.Left -= offset;
                picMother.Top += offset / 2;
                picPear.Left -= offset;
                picPear.Top += offset / 2;
            }
            if (flagm && picMother.Left == 528)
            {
                mgetFruit = BeforeAddInPlate(FruitFlag.PEAR);
                if (mgetFruit)
                {
                    picPear.Visible = false;
                    textBox1.AppendText("妈妈放进一个梨子。\r\n");
                }
                flagm = false;

            }
            if (!flagm && picMother.Left < 608)
            {
                picMother.Left += offset;
                picMother.Top -= offset / 2;
                picPear.Left += offset;
                picPear.Top -= offset / 2;
            }
            if (!flagm && picMother.Left == 608)
            {
                picPear.Visible = true;
                flagm = true;
                mgetFruit = false;
                tmrMother.Stop();
            }
        }



        private void btnFather_Click(object sender, EventArgs e)
        {           
            tmrFather.Start();
            
        }

        private void btnMother_Click(object sender, EventArgs e)
        {
            tmrMother.Start();
        }



        private void btnSister1_Click(object sender, EventArgs e)
        {
            tmrSister1.Start();
        }

        private void btnSister2_Click(object sender, EventArgs e)
        {
            tmrSister2.Start();
        }

        private void btnBrother1_Click(object sender, EventArgs e)
        {
            tmrBrother1.Start();
        }

        private void btnBrother2_Click(object sender, EventArgs e)
        {
            tmrBrother2.Start();
        }

        private void btnCleanDisk_Click(object sender, EventArgs e)
        {
            picPear1.Visible = false;
            picPear2.Visible = false;
            picPear3.Visible = false;
            picPear4.Visible = false;
            pearNum = 0;
            picApple1.Visible = false;
            picApple2.Visible = false;
            picApple3.Visible = false;
            picApple4.Visible = false;
            appleNum = 0;

            totalFruitNum = appleNum + pearNum;
        }
        private void tmrBrother2_Tick(object sender, EventArgs e)
        {
            
            if (flagb2 && picBrother2.Left == 226)
            {
                textBox1.AppendText("弟弟开始拿苹果。\r\n");
            }
            if (flagb2 && picBrother2.Left < 330)
            {
                picBrother2.Left += offset;
                picBrother2.Top -= offset / 2;
                picAppleBro2.Left += offset;
                picAppleBro2.Top -= offset / 2;
            }
            if (flagb2 && picBrother2.Left == 330)
            {
                if (picAppleBro2.Visible == false)
                {
                    b2getFruit = BeforeEatInPlate(FruitFlag.APPLE);
                    if (b2getFruit)
                    {

                        textBox1.AppendText("弟弟拿到苹果。\r\n");
                        picAppleBro2.Visible = true;

                    }
                }
                flagb2 = false;
            }
            if (!flagb2 && picBrother2.Left > 226)
            {
                picBrother2.Left -= offset;
                picBrother2.Top += offset / 2;
                picAppleBro2.Left -= offset;
                picAppleBro2.Top += offset / 2;

            }
            if (!flagb2 && picBrother2.Left == 226)
            {
                if (b2getFruit || picAppleBro2.Visible == true)
                {
                    if (delay % 5 == 0)
                    {
                        textBox1.AppendText("弟弟在吃苹果中。。。\r\n");
                    }
                    delay += 1;
                    if (delay > 15)
                    {
                        picAppleBro2.Visible = false;
                        flagb2 = true;
                        delay = 0;
                        b2getFruit = false;
                        textBox1.AppendText("弟弟苹果吃完了。\r\n");
                        tmrBrother2.Stop();
                    }
                }
                else
                {
                    textBox1.AppendText("弟弟没拿到苹果。\r\n");
                    flagb2 = true;
                    tmrBrother2.Stop();
                }

            }
            //if (picBrother2.Left < 330 && flag)
            //{
            //    picBrother2.Left += offset;
            //    picBrother2.Top -= offset / 2;

            //}
            //if (picBrother2.Left == 330 && flag)
            //{
            //    BeforeEatInPlate(FruitFlag.APPLE);
            //    flag = false;
            //}
            //if (picBrother2.Left > 226 && !flag)
            //{
            //    picBrother2.Left -= offset;
            //    picBrother2.Top += offset / 2;

            //}
            //if (picFather.Left == 226 && !flag)
            //{
            //    tmrBrother2.Stop();
            //    flag = true;
            //}
        }

        private void tmrBrother1_Tick(object sender, EventArgs e)
        {
            
            if (flagb1 && picBrother1.Left == 303)
            {
                textBox1.AppendText("哥哥开始拿苹果\r\n");
            }
            if (flagb1 && picBrother1.Left < 335)
            {
                picBrother1.Left += offset / 4;
                picBrother1.Top -= offset;
                picAppleBro1.Left += offset / 4;
                picAppleBro1.Top -= offset;
            }
            if (flagb1 && picBrother1.Left == 335)
            {
                if (picAppleBro1.Visible == false)
                {
                    b1getFruit = BeforeEatInPlate(FruitFlag.APPLE);
                    if (b1getFruit)
                    {

                        textBox1.AppendText("哥哥拿到苹果。\r\n");
                        picAppleBro1.Visible = true;

                    }
                }
                flagb1 = false;
            }
            if (!flagb1 && picBrother1.Left > 303)
            {
                picBrother1.Left -= offset / 4;
                picBrother1.Top += offset;
                picAppleBro1.Left -= offset / 4;
                picAppleBro1.Top += offset;
                
            }
            if (!flagb1 && picBrother1.Left == 303)
            {
                if (b1getFruit || picAppleBro1.Visible == true)
                {
                    if (delay % 5 == 0)
                    {
                        textBox1.AppendText("哥哥在吃苹果中。。。\r\n");
                    }
                    delay += 1;
                    if (delay > 15)
                    {
                        picAppleBro1.Visible = false;
                        tmrBrother1.Stop();
                        flagb1 = true;
                        delay = 0;
                        b1getFruit = false;
                        textBox1.AppendText("哥哥苹果吃完了。\r\n");
                    }
                }
                else
                {
                    textBox1.AppendText("哥哥没拿到苹果。\r\n");
                    flagb1 = true;
                    tmrBrother1.Stop();
                }
                
            }
        }
        private void tmrSister1_Tick(object sender, EventArgs e)
        {
            
            if (flags1 && picSister1.Left == 544)
            {
                textBox1.AppendText("姐姐开始拿梨子\r\n");
            }
            if (flags1 && picSister1.Left > 514)
            {
                picSister1.Left -= offset / 4;
                picSister1.Top -= offset;
                picPearSis1.Left -= offset / 4;
                picPearSis1.Top -= offset;
            }
            if (flags1 && picSister1.Left == 514)
            {
                if (picPearSis1.Visible == false) {
                    s1getFruit = BeforeEatInPlate(FruitFlag.PEAR);
                    if (s1getFruit)
                    {

                        textBox1.AppendText("姐姐拿到梨子。\r\n");
                        picPearSis1.Visible = true;

                    } 
                }
                flags1 = false;
            }
            if (!flags1 && picSister1.Left < 544)
            {
                picSister1.Left += offset / 4;
                picSister1.Top += offset;
                picPearSis1.Left += offset / 4;
                picPearSis1.Top += offset;

            }
            if (!flags1 && picSister1.Left == 544)
            {
                if (s1getFruit|| picPearSis1.Visible == true)
                {
                    if (delay % 5 == 0)
                    {
                        textBox1.AppendText("姐姐在吃梨子中。。。\r\n");
                    }
                    delay += 1;
                    if (delay > 15)
                    {
                        picPearSis1.Visible = false;
                        tmrSister1.Stop();
                        flags1 = true;
                        delay = 0;
                        s1getFruit = false;
                        textBox1.AppendText("姐姐梨子吃完了。\r\n");
                    }
                }
                else
                {
                    textBox1.AppendText("姐姐没拿到梨子。\r\n");
                    flags1 = true;
                    tmrSister1.Stop();
                }

            }

        }

        private void tmrSister2_Tick(object sender, EventArgs e)
        {
            
            if (flags2 && picSister2.Left == 621)
            {
                textBox1.AppendText("妹妹开始拿梨子\r\n");
            }
            if (flags2 && picSister2.Left > 517)
            {
                picSister2.Left -= offset;
                picSister2.Top -= offset / 2;
                picPearSis2.Left -= offset;
                picPearSis2.Top -= offset / 2;
            }
            if (flags2 && picSister2.Left == 517)
            {
                if (picPearSis2.Visible == false)
                {
                    s2getFruit = BeforeEatInPlate(FruitFlag.PEAR);
                    if (s2getFruit)
                    {

                        textBox1.AppendText("妹妹拿到梨子。\r\n");
                        picPearSis2.Visible = true;

                    }
                }
                flags2 = false;
            }
            if (!flags2 && picSister2.Left < 621)
            {
                picSister2.Left += offset;
                picSister2.Top += offset / 2;
                picPearSis2.Left += offset;
                picPearSis2.Top += offset / 2;

            }
            if (!flags2 && picSister2.Left == 621)
            {
                if (s2getFruit || picPearSis2.Visible == true)
                {
                    if (delay % 5 == 0)
                    {
                        textBox1.AppendText("妹妹在吃梨子中。。。\r\n");
                    }
                    delay += 1;
                    if (delay > 15)
                    {
                        picPearSis2.Visible = false;
                        tmrSister2.Stop();
                        flags2 = true;
                        delay = 0;
                        s2getFruit = false;
                        textBox1.AppendText("妹妹梨子吃完了。\r\n");
                    }
                }
                else
                {
                    textBox1.AppendText("妹妹没拿到梨子。\r\n");
                    flags2 = true;
                    tmrSister2.Stop();
                }

            }
        }

        private void btnThread_Click(object sender, EventArgs e)
        {
            this.tflag = !tflag;
            
            
            if (tflag)
            {
                btnFather.Visible = false;
                btnMother.Visible = false;
                btnBrother1.Visible = false;
                btnBrother2.Visible = false;
                btnSister1.Visible = false;
                btnSister2.Visible = false;
                tmrThread.Start();

            }
            else
            {
                btnFather.Visible = true;
                btnMother.Visible = true;
                btnBrother1.Visible = true;
                btnBrother2.Visible = true;
                btnSister1.Visible = true;
                btnSister2.Visible = true;
                tmrThread.Stop();
            }

            //if (tflag)
            //{
            //    //Thread t1 = new Thread(tmrSister1.Start);                   //多线程
            //    //Thread t2 = new Thread(tmrSister1.Start);
            //    //Thread t3 = new Thread(tmrSister1.Start);
            //    //Thread t4 = new Thread(tmrSister1.Start);
            //    //Thread t5 = new Thread(tmrSister1.Start);
            //    //Thread t6 = new Thread(tmrSister1.Start);
            //    //threadMethod(t1,t2,t3,t4,t5,t6);


            //}
            //Thread td = new Thread(threadMethod);
            //Thread td2 = new Thread(threadMethod);

            //td.Start();
            //td2.Start();
        }

        //private void threadMethod(Thread t1,Thread t2, Thread t3, Thread t4, Thread t5, Thread t6) {
        public void threadMethod() {

            while (tflag) { 
            
                tmrFather.Start();
                tmrMother.Start();
                tmrBrother1.Start();
                tmrBrother2.Start();
                tmrSister1.Start();
                tmrSister2.Start();
            }
            

            //while(tflag)
            //{
            //    if(count == 0) { 
            //    t1.Start();
            //    t2.Start();
            //    t3.Start();
            //    t4.Start();
            //    t5.Start();
            //    t6.Start();
            //    }

            //}

            //if (!tflag){
            //    t1.Abort();
            //    t2.Abort();
            //    t3.Abort();
            //    t4.Abort();
            //    t5.Abort();
            //    t6.Abort();
            //}



        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (tflag) { 
                tmrFather.Start();
                tmrMother.Start();
                tmrBrother1.Start();
                tmrBrother2.Start();
                tmrSister1.Start();
                tmrSister2.Start();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
            //this.WindowState = FormWindowState.Minimized;

            //DialogResult a = MessageBox.Show("你要将程序退出到托盘状态吗？\r\n", "退出确认", buttons: MessageBoxButtons.OKCancel);
            //if (a.Equals(DialogResult.OK))
            //{
            //    e.Cancel = false;
            //    this.WindowState = FormWindowState.Minimized;
            //    this.ShowInTaskbar = false;
            //}
            //else if (a.Equals(DialogResult.Cancel))
            //{
            //    e.Cancel = false;
            //}


            //if (MessageBox.Show("你要将程序退出到托盘状态吗？\r\n", "最终确认", MessageBoxButtons.OKCancel).Equals(DialogResult.Cancel))
            //{
            //    Application.Exit();
            //}
            //else
            //{
            //    form2.Close();
            //}


        }
    }
}
