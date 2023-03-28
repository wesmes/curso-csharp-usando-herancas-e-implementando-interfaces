
using bytebank_ADM.Funcionarios;

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro Malazartes";
pedro.Cpf = "123456789";
pedro.Salario = 2000.0;

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());