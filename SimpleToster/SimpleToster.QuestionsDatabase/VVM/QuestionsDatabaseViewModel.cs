using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using SimpleToster.QuestionsDatabase.Properties;
using SimpleToster.Shared;
using SimpleToster.Shared.Interfaces;

namespace SimpleToster.QuestionsDatabase.VVM
{
    [Export]
    internal class QuestionsDatabaseViewModel : ViewModelBase
    {
        public QuestionsDatabaseViewModel()
        {
            var scanner = new QuestionnairesDirectoryScanner(Settings.Default.QuestionnairesFolder);
            var fileNames = scanner.GetFileNames();
            this.QuestionnairesFiles.AddRange(fileNames);
        }

        public ObservableCollection<string> QuestionnairesFiles { get; } = new ObservableCollection<string>();

        public ObservableCollection<IQuestionnaire<IQuestion>> QuestionairesCollection { get; } =
            new ObservableCollection<IQuestionnaire<IQuestion>>();

        public string SelectedQuestionnaireFileName { get; set; }
    }
}