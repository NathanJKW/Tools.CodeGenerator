using System;
using System.IO;
using Tools.CodeGenerator.Tasks.FileSystem.ReplaceStringInFile.Exceptions;

namespace Tools.CodeGenerator.Tasks.FileSystem.ReplaceStringInFile;

public class ReplaceStringInFileFileSystemTask
{
    public ReplaceStringInFileFileSystemResult ExecuteTask(ReplaceStringInFileFileSystemInput replaceStringInFileFileSystemInput)
    {
        // Validate Input
        try
        {
            replaceStringInFileFileSystemInput.Validate();
        }
        catch (Exception)
        {
            throw;
        }

        if (!File.Exists(replaceStringInFileFileSystemInput.Path))
            throw new ReplaceStringInFileFileSystemTaskException("File does not exist.", null);

        string fileString = File.ReadAllText(replaceStringInFileFileSystemInput.Path);

        fileString = fileString.Replace(replaceStringInFileFileSystemInput.StringToFind, replaceStringInFileFileSystemInput.StringToReplace);

        try
        {
            File.WriteAllText(replaceStringInFileFileSystemInput.Path, fileString);
        }
        catch (Exception exception)
        {

            throw new ReplaceStringInFileFileSystemTaskException("Faile to write to file.", exception);
        }

        var result = new ReplaceStringInFileFileSystemResult();
        return result;
    }
}
