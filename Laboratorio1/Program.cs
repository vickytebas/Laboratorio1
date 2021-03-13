using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            int altura;
            int peso;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Insira a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Insira a sua altura (em centímetros): ");
            altura = int.Parse(Console.ReadLine());

            Console.Write("Insira seu peso: ");
            peso = int.Parse(Console.ReadLine());

            altura /= 100;

            float imc = peso / (altura ^ 2);

            CalculoIMC(imc, altura);
        }
        static void CalculoIMC(float imc, int altura)
        {
            Console.WriteLine("Seu IMC: {0}", imc);

            if (imc >= 18.5f && imc <= 24.9f)
            {
                Console.WriteLine("Situação: Parabéns — você está em seu peso normal!");
                Console.ReadLine();
            }
            if (imc >= 25 && imc <= 29.9f)
            {
                Console.WriteLine("Situação: Você está acima de seu peso (sobrepeso).");
                float pesoIdeal = ((altura ^ 2) * 24.9f);

                Console.Write("Meta: O seu peso ideal é: {0}", pesoIdeal);
                Console.ReadLine();
            }
            if (imc >= 30 && imc <= 34.9f)
            {
                Console.WriteLine("Situação: Obesidade grau I.");
                float pesoIdeal = ((altura ^ 2) * 24.9f);

                Console.Write("Meta: O seu peso ideal é: {0}", pesoIdeal);
                Console.ReadLine();
            }
            if (imc >= 35 && imc <= 39.9f)
            {
                Console.WriteLine("Situação: Obesidade grau II.");
                float pesoIdeal = ((altura ^ 2) * 24.9f);

                Console.Write("Meta: O seu peso ideal é: {0}", pesoIdeal);
                Console.ReadLine();
            }
            if (imc >= 40)
            {
                Console.WriteLine("Situação: Obesidade graus III e IV.");
                float pesoIdeal = ((altura ^ 2) * 24.9f);

                Console.Write("Meta: O seu peso ideal é: {0} ", pesoIdeal);
                Console.ReadLine();
            }
        }
    }
}