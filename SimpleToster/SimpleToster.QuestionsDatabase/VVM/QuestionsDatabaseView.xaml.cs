using System.ComponentModel.Composition;

namespace SimpleToster.QuestionsDatabase.VVM
{
    [Export]
    public partial class QuestionsDatabaseView
    {
        public QuestionsDatabaseView()
        {
            this.InitializeComponent();
        }
    }
}