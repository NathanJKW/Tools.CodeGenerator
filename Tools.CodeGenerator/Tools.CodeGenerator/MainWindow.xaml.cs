using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using System.Windows;

namespace Tools.CodeGenerator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var serviceCollection = new ServiceCollection();

            serviceCollection.AddFirstAttempt();

            Resources.Add("services", serviceCollection.BuildServiceProvider());
        }
    }
}