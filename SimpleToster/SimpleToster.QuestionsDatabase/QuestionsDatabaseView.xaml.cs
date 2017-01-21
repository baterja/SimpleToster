namespace SimpleToster.QuestionsDatabase
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