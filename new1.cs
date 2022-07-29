using System;
class new1
{
    static public void Main(string[] args)
    {
        byte[] B= {2,4,6,8,10};
        Console.WriteLine("BArray is :{0}",BitConverter.ToString(B));
        Console.WriteLine();
        string str = Convert.ToBase64String(B);
        Console.WriteLine("Base 64 String is :{0}",str);
    }
}