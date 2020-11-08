using System;

namespace mc
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
                Console.Write("> ");
                string line = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(line))
                    return;
                
                if(line == "1 * 3 + 1")
                    Console.WriteLine("7");
                else
                    Console.WriteLine("Error: lala");
            }
            
        }
    }

    class Lexer
    {
        public Lexer(string text)
        {
            
        }

    }
}
