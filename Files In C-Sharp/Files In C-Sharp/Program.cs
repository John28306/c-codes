using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files_In_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rootpath = @"C:\Users\Downloads\";

            //string[] dirs = Directory.GetDirectories(rootpath, "*", SearchOption.AllDirectories);
            //foreach (string dir in dirs)
            //{
            //    Console.WriteLine(dir);
            //}
            var files = Directory.GetFiles(rootpath, "*", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                Console.WriteLine(file);
                Console.WriteLine(Path.GetFileName(file));
                Console.WriteLine(Path.GetFileNameWithoutExtension(file));
                Console.WriteLine(Path.GetFullPath(file));
                Console.WriteLine(Path.GetDirectoryName(file));

                //to get infomation about the file
                var info = new FileInfo(file);
                Console.WriteLine(info.Length);
                Console.WriteLine($"{Path.GetFileName(file)}:{info.Length} bytes");

                //to check if a directory exist
                string newpath = @"E:\Temp\Demos\FileSystem\SubFolderC";
                bool directoryExists = Directory.Exists(newpath);

                if (directoryExists)
                {
                    Console.WriteLine("The directory exists");
                }
                else
                {
                    Console.WriteLine("the directory does not exist");
                    //to create new directory
                    Directory.CreateDirectory(newpath);
                }
                //to copy and paste file with same name
                string[] files1 = Directory.GetFiles(rootpath);
                string destinationFolder = @"E:\Temp\Demo\FileSystem\SubFolderA/";
                foreach (string filee in files1)
                {
                    File.Copy(filee, $"{destinationFolder}{Path.GetFileName(file)}", true);

                }
                //to copy and paste file with different name
                for (int i = 0; i < file.Length; i++)
                {
                    File.Copy(files[i], $"{destinationFolder}{i}.txt", true);
                    //to copy and paste without overwriting current file
                    File.Copy(files[i], $"{destinationFolder}{i}.txt", false);
                }

                //to move files
                foreach (string filee in files1)
                {
                    File.Move(filee, $"{destinationFolder}{Path.GetFileName(filee)}");

                }


                Console.ReadLine();



            }
        }
    }
}
