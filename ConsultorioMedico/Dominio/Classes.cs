using System.Collections.Generic;

namespace ConsultorioMedico.Dominio
{
    public abstract class Pessoa
    {
        protected string Nome { get; set; }
        protected Credencial Credencial { get; set; }
    }

    public class Atendente : Pessoa
    {

    }

    public class Paciente : Pessoa
    {
        public string CPF { get; private set; }
        public Endereco Endereco { get; private set; }
    }

    public class Medico : Pessoa
    {
        public string CRM { get; private set; }
    }

    public class Endereco
    {
        public string CEP { get; private set; }
        public string Rua { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
    }

    public class Credencial
    {
        public string NomeUsuario { get; private set; }
        public string Senha { get; private set; }
    }

    public class PlanoSaude
    {
        public string Nome { get; private set; }
        public IList<Cobertura> Coberturas { get; private set; }
    }

    public class Cobertura
    {
        public IList<Exame> Exames { get; private set; } 
    }

    public class Exame
    {
        public string Nome { get; private set; }
    }

    public class AgendamentoExame
    {
        public Exame Exame { get; private set; }
        public Paciente Paciente { get; private set; }
        public Resultado Resultado { get; private set; }
        public Medico MedicoResponsavel { get; private set; }

        public void AgendarExame(Exame exame)
        {
            
        }
    }

    public class Resultado
    {
        
    }
}