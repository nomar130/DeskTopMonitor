using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace DeskTopMonitor
{
    public partial class Form1 : Form
    {

        //添付画像ファイルパス配列
        string[] imgPaths;
        //送信メール
        MailMessage mm;
        //添付ファイル配列
        Attachment[] img;
        //状態
        bool isRunning = false;
        //配信時刻
        int HH1, HH2, HH3, mm1, mm2, mm3, mm00;
        //設定ファイル
        string setting = "setting.ini";
        //前回終了時刻
        DateTime lastExitTime;

        public Form1()
        {
            InitializeComponent();

            //イベント
            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
            this.Load += new EventHandler(Form1_Load);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            checkBox1.Enter += (s, e) => txt_mm00.Show();
            checkBox1.LostFocus += new EventHandler(checkBox1_LostFocus);
            txt_mm00.Leave += new EventHandler(txt_mm00_Leave);
            txt_mm00.VisibleChanged += new EventHandler(txt_mm00_VisibleChanged);
            txt_mm00.MouseClick += (s, e) => txt_mm00.SelectAll();
            txt_mm00.KeyDown += new KeyEventHandler(txt_mm00_KeyDown);
            listBox1.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);
            listBox2.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);
            btnDo.Click += new EventHandler(btnDo_Click);
            btnUndo.Click += new EventHandler(btnUndo_Click);

            //最初は隠す
            txt_mm00.Hide();

            //モニターリストを初期化
            for (int i = 0; i < Screen.AllScreens.Length; i++)
            {
                listBox1.Items.Add("モニター" + i.ToString());
            }

            //タイマーのインターバルを1分に設定
            timer1.Interval = 60000;

            if (File.Exists(setting))
            {
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Settings));
                using (FileStream fs = new FileStream(setting, FileMode.Open))
                {
                    Settings cfg = serializer.Deserialize(fs) as Settings;
                    //設定ファイル読み込み
                    txtID.Text = cfg.ID;
                    txtPassword.Text = cfg.Password;
                    txtMailTo.Text = cfg.MailTo;
                    txt_HH1.Text = cfg.HH1.ToString();
                    txt_HH2.Text = cfg.HH2.ToString();
                    txt_HH3.Text = cfg.HH3.ToString();
                    txt_mm1.Text = cfg.mm1.ToString("00");
                    txt_mm2.Text = cfg.mm2.ToString("00");
                    txt_mm3.Text = cfg.mm3.ToString("00");
                    checkBox1.Checked = cfg.RunPerHour;
                    lastExitTime = cfg.LastExitTime;
                }
            }
        }

        void btnUndo_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;
            if (item == null) return;
            listBox2.Items.Add(item);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        void btnDo_Click(object sender, EventArgs e)
        {
            var item = listBox2.SelectedItem;
            if (item == null) return;
            listBox1.Items.Add(item);
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }

        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;
            if (lb.SelectedItem == null) return;
            int i;
            bool b = int.TryParse(lb.SelectedItem.ToString().Substring(4), out i);
            //if (!b) MessageBox.Show("error");
            Screen scrn = Screen.AllScreens[i];
            Bitmap bmp = new Bitmap(scrn.Bounds.Width, scrn.Bounds.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(scrn.Bounds.Location, new Point(0, 0), bmp.Size);
            }
            if (MakeImgRotate.Checked)
            {
                bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            splitContainer1.Panel2.BackgroundImage = bmp;
        }

        void txt_mm00_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                ProcessTabKey(true);
            }
        }

        void txt_mm00_VisibleChanged(object sender, EventArgs e)
        {
            if (txt_mm00.Visible) return;

            checkBox1.Text = string.Format("終日配信する（mm = {0}）", txt_mm00.Text);
        }

        void txt_mm00_Leave(object sender, EventArgs e)
        {
            txt_mm00.Hide();
        }

        void checkBox1_LostFocus(object sender, EventArgs e)
        {
            if (!txt_mm00.Focused)
            {
                txt_mm00.Hide();
            }
        }

        void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_HH1.Enabled = !checkBox1.Checked;
            txt_HH2.Enabled = !checkBox1.Checked;
            txt_HH3.Enabled = !checkBox1.Checked;
            txt_mm1.Enabled = !checkBox1.Checked;
            txt_mm2.Enabled = !checkBox1.Checked;
            txt_mm3.Enabled = !checkBox1.Checked;

            rad_per15min.Enabled = checkBox1.Checked;
            rad_per1h.Enabled = checkBox1.Checked;
            rad_per2h0.Enabled = checkBox1.Checked;
            rad_per2h1.Enabled = checkBox1.Checked;
            rad_per30min.Enabled = checkBox1.Checked;
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Settings));
            using (FileStream fs = new FileStream(setting, FileMode.Create))
            {
                Settings cfg = new Settings();
                //入力項目の保存
                cfg.ID = txtID.Text;
                cfg.Password = txtPassword.Text;
                cfg.MailTo = txtMailTo.Text;
                cfg.HH1 = int.Parse(txt_HH1.Text);
                cfg.HH2 = int.Parse(txt_HH2.Text);
                cfg.HH3 = int.Parse(txt_HH3.Text);
                cfg.mm1 = int.Parse(txt_mm1.Text);
                cfg.mm2 = int.Parse(txt_mm2.Text);
                cfg.mm3 = int.Parse(txt_mm3.Text);
                cfg.RunPerHour = checkBox1.Checked;
                cfg.LastExitTime = DateTime.Now;

                serializer.Serialize(fs, cfg);
            }
        }

        void Form1_Load(object sender, EventArgs e)
        {
            string str = "DeskTopMonitor起動";
            checkBox1_CheckedChanged(null, null);
            if (!File.Exists(setting))
            {
                writeLog(str);
                return;
            }
            str += "(前回は" + lastExitTime.ToString("yyyy/MM/dd HH:mm:ss") + "に正常終了しました)";
            writeLog(str);
            //送信者
            string from = txtID.Text;
            //宛先
            string to = txtMailTo.Text;
            //件名
            string subject = "DeskTopMonitor起動";
            //本文
            string body = txtLog.Text;
            //パスワード
            string pass = txtPassword.Text;
            //SMTPクライアント
            SmtpClient client = new SmtpClient();
            //gmail用設定
            client.Host = "smtp.gmail.com";
            //client.Port = 465;
            client.Port = 587;
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(from, pass);
            try
            {
                client.Send(new MailMessage(from, to, subject, body));
                writeLog("起動時メール送信成功");
            }
            catch (SmtpException)
            {
                writeLog("起動時メール送信失敗");
            }
        }

        void SendMail()
        {
            try
            {
                //送信者
                string from = txtID.Text;
                //宛先
                string to = txtMailTo.Text;
                //件名
                string subject = "デスクトップキャプチャ画像配信";
                //本文
                string body = "\"" + Environment.MachineName + "\"上における" + DateTime.Now.ToString("yyyy/MM/dd HH:mm") + "の画像配信です。";
                //パスワード
                string pass = txtPassword.Text;
                //SMTPクライアント
                SmtpClient client = new SmtpClient();
                //gmail用設定
                client.Host = "smtp.gmail.com";
                //client.Port = 465;
                client.Port = 587;
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from, pass);

                client.SendCompleted += new SendCompletedEventHandler(client_SendCompleted);

                //送信メール
                mm = new MailMessage(from, to, subject, body);
                //添付ファイルを追加
                for (int i = 0; i < imgPaths.Length; i++)
                {
                    img[i] = new Attachment(imgPaths[i]);
                    mm.Attachments.Add(this.img[i]);
                }

                //メール送信
                client.SendAsync(mm, null);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("入力項目が不正です");
            }
            catch (Exception ex)
            {
                writeLog("キャプチャ画像の送信失敗　　　　エラー内容：\r\n\r\n" + ex.ToString());
            }
        }

        void client_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string log = "";

            if (e.Error != null)
            {
                //MessageBox.Show(e.Error.Message);
                log = "キャプチャ画像の送信失敗　　　　エラー内容：　　　" + e.Error.Message;
            }
            else
            {
                log = "キャプチャ画像の送信成功";
            }

            //クリーンアップ
            foreach (var item in this.img)
            {
                item.Dispose();
            }
            mm.Dispose();

            //終了処理
            if (!isRunning)
            {
                button2.Enabled = true;
            }

            //ログを追加
            writeLog(log);
        }

        void PrintScreen()
        {
            //初期化
            imgPaths = new string[listBox1.Items.Count];
            img = new Attachment[listBox1.Items.Count];

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                //該当モニター
                int scrnID;
                bool b = int.TryParse(listBox1.Items[i].ToString().Substring(4), out scrnID);
                //if (!b) MessageBox.Show("error");
                Screen scrn = Screen.AllScreens[scrnID];
                //Bitmapの作成
                using (Bitmap bmp = new Bitmap(scrn.Bounds.Width, scrn.Bounds.Height))
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    //画像ファイルパス
                    string imgPath = "image" + i.ToString("00") + ".jpg";
                    //画面全体をキャプチャする
                    this.Hide();
                    System.Threading.Thread.Sleep(3000);
                    g.CopyFromScreen(scrn.Bounds.Location, new Point(0, 0), bmp.Size);
                    this.Show();
                    //画像のクリーンアップ
                    System.IO.File.Delete(imgPath);
                    System.Threading.Thread.Sleep(5000);
                    if (MakeImgRotate.Checked)
                    {
                        //画像を90度回転する
                        bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    //jpgで保存
                    bmp.Save(imgPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    System.Threading.Thread.Sleep(5000);
                    //画像ファイルパスの登録
                    this.imgPaths[i] = imgPath;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!isRunning) return;
            DateTime now = DateTime.Now;

            try
            {
                if (checkBox1.Checked)
                {
                    bool b1 = rad_per1h.Checked && now.Minute == mm00;
                    bool b2 = rad_per2h0.Checked && now.Minute == mm00 && now.Hour % 2 == 0;
                    bool b3 = rad_per2h1.Checked && now.Minute == mm00 && now.Hour % 2 == 1;
                    bool b4 = rad_per15min.Checked && now.Minute % 15 == 0;
                    bool b5 = rad_per30min.Checked && now.Minute % 30 == 0;

                    if (b1 | b2 | b3 | b4 | b5)
                    {
                        PrintScreen();
                        SendMail();
                    }
                }
                else
                {
                    bool b1 = now.Hour == HH1 && now.Minute == mm1;
                    bool b2 = now.Hour == HH2 && now.Minute == mm2;
                    bool b3 = now.Hour == HH3 && now.Minute == mm3;

                    if (b1 | b2 | b3)
                    {
                        PrintScreen();
                        SendMail();
                    }
                }
            }
            catch (Exception ex)
            {
                writeLog(ex.ToString());
                return;
            }
        }

        void writeLog(string log)
        {
            string str = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "    " + log + "\r\n";
            txtLog.AppendText(str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string log = "";

            if (isRunning)
            {
                button1.Text = "開始";
                this.Text = "DeskTopMonitor";

                log = "デスクトップ監視サービスを停止しました";
            }
            else
            {
                button1.Text = "停止";
                this.Text = "DeskTopMonitor (実行中)";

                //設定値の反映
                int.TryParse(txt_HH1.Text, out HH1);
                int.TryParse(txt_HH2.Text, out HH2);
                int.TryParse(txt_HH3.Text, out HH3);
                int.TryParse(txt_mm1.Text, out mm1);
                int.TryParse(txt_mm2.Text, out mm2);
                int.TryParse(txt_mm3.Text, out mm3);
                int.TryParse(txt_mm00.Text, out mm00);

                log = "デスクトップ監視サービスを開始しました";
            }

            //トグル
            txtID.Enabled = isRunning;
            txtPassword.Enabled = isRunning;
            txtMailTo.Enabled = isRunning;
            txt_HH1.Enabled = isRunning & !checkBox1.Checked;
            txt_HH2.Enabled = isRunning & !checkBox1.Checked;
            txt_HH3.Enabled = isRunning & !checkBox1.Checked;
            txt_mm1.Enabled = isRunning & !checkBox1.Checked;
            txt_mm2.Enabled = isRunning & !checkBox1.Checked;
            txt_mm3.Enabled = isRunning & !checkBox1.Checked;
            rad_per15min.Enabled = isRunning & checkBox1.Checked;
            rad_per1h.Enabled = isRunning & checkBox1.Checked;
            rad_per2h0.Enabled = isRunning & checkBox1.Checked;
            rad_per2h1.Enabled = isRunning & checkBox1.Checked;
            rad_per30min.Enabled = isRunning & checkBox1.Checked;
            button2.Enabled = isRunning;
            checkBox1.Enabled = isRunning;
            isRunning = !isRunning;

            //ログを追加
            writeLog(log);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            PrintScreen();
            SendMail();
        }
    }
}
