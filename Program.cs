using System;

namespace Exercicio3_Fixacao_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Descrição do Produto: ");
            string produto = Console.ReadLine();

            Console.Write("Quantidade (unitário): ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.Write("Preço unitário: R$ ");
            double precoUnitario = double.Parse(Console.ReadLine());

            double valorTotal = (quantidade * precoUnitario);
            Console.WriteLine($"Valor Bruto : R$ {valorTotal}");

            if(quantidade <=5)
            {
                double desconto = valorTotal *0.02;
                Console.WriteLine($"Valor do desconto: R$ {desconto}");
                
                double valorFinal = valorTotal * 0.98;
                Console.WriteLine($"Valor líquido a ser pago: R$ {valorFinal}");
            }

            Console.WriteLine("----Obrigado pela preferência - Volte sempre !----");
                       
        }
    }
}
// 3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade <= 5 o desconto será de 2%
// - Se quantidade >5 e quantidade <= 10 o desconto será de 3%
// - Se quantidade >10 o desconto será de 5%
// Dica: utilize if / else if / else
