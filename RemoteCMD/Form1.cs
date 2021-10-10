using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RemoteCMD {
    public partial class Form1 : Form {
        private Encoding Enc
        {
            get
            {
                return Encoding.GetEncoding("SHIFT_JIS");
            }
        }
        private List<byte> targetIP = new List<byte>();
        private List<TextBox> textboxIP = new List<TextBox>();
        private string targetHostName = null;
        private string tagetUserName = null;
        private string targetPassword = null;
        private string accessTarget = null;
        public Form1() {
            InitializeComponent();
            targetIP.Add(0);
            targetIP.Add(0);
            targetIP.Add(0);
            targetIP.Add(0);
            textboxIP.Add(textBoxIPML);
            textboxIP.Add(textBoxIPL);
            textboxIP.Add(textBoxIPR);
            textboxIP.Add(textBoxIPMR);
        }

        private void button1_Click(object sender, EventArgs e) {
            //入力処理
            byte ans;
            if (textBoxIPMR.Enabled) {
                foreach (var i in Enumerable.Range(0, textboxIP.Count)) {
                    if (byte.TryParse(textboxIP[i].Text, out ans)) {
                        targetIP[i] = ans;
                    }
                    else if(textboxIP[i].Text == ""){
                        MessageBox.Show("please input IP or HostName");
                        return;
                    }
                    else {
                        Console.WriteLine("INPUT ERROR : IP NOT EXISTS");
                        MessageBox.Show("please input 0~255");
                        return;
                    }
                }
                accessTarget = targetIP[0].ToString() + "."+targetIP[1].ToString() + "." + targetIP[2].ToString() + "." + targetIP[3].ToString();
            }
            if (textBoxTargetHost.Enabled) {
                if (targetHostName=="") {
                    MessageBox.Show("please input hostname");
                    return;
                }
                targetHostName = textBoxTargetHost.Text;
                accessTarget = targetHostName;
            }
            tagetUserName = textBoxUserName.Text;
            if (tagetUserName=="") {
                MessageBox.Show("please input username");
                return;
            }
            targetPassword = textBoxPassword.Text;
            if (targetPassword=="") {
                MessageBox.Show("please input password");
                return;
            }
            //入力拒否
            buttonMake.Enabled = false;

            //デスクトップを探す
            string desktopDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            //一時ファイルを作成する
            string tmpPath = Path.GetTempFileName();
            //一時ファイルを書き込みで開く
            StreamWriter sw = new StreamWriter(tmpPath, false, Enc);
            //内容を一行ずつ読み込む
            sw.Write(@"@psexec -u " + accessTarget + @"\" + tagetUserName + @" -p " + targetPassword + @" \\" + accessTarget + @" cmd");
            //閉じる
            sw.Close();
            //一時ファイルと入れ替える
            File.Copy(tmpPath, desktopDirectoryPath + @"\" + accessTarget + ".cmd", true);
            File.Delete(tmpPath);
            MessageBox.Show("Make this file on Desktop\n<" + accessTarget + ".cmd>");
            //入力許可
            buttonMake.Enabled = true;
        }

        private void HostNameChanged(object sender, EventArgs e) {
            bool canUseIP;
            if (textBoxTargetHost.Text == "") {
                canUseIP = true;
            }
            else {
                canUseIP = false;
            }
            foreach (var i in Enumerable.Range(0, textboxIP.Count)) {
                textboxIP[i].Enabled = canUseIP;
            }
        }
        private void ChangedIP(object sender, EventArgs e) {
            bool canUseHostName=true;
            if (textboxIP[0].Text != "" & textboxIP[1].Text != "" & textboxIP[2].Text != "" & textboxIP[3].Text != "") {
                canUseHostName = false;
            }
            textBoxTargetHost.Enabled = canUseHostName;
        }
        private void TextBoxEnterKey(object sender, KeyEventArgs e) {
          if (e.KeyData==Keys.Enter) {
                buttonMake.PerformClick();
            }
        }
    }
}
