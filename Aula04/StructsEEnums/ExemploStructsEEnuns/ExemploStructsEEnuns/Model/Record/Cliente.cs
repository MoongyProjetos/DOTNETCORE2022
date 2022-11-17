using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploStructsEEnums.Model.Record
{

    //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record
    public record Cliente
    {
        public string FirstName { get; init; } = default!;
        public string LastName { get; init; } = default!;
    };
}
