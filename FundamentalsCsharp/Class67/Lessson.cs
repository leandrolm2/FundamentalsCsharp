using FundamentalsCsharp.Class31;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCsharp.Class67
{
    internal class Lessson
    {
        public static void WorkingWithStringBuilder()
        {
            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.Append('-', 10);
            builder.AppendLine();

            //you can use encadiate functions
            builder.Append('-', 10)
            .AppendLine()
            .Append("Header")
            .Append('-', 10)
            .AppendLine()
            .Replace('-', '+');

            builder.Remove(0, 10);

            builder.Insert(0, new string('-', 10));

            Console.WriteLine(builder);
        }
    }
}
