using Aluguel_de_Carros__interface_.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

//RAFAEL DO NASCIMENTO RODRIGUES RA 210211
namespace Aluguel_de_Carros__interface_.Serviços
{
    //Criação da classe ServiçoLocação
    class ServiçoLocação
    {
        //Encapsulamento da variavel PreçoPorHora, com private set pra impedir a migração entre classes
        public double PreçoPorHora { get; private set; }
        //Encapsulamento da variavel PreçoPorDia, com private set pra impedir a migração entre classes
        public double PreçoPorDia { get; private set; }
        //Instanciar a interface ITaxaServiço na variável "_taxaServiço"
        private ITaxaServiço _taxaServiço;
        //Criação do método construtor da classe ServiçoLocação
        public ServiçoLocação(double preçoPorHora, double preçoPorDia, ITaxaServiço taxaServiço)
        {
            PreçoPorHora = preçoPorHora;
            PreçoPorDia = preçoPorDia;
            _taxaServiço = taxaServiço;
        }

        //criação do método ProcessoFatura recebendo os parâmetros do alugel do carro (AluguelCarro)
        public void ProcessoFatura(AluguelCarro aluguelCarro)
        {
            //Criação do TimeSpan subtraindo o valor do aluguel do carro no checkout com o do checkin e adicionando o valor na variável duração
            TimeSpan duração = aluguelCarro.CheckOut.Subtract(aluguelCarro.CheckIn);

            //criação da variável pagamentoBásico e definindo que ela é igual a 0 para poder receber os resultados das operações
            double pagamentoBásico = 0.0;
            //condicional caso a duração seja menor ou igual a 12
            if(duração.TotalHours <= 12.0)
            {
                //pagamentoBásico é igual ao preço por hora(PreçoPorHora) vezes a duração
                pagamentoBásico = PreçoPorHora * Math.Ceiling(duração.TotalHours);
            }

            //condicional caso a anterior não se conclua
            else
            {
                //pagamentoBáscio é igual ao preço por dia (PreçoPorDia) vezes a duração
                pagamentoBásico = PreçoPorDia * Math.Ceiling(duração.TotalDays);
            }
            
            //criação da variável taxa e definindo que ela é igual a _taxaServiço (interface ITaxaServiço) com o paramêtros pagamentoBásico
            double taxa = _taxaServiço.Taxa(pagamentoBásico);
            
            //criação da Fatura no aluguelCarro, com os parâmetros pagamentoBásico e taxa
            aluguelCarro.Fatura = new Fatura(pagamentoBásico, taxa);
        }

       
    }
}
