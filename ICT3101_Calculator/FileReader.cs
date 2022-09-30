using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Text;

namespace ICT3101_Calculator
{
    public class FileReader: IFileReader
    {
        public string[] Read(string path)
        {
            Console.WriteLine(new DirectoryInfo("."));
            return File.ReadAllLines("../../../../"+path);
        }
    }
}