using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locadora
{
    public abstract class Veiculo
    {
        protected double TaxaDiaria { get; set; }
        public abstract double CalcularValorTotal(int numDiarias);

    }

    class Carro : Veiculo
    {
        public Carro(double TaxaDiaria) 
        {
            this.TaxaDiaria = TaxaDiaria;
        }

        public override double CalcularValorTotal(int numDiarias)
        {
            double pagamento = TaxaDiaria * numDiarias;
            Console.WriteLine($"O valor do aluguel é {pagamento},00.");
            return pagamento; 

        }
    }

    class Moto : Veiculo
    {
        public Moto(double TaxaDiaria) 
        {
            this.TaxaDiaria = TaxaDiaria;
        }

        public override double CalcularValorTotal(int numDiarias)
        {
            double pagamento = TaxaDiaria * numDiarias;
            Console.WriteLine($"O valor do aluguel é {pagamento},00.");
            return pagamento;

        }
    }
}