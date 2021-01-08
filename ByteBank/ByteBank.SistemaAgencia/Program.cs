using ByteBank.Modelos;
using System;
using System.Text.RegularExpressions;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente c = new ContaCorrente(123, 789654);
            Console.WriteLine(c);
            Console.ReadLine();

            string padrao = "Sala [A-G][-]?[0123456789]{2}";

            Console.WriteLine(Regex.IsMatch("Sala G345", padrao));
            Console.WriteLine(Regex.IsMatch("Sala J-001", padrao));
            Console.WriteLine(Regex.IsMatch("Sala a004", padrao));
            Console.WriteLine(Regex.IsMatch("Sala C004", padrao));
            Console.WriteLine(Regex.IsMatch("Minha sala é a sala G34", padrao));
            Console.WriteLine(Regex.IsMatch("Minha sala é a Sala G-34", padrao));
            Console.ReadLine();

            Console.WriteLine("Regex");
            string texto = "Meu telefone é 9968328, entre em contato.";
            Match resultado = Regex.Match(texto, "[0-9]{4,5}-?[0-9]{4}");
            Console.WriteLine(resultado.Value);
            Console.ReadLine();

            string url = "www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);
            Console.WriteLine(extrator.GetValor("moedaOrigem")); // real
            Console.WriteLine(extrator.GetValor("moedaDestino")); // dolar
            Console.WriteLine(extrator.GetValor("valor")); // 1500

            Console.ReadLine();


        }
    }


}
