using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.DataModel
{
    [AttributeUsage(AttributeTargets.Property)]
    public class AtributoCustomizado : Attribute
    {
        private int _revision { get; set; }
        private string _emailAddress { get; set; }

        public AtributoCustomizado(int revision, string emailAddress)
        {
            _revision = revision;
            _emailAddress = emailAddress;
        }
    }
}
