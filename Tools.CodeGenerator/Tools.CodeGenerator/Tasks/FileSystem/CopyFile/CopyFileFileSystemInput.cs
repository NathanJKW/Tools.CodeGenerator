using Tools.CodeGenerator.Tasks.FileSystem.CopyFile.Exceptions;

namespace Tools.CodeGenerator.Tasks.FileSystem.CopyFile;

public class CopyFileFileSystemInput
{
    public string SourcePath { get; set; } = "";
    public string DestiniationPath { get; set; } = "";
    public bool OverWrite { get; set; } = false;

    public void Validate()
    {
        if (string.IsNullOrWhiteSpace(SourcePath))
            throw new CopyFileFileSystemTaskValidationException("SourcePath is null or empty");

        if (string.IsNullOrWhiteSpace(DestiniationPath))
            throw new CopyFileFileSystemTaskValidationException("DestiniationPath is null or empty");
    }
}
