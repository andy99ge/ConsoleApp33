﻿using System;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("test");

            var temp = Guid.NewGuid().ToString("N");

            Console.WriteLine(temp);

            var dt = DateTime.Now.ToString();

            Console.WriteLine("datetime:"+dt.ToString());

            tempF t=new tempF(5.55f);

            Console.WriteLine(t.tempValue);
            Console.WriteLine(t.ToString());

            
        }
    }
}
