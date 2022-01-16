using System;
using System.Collections.Generic;
using System.Linq;

namespace _010EditorKeygen // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Number of users: 1000");
            Console.WriteLine("Key: " + Keygen.MakeKey(username, 1000));
        }
    }
}