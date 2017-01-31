using System.ComponentModel.Composition;

namespace SimpleToster.Shell
{
    [Export]
    public partial class MainWindow
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }
    }
}