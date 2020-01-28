using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var notasProfessorJoao = new Nota[]
            {
                new Nota("Paulo", 6),
                new Nota("Maria", 8),
                new Nota("Ana", 9.5),
                new Nota("Patricia", 10)
            };

            var notasProfessorJose = new Nota[]
            {
                new Nota("Guilherme", 5),
                new Nota("Maurício", 7),
                new Nota("Júlio", 7.5),
                new Nota("João", 8.5),
                new Nota("Giovanni", 10)
            };

            var classificacao = Intercala(notasProfessorJoao, notasProfessorJose);

            for (int i = 0; i < classificacao.Length; i++)
            {
                Console.WriteLine(classificacao[i].ToString());
            }

            Console.ReadKey();
        }

        private static Nota[] Intercala(Nota[] notas1, Nota[] notas2)
        {
            var total = notas1.Length + notas2.Length;

            Nota[] resultado = new Nota[total];

            var atual1 = 0;
            var atual2 = 0;
            var atual = 0;

            while(atual1 < notas1.Length && 
                  atual2 < notas2.Length)
            {
                Nota nota1 = notas1[atual1];
                Nota nota2 = notas2[atual2];

                if(nota1.Valor < nota2.Valor)
                {
                    resultado[atual] = nota1;
                    atual1++;
                }
                else
                {
                    resultado[atual] = nota2;
                    atual2++;
                }

                atual++;
            }

            while (atual1 < notas1.Length)
            {
                resultado[atual] = notas1[atual1];
                atual1++;
                atual++;
            }

            while (atual2 < notas2.Length)
            {
                resultado[atual] = notas2[atual2];
                atual2++;
                atual++;
            }

            return resultado;
        }
    }
}
