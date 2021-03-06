using System;
using System.Collections.Generic;
using System.Text;

namespace trabalhando_csharp_dotnet.metodos_instrucao
{
    internal class Instrucao
    {

        //Nesta classe coloco em pratica conceitos basicos de logica de programação 
        public static void Declaracoes()
        {
            int a;
            int b = 2, c = 3;
            const int d = 4;
            a = 1;
            Console.WriteLine(a+b+c+d); 
        }
        public static void InstrucaoIf(string[] arr)
        {
            if(arr.Length == 0)
            {
                Console.WriteLine("Tamanho da Array 0 ");
            }
            else
            {
                Console.WriteLine("A array não esta vazia");
            }
        }
        public static void InstrucaoSwitch(string[] arr)
        {
            switch (arr.Length)
            {
                case 0:
                    Console.WriteLine("Array esta vazia");
                    break;
                case 1:
                    Console.WriteLine("Array tem um elemento");
                    break;  
                default: Console.WriteLine("Array maior que 1 elemento");
                    break;
            }
        }
        public static void InstrucaoWhile(string[] arr)
        {
            int i = 1;

            while (i < arr.Length)
            {
                Console.WriteLine($"Contador: {i}");
                i++;
            }
        }
        public static void InstrucaoDo()
        {
            do
            {
                Console.WriteLine("Imprimiu antes do False");
            } while (false);
        }
        public static void InstrucaoFor(string[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static void InstrucaoForeach(string[] arr)
        {
            foreach(string s in arr)
            {
                Console.WriteLine(s);
            }
        }
        public static void InstrucaoBreak(string[] arr)
        {
            int i = 0;

            while(i < arr.Length)
            {
                Console.WriteLine($"Contador: {i}");

                if(i == 2)
                {
                    break;
                }
            }
        }

 
    
    }
}

