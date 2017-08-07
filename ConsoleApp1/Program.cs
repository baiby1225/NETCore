using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            while (b)
            {
                Console.WriteLine("Hello World!,input:");
                string input = Console.ReadLine();
                if (input=="y")
                {
                    b = false;
                }
                Console.WriteLine("你输入了："+input);
            }
          

           
        }
    }
}