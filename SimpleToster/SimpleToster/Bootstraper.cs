namespace SimpleToster.Shell
{
    using System.Windows;

    using Microsoft.Practices.Unity;

    using Prism.Modularity;
    using Prism.Unity;

    using SimpleToster.Configuration;
    using SimpleToster.QuestionsDatabase;

    public class Bootstrapper : UnityBootstrapper
    {
        protected override void ConfigureModuleCatalog()
        {
            this.ModuleCatalog.AddModule(
                new ModuleInfo
                    {
                        ModuleName = nameof(ConfigurationModule),
                        ModuleType = typeof(ConfigurationModule).AssemblyQualifiedName,
                        InitializationMode = InitializationMode.WhenAvailable
                    });

            this.ModuleCatalog.AddModule(
                new ModuleInfo
                    {
                        ModuleName = nameof(QuestionsDatabaseModule),
                        ModuleType = typeof(QuestionsDatabaseModule).AssemblyQualifiedName,
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