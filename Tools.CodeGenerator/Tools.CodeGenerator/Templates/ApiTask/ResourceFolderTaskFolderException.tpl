using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace {$NameSpace}.Exceptions;

public class {$ClassName} : Exception
{
    public {$ClassName}(string? message, Exception? innerException) 
        : base(message, innerException)
    {
    }
}
