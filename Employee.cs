//4 employees with name and address
using System;


namespace Employee
{
    class EmpDetails
    {
        static void Main(string[] args)
        {
            string[] empname = {"John","Alex","Simon","Charlie"};
            string[] empaddress = {"Seattle","Long Island","Washington","Berlin"};

            Employee.EmpData.PrintData(empname,empaddress);

        }
    }

    class EmpData
    {
        public static void PrintData(string[] empname,string[] empaddress)
        {
            Console.WriteLine("The Employee data is as follows\n");

            for (int i=0; i<empname.Length; i++)
            {
                Console.WriteLine("Employee Name : "+empname[i]);
                Console.WriteLine("Address : "+ empaddress[i]);
                Console.WriteLine();
            }
        }
    }
}