using Aluguel_de_Carros__interface_.Entidades;
using Aluguel_de_Carros__interface_.Serviços;
using System;
using System.Globalization;

//RAFAEL DO NASCIMENTO RODRIGUES RA 210211
namespace Aluguel_de_Carros__interface_
{
    class Program
    {
        static void Main(string[] args)
        {
            //mostrar ao usuário que é para se colocar os dados da locação
            Console.WriteLine("Entre com os dados da locação: ");
            //pedir ao usuário para digitar o modelo
            Console.Write("Modelo: ");
            //comando para ler a string
            string modelo = Console.ReadLine();
            //pedir ao usuário pra digitar o checkin
            Console.Write("Check-in (dd/MM/yyyy HH:mm): ");
            //comando para ler e transformar a string digitada em DateTime e armazenar na variavel checkin
            DateTime checkin = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            // pedir ao usuário pra digitar o checkout
            Console.Write("Check-out (dd/MM/yyyy HH:mm): ");
            //comando para ler e transformar a string digitada em DateTime e armazenar na variavel checkout
            DateTime checkout = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            //pedir ao usuário para digitar o preço por hora do aluguel
            Console.Write("Entre com o preço por hora: ");
            //comando para ler e transformar a string digitada em double a armazenar na variavel hora
            double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //pedir ao usuário para digitar o preço por dia do aluguel
            Console.Write("Entre com o preço por dia: ");
            //comando para ler e transformar a string digitada em double a armazenar na variavel dia
            double dia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //criação do objeto "aluguelCarro" da classe AluguelCarro, Herdando os parametros checkin e checkount e instanciando um objeto modelo da classe Veículo
            AluguelCarro aluguelCarro = new AluguelCarro(checkin, checkout, new Veículo(modelo));

            //criação do objeto "serviçoLocação" da classe ServiçoLocação, Herdando os parametros hora e dia e instanciando a um objeto da classe TaxaServiçoBR que possui uma operação da taxa brasileira
            ServiçoLocação serviçoLocação = new ServiçoLocação(hora, dia, new TaxaServiçoBR());

            //chamando o método ProcessoFatura pra imprimir a fatura
            serviçoLocação.ProcessoFatura(aluguelCarro);

            //Escrever Fatura na tela pra que se saiba o que é o próximo valor que aparece na tela
            Console.WriteLine("FATURA: ");
            //Impressão da fatura na tela
            Console.WriteLine(aluguelCarro.Fatura);
        }
    }
}
