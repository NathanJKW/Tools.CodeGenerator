using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;

namespace Tools.CodeGenerator
{
    public static class DependancyInjectionSetup
    {
        public static void AddFirstAttempt(this ServiceCollection serviceCollection)
        {
            serviceCollection.AddWpfBlazorWebView();
            serviceCollection.AddMudServices();
        }
    }
}
