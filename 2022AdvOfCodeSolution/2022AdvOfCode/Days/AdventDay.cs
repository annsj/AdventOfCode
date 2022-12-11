using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022AdvOfCode.Days
{
    public class AdventDay
    {
        public string InputFile { get; set; }
        public List<string> FileContent { get; set; }

        public AdventDay(string inputFile)
        {
            InputFile= inputFile;
            FileContent = ReadFile();
        }

        public List<string> ReadFile()
        {
            List<string> fileContent = System.IO.File.ReadAllLines(InputFile).ToList();
            return fileContent;
        }
    }
}
