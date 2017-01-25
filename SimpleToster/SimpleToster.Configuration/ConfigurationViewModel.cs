using System.ComponentModel.Composition;

namespace SimpleToster.Configuration
{
    [Export]
    internal class ConfigurationViewModel
    {
        public string Test { get; set; } = "Test";
    }
}