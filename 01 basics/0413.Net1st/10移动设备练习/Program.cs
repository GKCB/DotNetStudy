using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10移动设备练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Telphone tel = new Telphone();
            MobileDisk mob = new MobileDisk();
            UDisk usb = new UDisk();

            Computer comp = new Computer();
            comp.MS = tel;
            comp.CpuRead();
            comp.CpuWrite();
            Console.WriteLine("-----------------------");

            comp.MS = mob;
            comp.CpuRead();
            comp.CpuWrite();
            Console.WriteLine("-----------------------");

            comp.MS = usb;
            comp.CpuRead();
            comp.CpuWrite();

        }
    }

    abstract class MobileStorage
    {
        public abstract void Read();
        public abstract void Write();
    }

    class Telphone : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("手机在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("手机在写入数据");
        }
    }
    class MobileDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("移动硬盘在写入数据");
        }
    }


    class UDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("U盘在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("U盘在写入数据");
        }
    }

    class MP3 : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("Mp3在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("Mp3在写入数据");
        }

        public void PlayMusic()
        {
            Console.WriteLine("Mp3可以自己播放音乐");
        }
    }

    class Computer
    {
        //没有明显的继承关系
        //父类的自动属性
        public MobileStorage MS
        {
            get;
            set;
        }

        //电脑通过插入的移动设备来读写
        public void CpuRead()
        {
            //单独的子类其实都不合适，最佳结果是用父类
            //MobileStorage ms 这属于传参的方式
            this.MS.Read();
        }

        public void CpuWrite()
        {
            //单独的子类其实都不合适，最佳结果是用父类
            this.MS.Write();
        }

    }


}
