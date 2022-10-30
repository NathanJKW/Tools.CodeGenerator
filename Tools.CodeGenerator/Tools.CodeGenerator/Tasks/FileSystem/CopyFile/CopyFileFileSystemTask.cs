using System;
using System.IO;
using Tools.CodeGenerator.Tasks.FileSystem.CopyFile.Exceptions;

namespace Tools.CodeGenerator.Tasks.FileSystem.CopyFile;

public class CopyFileFileSystemTask
{
    CopyFileFileSystemResult CopyFile(CopyFileFileSystemInput copyFileFileSystemInput)
    {
		//Validate Input
		try
		{
			copyFileFileSystemInput.Validate();
		}
		catch (Exception)
        {
            throw;
		}

        // Check if file exists & delete is requested
        if (File.Exists($@".\{copyFileFileSystemInput.DestiniationPath}") && copyFileFileSystemInput.OverWrite == true)
        {
            try
            {
                File.Delete($@".\{copyFileFileSystemInput.DestiniationPath}");
            }
            catch (Exception exception)
            {
                throw new CopyFileFileSystemTaskDependancyException(exception.Message, exception);
            }
        }
        else if (File.Exists($@".\{copyFileFileSystemInput.DestiniationPath}") && copyFileFileSystemInput.OverWrite == false)
        {
            return new CopyFileFileSystemResult { Sucssesful = false, FileAlreadyExists = true };
        }

        // Copy file
        try
        {
            File.Copy($@"{copyFileFileSystemInput.SourcePath}", $@"{copyFileFileSystemInput.DestiniationPath}");
            return new CopyFileFileSystemResult { Sucssesful = true, FileAlreadyExists = false };
        }
        catch (Exception exception)
        {
            throw new CopyFileFileSystemTaskDependancyException(exception.Message, exception);
        }
    }
}
