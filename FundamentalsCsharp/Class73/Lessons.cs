using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCsharp.Class73
{
    internal class Lessons
    {
        public static void FileAndFileInfo()
        {
            var path = @"c:\somefile.jpg"; ;
            File.Copy(@"c:\tempo\myfile.jpg", @"d:\tempo\myfile.jpg", true);

            File.Delete(path);

            if(File.Exists(path)) 
            {
                //
            }

            var content = File.ReadAllText(path);

            //FileInfo need to be instantiated before we can use them
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();

            if(fileInfo.Exists)
            {
                //
            }
        }
    }
}
