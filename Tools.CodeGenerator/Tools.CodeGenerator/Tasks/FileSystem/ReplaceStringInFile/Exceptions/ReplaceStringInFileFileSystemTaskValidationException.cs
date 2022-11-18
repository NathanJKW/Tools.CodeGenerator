using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.CodeGenerator.Tasks.FileSystem.ReplaceStringInFile.Exceptions;

public class ReplaceStringInFileFileSystemTaskValidationException : Exception
{
    public ReplaceStringInFileFileSystemTaskValidationException(string? message, Exception? innerException) 
        : base(message, innerException)
    {
    }
}
