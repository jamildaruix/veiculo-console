
// See https://aka.ms/new-console-template for more information
using VeiculoExemplo;

Console.WriteLine("Hello, World!");

Veiculo veiculo1 = new Veiculo();
veiculo1.Id = 1;
veiculo1.Nome = "Teste 1";

Veiculo veiculo2 = new Veiculo();
veiculo2.Id = 2;
veiculo2.Nome = "Teste 2";

Repositorio.Inserir(veiculo1);
Repositorio.Inserir(veiculo2);


veiculo1.Id = 1;
veiculo1.Nome = "ALTERADO PARA UM";

Repositorio.Alterar(veiculo1);


var listaAntesExcluir = Repositorio.Listar();

Repositorio.Remover(1);

var listaApoxExcluir = Repositorio.Listar();