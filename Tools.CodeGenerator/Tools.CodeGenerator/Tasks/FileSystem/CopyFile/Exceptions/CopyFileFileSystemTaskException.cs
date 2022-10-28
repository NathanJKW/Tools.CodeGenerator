using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.CodeGenerator.Tasks.FileSystem.CopyFile.Exceptions;

public class CopyFileFileSystemTaskException : Exception
{
    public CopyFileFileSystemTaskException(string? message, Exception? innerException) 
        : base(message, innerException)
    {
    }
}
