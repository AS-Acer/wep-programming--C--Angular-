using Matematik;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5.6, 5.4);
            dortIslem.cıkar(859,4);
            dortIslem.bol(8, 3);
            dortIslem.carp(8, 3);
            
        }
    }
}