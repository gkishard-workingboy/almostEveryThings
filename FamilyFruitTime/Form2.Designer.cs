namespace FamilyFruitTime
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tmrFather = new System.Windows.Forms.Timer(this.components);
            this.tmrMother = new System.Windows.Forms.Timer(this.components);
            this.btnFather = new System.Windows.Forms.Button();
            this.btnMother = new System.Windows.Forms.Button();
            this.btnSister1 = new System.Windows.Forms.Button();
            this.btnSister2 = new System.Windows.Forms.Button();
            this.btnBrother2 = new System.Windows.Forms.Button();
            this.btnBrother1 = new System.Windows.Forms.Button();
            this.tmrSister1 = new System.Windows.Forms.Timer(this.components);
            this.tmrSister2 = new System.Windows.Forms.Timer(this.components);
            this.tmrBrother1 = new System.Windows.Forms.Timer(this.components);
            this.tmrBrother2 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCleanDisk = new System.Windows.Forms.Button();
            this.picBrother1 = new System.Windows.Forms.PictureBox();
            this.picBrother2 = new System.Windows.Forms.PictureBox();
            this.picSister1 = new System.Windows.Forms.PictureBox();
            this.picFather = new System.Windows.Forms.PictureBox();
            this.picMother = new System.Windows.Forms.PictureBox();
            this.picSister2 = new System.Windows.Forms.PictureBox();
            this.picApple = new System.Windows.Forms.PictureBox();
            this.picPlate = new System.Windows.Forms.PictureBox();
            this.picPear = new System.Windows.Forms.PictureBox();
            this.picApple1 = new System.Windows.Forms.PictureBox();
            this.picApple2 = new System.Windows.Forms.PictureBox();
            this.picApple3 = new System.Windows.Forms.PictureBox();
            this.picApple4 = new System.Windows.Forms.PictureBox();
            this.picPear1 = new System.Windows.Forms.PictureBox();
            this.picPear2 = new System.Windows.Forms.PictureBox();
            this.picPear3 = new System.Windows.Forms.PictureBox();
            this.picPear4 = new System.Windows.Forms.PictureBox();
            this.picAppleBro1 = new System.Windows.Forms.PictureBox();
            this.picAppleBro2 = new System.Windows.Forms.PictureBox();
            this.picPearSis2 = new System.Windows.Forms.PictureBox();
            this.picPearSis1 = new System.Windows.Forms.PictureBox();
            this.btnThread = new System.Windows.Forms.Button();
            this.tmrThread = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBrother1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBrother2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSister1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMother)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSister2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApple1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApple2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApple3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApple4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPear1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPear2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPear3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPear4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAppleBro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAppleBro2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPearSis2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPearSis1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrFather
            // 
            this.tmrFather.Interval = 150;
            this.tmrFather.Tick += new System.EventHandler(this.tmrFather_Tick);
            // 
            // tmrMother
            // 
            this.tmrMother.Interval = 150;
            this.tmrMother.Tick += new System.EventHandler(this.tmrMother_Tick);
            // 
            // btnFather
            // 
            this.btnFather.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFather.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFather.Location = new System.Drawing.Point(186, 588);
            this.btnFather.Name = "btnFather";
            this.btnFather.Size = new System.Drawing.Size(75, 40);
            this.btnFather.TabIndex = 0;
            this.btnFather.Text = "父亲放苹果";
            this.btnFather.UseVisualStyleBackColor = false;
            this.btnFather.Click += new System.EventHandler(this.btnFather_Click);
            // 
            // btnMother
            // 
            this.btnMother.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMother.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMother.Location = new System.Drawing.Point(267, 588);
            this.btnMother.Name = "btnMother";
            this.btnMother.Size = new System.Drawing.Size(75, 40);
            this.btnMother.TabIndex = 1;
            this.btnMother.Text = "母亲放梨";
            this.btnMother.UseVisualStyleBackColor = false;
            this.btnMother.Click += new System.EventHandler(this.btnMother_Click);
            // 
            // btnSister1
            // 
            this.btnSister1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSister1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSister1.Location = new System.Drawing.Point(348, 588);
            this.btnSister1.Name = "btnSister1";
            this.btnSister1.Size = new System.Drawing.Size(75, 40);
            this.btnSister1.TabIndex = 2;
            this.btnSister1.Text = "姐姐吃梨";
            this.btnSister1.UseVisualStyleBackColor = false;
            this.btnSister1.Click += new System.EventHandler(this.btnSister1_Click);
            // 
            // btnSister2
            // 
            this.btnSister2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSister2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSister2.Location = new System.Drawing.Point(429, 588);
            this.btnSister2.Name = "btnSister2";
            this.btnSister2.Size = new System.Drawing.Size(75, 40);
            this.btnSister2.TabIndex = 3;
            this.btnSister2.Text = "妹妹吃梨";
            this.btnSister2.UseVisualStyleBackColor = false;
            this.btnSister2.Click += new System.EventHandler(this.btnSister2_Click);
            // 
            // btnBrother2
            // 
            this.btnBrother2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBrother2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrother2.Location = new System.Drawing.Point(591, 588);
            this.btnBrother2.Name = "btnBrother2";
            this.btnBrother2.Size = new System.Drawing.Size(75, 40);
            this.btnBrother2.TabIndex = 4;
            this.btnBrother2.Text = "弟弟吃苹果";
            this.btnBrother2.UseVisualStyleBackColor = false;
            this.btnBrother2.Click += new System.EventHandler(this.btnBrother2_Click);
            // 
            // btnBrother1
            // 
            this.btnBrother1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBrother1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrother1.Location = new System.Drawing.Point(510, 588);
            this.btnBrother1.Name = "btnBrother1";
            this.btnBrother1.Size = new System.Drawing.Size(75, 40);
            this.btnBrother1.TabIndex = 5;
            this.btnBrother1.Text = "哥哥吃苹果";
            this.btnBrother1.UseVisualStyleBackColor = false;
            this.btnBrother1.Click += new System.EventHandler(this.btnBrother1_Click);
            // 
            // tmrSister1
            // 
            this.tmrSister1.Interval = 150;
            this.tmrSister1.Tick += new System.EventHandler(this.tmrSister1_Tick);
            // 
            // tmrSister2
            // 
            this.tmrSister2.Interval = 150;
            this.tmrSister2.Tick += new System.EventHandler(this.tmrSister2_Tick);
            // 
            // tmrBrother1
            // 
            this.tmrBrother1.Interval = 150;
            this.tmrBrother1.Tick += new System.EventHandler(this.tmrBrother1_Tick);
            // 
            // tmrBrother2
            // 
            this.tmrBrother2.Interval = 150;
            this.tmrBrother2.Tick += new System.EventHandler(this.tmrBrother2_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(998, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 616);
            this.textBox1.TabIndex = 6;
            // 
            // btnCleanDisk
            // 
            this.btnCleanDisk.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCleanDisk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCleanDisk.Location = new System.Drawing.Point(672, 588);
            this.btnCleanDisk.Name = "btnCleanDisk";
            this.btnCleanDisk.Size = new System.Drawing.Size(75, 40);
            this.btnCleanDisk.TabIndex = 7;
            this.btnCleanDisk.Text = "清空盘子";
            this.btnCleanDisk.UseVisualStyleBackColor = false;
            this.btnCleanDisk.Click += new System.EventHandler(this.btnCleanDisk_Click);
            // 
            // picBrother1
            // 
            this.picBrother1.BackColor = System.Drawing.Color.Transparent;
            this.picBrother1.Image = ((System.Drawing.Image)(resources.GetObject("picBrother1.Image")));
            this.picBrother1.Location = new System.Drawing.Point(303, 399);
            this.picBrother1.Name = "picBrother1";
            this.picBrother1.Size = new System.Drawing.Size(71, 70);
            this.picBrother1.TabIndex = 8;
            this.picBrother1.TabStop = false;
            // 
            // picBrother2
            // 
            this.picBrother2.BackColor = System.Drawing.Color.Transparent;
            this.picBrother2.Image = ((System.Drawing.Image)(resources.GetObject("picBrother2.Image")));
            this.picBrother2.Location = new System.Drawing.Point(226, 333);
            this.picBrother2.Name = "picBrother2";
            this.picBrother2.Size = new System.Drawing.Size(71, 70);
            this.picBrother2.TabIndex = 9;
            this.picBrother2.TabStop = false;
            // 
            // picSister1
            // 
            this.picSister1.BackColor = System.Drawing.Color.Transparent;
            this.picSister1.Image = ((System.Drawing.Image)(resources.GetObject("picSister1.Image")));
            this.picSister1.Location = new System.Drawing.Point(544, 399);
            this.picSister1.Name = "picSister1";
            this.picSister1.Size = new System.Drawing.Size(71, 70);
            this.picSister1.TabIndex = 10;
            this.picSister1.TabStop = false;
            // 
            // picFather
            // 
            this.picFather.BackColor = System.Drawing.Color.Transparent;
            this.picFather.Image = ((System.Drawing.Image)(resources.GetObject("picFather.Image")));
            this.picFather.Location = new System.Drawing.Point(242, 209);
            this.picFather.Name = "picFather";
            this.picFather.Size = new System.Drawing.Size(71, 70);
            this.picFather.TabIndex = 11;
            this.picFather.TabStop = false;
            // 
            // picMother
            // 
            this.picMother.BackColor = System.Drawing.Color.Transparent;
            this.picMother.Image = ((System.Drawing.Image)(resources.GetObject("picMother.Image")));
            this.picMother.Location = new System.Drawing.Point(608, 209);
            this.picMother.Name = "picMother";
            this.picMother.Size = new System.Drawing.Size(71, 70);
            this.picMother.TabIndex = 12;
            this.picMother.TabStop = false;
            // 
            // picSister2
            // 
            this.picSister2.BackColor = System.Drawing.Color.Transparent;
            this.picSister2.Image = ((System.Drawing.Image)(resources.GetObject("picSister2.Image")));
            this.picSister2.Location = new System.Drawing.Point(621, 333);
            this.picSister2.Name = "picSister2";
            this.picSister2.Size = new System.Drawing.Size(71, 70);
            this.picSister2.TabIndex = 13;
            this.picSister2.TabStop = false;
            // 
            // picApple
            // 
            this.picApple.BackColor = System.Drawing.Color.Transparent;
            this.picApple.Image = ((System.Drawing.Image)(resources.GetObject("picApple.Image")));
            this.picApple.Location = new System.Drawing.Point(293, 244);
            this.picApple.Name = "picApple";
            this.picApple.Size = new System.Drawing.Size(30, 32);
            this.picApple.TabIndex = 14;
            this.picApple.TabStop = false;
            // 
            // picPlate
            // 
            this.picPlate.BackColor = System.Drawing.Color.Transparent;
            this.picPlate.Image = ((System.Drawing.Image)(resources.GetObject("picPlate.Image")));
            this.picPlate.Location = new System.Drawing.Point(400, 298);
            this.picPlate.Name = "picPlate";
            this.picPlate.Size = new System.Drawing.Size(127, 36);
            this.picPlate.TabIndex = 15;
            this.picPlate.TabStop = false;
            // 
            // picPear
            // 
            this.picPear.BackColor = System.Drawing.Color.Transparent;
            this.picPear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPear.Image = ((System.Drawing.Image)(resources.GetObject("picPear.Image")));
            this.picPear.Location = new System.Drawing.Point(608, 244);
            this.picPear.Name = "picPear";
            this.picPear.Size = new System.Drawing.Size(24, 35);
            this.picPear.TabIndex = 16;
            this.picPear.TabStop = false;
            // 
            // picApple1
            // 
            this.picApple1.BackColor = System.Drawing.Color.Transparent;
            this.picApple1.Image = ((System.Drawing.Image)(resources.GetObject("picApple1.Image")));
            this.picApple1.Location = new System.Drawing.Point(412, 275);
            this.picApple1.Name = "picApple1";
            this.picApple1.Size = new System.Drawing.Size(30, 32);
            this.picApple1.TabIndex = 17;
            this.picApple1.TabStop = false;
            this.picApple1.Visible = false;
            // 
            // picApple2
            // 
            this.picApple2.BackColor = System.Drawing.Color.Transparent;
            this.picApple2.Image = ((System.Drawing.Image)(resources.GetObject("picApple2.Image")));
            this.picApple2.Location = new System.Drawing.Point(438, 275);
            this.picApple2.Name = "picApple2";
            this.picApple2.Size = new System.Drawing.Size(30, 32);
            this.picApple2.TabIndex = 18;
            this.picApple2.TabStop = false;
            this.picApple2.Visible = false;
            // 
            // picApple3
            // 
            this.picApple3.BackColor = System.Drawing.Color.Transparent;
            this.picApple3.Image = ((System.Drawing.Image)(resources.GetObject("picApple3.Image")));
            this.picApple3.Location = new System.Drawing.Point(465, 275);
            this.picApple3.Name = "picApple3";
            this.picApple3.Size = new System.Drawing.Size(30, 32);
            this.picApple3.TabIndex = 19;
            this.picApple3.TabStop = false;
            this.picApple3.Visible = false;
            // 
            // picApple4
            // 
            this.picApple4.BackColor = System.Drawing.Color.Transparent;
            this.picApple4.Image = ((System.Drawing.Image)(resources.GetObject("picApple4.Image")));
            this.picApple4.Location = new System.Drawing.Point(488, 275);
            this.picApple4.Name = "picApple4";
            this.picApple4.Size = new System.Drawing.Size(30, 32);
            this.picApple4.TabIndex = 20;
            this.picApple4.TabStop = false;
            this.picApple4.Visible = false;
            // 
            // picPear1
            // 
            this.picPear1.BackColor = System.Drawing.Color.Transparent;
            this.picPear1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPear1.Image = ((System.Drawing.Image)(resources.GetObject("picPear1.Image")));
            this.picPear1.Location = new System.Drawing.Point(418, 275);
            this.picPear1.Name = "picPear1";
            this.picPear1.Size = new System.Drawing.Size(24, 35);
            this.picPear1.TabIndex = 21;
            this.picPear1.TabStop = false;
            this.picPear1.Visible = false;
            // 
            // picPear2
            // 
            this.picPear2.BackColor = System.Drawing.Color.Transparent;
            this.picPear2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPear2.Image = ((System.Drawing.Image)(resources.GetObject("picPear2.Image")));
            this.picPear2.Location = new System.Drawing.Point(444, 275);
            this.picPear2.Name = "picPear2";
            this.picPear2.Size = new System.Drawing.Size(24, 35);
            this.picPear2.TabIndex = 22;
            this.picPear2.TabStop = false;
            this.picPear2.Visible = false;
            // 
            // picPear3
            // 
            this.picPear3.BackColor = System.Drawing.Color.Transparent;
            this.picPear3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPear3.Image = ((System.Drawing.Image)(resources.GetObject("picPear3.Image")));
            this.picPear3.Location = new System.Drawing.Point(465, 275);
            this.picPear3.Name = "picPear3";
            this.picPear3.Size = new System.Drawing.Size(24, 35);
            this.picPear3.TabIndex = 23;
            this.picPear3.TabStop = false;
            this.picPear3.Visible = false;
            // 
            // picPear4
            // 
            this.picPear4.BackColor = System.Drawing.Color.Transparent;
            this.picPear4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPear4.Image = ((System.Drawing.Image)(resources.GetObject("picPear4.Image")));
            this.picPear4.Location = new System.Drawing.Point(494, 275);
            this.picPear4.Name = "picPear4";
            this.picPear4.Size = new System.Drawing.Size(24, 35);
            this.picPear4.TabIndex = 24;
            this.picPear4.TabStop = false;
            this.picPear4.Visible = false;
            // 
            // picAppleBro1
            // 
            this.picAppleBro1.BackColor = System.Drawing.Color.Transparent;
            this.picAppleBro1.Image = ((System.Drawing.Image)(resources.GetObject("picAppleBro1.Image")));
            this.picAppleBro1.Location = new System.Drawing.Point(348, 437);
            this.picAppleBro1.Name = "picAppleBro1";
            this.picAppleBro1.Size = new System.Drawing.Size(30, 32);
            this.picAppleBro1.TabIndex = 25;
            this.picAppleBro1.TabStop = false;
            this.picAppleBro1.Visible = false;
            // 
            // picAppleBro2
            // 
            this.picAppleBro2.BackColor = System.Drawing.Color.Transparent;
            this.picAppleBro2.Image = ((System.Drawing.Image)(resources.GetObject("picAppleBro2.Image")));
            this.picAppleBro2.Location = new System.Drawing.Point(267, 371);
            this.picAppleBro2.Name = "picAppleBro2";
            this.picAppleBro2.Size = new System.Drawing.Size(30, 32);
            this.picAppleBro2.TabIndex = 26;
            this.picAppleBro2.TabStop = false;
            this.picAppleBro2.Visible = false;
            // 
            // picPearSis2
            // 
            this.picPearSis2.BackColor = System.Drawing.Color.Transparent;
            this.picPearSis2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPearSis2.Image = ((System.Drawing.Image)(resources.GetObject("picPearSis2.Image")));
            this.picPearSis2.Location = new System.Drawing.Point(621, 371);
            this.picPearSis2.Name = "picPearSis2";
            this.picPearSis2.Size = new System.Drawing.Size(24, 35);
            this.picPearSis2.TabIndex = 27;
            this.picPearSis2.TabStop = false;
            this.picPearSis2.Visible = false;
            // 
            // picPearSis1
            // 
            this.picPearSis1.BackColor = System.Drawing.Color.Transparent;
            this.picPearSis1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPearSis1.Image = ((System.Drawing.Image)(resources.GetObject("picPearSis1.Image")));
            this.picPearSis1.Location = new System.Drawing.Point(544, 434);
            this.picPearSis1.Name = "picPearSis1";
            this.picPearSis1.Size = new System.Drawing.Size(24, 35);
            this.picPearSis1.TabIndex = 28;
            this.picPearSis1.TabStop = false;
            this.picPearSis1.Visible = false;
            // 
            // btnThread
            // 
            this.btnThread.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThread.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThread.Location = new System.Drawing.Point(840, 578);
            this.btnThread.Name = "btnThread";
            this.btnThread.Size = new System.Drawing.Size(91, 50);
            this.btnThread.TabIndex = 29;
            this.btnThread.Text = "切换手动/并发";
            this.btnThread.UseVisualStyleBackColor = false;
            this.btnThread.Click += new System.EventHandler(this.btnThread_Click);
            // 
            // tmrThread
            // 
            this.tmrThread.Interval = 500;
            this.tmrThread.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1225, 640);
            this.Controls.Add(this.btnThread);
            this.Controls.Add(this.picPearSis1);
            this.Controls.Add(this.picPearSis2);
            this.Controls.Add(this.picAppleBro2);
            this.Controls.Add(this.picAppleBro1);
            this.Controls.Add(this.picPlate);
            this.Controls.Add(this.picPear4);
            this.Controls.Add(this.picPear3);
            this.Controls.Add(this.picPear2);
            this.Controls.Add(this.picPear1);
            this.Controls.Add(this.picApple1);
            this.Controls.Add(this.picApple2);
            this.Controls.Add(this.picApple);
            this.Controls.Add(this.picFather);
            this.Controls.Add(this.picPear);
            this.Controls.Add(this.picSister2);
            this.Controls.Add(this.picMother);
            this.Controls.Add(this.picSister1);
            this.Controls.Add(this.picBrother1);
            this.Controls.Add(this.btnCleanDisk);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBrother1);
            this.Controls.Add(this.btnBrother2);
            this.Controls.Add(this.btnSister2);
            this.Controls.Add(this.btnSister1);
            this.Controls.Add(this.btnMother);
            this.Controls.Add(this.btnFather);
            this.Controls.Add(this.picApple3);
            this.Controls.Add(this.picApple4);
            this.Controls.Add(this.picBrother2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "吃水果小程序 v0.2";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBrother1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBrother2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSister1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMother)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSister2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApple1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApple2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApple3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApple4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPear1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPear2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPear3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPear4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAppleBro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAppleBro2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPearSis2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPearSis1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrFather;
        private System.Windows.Forms.Timer tmrMother;
        private System.Windows.Forms.Button btnFather;
        private System.Windows.Forms.Button btnMother;
        private System.Windows.Forms.Button btnSister1;
        private System.Windows.Forms.Button btnSister2;
        private System.Windows.Forms.Button btnBrother2;
        private System.Windows.Forms.Button btnBrother1;
        private System.Windows.Forms.Timer tmrSister1;
        private System.Windows.Forms.Timer tmrSister2;
        private System.Windows.Forms.Timer tmrBrother1;
        private System.Windows.Forms.Timer tmrBrother2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCleanDisk;
        private System.Windows.Forms.PictureBox picBrother1;
        private System.Windows.Forms.PictureBox picBrother2;
        private System.Windows.Forms.PictureBox picSister1;
        private System.Windows.Forms.PictureBox picFather;
        private System.Windows.Forms.PictureBox picMother;
        private System.Windows.Forms.PictureBox picSister2;
        private System.Windows.Forms.PictureBox picApple;
        private System.Windows.Forms.PictureBox picPlate;
        private System.Windows.Forms.PictureBox picPear;
        private System.Windows.Forms.PictureBox picApple1;
        private System.Windows.Forms.PictureBox picApple2;
        private System.Windows.Forms.PictureBox picApple3;
        private System.Windows.Forms.PictureBox picApple4;
        private System.Windows.Forms.PictureBox picPear1;
        private System.Windows.Forms.PictureBox picPear2;
        private System.Windows.Forms.PictureBox picPear3;
        private System.Windows.Forms.PictureBox picPear4;
        private System.Windows.Forms.PictureBox picAppleBro1;
        private System.Windows.Forms.PictureBox picAppleBro2;
        private System.Windows.Forms.PictureBox picPearSis2;
        private System.Windows.Forms.PictureBox picPearSis1;
        private System.Windows.Forms.Button btnThread;
        private System.Windows.Forms.Timer tmrThread;
    }
}