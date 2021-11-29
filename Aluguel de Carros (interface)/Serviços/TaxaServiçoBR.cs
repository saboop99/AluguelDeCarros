using System;
using System.Collections.Generic;
using System.Text;

//RAFAEL DO NASCIMENTO RODRIGUES RA 210211
namespace Aluguel_de_Carros__interface_.Serviços
{
    //Criação da classe TaxaServiçoBR, que herda da interface ITaxaServiço
    class TaxaServiçoBR : ITaxaServiço
    {
        //Variável Taxa herdada da interface ITaxaServiço
        public double Taxa(double quantia)
        {
            //Condicional para se quantia for menor ou igual a 100, caso seja, retornar essa quantia multiplicando por 0.2
            if (quantia <= 100.00)
            {
                return quantia * 0.2;
            }

            //condicional que se conclui caso a anterior não seja verdadeira, e retorna a quantia multiplicando por 0.15
            else
            {
                return quantia * 0.15;
            }
        }
    }
}
