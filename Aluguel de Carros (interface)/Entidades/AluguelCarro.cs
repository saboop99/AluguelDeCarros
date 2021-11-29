using System;
using System.Collections.Generic;
using System.Text;

//RAFAEL DO NASCIMENTO RODRIGUES RA 210211
namespace Aluguel_de_Carros__interface_.Entidades
{
    //Criação da classe AluguelCarro
    class AluguelCarro
    {
        //Encapsulamento da variavel CheckIn
        public DateTime CheckIn { get; set; }
        //Encapsulamento da variavel CheckOut
        public DateTime CheckOut { get; set; }
        //Encapsulamento da variavel Veículo
        public Veículo Veículo { get; private set; }
        //Encapsulamento da variavel Fatura
        public Fatura Fatura { get; set; }

        //Criação do método construtor da classe AluguelCarro
        public AluguelCarro(DateTime checkin, DateTime checkout, Veículo veículo)
        {
            CheckIn = checkin;
            CheckOut = checkout;
            Veículo = veículo;
            Fatura = null;
        }
    }
}
