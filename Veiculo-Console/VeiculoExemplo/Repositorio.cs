﻿namespace VeiculoExemplo
{
    public static class Repositorio
    {
        private static List<Veiculo> ListaVeiculo { get; set; }
        private static List<Carro> ListaCarro { get; set; }
        private static List<Moto> ListaMoto { get; set; }

        static Repositorio()
        {
            if (ListaVeiculo == null)
            {
                ListaVeiculo = new List<Veiculo>();
            }

            if (ListaCarro == null)
            {
                ListaCarro = new List<Carro>();
            }

            if (ListaVeiculo == null)
            {
                ListaMoto = new List<Moto>();
            }
        }

        public static void InserirVeiculo(Veiculo veiculo)
        {
            ListaVeiculo.Add(veiculo);
        }

        public static void InserirCarro(Carro carro)
        {
            ListaCarro.Add(carro);
        }

        public static void InserirMoto(Moto moto)
        {
            ListaMoto.Add(moto);
        }

        public static void Alterar(Veiculo veiculo)
        {
            foreach (var item in ListaVeiculo.Where(w => w.Id == veiculo.Id))
            {
                item.Nome = veiculo.Nome;
            }
        }

        public static void Remover(int id)
        {
            var localVeiculo = ListaVeiculo.FirstOrDefault(w => w.Id == id);
            if (localVeiculo != null)
            {
                ListaVeiculo.Remove(localVeiculo);
            }
        }

        public static List<Veiculo> Listar()
        {
            return ListaVeiculo;
        }

        public static void ImprimirCarro()
        {
            foreach (var carro in ListaCarro)
            {
                carro.ImprimirDados();
            }
        }

        public static void ImprimirMoto()
        {
            foreach (var moto in ListaMoto)
            {
                moto.ImprimirDados();
            }
        }
    }
}
