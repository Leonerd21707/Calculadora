using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;


class Program
{
    static void Main()
    {

    double num1;
    double num2;

        Console.WriteLine("Selecione uma operacao: + - * / ou Sair");
        string operacao = Console.ReadLine();

        string recebe1 = "Digite o primeiro numero:";
        string recebe2 = "Digite o segundo numero da operacao:";
    
        switch (operacao)
        {
            case "+":
                Console.WriteLine(recebe1);
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(recebe2);
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Resultado = {num1 + num2}");
            break;

            case "-":
                Console.WriteLine(recebe1);
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(recebe2);
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Resultado = {num1 - num2}");
            break;

            case "*":
                Console.WriteLine(recebe1);
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(recebe2);
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Resultado = {num1 * num2}");
            break;
            
            case "/":
                Console.WriteLine(recebe1);
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(recebe2);
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Resultado = {num1 / num2}");
            break;

            case "Sair":
                Console.WriteLine("Saindo do programa...");
            break;

            default:
                Console.WriteLine("Operacao invalida!");
            break;
        }


    }
}