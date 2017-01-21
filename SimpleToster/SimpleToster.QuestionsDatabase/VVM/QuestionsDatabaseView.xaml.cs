namespace SimpleToster.QuestionsDatabase.VVM
{
    using System.ComponentModel.Composition;

    [Export]
    public partial class QuestionsDatabaseView
    {
        public QuestionsDatabaseView()
        {
            this.InitializeComponent();
        }
    }
}