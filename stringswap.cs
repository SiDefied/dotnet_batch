using System;

namespace StringOp
{
    class stringswap
    {
        static void Main(string[] args)
        {
            string s1 = "Shivtej";
            string s2 = "Deshmukh";
           
            Console.WriteLine("String S2 before swap = "+s2);
            Console.WriteLine("String S1 before swap = "+s1);

            
            s1=s1+s2;            
            

            s2 = s1.Substring(0,(s1.Length-s2.Length));
            Console.WriteLine("String S2 after swap = "+s2);

            s1 = s1.Substring(s2.Length);
            Console.WriteLine("String S1 after swap = "+s1);
            
        }
    }
    
}