namespace VeiculoExemplo
{
    public static class Repositorio
    {
        private static List<Veiculo> Lista { get; set; }

        static Repositorio()
        {
            if (Lista == null)
            {
                Lista = new List<Veiculo>();
            }
        }

        public static void Inserir(Veiculo veiculo)
        {
            Lista.Add(veiculo);
        }

        public static void Alterar(Veiculo veiculo)
        {
            foreach (var item in Lista.Where(w => w.Id == veiculo.Id))
            {
                item.Nome = veiculo.Nome;
            }
        }

        public static void Remover(int id)
        {
            var localVeiculo = Lista.FirstOrDefault(w => w.Id == id);
            if (localVeiculo != null)
            {
                Lista.Remove(localVeiculo);
            }
        }

        public static List<Veiculo> Listar()
        {
            return Lista;
        }
    }
}
