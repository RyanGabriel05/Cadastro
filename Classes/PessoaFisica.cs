using CadastroPessoa_FS1.interfaces;

namespace CadastroPessoa_FS1.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica       
    {

        public string ?cpf { get; set; }        

        public DateTime ?dataNascimento { get; set; }
        
        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }

        public override float PegarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}