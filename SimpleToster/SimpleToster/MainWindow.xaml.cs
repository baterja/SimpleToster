namespace SimpleToster.Shell
{
    using System.ComponentModel.Composition;

    [Export]
    public partial class MainWindow
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }
    }
}