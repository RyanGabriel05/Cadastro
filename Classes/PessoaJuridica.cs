using CadastroPessoa_FS1.interfaces;

namespace CadastroPessoa_FS1.Classes
{
    public class PessoaJuridica : Pessoa , IPessoaJuridica
    {

        public string ?cnpj { get; set; }
        
        public string ?razaoSocial { get; set; }
        
        

        public override float PegarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}