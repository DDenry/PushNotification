using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PushNotification
{
    public partial class Form1 : Form
    {
        private string path;
        protected int count;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //应用启动
            Console.Beep();
        }

        private void FileDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Link;
            else e.Effect = DragDropEffects.None;
        }

        private void FileDragDrop(object sender, DragEventArgs e)
        {
            string[] filePath = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in filePath)
            {
                FileInfo _file = new FileInfo(file);
                //file就是单个文件路径
                if (_file.Name.Equals("Notification.txt"))
                {
                    path = _file.FullName;
                    //
                    GetNotificationList();
                    groupBox.Visible = false;
                }
                else Console.WriteLine(_file.Name);
            }
        }

        private void GetNotificationList()
        {
            //
            content.Text = "";
            StreamReader streamReader = new StreamReader(path);
            String line = "";
            while (!String.IsNullOrEmpty(line = streamReader.ReadLine()))
            {
                if (!String.IsNullOrEmpty(content.Text)) content.Text += "\n";
                content.Text += line;
            }
            streamReader.Close();
            streamReader.Dispose();
        }

        private void NotificationLIstChanged(object sender, EventArgs e)
        {
            //
            count = content.Text.Split('\n').Length;
            NotificationCount.Text = "Total Message:" + count;
        }

        private void PublishNotification(object sender, EventArgs e)
        {
            String message = "";
            switch (NotificationType.SelectedIndex)
            {
                case 0:
                    if (!String.IsNullOrEmpty(AudioMessage.Text.Trim()))
                    {
                        message = count + 1 + "[0,<>," + DateTime.Now + ",]" + AudioMessage.Text.Trim();
                    }
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
            //
            if (!String.IsNullOrEmpty(message))
            {
                StreamWriter streamWriter = new StreamWriter(path, true, Encoding.UTF8);
                streamWriter.Write(message + "\r\n");
                streamWriter.Close();
                streamWriter.Dispose();
                //
                GetNotificationList();

                //发布成功
                AudioMessage.Text = "";
                Log.Text = "已成功发布一条消息!";
            }
        }
    }
}
