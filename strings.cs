using System;
using System.Text;
namespace StringBuilders
{
    class Strings
    {
        static void Main(string[] args)
        {
            StringBuilder string1 =new StringBuilder(" Hello ", 50);
            StringBuilder string2 = new StringBuilder(" World ", 50);
            string1.Append(string2);
            Console.WriteLine("The string after appending is {0}",string1.ToString());

        }
    }
    
}