﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_01_Lógica_de_Pogramação
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
                double n1, n2, n3, resultado, media;
                Console.WriteLine("Escreva o nome sdo aluno");
                Console.ReadLine();

                Console.WriteLine("Digite a Nota do Aluno");
                n1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a Nota do Aluno");
                n2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a Nota do Aluno");
                n3 = Convert.ToDouble(Console.ReadLine());

                resultado = n1 + n2 + n3;
                media = resultado / 3;

                if (media >= 8.5)
                {
                    Console.WriteLine("Nota A");
                    Console.WriteLine(media);
                }
                else if (media >= 7)
                {
                    Console.WriteLine("Nota B");
                    Console.WriteLine(media);
                }
                else if (media >= 6)
                {
                    Console.WriteLine("Nota C");
                    Console.WriteLine(media);
                }
                else if (media >= 0.1)
                {
                    Console.WriteLine("Nota D");
                    Console.WriteLine(media);
                }


                else if (media >= 0.0)
                {
                    Console.WriteLine("Nota E");
                    Console.WriteLine(media);
                }
                Console.ReadKey();
            }
        }
    }

 

