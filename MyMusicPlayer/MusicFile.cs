using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMusicPlayer
{
    //音乐文件，属性:文件名，文件路径,文件大小
    class MusicFile
    {
        public MusicFile(string name, string path, long size)
        {
            this.Name = name;
            this.Path = path;
            this.Size = size;
        }
        public string Name
        {
            set;
            get;
        }
        public string Path
        {
            set;
            get;
        }
        /*public string Singer
        {
            set;
            get;
        }*/
        public long Size
        {
            set;
            get;
        }
    }
}
