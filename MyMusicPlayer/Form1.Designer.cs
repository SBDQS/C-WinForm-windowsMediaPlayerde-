namespace MyMusicPlayer
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listMusic = new System.Windows.Forms.ListBox();
            this.musicList = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preSong = new System.Windows.Forms.PictureBox();
            this.nextSong = new System.Windows.Forms.PictureBox();
            this.playSong = new System.Windows.Forms.PictureBox();
            this.addMusicPic = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tkbVolume = new System.Windows.Forms.TrackBar();
            this.lbVolumeVal = new System.Windows.Forms.Label();
            this.tkbSongProgress = new System.Windows.Forms.TrackBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tbTimeProgress = new System.Windows.Forms.TextBox();
            this.wmPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMusicPic)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSongProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 395);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listMusic
            // 
            this.listMusic.FormattingEnabled = true;
            this.listMusic.ItemHeight = 15;
            this.listMusic.Location = new System.Drawing.Point(659, 42);
            this.listMusic.Name = "listMusic";
            this.listMusic.Size = new System.Drawing.Size(361, 394);
            this.listMusic.TabIndex = 3;
            this.listMusic.DoubleClick += new System.EventHandler(this.listMusic_DoubleClick);
            // 
            // musicList
            // 
            this.musicList.AutoSize = true;
            this.musicList.Location = new System.Drawing.Point(809, 9);
            this.musicList.Name = "musicList";
            this.musicList.Size = new System.Drawing.Size(67, 15);
            this.musicList.TabIndex = 5;
            this.musicList.Text = "歌曲列表";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "千千静听";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示ToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 76);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.显示ToolStripMenuItem.Text = "显示";
            this.显示ToolStripMenuItem.Click += new System.EventHandler(this.显示ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // preSong
            // 
            this.preSong.BackgroundImage = global::MyMusicPlayer.Properties.Resources.上一首;
            this.preSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.preSong.Location = new System.Drawing.Point(28, 505);
            this.preSong.Name = "preSong";
            this.preSong.Size = new System.Drawing.Size(50, 50);
            this.preSong.TabIndex = 6;
            this.preSong.TabStop = false;
            this.preSong.Click += new System.EventHandler(this.preSong_Click);
            this.preSong.MouseEnter += new System.EventHandler(this.preSong_MouseEnter);
            this.preSong.MouseLeave += new System.EventHandler(this.preSong_MouseLeave);
            // 
            // nextSong
            // 
            this.nextSong.BackgroundImage = global::MyMusicPlayer.Properties.Resources.下一首;
            this.nextSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextSong.Location = new System.Drawing.Point(252, 505);
            this.nextSong.Name = "nextSong";
            this.nextSong.Size = new System.Drawing.Size(50, 50);
            this.nextSong.TabIndex = 6;
            this.nextSong.TabStop = false;
            this.nextSong.Click += new System.EventHandler(this.nextSong_Click);
            this.nextSong.MouseEnter += new System.EventHandler(this.nextSong_MouseEnter);
            this.nextSong.MouseLeave += new System.EventHandler(this.nextSong_MouseLeave);
            // 
            // playSong
            // 
            this.playSong.BackColor = System.Drawing.SystemColors.Control;
            this.playSong.BackgroundImage = global::MyMusicPlayer.Properties.Resources.播放;
            this.playSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playSong.InitialImage = null;
            this.playSong.Location = new System.Drawing.Point(137, 505);
            this.playSong.Name = "playSong";
            this.playSong.Size = new System.Drawing.Size(50, 50);
            this.playSong.TabIndex = 6;
            this.playSong.TabStop = false;
            this.playSong.Click += new System.EventHandler(this.playSong_Click);
            this.playSong.MouseEnter += new System.EventHandler(this.playSong_MouseEnter);
            this.playSong.MouseLeave += new System.EventHandler(this.playSong_MouseLeave);
            // 
            // addMusicPic
            // 
            this.addMusicPic.BackColor = System.Drawing.SystemColors.Control;
            this.addMusicPic.BackgroundImage = global::MyMusicPlayer.Properties.Resources.添加音乐;
            this.addMusicPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addMusicPic.Location = new System.Drawing.Point(774, 451);
            this.addMusicPic.Name = "addMusicPic";
            this.addMusicPic.Size = new System.Drawing.Size(50, 50);
            this.addMusicPic.TabIndex = 7;
            this.addMusicPic.TabStop = false;
            this.addMusicPic.Click += new System.EventHandler(this.addMusicPic_Click);
            this.addMusicPic.MouseEnter += new System.EventHandler(this.addMusicPic_MouseEnter);
            this.addMusicPic.MouseLeave += new System.EventHandler(this.addMusicPic_MouseLeave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 569);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1033, 25);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "状态栏";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 20);
            this.toolStripStatusLabel1.Text = "就绪";
            // 
            // tkbVolume
            // 
            this.tkbVolume.Location = new System.Drawing.Point(376, 505);
            this.tkbVolume.Maximum = 100;
            this.tkbVolume.Name = "tkbVolume";
            this.tkbVolume.Size = new System.Drawing.Size(171, 56);
            this.tkbVolume.TabIndex = 9;
            this.tkbVolume.Value = 20;
            this.tkbVolume.ValueChanged += new System.EventHandler(this.tkbVolume_ValueChanged);
            this.tkbVolume.MouseLeave += new System.EventHandler(this.tkbVolume_MouseLeave);
            this.tkbVolume.MouseHover += new System.EventHandler(this.tkbVolume_MouseHover);
            // 
            // lbVolumeVal
            // 
            this.lbVolumeVal.AutoSize = true;
            this.lbVolumeVal.Location = new System.Drawing.Point(325, 519);
            this.lbVolumeVal.Name = "lbVolumeVal";
            this.lbVolumeVal.Size = new System.Drawing.Size(45, 15);
            this.lbVolumeVal.TabIndex = 10;
            this.lbVolumeVal.Text = "音量:";
            // 
            // tkbSongProgress
            // 
            this.tkbSongProgress.Location = new System.Drawing.Point(18, 451);
            this.tkbSongProgress.Maximum = 100;
            this.tkbSongProgress.Name = "tkbSongProgress";
            this.tkbSongProgress.Size = new System.Drawing.Size(483, 56);
            this.tkbSongProgress.TabIndex = 11;
            this.tkbSongProgress.Scroll += new System.EventHandler(this.tkbSongProgress_Scroll);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tbTimeProgress
            // 
            this.tbTimeProgress.Location = new System.Drawing.Point(507, 451);
            this.tbTimeProgress.Name = "tbTimeProgress";
            this.tbTimeProgress.ReadOnly = true;
            this.tbTimeProgress.Size = new System.Drawing.Size(100, 25);
            this.tbTimeProgress.TabIndex = 12;
            this.tbTimeProgress.Text = "00:00/00:00";
            // 
            // wmPlayer
            // 
            this.wmPlayer.Enabled = true;
            this.wmPlayer.Location = new System.Drawing.Point(624, 519);
            this.wmPlayer.Name = "wmPlayer";
            this.wmPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmPlayer.OcxState")));
            this.wmPlayer.Size = new System.Drawing.Size(0, 0);
            this.wmPlayer.TabIndex = 0;
            this.wmPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.wmPlayer_PlayStateChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1033, 594);
            this.Controls.Add(this.tbTimeProgress);
            this.Controls.Add(this.tkbSongProgress);
            this.Controls.Add(this.lbVolumeVal);
            this.Controls.Add(this.tkbVolume);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.addMusicPic);
            this.Controls.Add(this.playSong);
            this.Controls.Add(this.nextSong);
            this.Controls.Add(this.preSong);
            this.Controls.Add(this.musicList);
            this.Controls.Add(this.wmPlayer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listMusic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "千千静听";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.preSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMusicPic)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSongProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmPlayer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listMusic;
        private System.Windows.Forms.Label musicList;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.PictureBox preSong;
        private System.Windows.Forms.PictureBox nextSong;
        private System.Windows.Forms.PictureBox playSong;
        private System.Windows.Forms.PictureBox addMusicPic;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TrackBar tkbVolume;
        private System.Windows.Forms.Label lbVolumeVal;
        private System.Windows.Forms.TrackBar tkbSongProgress;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox tbTimeProgress;
    }
}

