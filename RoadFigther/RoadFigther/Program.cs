using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadFigther
{
    class Program
    {
        static void Main(string[] args)
        {
            string dllDirectory = @"C:\sdldotnet\lib\"; // Serveix per dir-li on estan les llibreries
            Environment.SetEnvironmentVariable("PATH", Environment.GetEnvironmentVariable("PATH") + ";" + dllDirectory);

            Game g = new Game();
            Console.WriteLine("El MAC Xuta!!");
        }
    }
}