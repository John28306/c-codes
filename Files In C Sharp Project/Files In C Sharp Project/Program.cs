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
            string[] moves = Directory.GetFiles(path, "*.jpg");

            //To create the new subfolder.
            string imageFolder = @"C:\Users\Student\Downloads\Image\";
            Directory.CreateDirectory(imageFolder);

            // 1....to move from downloads to image folder in downloads.
                if (moves.Length == 0)
                {
                    Console.WriteLine("No image exist in this folder");
                }
                else
                {
                      foreach (string move in moves)
                      {
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
                }
            Console.ReadLine();
        }
    }
}

