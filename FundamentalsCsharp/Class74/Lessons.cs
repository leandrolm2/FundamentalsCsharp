using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCsharp.Class74
{
    internal class Lessons
    {
        public static void DirectoryAndDirectoryInfo()
        {
            Directory.CreateDirectory(@"c:\temp\folder1");

            var files = Directory.GetFiles(@"c:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories("c:\projects\CShaopFundamentals", "*.*", SearchOption.AllDirectories);

            foreach(var directory in directories)
            {
                Console.WriteLine( directory);
            }
        }
    }
}
