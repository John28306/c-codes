using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileMoverApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Student\Downloads\";

            //To create the new subfolder.
            string imageFolder = @"C:\Users\Student\Downloads\Image\";
            Directory.CreateDirectory(imageFolder);
            string[] moves = Directory.GetFiles(path, "*.jpg");

            //string newpath = @"C:\Users\Student\Downloads\Image";
            //bool imageExists = Directory.Exists(newpath);

            // 1....to move from downloads to image folder in downloads.
            foreach (string move in moves)
            {
                //var info = new FileInfo(move);
                //Console.WriteLine(info.Length);
                if (move.Length != 0)
                {
                    Console.WriteLine("Moving Files");
                    //To check if image file exist in folder
                    try
                    {
                        File.Move(move, $"{imageFolder}{ Path.GetFileName(move)}");
                    }
                    // 3......to catch exception.
                    catch (Exception err)
                    {
                        Console.WriteLine("File name already exist in folder");
                    }
                }
                else
                {
                   
                    Console.WriteLine("hello world");
                }



            }
           

         







            Console.ReadLine();

        }
    }
}

