using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeiculoExemplo
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }

    public class Carro : Veiculo 
    {
        public int Valor { get; set; }

        public void ImprimirDados()
        {
            Console.WriteLine($"Id {Id} - Nome {Nome} - Valor {Valor}");
        }
    }

    public class Moto : Veiculo
    {

        public void ImprimirDados()
        {
            Console.WriteLine($"Id {Id} - Nome {Nome}");
        }
    }
}
