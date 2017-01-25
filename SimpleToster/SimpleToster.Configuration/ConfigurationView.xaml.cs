using System.ComponentModel.Composition;

namespace SimpleToster.Configuration
{
    [Export]
    public partial class ConfigurationView
    {
        public ConfigurationView()
        {
            InitializeComponent();
        }
    }
}