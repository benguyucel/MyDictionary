using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(149, "Yücel Bengü");
            MDictionary<int, string> mDictionary = new MDictionary<int, string>();
            
            mDictionary.Add(149, "Yücel Bengü");
            mDictionary.Add(1492, "Yücel Bengü2");
           

        }
    }
}
