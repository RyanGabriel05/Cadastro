﻿// See https://aka.ms/new-console-template for more information
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

List<PessoaFisica> listaPf = new List<PessoaFisica>();

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


            string? opcaoPf;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
===============================================
|        Escolha uma das opções abaixo        |
|---------------------------------------------|
|        1 - Cadastrar Pessoa Física          |
|        2 - Mostrar Pessoa Física            |
|                                             |
|        0 - Voltar ao menu anterior          |
===============================================
");
                opcaoPf = Console.ReadLine();

                switch (opcaoPf)
                {
                    case "1":

                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEnd = new Endereco();

                        Console.WriteLine($"Digete o nome da pessoa física que deseja cadastrar");
                        novaPf.nome = Console.ReadLine();

                        // bool dataValida;
                        // do
                        // {
                        //     Console.WriteLine($"Digite a data de nascimento Ex:DD/MM/AAAA");
                        //     string? dataNasc = Console.ReadLine();

                        //     dataValida = metodoPf.ValidarDataNascimento(dataNasc);
                        //     if (dataValida)
                        //     {
                        //         novaPf.dataNascimento = dataNasc;
                        //     }
                        //     else
                        //     {
                        //         Console.ForegroundColor = ConsoleColor.DarkRed;
                        //         Console.WriteLine($"Data digitada invalida, por favor digite uma data valida");
                        //         Console.ResetColor();
                        //     }
                        // } while (dataValida == false);


                        // Console.WriteLine($"Digite o numero do CPF");
                        // novaPf.cpf = Console.ReadLine();

                        // Console.WriteLine($"Digite o rendimento mensal (digete somente numeros)");
                        // novaPf.rendimento = float.Parse(Console.ReadLine());

                        // Console.WriteLine($"Digite o logradouro");
                        // novoEnd.logradouro = Console.ReadLine();

                        // Console.WriteLine($"Digite o numero");
                        // novoEnd.numero = int.Parse(Console.ReadLine());

                        // Console.WriteLine($"Digite o complemento (Aperte ENTER para vazio)");
                        // novoEnd.complemento = "casa";

                        // Console.WriteLine($"Este endereço é comercial? S/N");
                        // string endCom = Console.ReadLine().ToUpper();

                        // if (endCom == "S")
                        // {
                        //     novoEnd.endComercial = true;
                        // }
                        // else
                        // {
                        //     novoEnd.endComercial = false;
                        // }

                        // novaPf.endereco = novoEnd;

                        // listaPf.Add(novaPf);

                        // StreamWriter sw = new StreamWriter($"{novaPf.nome}.txt");
                        // sw.WriteLine(novaPf.nome);
                        // sw.Close();

                        // CRIAR ARQUIVO TXT

                        using (StreamWriter sw = new StreamWriter($"{novaPf.nome}.txt"))
                        {
                            sw.WriteLine($"{novaPf.nome}");
                        }

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso");
                        Thread.Sleep(3000);

                        Console.ResetColor();

                        break;

                    case "2":

                        Console.Clear();

//                         if (listaPf.Count > 0)
//                         {
                            
//                             foreach (PessoaFisica cadaPessoa in listaPf)
//                             {
//                                 Console.Clear();
//                                 Console.WriteLine(@$"
// Nome: {cadaPessoa.nome}
// Data de nascimento: {cadaPessoa.dataNascimento}
// CPF: {cadaPessoa.cpf}
// Rendimento: {cadaPessoa.rendimento}
// Endereço: {cadaPessoa.endereco.logradouro}, {cadaPessoa.endereco.numero}, {cadaPessoa.endereco.complemento}
// Data de nascimento: {cadaPessoa.dataNascimento}
// Taxa de imposto a ser paga é: {metodoPf.PegarImposto(cadaPessoa.rendimento).ToString("C")}
// ");                         
//                                 Console.WriteLine($"Aperte 'Enter' para continuar");
//                                 Console.ReadLine();
//                             }

//                         }
//                         else
//                         {
//                             Console.WriteLine($"Lista vazia!!");
//                             Thread.Sleep(3000);
//                         }


                            // LER AQUIVO TXT

                            using (StreamReader sr = new StreamReader("ryan.txt"))
                            {

                                string linha;
                                while ((linha = sr.ReadLine()) != null)
                                {
                                    Console.WriteLine($"{linha}");
                                }
                            }

                            Console.WriteLine($"Aperte 'Enter' para continuar");
                            Console.ReadLine();

                        break;

                    case "0":
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção inválida, por favor digete outra opção");
                        Thread.Sleep(2000);
                        break;
                }



            } while (opcaoPf != "0");

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


            metodoPj.Inserir(novaPj); 

            List<PessoaJuridica> listaPj = metodoPj.Ler();

            foreach (PessoaJuridica cadaItem in listaPj)
            {
            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj}");

// CNPJ válido: {metodoPj.ValidarCnpj(novaPj.cnpj)}

            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();

            BarraCarregamento("Finalizando ", 300);               
            }

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
