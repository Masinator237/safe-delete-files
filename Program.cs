using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileErase
{
    class Handler
    {
       static private Random rnd;
      static  Handler()
        {
            rnd = new Random();
        }

        public static byte[] random_bytes(int length)
        {
            length = length + 1;
            byte[] random = new byte[length];
            rnd.NextBytes(random);
            return random;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Secure file erase sample");
            Console.WriteLine("File ?");
            string file = Console.ReadLine();
            if (file != "")
            {
                File.WriteAllBytes(file, Handler.random_bytes(2048));
                File.WriteAllBytes(file, Handler.random_bytes(4096));
                File.WriteAllBytes(file, Handler.random_bytes(1024));
                File.Delete(file);
            }
            Console.WriteLine("DONE");
            Console.ReadLine();
        }
    }
}
