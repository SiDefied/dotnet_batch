using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    class Array
    {
        static void Main(string[] args)
        {
            int [] arr = {1,4,6,12,8,5,13,10,11,7};
            int max=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }  
            }
            Console.WriteLine("Using Arrays");
            Console.WriteLine("The largest number is : "+max);

            DataStructures.MyArrayList.UsingArrayList(arr);
            DataStructures.MyLinkedList.UsingLinkedList(arr);
        }

        
    }
    class MyArrayList
    {
        public static void UsingArrayList(int[] myarray)
        {
            
            ArrayList arrList = new ArrayList();
            arrList.AddRange(myarray);
            int maxnumber=0;

            for (int i = 0; i < arrList.Count; i++)
            {
                int element =(int)arrList[i];
                if (element>maxnumber)
                {
                    maxnumber = element;
                }
            }
            Console.WriteLine("Using ArrayList");
            Console.WriteLine("The largest number is : "+maxnumber);

        }
        
    }
    class MyLinkedList
    {
        public static void UsingLinkedList(int[] myarray)
        {
            LinkedList<int> numList = new LinkedList<int>();
            int largestnumber=0;
            
            for (int i = 0; i < myarray.Length; i++)
            {
                 numList.AddLast(myarray[i]);
            }

            foreach (int LLelement in numList)
            {
                if(LLelement>largestnumber)
                {
                    largestnumber=LLelement;
                }
            }

            Console.WriteLine("Using LinkedList");
            Console.WriteLine("The largest number is : "+largestnumber);


        }
        
    }
}