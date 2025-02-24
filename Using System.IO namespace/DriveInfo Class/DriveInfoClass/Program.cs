using System;
using System.IO;


namespace DriveInfoClass
{
    internal class Program
    {
        static void Main()
        {
            DriveInfo driveInfo = new DriveInfo("D:");

            Console.WriteLine("the name of the drive = " + driveInfo.Name);
            Console.WriteLine("the type of the drive = " + driveInfo.DriveType);
            Console.WriteLine("the volume label of the drive = " + driveInfo.VolumeLabel);
            Console.WriteLine("the total size of the drive in GB = " + driveInfo.TotalSize / 1024 / 1024 / 1024);
            Console.WriteLine("the available free space of the drive in GB = " + driveInfo.AvailableFreeSpace / 1024 / 1024 / 1024);
            Console.WriteLine("the format of the drive = " + driveInfo.DriveFormat);

            Console.ReadKey();
        }
    }
}
