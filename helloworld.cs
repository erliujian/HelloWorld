using System;
using System.Collections.Generic;
using Class_Library;
using System.Collections;
namespace CSHARP

{
    
    class Program
    {
        public static int count = 0;

        static void Main(string[] args)
        {

            MyList list = new MyList(10);
        }

        class  MyList
        {
            public MyList( int n)
            {
                for (int i = 0; i < n; i++)
                {
                    i = new Random().Next(1, 10);
                    Console.WriteLine(i);
                }

            }
        }
    }
    
}





