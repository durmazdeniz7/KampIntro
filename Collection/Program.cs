using System;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { 
            //"Deniz","Durmaz","Sibel","Ayuldar"};


            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //foreach (var item in isimler)
            //{
            //    Console.WriteLine(item);
            //}

            List<string> isimler2 = new List<string> { 
            
            "Deniz","Durmaz","Ramazan","Kürşat"
            };


            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Baby");
            foreach (var item in isimler2)
            {
                Console.WriteLine(item);
            }
        
        }
    }
}
