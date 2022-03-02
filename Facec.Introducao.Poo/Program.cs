using Facec.Introducao.Poo.Enums;
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

            //char letra = 'B';
            //string frase = "om dia!";

            //Console.WriteLine(letra + frase);
            //Console.WriteLine(string.Concat(letra, frase));
            //Console.WriteLine($"{letra}{frase} Juliano.");
            //Console.WriteLine(string.Format("{0}{1} Juliano", letra, frase));
            //Console.WriteLine(frase[6]);
            //Console.WriteLine("Informe seu nome:");
            //Console.WriteLine("Seu nome é: " + Console.ReadLine());

            //Console.WriteLine($"{letra}{frase}".ToLower());
            //Console.WriteLine($"{letra}{frase}".ToUpper());

            //Console.ReadKey();

            #endregion Char e Strings

            #region Inteiros

            //int inteiro1 = 1;
            //short short1 = short.MaxValue;

            //Console.WriteLine($"Valor minimo short: {short.MinValue}");
            //Console.WriteLine($"Valor maximo short: {short.MaxValue}");
            //Console.WriteLine($"Valor minimo inteiro: {int.MinValue}");
            //Console.WriteLine($"Valor maximo inteiro: {int.MaxValue}");
            //Console.WriteLine($"Valor minimo long: {long.MinValue}");
            //Console.WriteLine($"Valor maximo long: {long.MaxValue}");

            //Console.WriteLine($"Valor minimo ushort: {ushort.MinValue}");
            //Console.WriteLine($"Valor maximo ushort: {ushort.MaxValue}");
            //Console.WriteLine($"Valor minimo uint: {uint.MinValue}");
            //Console.WriteLine($"Valor maximo uint: {uint.MaxValue}");
            //Console.WriteLine($"Valor minimo long: {ulong.MinValue}");
            //Console.WriteLine($"Valor maximo long: {ulong.MaxValue}");

            //int inteiro1 = 3;
            //int inteiro2 = inteiro1;
            //inteiro1 = 7;

            //Console.WriteLine($"{nameof(inteiro1)}:{inteiro1}");
            //Console.WriteLine($"{nameof(inteiro2)}:{inteiro2}");

            //Console.ReadLine();

            #endregion Inteiros

            #region Ponto Flutuante e Decimal

            //Console.WriteLine($"Valor minimo float: {float.MinValue}");
            //Console.WriteLine($"Valor maximo float: {float.MaxValue}");
            //Console.WriteLine($"Valor minimo double: {double.MinValue}");
            //Console.WriteLine($"Valor maximo double: {double.MaxValue}");
            //Console.WriteLine($"Valor minimo decimal: {decimal.MinValue}");
            //Console.WriteLine($"Valor maximo decimal: {decimal.MaxValue}");

            //float float1 = 10.00f;
            //float float2 = 20.00f;

            //Console.WriteLine($"{nameof(float1)} {float1} + {nameof(float2)} {float2} = 30?");
            //Console.WriteLine($"{float1 + float2 == 30.00f} Resultado soma = {float1 + float2}");

            //float float3 = 10.10f;
            //float float4 = 20.20f;

            //Console.WriteLine($"{nameof(float3)} {float3} + {nameof(float4)} {float4} = 30.30?");
            //Console.WriteLine($"{float3 + float4 == 30.30f} Resultado soma = {float3 + float4}");

            //decimal decimal1 = 10.10m;
            //decimal decimal2 = 20.20m;

            //Console.WriteLine($"{nameof(decimal1)} {decimal1} + {nameof(decimal2)} {decimal2} = 30.30?");
            //Console.WriteLine($"{decimal1 + decimal2 == 30.30m} Resultado soma = {decimal1 + decimal2}");

            //Console.ReadLine();

            #endregion Ponto Flutuante e Decimal

            #region Booleano

            //bool booleano1 = false;
            //bool booleano2 = true;

            //Console.WriteLine($"{nameof(booleano1)}:{booleano1}");
            //Console.WriteLine($"{nameof(booleano2)}:{booleano2}");

            //Console.ReadLine();

            #endregion Booleano

            #region Enum

            //TipoPessoa tipoPessoa1 = TipoPessoa.Fisica;
            //TipoPessoa tipoPessoa2 = TipoPessoa.Juridica;

            //Console.WriteLine($"{nameof(tipoPessoa1)}:{tipoPessoa1}");
            //Console.WriteLine($"{nameof(tipoPessoa2)}:{tipoPessoa2}");

            //Console.ReadLine();

            #endregion Enum

            #region Data

            //DateTime data1 = DateTime.Now;
            //DateTime data2 = DateTime.Today;
            //DateTime data3 = DateTime.Today.AddMonths(-1).AddDays(7);
            //DateTime data4 = DateTime.Today.AddMonths(-1).AddDays(7).AddMonths(1);
            //int mes = DateTime.Today.Month;
            //int dia = DateTime.Today.Day;
            //int ano = DateTime.Today.Year;

            //Console.WriteLine($"{nameof(data1)}:{data1}");
            //Console.WriteLine($"{nameof(data2)}:{data2}");
            //Console.WriteLine($"{nameof(data3)}:{data3}");
            //Console.WriteLine($"{nameof(data4)}:{data4}");
            //Console.WriteLine($"{data4.ToShortDateString()}");
            //Console.WriteLine($"{data4.ToLongDateString()}");
            //Console.WriteLine($"{data1.ToShortTimeString()}");
            //Console.WriteLine($"{data1.ToLongTimeString()}");

            //Console.ReadLine();

            #endregion Data

            #region Operadores Aritiméticos

            //int valor1 = 1 + 2;
            //int valor2 = 3 - 1;
            //int valor3 = 2 * 3;
            //int valor4 = 6 / 2;
            //int valor5 = 7 % 2;

            //Console.WriteLine($"{nameof(valor1)}: 1 + 2 = {valor1}");
            //Console.WriteLine($"{nameof(valor2)}: 3 - 1 = {valor2}");
            //Console.WriteLine($"{nameof(valor3)}: 2 * 3 = {valor3}");
            //Console.WriteLine($"{nameof(valor4)}: 6 / 2 = {valor4}");
            //Console.WriteLine($"{nameof(valor5)}: 7 % 2 = {valor5}");

            //Console.ReadLine();

            #endregion Operadores Aritiméticos

            #region Operadores comparação

            Console.WriteLine($" 3 > 1 : {3 > 1 }");
            Console.WriteLine($" 3 < 1 : {3 < 1 }");
            Console.WriteLine($" 1 >= 1 : {1 >= 1 }");
            Console.WriteLine($" 0 <= 1 : {0 <= 1 }");
            Console.WriteLine($" 3 == 1 : {3 == 1 }");

            TipoPessoa pessoaFisica = TipoPessoa.Fisica;

            Console.WriteLine(pessoaFisica.Equals(TipoPessoa.Fisica));
            Console.WriteLine(TipoPessoa.Fisica.Equals(pessoaFisica));

            Console.ReadLine();

            #endregion Operadores comparação
        }
    }
}