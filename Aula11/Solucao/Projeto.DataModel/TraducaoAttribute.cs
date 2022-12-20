namespace Projeto.DataModel
{
    [AttributeUsage(AttributeTargets.All)]
    public class TraducaoAttribute : Attribute
    {
        private string _nome;
        public TraducaoAttribute(string nome)
        {
            _nome = nome;
        }
    }
}