using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileGenerator.BLL;

namespace FileGenerator.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new FileGenerateService();
            service.GenerateFiles();

            System.Console.ReadKey();
        }
    }
}
