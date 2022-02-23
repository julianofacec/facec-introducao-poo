using System;

namespace Facec.Introducao.Poo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Hello Word

            //Console.WriteLine("Hello World!");
            //Console.ReadKey();

            #endregion Hello Word

            #region Char e Strings

            char letra = 'B';
            string frase = "om dia!";

            Console.WriteLine(letra + frase);
            Console.WriteLine(string.Concat(letra, frase));
            Console.WriteLine($"{letra}{frase} Juliano.");
            Console.WriteLine(string.Format("{0}{1} Juliano", letra, frase));
            Console.WriteLine(frase[6]);
            Console.WriteLine("Informe seu nome:");
            Console.WriteLine(Console.ReadLine());
            Console.ReadKey();

            #endregion Char e Strings
        }
    }
}
