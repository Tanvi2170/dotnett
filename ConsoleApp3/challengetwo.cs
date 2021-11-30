using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class challengetwo
    {
        public static void showoutput()
        {
            string name = "Bob";
            int messages = 3;
            decimal temperature = 34.4m;

            Console.Write("Hello,");
            Console.WriteLine(name);
            Console.Write("You have ");
            Console.Write(messages);
            Console.WriteLine(" in your inbox. ");
            Console.Write("The temperature is ");
            Console.Write(temperature);
            Console.WriteLine(" celsius.");
        }
    }
}
