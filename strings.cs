using System;
using System.Text;
namespace StringOperations
{
    class Strings
    {
        static void Main(string[] args)
        {
            string s1 = "My name is ";
            string s2 = "Shivtej";

            StringBuilder sbstring1 =new StringBuilder(" Hello ", 50);
            StringBuilder sbstring2 = new StringBuilder(" World ", 50);
            
            Console.WriteLine("Concatinating two strings ");
            StringOperations.StringConcat.concat(s1,s2);

            Console.WriteLine("Appending two strings using string Builder");
            StringOperations.StringAppend.sbappend(sbstring1,sbstring2);
            
            
        }
    }
    class StringConcat
    {
        public static void concat(string s1,string s2)
        {
            string concatstring = "";
            concatstring = s1+s2;
            Console.WriteLine("The strings after using concat : " + concatstring+"\n");
        }
    }

    class StringAppend
    {
        public static void sbappend(StringBuilder sb1,StringBuilder sb2)
        {
            StringBuilder sbstring = new StringBuilder("",50);
            sbstring.Append(sb1);
            sbstring.Append(sb2);
            Console.WriteLine("The string after appending is : {0} \n",sbstring.ToString());
        }
    }
    
}

