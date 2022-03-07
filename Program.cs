// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Globalization;
using CadastroPessoa_FS1.Classes;

Console.WriteLine(@$"
===============================================
|     Bem vindo ao sistema de cadastro de     |
|         Pessoas Fisicas e Juridicas         |
===============================================
");

BarraCarregamento("Finalizando ", 300);

string? opcao;
do
{

    Console.Clear();
    Console.WriteLine(@$"
===============================================
|        Escolha uma das opções abaixo        |
|---------------------------------------------|
|        1 - Pessoa Física                    |
|        2 - Pessoa Juridíca                  |
|                                             |
|        0 - Sair                             |
===============================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            PessoaFisica metodoPf = new PessoaFisica();

            PessoaFisica novaPf = new PessoaFisica();
            Endereco novoEnd = new Endereco();

            novaPf.nome = "Ryan";
            novaPf.dataNascimento = "05/06/2005";
            novaPf.cpf = "412894721";
            novaPf.rendimento = 15000.5f;


            novoEnd.logradouro = "Maria Rodrigues Machado";
            novoEnd.numero = 16;
            novoEnd.complemento = "casa";
            novoEnd.endComercial = true;

            novaPf.endereco = novoEnd;

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPf.nome}
Data de nascimento: {novaPf.dataNascimento}
CPF: {novaPf.cpf}
Rendimento: {novaPf.rendimento}
Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}, {novaPf.endereco.complemento}
Maior de idade: {(metodoPf.ValidarDataNascimento(novaPf.dataNascimento) ? "Sim" : "Não")}
Taxa de imposto a ser paga é: {metodoPf.PegarImposto(novaPf.rendimento).ToString("C")}
");
// , CultureInfo.CreateSpecificCulture("fr-FR")

            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();

            break;

        case "2":
            PessoaJuridica metodoPj = new PessoaJuridica();
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.nome = "Nome Pj";
            novaPj.cnpj = "00.000.000/0001-00";
            novaPj.razaoSocial = "Razão Social Pj";
            novaPj.rendimento = 8000.5f;

            novoEndPj.logradouro = "Maria Rodrigues Machado";
            novoEndPj.numero = 16;
            novoEndPj.complemento = "casa";
            novoEndPj.endComercial = true;

            novaPj.endereco = novoEndPj;

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj}
CNPJ válido: {metodoPj.ValidarCnpj(novaPj.cnpj)}");

            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();

            BarraCarregamento("Finalizando ", 300);

            break;

        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema");

            break;

        default:
            Console.Clear();
            Console.WriteLine($"Opção inválida, por favor digete outra opção");
            Thread.Sleep(2000);
            break;
    }
} while (opcao != "0");

static void BarraCarregamento(string texto, int tempo)
{

    Console.BackgroundColor = ConsoleColor.DarkCyan;
    Console.ForegroundColor = ConsoleColor.Red;

    Console.Write($"{texto}");

    for (var contador = 0; contador < 10; contador++)
    {
        Console.Write(". ");
        Thread.Sleep(tempo);
    }

    Console.ResetColor();
}
