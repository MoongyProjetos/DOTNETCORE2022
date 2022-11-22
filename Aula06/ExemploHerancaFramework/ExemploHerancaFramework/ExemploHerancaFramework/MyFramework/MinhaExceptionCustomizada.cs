using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHerancaFramework.MyFramework
{
     public class MinhaExceptionCustomizada : Exception
    {
        public MinhaExceptionCustomizada(string message) : base(message)
        {
            var path = @"c:\temp\exceptions.log";
            var content = $"{Environment.NewLine} ERROR: {DateTime.Now} - {Message}";

            File.AppendAllText(path, content);
        }

        public MinhaExceptionCustomizada() : base()
        {
            var path = @"c:\temp\exceptions.log";
            var content = $"{Environment.NewLine} ERROR: {DateTime.Now} - {Message}";

            File.AppendAllText(path, content);
        }


        public MinhaExceptionCustomizada(string message, Exception inner) : base(message, inner)
        {
            var path = @"c:\temp\exceptions.log";
            var content = $"{Environment.NewLine} ERROR: {DateTime.Now} - {Message} - Detalhe: {inner.Message}";

            File.AppendAllText(path, content);
        }
    }
}
