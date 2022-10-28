using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.CodeGenerator.Tasks.FileSystem.CreateDirectory.Exceptions;

public class CreateDirectoryFileSystemTaskException : Exception
{
    public CreateDirectoryFileSystemTaskException(string? message, Exception? innerException) 
        : base(message, innerException)
    {
    }
}
