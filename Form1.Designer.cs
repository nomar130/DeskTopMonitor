namespace DeskTopMonitor
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MakeImgRotate = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rad_per30min = new System.Windows.Forms.RadioButton();
            this.rad_per15min = new System.Windows.Forms.RadioButton();
            this.rad_per2h1 = new System.Windows.Forms.RadioButton();
            this.rad_per2h0 = new System.Windows.Forms.RadioButton();
            this.rad_per1h = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_mm3 = new System.Windows.Forms.TextBox();
            this.txt_mm2 = new System.Windows.Forms.TextBox();
            this.txt_mm00 = new System.Windows.Forms.TextBox();
            this.txt_mm1 = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtMailTo = new System.Windows.Forms.TextBox();
            this.txt_HH3 = new System.Windows.Forms.TextBox();
            this.txt_HH2 = new System.Windows.Forms.TextBox();
            this.txt_HH1 = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.txtLog);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(496, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ログ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 3);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(490, 336);
            this.txtLog.TabIndex = 0;
            this.txtLog.WordWrap = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 21);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(496, 342);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "キャプチャ設定";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MakeImgRotate);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.listBox2);
            this.splitContainer1.Panel1.Controls.Add(this.btnUndo);
            this.splitContainer1.Panel1.Controls.Add(this.btnDo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.WindowText;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splitContainer1.Size = new System.Drawing.Size(496, 342);
            this.splitContainer1.SplitterDistance = 165;
            this.splitContainer1.TabIndex = 5;
            // 
            // MakeImgRotate
            // 
            this.MakeImgRotate.AutoSize = true;
            this.MakeImgRotate.Location = new System.Drawing.Point(8, 14);
            this.MakeImgRotate.Name = "MakeImgRotate";
            this.MakeImgRotate.Size = new System.Drawing.Size(132, 16);
            this.MakeImgRotate.TabIndex = 2;
            this.MakeImgRotate.Text = "画像を90度回転させる";
            this.MakeImgRotate.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "配信しない";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(8, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(132, 100);
            this.listBox1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "配信する";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(8, 233);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(132, 100);
            this.listBox2.TabIndex = 1;
            // 
            // btnUndo
            // 
            this.btnUndo.AutoSize = true;
            this.btnUndo.Location = new System.Drawing.Point(31, 180);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(27, 23);
            this.btnUndo.TabIndex = 3;
            this.btnUndo.Text = "↓";
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnDo
            // 
            this.btnDo.AutoSize = true;
            this.btnDo.Location = new System.Drawing.Point(84, 180);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(27, 23);
            this.btnDo.TabIndex = 3;
            this.btnDo.Text = "↑";
            this.btnDo.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.rad_per30min);
            this.tabPage2.Controls.Add(this.rad_per15min);
            this.tabPage2.Controls.Add(this.rad_per2h1);
            this.tabPage2.Controls.Add(this.rad_per2h0);
            this.tabPage2.Controls.Add(this.rad_per1h);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txt_mm3);
            this.tabPage2.Controls.Add(this.txt_mm2);
            this.tabPage2.Controls.Add(this.txt_mm00);
            this.tabPage2.Controls.Add(this.txt_mm1);
            this.tabPage2.Controls.Add(this.txtPassword);
            this.tabPage2.Controls.Add(this.txtMailTo);
            this.tabPage2.Controls.Add(this.txt_HH3);
            this.tabPage2.Controls.Add(this.txt_HH2);
            this.tabPage2.Controls.Add(this.txt_HH1);
            this.tabPage2.Controls.Add(this.txtID);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(496, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "配信設定";
            // 
            // rad_per30min
            // 
            this.rad_per30min.AutoSize = true;
            this.rad_per30min.Location = new System.Drawing.Point(126, 284);
            this.rad_per30min.Name = "rad_per30min";
            this.rad_per30min.Size = new System.Drawing.Size(160, 16);
            this.rad_per30min.TabIndex = 54;
            this.rad_per30min.Text = "30分おきに配信する（00, 30）";
            this.rad_per30min.UseVisualStyleBackColor = true;
            // 
            // rad_per15min
            // 
            this.rad_per15min.AutoSize = true;
            this.rad_per15min.Location = new System.Drawing.Point(126, 264);
            this.rad_per15min.Name = "rad_per15min";
            this.rad_per15min.Size = new System.Drawing.Size(196, 16);
            this.rad_per15min.TabIndex = 53;
            this.rad_per15min.Text = "15分おきに配信する（00, 15, 30, 45）";
            this.rad_per15min.UseVisualStyleBackColor = true;
            // 
            // rad_per2h1
            // 
            this.rad_per2h1.AutoSize = true;
            this.rad_per2h1.Location = new System.Drawing.Point(126, 244);
            this.rad_per2h1.Name = "rad_per2h1";
            this.rad_per2h1.Size = new System.Drawing.Size(184, 16);
            this.rad_per2h1.TabIndex = 52;
            this.rad_per2h1.Text = "2時間おき（奇数：mm）に配信する";
            this.rad_per2h1.UseVisualStyleBackColor = true;
            // 
            // rad_per2h0
            // 
            this.rad_per2h0.AutoSize = true;
            this.rad_per2h0.Location = new System.Drawing.Point(126, 224);
            this.rad_per2h0.Name = "rad_per2h0";
            this.rad_per2h0.Size = new System.Drawing.Size(184, 16);
            this.rad_per2h0.TabIndex = 51;
            this.rad_per2h0.Text = "2時間おき（偶数：mm）に配信する";
            this.rad_per2h0.UseVisualStyleBackColor = true;
            // 
            // rad_per1h
            // 
            this.rad_per1h.AutoSize = true;
            this.rad_per1h.Checked = true;
            this.rad_per1h.Location = new System.Drawing.Point(126, 204);
            this.rad_per1h.Name = "rad_per1h";
            this.rad_per1h.Size = new System.Drawing.Size(129, 16);
            this.rad_per1h.TabIndex = 50;
            this.rad_per1h.TabStop = true;
            this.rad_per1h.Text = "毎時mm分に配信する";
            this.rad_per1h.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 47;
            this.label7.Text = "：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 46;
            this.label8.Text = "：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 45;
            this.label9.Text = "：";
            // 
            // txt_mm3
            // 
            this.txt_mm3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_mm3.Location = new System.Drawing.Point(62, 285);
            this.txt_mm3.MaxLength = 2;
            this.txt_mm3.Name = "txt_mm3";
            this.txt_mm3.Size = new System.Drawing.Size(18, 19);
            this.txt_mm3.TabIndex = 32;
            this.txt_mm3.Text = "00";
            // 
            // txt_mm2
            // 
            this.txt_mm2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_mm2.Location = new System.Drawing.Point(62, 238);
            this.txt_mm2.MaxLength = 2;
            this.txt_mm2.Name = "txt_mm2";
            this.txt_mm2.Size = new System.Drawing.Size(18, 19);
            this.txt_mm2.TabIndex = 28;
            this.txt_mm2.Text = "00";
            // 
            // txt_mm00
            // 
            this.txt_mm00.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_mm00.Location = new System.Drawing.Point(246, 178);
            this.txt_mm00.MaxLength = 2;
            this.txt_mm00.Name = "txt_mm00";
            this.txt_mm00.Size = new System.Drawing.Size(18, 19);
            this.txt_mm00.TabIndex = 26;
            this.txt_mm00.Text = "00";
            // 
            // txt_mm1
            // 
            this.txt_mm1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_mm1.Location = new System.Drawing.Point(62, 191);
            this.txt_mm1.MaxLength = 2;
            this.txt_mm1.Name = "txt_mm1";
            this.txt_mm1.Size = new System.Drawing.Size(18, 19);
            this.txt_mm1.TabIndex = 26;
            this.txt_mm1.Text = "00";
            // 
            // txtPassword
            // 
            this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtPassword.Location = new System.Drawing.Point(16, 80);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(349, 19);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.Text = "aaaaaaaa";
            // 
            // txtMailTo
            // 
            this.txtMailTo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtMailTo.Location = new System.Drawing.Point(16, 127);
            this.txtMailTo.Name = "txtMailTo";
            this.txtMailTo.Size = new System.Drawing.Size(349, 19);
            this.txtMailTo.TabIndex = 20;
            this.txtMailTo.Text = "nomar130@yahoo.co.jp";
            // 
            // txt_HH3
            // 
            this.txt_HH3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_HH3.Location = new System.Drawing.Point(32, 285);
            this.txt_HH3.MaxLength = 2;
            this.txt_HH3.Name = "txt_HH3";
            this.txt_HH3.Size = new System.Drawing.Size(18, 19);
            this.txt_HH3.TabIndex = 31;
            this.txt_HH3.Text = "20";
            // 
            // txt_HH2
            // 
            this.txt_HH2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_HH2.Location = new System.Drawing.Point(32, 238);
            this.txt_HH2.MaxLength = 2;
            this.txt_HH2.Name = "txt_HH2";
            this.txt_HH2.Size = new System.Drawing.Size(18, 19);
            this.txt_HH2.TabIndex = 27;
            this.txt_HH2.Text = "15";
            // 
            // txt_HH1
            // 
            this.txt_HH1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_HH1.Location = new System.Drawing.Point(32, 191);
            this.txt_HH1.MaxLength = 2;
            this.txt_HH1.Name = "txt_HH1";
            this.txt_HH1.Size = new System.Drawing.Size(18, 19);
            this.txt_HH1.TabIndex = 25;
            this.txt_HH1.Text = "12";
            // 
            // txtID
            // 
            this.txtID.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtID.Location = new System.Drawing.Point(16, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(349, 19);
            this.txtID.TabIndex = 15;
            this.txtID.Text = "xxx@gmail.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 12);
            this.label6.TabIndex = 41;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 12);
            this.label5.TabIndex = 39;
            this.label5.Text = "To";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(326, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "テスト";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 37;
            this.label4.Text = "配信時刻3";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(407, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "開始";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "配信時刻2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "配信時刻1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "From (gmail ID)";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(126, 180);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(147, 16);
            this.checkBox1.TabIndex = 48;
            this.checkBox1.Text = "終日配信する（mm = 00）";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(504, 367);
            this.tabControl1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 367);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "DeskTopMonitor";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_mm3;
        private System.Windows.Forms.TextBox txt_mm2;
        private System.Windows.Forms.TextBox txt_mm1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtMailTo;
        private System.Windows.Forms.TextBox txt_HH3;
        private System.Windows.Forms.TextBox txt_HH2;
        private System.Windows.Forms.TextBox txt_HH1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.RadioButton rad_per2h1;
        private System.Windows.Forms.RadioButton rad_per2h0;
        private System.Windows.Forms.RadioButton rad_per1h;
        private System.Windows.Forms.TextBox txt_mm00;
        private System.Windows.Forms.RadioButton rad_per30min;
        private System.Windows.Forms.RadioButton rad_per15min;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.CheckBox MakeImgRotate;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

