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
            this.button1 = new System.Windows.Forms.Button();
            this.Notification = new System.Windows.Forms.TabPage();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.NotificationType.SuspendLayout();
            this.Notification.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotificationType
            // 
            this.NotificationType.Controls.Add(this.Notification);
            this.NotificationType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotificationType.Location = new System.Drawing.Point(0, 69);
            this.NotificationType.Name = "NotificationType";
            this.NotificationType.SelectedIndex = 0;
            this.NotificationType.Size = new System.Drawing.Size(769, 123);
            this.NotificationType.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(769, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "发布";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Notification
            // 
            this.Notification.Controls.Add(this.richTextBox1);
            this.Notification.Location = new System.Drawing.Point(4, 22);
            this.Notification.Name = "Notification";
            this.Notification.Size = new System.Drawing.Size(761, 97);
            this.Notification.TabIndex = 0;
            this.Notification.Text = "Notification";
            this.Notification.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(769, 69);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Essential";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(232, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please drag file here";
            this.label1.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileDragDrop);
            this.label1.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileDragEnter);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.richTextBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.richTextBox1.Location = new System.Drawing.Point(236, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(525, 97);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.toolTip.SetToolTip(this.richTextBox1, "请输入消息内容");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(769, 215);
            this.Controls.Add(this.NotificationType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotificationPusher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NotificationType.ResumeLayout(false);
            this.Notification.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl NotificationType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage Notification;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

