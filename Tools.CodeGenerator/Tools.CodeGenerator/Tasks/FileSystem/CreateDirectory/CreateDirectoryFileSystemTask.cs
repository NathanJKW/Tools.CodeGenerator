using System;
using System.IO;
using Tools.CodeGenerator.Tasks.FileSystem.CreateDirectory.Exceptions;

namespace Tools.CodeGenerator.Tasks.FileSystem.CreateDirectory;

public class CreateDirectoryFileSystemTask
{
    CreateDirectoryFileSystemResult CreateDirectory(CreateDirectoryFileSystemInput createDirectoryFileSystemInput)
    {
        // Validate Input
        try
        {
            createDirectoryFileSystemInput.Validate();
        }
        catch (Exception)
        {
            throw;
        }

        // Check if directory exists & delete if requested
        if (Directory.Exists($@".\{createDirectoryFileSystemInput.Path}") && createDirectoryFileSystemInput.OverWrite == true)
        {
            try
            {
                Directory.Delete($@".\{createDirectoryFileSystemInput.Path}", true);
            }
            catch (Exception exception)
            {
                throw new CreateDirectoryFileSystemTaskDependancyException(exception.Message, exception);
            }
        }
        else if (Directory.Exists($@".\{createDirectoryFileSystemInput.Path}") && createDirectoryFileSystemInput.OverWrite == false)
        {
            return new CreateDirectoryFileSystemResult { Sucssesful = false, DirectoryAlreadyExists = true };
        }

        // Create directory
        try
        {
            Directory.CreateDirectory($@".\{createDirectoryFileSystemInput.Path}");
            return new CreateDirectoryFileSystemResult { Sucssesful = true, DirectoryAlreadyExists = false };
        }
        catch (Exception exception)
        {
            throw new CreateDirectoryFileSystemTaskDependancyException(exception.Message, exception);
        }
    }
}
