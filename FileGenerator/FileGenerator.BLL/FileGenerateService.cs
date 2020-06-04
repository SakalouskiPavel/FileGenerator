using System;
using System.IO;
using System.Net;
using FileGenerator.BLL.Properties;

namespace FileGenerator.BLL
{
    public class FileGenerateService
    {
        private const string defaultNamePrefix = "TestFile";

        private const int charSize = 3;

        private const int defaultFileSizeKB = 150;

        private const int kiloByteSize = 1024;

        public void GenerateFiles()
        {
            for (int i = 0; i < 400; i++)
            {
                string path = @"D:\testFolder\" + defaultNamePrefix + i + ".txt";
                using (StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.OpenOrCreate)))
                {
                    for (int j = 0; j < (defaultFileSizeKB * kiloByteSize) / charSize; j++)
                    {
                        sw.WriteLine(Resources.defaultFileContent);
                    }
                }
            }
        }
    }
}