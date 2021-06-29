using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System;
using Exercicio_POO.Entities;

namespace Exercicio_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto("Banana", 0.99, 2);
            Produto p2 = new Produto("Energético", 5.49, 3);
            Produto p3 = new Produto("Arroz", 20.00, 1);
            Produto p4 = new Produto("Chocolate", 4.50, 1);
            Produto p5 = new Produto("Leite", 3.73, 3);
            Produto p6 = new Produto("Abacaxi", 2.40, 2);

            List<Produto> produtos = new List<Produto>{p1, p2, p3, p4, p5, p6};

            Caixa caixa = new Caixa();

            var t1 = caixa.calculaValorFinal(p1, 3);
            var t2 = caixa.calculaValorFinal(p2, 7);
            var t3 = caixa.calculaValorFinal(p3, 1);
            var t4 = caixa.calculaValorFinal(p4, 12);
            var t5 = caixa.calculaValorFinal(p5, 5);
            var t6 = caixa.calculaValorFinal(p6, 1);

            Console.WriteLine("Nome | Valor total");

            Console.WriteLine(p1.Nome + " | R$" + t1);
            Console.WriteLine(p2.Nome + " | R$" + t2);
            Console.WriteLine(p3.Nome + " | R$" + t3);
            Console.WriteLine(p4.Nome + " | R$" + t4);
            Console.WriteLine(p5.Nome + " | R$" + t5);
            Console.WriteLine(p6.Nome + " | R$" + t6);
        }
    }
}
