using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

//RAFAEL DO NASCIMENTO RODRIGUES RA 210211
namespace Aluguel_de_Carros__interface_.Entidades
{
    //Criação da classe Fatura
    class Fatura
    {
        //Encapsulamento da variavel Pagamento
        public double PagamentoBásico { get; set; }
        //Encapsulamento da variavel Taxa
        public double Taxa { get; set; }

        //Criação do método construtor da classe Fatura
        public Fatura(double aluguel, double taxa)
        {
            PagamentoBásico = aluguel;
            Taxa = taxa;
        }

        //variável totalPagamento, que retorna o valor do Pagamento básico e acrescenta a Taxa
        public double totalPagamento
        {
            get { return PagamentoBásico + Taxa; }
        }

        //Criação do override para sobrescrever os valores para os valores atualizados, retornando todos os valores descritos um em cada linha
        public override string ToString()
        {
            return "Pagamento Básico: "
                + PagamentoBásico.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTaxa: "
                + Taxa.ToString("F2", CultureInfo.InvariantCulture)
                + "\nPagamento Total: "
                + totalPagamento.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
