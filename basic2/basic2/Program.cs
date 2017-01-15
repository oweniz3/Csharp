using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic2
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg {0} : {1}", i, args[i]);
            }

            string[] myArgs = Environment.GetCommandLineArgs();
            Console.WriteLine(string.Join(", ", myArgs));

            Sayhello();

            Console.ReadLine();
        }
        //how to get input from console

        private static void Sayhello()
        {
            String name = "";
            Console.Write("What is your name : ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);

        }
    }
}
