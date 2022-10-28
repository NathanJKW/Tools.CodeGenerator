using Tools.CodeGenerator.Tasks.FileSystem.CreateDirectory.Exceptions;

namespace Tools.CodeGenerator.Tasks.FileSystem.CreateDirectory;

public class CreateDirectoryFileSystemInput
{
    public string Path { get; set; } = "";
    public bool OverWrite { get; set; } = false;

    public void Validate()
    {
        if (string.IsNullOrWhiteSpace(Path))
            throw new CreateDirectoryFileSystemTaskValidationException("Path is null or empty");
    }
}
