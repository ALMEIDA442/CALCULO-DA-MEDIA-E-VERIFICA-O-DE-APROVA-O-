﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_29
{
    internal class Program
    {
        static void Main(string[] args)
        {// Exercício 29: Cálculo da Média e Verificação de Aprovação

            // Descrição:
            // Este exercício consiste em desenvolver um programa que leia os valores de
            // quatro notas bimestrais de um aluno, calcule a média aritmética e informe
            // se o aluno foi aprovado ou reprovado. A nota para ser aprovado é 5.

            // Passo a Passo:

            // 1. Entrada de Dados:
            //    - Solicite ao usuário que insira os valores das quatro notas bimestrais
            //      do aluno.
            //    - Aguarde a entrada do usuário.

            Console.WriteLine("Insira os valores das quatro notas bimestrais: ");
            int a,b, c, d;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());



            // 2. Processamento:
            //    - Calcule a média aritmética das quatro notas.
            //    - Verifique se a média é maior ou igual a 5 para determinar se o aluno
            //      foi aprovado ou reprovado.
            string res;
            double por;
           
            por = (a + b + c + d) / 4;
           if (por >= 5) 
            { 
                res = "o Aluno foi APROVADO"; 
            }
           else 
            { 
                res = "o Aluno foi REPROVADO"; 
            }
            Console.WriteLine("Média é: " + por + " , " + res);
           Console.ReadKey();
            // 3. Saída de Dados:
            //    - Apresente a média calculada e a informação se o aluno foi aprovado ou
            //      reprovado.

            // Exemplos:

            // - Exemplo 1:
            //   - Entrada: 7, 6, 4, 5
            //   - Saída: Média: 5.5, Aprovado

            // - Exemplo 2:
            //   - Entrada: 6, 5, 3, 4
            //   - Saída: Média: 4.5, Reprovado

            // - Exemplo 3:
            //   - Entrada: 8, 7, 6, 8
            //   - Saída: Média: 7.25, Aprovado

            // Exemplo em Pseudocódigo:
            // ENTRADA: nota1, nota2, nota3, nota4
            // PROCESSAMENTO: media = (nota1 + nota2 + nota3 + nota4) / 4
            //                SE media >= 5
            //                    exibir "Média: ", media, ", Aprovado"
            //                SENÃO
            //                    exibir "Média: ", media, ", Reprovado"
        }
    }
}
