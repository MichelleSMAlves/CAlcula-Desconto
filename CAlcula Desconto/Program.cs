// Calcula Desconto (Trio 2 Método com retorno)

using System;

public class DescontoCalculadora
{
    // Método para calcular o desconto e retornar o preço com desconto
    public double CalcularDesconto(double precoOriginal, double percentualDesconto)
    {
        if (precoOriginal < 0 || percentualDesconto < 0 || percentualDesconto > 100)
        {
            throw new ArgumentException("O preço original e o percentual de desconto devem ser números positivos e o percentual de desconto não pode ser superior a 100.");
        }

        double desconto = (precoOriginal * percentualDesconto) / 100;
        double precoComDesconto = precoOriginal - desconto;
        return precoComDesconto;
    }
}

class Program
{
    static void Main(string[] args)
    {
        DescontoCalculadora calculadora = new DescontoCalculadora();

        Console.WriteLine("Digite o preço original:");
        double precoOriginal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o percentual de desconto:");
        double percentualDesconto = Convert.ToDouble(Console.ReadLine());

        try
        {
            // Chamando o método para calcular o desconto
            double precoComDesconto = calculadora.CalcularDesconto(precoOriginal, percentualDesconto);

            Console.WriteLine($"Preço original: R${precoOriginal}");
            Console.WriteLine($"Percentual de desconto: {percentualDesconto}%");
            Console.WriteLine($"Preço com desconto: R${precoComDesconto}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Por favor, insira um valor numérico válido.");
        }
    }
}
