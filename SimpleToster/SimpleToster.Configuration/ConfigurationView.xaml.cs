namespace SimpleToster.Configuration
{
    using System.ComponentModel.Composition;

    [Export]
    public partial class ConfigurationView
    {
        public ConfigurationView()
        {
            this.InitializeComponent();
        }
    }
}