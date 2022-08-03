using System;
using System.Globalization;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Mensagem de Bom dia!*/
            string primeiraMsg = Console.ReadLine();

            /*Definição da Primeira Cor*/
            Console.WriteLine("Insira a primeira cor: ");
            string primeiraCor = Console.ReadLine();
            
            /*Definição da Segunda Cor*/
            Console.WriteLine("Insira a segunda cor: ");
            string segundaCor = Console.ReadLine();
            
            /*Definição da Terceira Cor*/
            Console.WriteLine("Insira a terceira cor: ");
            string terceiraCor = Console.ReadLine();

            /*Definição da String com 3 Cores*/
            Console.WriteLine("Digite três cores: ");
            string _3Cores = Console.ReadLine();

            /*Separação da String de 3 cores em 3 variáveis distintas*/
            string[] vet3Cores = _3Cores.Split(' ');
            string vet1Cor = vet3Cores[0];
            string vet2Cor = vet3Cores[1];
            string vet3Cor = vet3Cores[2];

            /*Print de todos os inputs*/
            Console.WriteLine("Primeira Mensagem: " + primeiraMsg);
            Console.WriteLine("Primeira Cor: " + primeiraCor);
            Console.WriteLine("Segunda Cor: " + segundaCor);
            Console.WriteLine("Terceira Cor: " + terceiraCor);
            Console.WriteLine("String completa: " + _3Cores);
            Console.WriteLine("Primeira Cor da String: " + vet1Cor);
            Console.WriteLine("Segunda Cor da String: " + vet2Cor);
            Console.WriteLine("Terceira Cor da String: " + vet3Cor);


        }
    }
}
