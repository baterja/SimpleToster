namespace SimpleToster.Shell
{
    using System.Windows;

    using Microsoft.Practices.Unity;

    using Prism.Modularity;
    using Prism.Unity;

    using SimpleToster.Configuration;

    public class Bootstrapper : UnityBootstrapper
    {
        protected override void ConfigureModuleCatalog()
        {
            this.ModuleCatalog.AddModule(
                new ModuleInfo
                    {
                        ModuleName = nameof(ConfigarationModule),
                        ModuleType = typeof(ConfigarationModule).AssemblyQualifiedName,
                        InitializationMode = InitializationMode.WhenAvailable
                    });
        }

        protected override DependencyObject CreateShell()
        {
            return this.Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}