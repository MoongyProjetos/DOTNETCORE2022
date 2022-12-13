using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfServiceExemplo
{
    [ServiceContract]
    public interface IPessoaService
    {
        [OperationContract]
        Pessoa ObterPessoaPorNome(string nome);
    }


    [DataContract]
    public class Pessoa
    {
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public DateTime DataNascimento { get; set; }
    }
}
