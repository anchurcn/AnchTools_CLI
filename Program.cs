using System;
using System.IO;

namespace AnchTools_CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileEnumerator=new FileEnumerator();
            fileEnumerator.ShowEachDiskInfo();
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
