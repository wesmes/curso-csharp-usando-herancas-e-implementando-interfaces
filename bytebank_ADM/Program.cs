
using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Funcionario pedro = new Funcionario("23234578", 2000.0);
pedro.Nome = "Pedro Malazartes";

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());

Diretor roberta = new Diretor("234568456", 5000.0);
roberta.Nome = "Roberta Silva";

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

Console.WriteLine("Total de bonificações: "+gerenciador.TotalDeBonificacoes);
Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);

pedro.AumentaSalario();
roberta.AumentaSalario();

Console.WriteLine("Novo salário do Pedro: R$"+pedro.Salario);
Console.WriteLine("Novo salário do Roberta: R$" + roberta.Salario);