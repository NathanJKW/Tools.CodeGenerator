using Tools.CodeGenerator.Tasks.FileSystem.CreateDirectory.Exceptions;

namespace Tools.CodeGenerator.Tasks.FileSystem.ReplaceStringInFile;

public class ReplaceStringInFileFileSystemInput
{
    public string Path { get; set; }
    public string StringToFind { get; set; }
    public string StringToReplace { get; set; }

    public void Validate()
    {
        if (string.IsNullOrWhiteSpace(Path))
            throw new CreateDirectoryFileSystemTaskValidationException("Path is null or empty");

        if (string.IsNullOrWhiteSpace(StringToFind))
            throw new CreateDirectoryFileSystemTaskValidationException("StringToFind is null or empty");

        if (string.IsNullOrWhiteSpace(StringToReplace))
            throw new CreateDirectoryFileSystemTaskValidationException("StringToReplace is null or empty");
    }
}
