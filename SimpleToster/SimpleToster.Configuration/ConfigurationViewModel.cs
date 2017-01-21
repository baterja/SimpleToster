namespace SimpleToster.Configuration
{
    using System.ComponentModel.Composition;

    [Export]
    internal class ConfigurationViewModel
    {
        public string Test { get; set; } = "Test";
    }
}