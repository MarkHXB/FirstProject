using System;

namespace HelloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args[0] == "help")
            {
                Console.WriteLine("valamilyen bullshit szöveg");
            }
            else
            {
                Console.WriteLine("Hello Git");
            }
        }
    }
}
