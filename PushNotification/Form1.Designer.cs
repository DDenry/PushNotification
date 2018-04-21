namespace PushNotification
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NotificationType = new System.Windows.Forms.TabControl();
            this.Audio = new System.Windows.Forms.TabPage();
            this.AudioMessage = new System.Windows.Forms.TextBox();
            this.Alert = new System.Windows.Forms.TabPage();
            this.Activity = new System.Windows.Forms.TabPage();
            this.WebView = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.content = new System.Windows.Forms.RichTextBox();
            this.NotificationCount = new System.Windows.Forms.TextBox();
            this.Log = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NotificationType.SuspendLayout();
            this.Audio.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotificationType
            // 
            this.NotificationType.Controls.Add(this.Audio);
            this.NotificationType.Controls.Add(this.Alert);
            this.NotificationType.Controls.Add(this.Activity);
            this.NotificationType.Controls.Add(this.WebView);
            this.NotificationType.Dock = System.Windows.Forms.DockStyle.Left;
            this.NotificationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NotificationType.ItemSize = new System.Drawing.Size(120, 25);
            this.NotificationType.Location = new System.Drawing.Point(0, 75);
            this.NotificationType.Multiline = true;
            this.NotificationType.Name = "NotificationType";
            this.NotificationType.SelectedIndex = 0;
            this.NotificationType.Size = new System.Drawing.Size(350, 156);
            this.NotificationType.TabIndex = 0;
            // 
            // Audio
            // 
            this.Audio.Controls.Add(this.AudioMessage);
            this.Audio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Audio.Location = new System.Drawing.Point(4, 29);
            this.Audio.Name = "Audio";
            this.Audio.Size = new System.Drawing.Size(342, 123);
            this.Audio.TabIndex = 0;
            this.Audio.Text = "Audio";
            this.Audio.UseVisualStyleBackColor = true;
            // 
            // AudioMessage
            // 
            this.AudioMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AudioMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AudioMessage.Location = new System.Drawing.Point(0, 100);
            this.AudioMessage.Name = "AudioMessage";
            this.AudioMessage.Size = new System.Drawing.Size(342, 23);
            this.AudioMessage.TabIndex = 0;
            this.toolTip.SetToolTip(this.AudioMessage, "Enter notification message here");
            // 
            // Alert
            // 
            this.Alert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Alert.Location = new System.Drawing.Point(4, 29);
            this.Alert.Name = "Alert";
            this.Alert.Size = new System.Drawing.Size(342, 123);
            this.Alert.TabIndex = 4;
            this.Alert.Text = "Alert";
            this.Alert.UseVisualStyleBackColor = true;
            // 
            // Activity
            // 
            this.Activity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Activity.Location = new System.Drawing.Point(4, 29);
            this.Activity.Name = "Activity";
            this.Activity.Size = new System.Drawing.Size(342, 123);
            this.Activity.TabIndex = 3;
            this.Activity.Text = "Activity";
            this.Activity.UseVisualStyleBackColor = true;
            // 
            // WebView
            // 
            this.WebView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WebView.Location = new System.Drawing.Point(4, 29);
            this.WebView.Name = "WebView";
            this.WebView.Size = new System.Drawing.Size(342, 123);
            this.WebView.TabIndex = 1;
            this.WebView.Text = "WebView";
            this.WebView.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "发布(&P)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PublishNotification);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(1184, 75);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Essential";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("SimSun", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1178, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please drag file (Server\'s asset) here";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileDragDrop);
            this.label1.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileDragEnter);
            // 
            // content
            // 
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.content.Location = new System.Drawing.Point(350, 105);
            this.content.Name = "content";
            this.content.ReadOnly = true;
            this.content.Size = new System.Drawing.Size(834, 126);
            this.content.TabIndex = 1;
            this.content.Text = "";
            this.content.TextChanged += new System.EventHandler(this.NotificationLIstChanged);
            this.content.DoubleClick += new System.EventHandler(this.content_DoubleClick);
            // 
            // NotificationCount
            // 
            this.NotificationCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.NotificationCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NotificationCount.ForeColor = System.Drawing.Color.BlueViolet;
            this.NotificationCount.Location = new System.Drawing.Point(350, 75);
            this.NotificationCount.Name = "NotificationCount";
            this.NotificationCount.ReadOnly = true;
            this.NotificationCount.Size = new System.Drawing.Size(834, 30);
            this.NotificationCount.TabIndex = 2;
            // 
            // Log
            // 
            this.Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Log.ForeColor = System.Drawing.Color.DarkRed;
            this.Log.Location = new System.Drawing.Point(350, 0);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(834, 30);
            this.Log.TabIndex = 3;
            this.Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Log);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 30);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 261);
            this.Controls.Add(this.content);
            this.Controls.Add(this.NotificationCount);
            this.Controls.Add(this.NotificationType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotificationPusher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NotificationType.ResumeLayout(false);
            this.Audio.ResumeLayout(false);
            this.Audio.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl NotificationType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage Audio;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabPage WebView;
        private System.Windows.Forms.TabPage Alert;
        private System.Windows.Forms.TabPage Activity;
        private System.Windows.Forms.RichTextBox content;
        private System.Windows.Forms.TextBox AudioMessage;
        private System.Windows.Forms.TextBox NotificationCount;
        private System.Windows.Forms.Label Log;
        private System.Windows.Forms.Panel panel1;
    }
}

