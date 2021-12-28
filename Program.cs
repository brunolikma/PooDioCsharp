using System;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculadora calc = new Calculadora();
            System.Console.WriteLine(calc.Somar(10, 20));

            

            // Corrente c = new Corrente();
            // c.Creditar(100);
            // c.ExibirSaldo();

            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(1 , 5));
            // System.Console.WriteLine("Resultado da segunda Soma: " + calc.Somar(3 , 8 , 10));

            // Aluno a1 = new Aluno();
            // a1.Nome = "Bob";
            // a1.Idade = 20;
            // a1.Documento = "123456";
            // a1.Nota = 10;
            // a1.Apresentar();

            // Professor p1 = new Professor();
            // p1.Nome = "José";
            // p1.Idade = 45;
            // p1.Documento = "654321";
            // p1.Salario = 3500;
            // p1.Apresentar();
        


            // // Valores Validos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 30);
            // System.Console.WriteLine($"Área: {r.ObterArea()}");

            // //valores invalidos
            // Retangulo r1 = new Retangulo();
            // r1.DefinirMedidas(0, 0);
            // System.Console.WriteLine($"Área: {r1.ObterArea()}");











        //     Pessoa p1 = new Pessoa();

        //     p1.Nome = "Bob";
        //     p1.Idade = 20;

        //     p1.Apresentar();
        }
    }
}