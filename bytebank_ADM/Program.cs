
using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Funcionario pedro = new Funcionario("23234578");
pedro.Nome = "Pedro Malazartes";
pedro.Salario = 2000.0;

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());

Diretor roberta = new Diretor("234568456");
roberta.Nome = "Roberta Silva";
roberta.Salario = 5000;

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

Console.WriteLine("Total de bonificações: "+gerenciador.TotalDeBonificacoes);
Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);