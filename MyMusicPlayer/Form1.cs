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

namespace MyMusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] picFiles;//图片存放路径
        int index = 0;
        List<MusicFile> musicFiles;//音乐列表

        private void timer1_Tick(object sender, EventArgs e)
        {
            //循环替换图片
            if (index >= picFiles.Count())
            {
                index = 0;
            }
            pictureBox1.Image = Image.FromFile(picFiles[index]);
            index++;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            picFiles = Directory.GetFiles("images");          
            musicFiles = MusicFileService.Instance().GetAllFiles();
            for (int i = 0; i < musicFiles.Count; i++)
            {
               listMusic.Items.Add(musicFiles[i].Name);
            }
            //默认选中第一首歌,设置初始音量
            try
            {
                listMusic.SelectedIndex = 0;
                wmPlayer.settings.volume = this.tkbVolume.Value;
            }
            catch
            {

            }
                //wmPlayer.URL = musicFiles[listMusic.SelectedIndex].Path;
                
        

        }   
        
        private void listMusic_DoubleClick(object sender, EventArgs e)
        {
            //获取当前选中的歌曲
             musicFiles = MusicFileService.Instance().GetAllFiles();
             MusicFile seleMusic=musicFiles.Find(x=>x.Name.Equals(listMusic.SelectedItem.ToString()));
             wmPlayer.URL = seleMusic.Path;
             wmPlayer.Ctlcontrols.play();
           
            playMusic();

        }

        private void playMusic()
        {
            this.playSong.BackgroundImage = Properties.Resources.暂停;
            toolStripStatusLabel1.Text = "正在播放歌曲:\t" + wmPlayer.currentMedia.name;
            this.tkbSongProgress.Value = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = MessageBox.Show("是否直接退出系统?(选否，最小化到托盘)", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                this.Dispose();

            }else
            {
                //取消关闭窗口
                e.Cancel = true;
                //最小化主窗口
                this.WindowState = FormWindowState.Minimized;
                //不在系统任务栏显示主窗口图标
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                //提示气泡
                notifyIcon1.ShowBalloonTip(2000, "最小化到托盘", "程序已经缩小到托盘，单击打开程序。", ToolTipIcon.Info);
            }

        }

        /*
         双击托盘图标还原窗口
             */
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                //还原窗体显示    
                WindowState = FormWindowState.Normal;
                //激活窗体并给予它焦点
                this.Activate();
                //任务栏区显示图标
                this.ShowInTaskbar = true;
                //托盘区图标隐藏
                notifyIcon1.Visible = false;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //判断是否选择的是最小化按钮
            if(WindowState==FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
        }
        //右击托盘显示菜单
        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author:Ningzhicheng\nVersion:1.0.0\nClass:1707","关于");
       
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void addMusicPic_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog df = new FolderBrowserDialog();//选择一个文件夹
            df.ShowDialog();
            string selectPath = df.SelectedPath;
            if ("" == selectPath)
            {
                return;
            }
            DirectoryInfo dInfo = new DirectoryInfo(selectPath);
            foreach (FileInfo f in dInfo.GetFiles("*.*"))
            {
                //获取多种指定的音乐文件格式
                if(f.Name.ToLower().EndsWith(".mp3")|| f.Name.ToLower().EndsWith(".flac"))
                {
                    MusicFileService.Instance().AddFile(new MusicFile(f.Name, f.FullName, f.Length));
                    listMusic.Items.Add(f.Name);
                }
                
            }
            MusicFileService.Instance().Save();
        }

        /*
         设置鼠标进出图标时图标背景色的变化
             */
        private void addMusicPic_MouseEnter(object sender, EventArgs e)
        {
            this.addMusicPic.BackColor = Color.Blue;
        }

        private void addMusicPic_MouseLeave(object sender, EventArgs e)
        {
            this.addMusicPic.BackColor = SystemColors.Control;
        }

        private void nextSong_MouseEnter(object sender, EventArgs e)
        {
            this.nextSong.BackColor = Color.Blue;
        }

        private void nextSong_MouseLeave(object sender, EventArgs e)
        {
            this.nextSong.BackColor = SystemColors.Control;
        }

        private void preSong_MouseEnter(object sender, EventArgs e)
        {
            this.preSong.BackColor = Color.Blue;
        }

        private void preSong_MouseLeave(object sender, EventArgs e)
        {
            this.preSong.BackColor = SystemColors.Control;
        }

        private void playSong_MouseEnter(object sender, EventArgs e)
        {
            this.playSong.BackColor = Color.Blue;
        }

        private void playSong_MouseLeave(object sender, EventArgs e)
        {
            this.playSong.BackColor = SystemColors.Control;
        }

        private void playSong_Click(object sender, EventArgs e)
        {
            
            if (wmPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                wmPlayer.Ctlcontrols.pause();
                this.playSong.BackgroundImage = Properties.Resources.播放;
            }
            else if(wmPlayer.playState==WMPLib.WMPPlayState.wmppsPaused)
            {
                wmPlayer.Ctlcontrols.play();
                this.playSong.BackgroundImage = Properties.Resources.暂停;
            }
        }

        private void nextSong_Click(object sender, EventArgs e)
        {
            //播放下一曲
            int index = listMusic.SelectedIndex;
            index++;
            if (index == musicFiles.Count())
            {
                index = 0;
            }
            listMusic.SelectedIndex = index;
            wmPlayer.URL = musicFiles[index].Path;
            wmPlayer.Ctlcontrols.play();
            playMusic();

        }

        private void preSong_Click(object sender, EventArgs e)
        {
            //播放上一首
            int index = listMusic.SelectedIndex;
            index--;
            if(index<0)
            {
                index = musicFiles.Count() - 1;
            }
            listMusic.SelectedIndex = index;
            wmPlayer.URL = musicFiles[listMusic.SelectedIndex].Path;
            wmPlayer.Ctlcontrols.play();
            playMusic();


        }

      private void wmPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            //自动播放下一首
            if(wmPlayer.playState==WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                int index = listMusic.SelectedIndex;
                if (index == musicFiles.Count() - 1)
                {
                    index = 0;
                }
                else
                {
                    index++;
                }
                listMusic.SelectedIndex = index;
                wmPlayer.URL = musicFiles[index].Path;
                playMusic();

            }
            if (wmPlayer.playState==WMPLib.WMPPlayState.wmppsReady)
            {
                try
                {
                    
                    wmPlayer.Ctlcontrols.play();
                }
                catch
                {

                }
            }

        }
        //音量条
        private void tkbVolume_MouseLeave(object sender, EventArgs e)
        {
            lbVolumeVal.Text = "音量:";

        }

        private void tkbVolume_MouseHover(object sender, EventArgs e)
        {
            lbVolumeVal.Text = tkbVolume.Value.ToString()+"%";

        }

        private void tkbVolume_ValueChanged(object sender, EventArgs e)
        {
            wmPlayer.settings.volume = tkbVolume.Value;
            lbVolumeVal.Text = tkbVolume.Value.ToString() + "%";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (wmPlayer.currentMedia != null&&!wmPlayer.Ctlcontrols.currentPositionString.Equals(""))
            {
                string currPlayTime = null;
                currPlayTime = wmPlayer.Ctlcontrols.currentPositionString;//当前进度，字符串格式。如“00:23”
                tbTimeProgress.Text = currPlayTime + "/" + wmPlayer.currentMedia.durationString;
                this.tkbSongProgress.Value = (int)(wmPlayer.Ctlcontrols.currentPosition * 100 / wmPlayer.currentMedia.duration);

              
            }
            
        
            //this.tkbSongProgress.Value = (int)(wmPlayer.Ctlcontrols.currentPosition * 100 /wmPlayer.currentMedia.duration);

        }

        //实现拖动进度条来控制音乐播放进度
        private void tkbSongProgress_Scroll(object sender, EventArgs e)
        {
            if (wmPlayer.currentMedia != null)
            {
                wmPlayer.Ctlcontrols.currentPosition = (double)this.tkbSongProgress.Value * 0.01 * wmPlayer.currentMedia.duration;
                if (wmPlayer.Ctlcontrols.currentPosition == wmPlayer.currentMedia.duration)
                { 
                  this.tkbSongProgress.Value = 0;
                 }

            }
           
        }

      
    }
}
