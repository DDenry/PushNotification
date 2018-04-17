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
                if (_file.Name.Equals("Notification.txt")) {
                    path = _file.FullName;
                    groupBox.Visible = false;
                }
                else Console.WriteLine(_file.Name);
            }
        }
    }
}
