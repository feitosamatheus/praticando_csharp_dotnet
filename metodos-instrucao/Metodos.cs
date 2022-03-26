using System;
using System.Collections.Generic;
using System.Text;

namespace trabalhando_csharp_dotnet.metodos
{
    internal class Metodos
    {
        public string retonarNome()
        {
            return "Matheus Feitosa";
        }
        public Aluno AdicionaItemArray(Aluno[] arr, int index)
        {   
            Console.WriteLine("Informe o nome do aluno");
            Aluno aluno = new Aluno();
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Informe a nota do aluno");

            if (decimal.TryParse(Console.ReadLine(), out decimal nota))
            {
                aluno.Nota = nota;
            }
            else
            {
                throw new ArgumentException("Valor da nota deve ser decimal");
            }

            arr[index] = aluno;

            return aluno;
        }
        public void pecorrendoArray(Aluno[] arr)
        {
            foreach (Aluno i in arr)
            {
                if (!string.IsNullOrEmpty(i.Nome))
                {
                    Console.WriteLine($"ALUNO: {i.Nome} | NOTA: {i.Nota}");
                }
            }
        }
        public void retornaMedia(Aluno[] arr)
        {
            decimal notaTotal = 0;
            decimal mediaGeral = 0;
            int contador = 0;

            for (int i = 0; i < arr.Length; i++)

            {
                if (!string.IsNullOrEmpty(arr[i].Nome))
                {
                    notaTotal += arr[i].Nota;
                    contador++;

                }

            }

            mediaGeral = notaTotal / contador;

            ConceitoEnum conceitoGeral;

            if (mediaGeral < 3)
            {
                conceitoGeral = ConceitoEnum.E;
            }
            else if (mediaGeral < 6)
            {
                conceitoGeral = ConceitoEnum.D;
            }
            else
            {
                conceitoGeral = ConceitoEnum.A;
            }

            Console.WriteLine($" SUA MEDIA: {mediaGeral}\n CONCEITO: {conceitoGeral}");

        }
    }
}
