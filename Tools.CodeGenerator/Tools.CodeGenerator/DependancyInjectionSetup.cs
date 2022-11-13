using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using Tools.CodeGenerator.Tasks.FileSystem.CopyFile;
using Tools.CodeGenerator.Tasks.FileSystem.CreateDirectory;

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
        }
    }
}
