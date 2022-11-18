using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using Tools.CodeGenerator.Tasks.FileSystem.CopyFile;
using Tools.CodeGenerator.Tasks.FileSystem.CreateDirectory;
using Tools.CodeGenerator.Tasks.FileSystem.ReplaceStringInFile;

namespace Tools.CodeGenerator
{
    public static class DependancyInjectionSetup
    {
        public static void AddFirstAttempt(this ServiceCollection serviceCollection)
        {
            serviceCollection.AddWpfBlazorWebView();
            serviceCollection.AddMudServices();
            serviceCollection.AddTransient<CopyFileFileSystemTask>();
            serviceCollection.AddTransient<CreateDirectoryFileSystemTask>();
            serviceCollection.AddTransient<ReplaceStringInFileFileSystemTask>();
        }
    }
}
