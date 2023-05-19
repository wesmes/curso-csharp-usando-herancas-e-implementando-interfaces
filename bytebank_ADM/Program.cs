
using bytebank_ADM.Funcionarios;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Parceria;

#region
//Funcionario pedro = new Funcionario("23234578", 2000.0);
//pedro.Nome = "Pedro Malazartes";

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor("234568456");
//roberta.Nome = "Roberta Silva";

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: "+gerenciador.TotalDeBonificacoes);
//Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);

//pedro.AumentaSalario();
//roberta.AumentaSalario();

//Console.WriteLine("Novo salário do Pedro: R$"+pedro.Salario);
//Console.WriteLine("Novo salário do Roberta: R$" + roberta.Salario);
#endregion

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("132132132");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("135467321");
    paula.Nome = "Paula Garcia";

    Auxiliar igor = new Auxiliar("21378956");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("213789546");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(ulisses);

    Console.WriteLine("Total de bonificação: R$"+gerenciador.TotalDeBonificacoes);
}

// CalcularBonificacao();
void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("195273654");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("456156567");
    ursula.Nome = "Ursula Alcantara";
    ursula.Senha = "321";

    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "999";

    sistema.Logar(ingrid, "123");
    sistema.Logar(ursula, "963");
    sistema.Logar(caio, "999");

}

UsarSistema();
