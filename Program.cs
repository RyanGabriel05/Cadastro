// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using CadastroPessoa_FS1.Classes;

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

bool dataValida = metodoPf.ValidarDataNascimento(novaPf.dataNascimento);

Console.WriteLine(@$"
Nome: {novaPf.nome}
Data de nascimento: {novaPf.dataNascimento}
CPF: {novaPf.cpf}
Rendimento: {novaPf.rendimento}
Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}, {novaPf.endereco.complemento}
Maior de idade: {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}
");
