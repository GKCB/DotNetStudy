using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _08事件的本质
{
    public delegate void DelTest(string ss);
    class Program
    {
        static void Main(string[] args)
        {
            PlayMusic p = new PlayMusic("忐忑");
            //注册要执行的事件 ，按两下tab就可以插入
            p.DelPlayOver +=new EventHandler(p_DelPlayOver);
            p.PlaySongs();
            Console.ReadKey();
        }

        static void p_DelPlayOver(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            DelTest del = (s) => { }; //委托指向一个函数
            del("张三");//委托调用这个函数
            PlayMusic p = sender as PlayMusic; //由PlayMusic这个类来触发
            Console.WriteLine(p.Name+"播放完了");
        }
    }

    class PlayMusic
    {
        public event EventHandler DelPlayOver; //注册事件
        public string Name { get; set; }
        public PlayMusic(string name)
        {
            this.Name = name;
        }
        public void PlaySongs()
        {
            Console.WriteLine("正在播放 {0}",this.Name);
            Thread.Sleep(3000);
            //播放完成后 应该执行一个事件 告诉用户播放完成了

            if (DelPlayOver != null)
            {
                EventArgs e = new EventArgs();
                DelPlayOver(this,e); //触发事件的对象
            }
        }
    }
}
