using System;
using System.IO;
using System.Net;

namespace AnchTools_CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            //var fileEnumerator=new FileEnumerator();
            //fileEnumerator.ShowEachDiskInfo();
            WebClient webClient = new WebClient();
            var msg=webClient.DownloadString("https://www.baidu.com");
            if (string.IsNullOrEmpty(msg))
            {
                Console.WriteLine("nothing here");
            }
            else
            {
                Console.WriteLine(msg);
            }
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
    }
    class FileEnumerator
    {
        public void ShowEachDiskInfo()
        {
            var infos = DriveInfo.GetDrives();
            foreach (var i in infos)
            {
                Console.WriteLine(i.VolumeLabel+" "+i.Name);
                Console.WriteLine(i.TotalFreeSpace/1024/1024/1024+"Gb/");
                Console.WriteLine(i.TotalSize/1024/1024/1024);
                Console.WriteLine(i.DriveFormat);
                Console.WriteLine(i.DriveType);
                Console.WriteLine(i.IsReady);
                Console.WriteLine("-------------------------------------------------------------------------");
            }
        }
    } 
}
