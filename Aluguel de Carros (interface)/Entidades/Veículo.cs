using System;
using System.Collections.Generic;
using System.Text;

//RAFAEL DO NASCIMENTO RODRIGUES RA 210211
namespace Aluguel_de_Carros__interface_.Entidades
{
    //Criação da classe Veículo
    class Veículo
    {
        //Encapsulamento da variavel Módelo
        public string Modelo { get; set; }
        //Método construtor da classe Veículo
        public Veículo(string modelo)
        {
            Modelo = modelo;
        }
    }
}
