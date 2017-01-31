using System.ComponentModel.Composition;
using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using SimpleToster.QuestionsDatabase.VVM;
using SimpleToster.Shared;

namespace SimpleToster.QuestionsDatabase
{
    [ModuleExport(typeof(QuestionsDatabaseModule), InitializationMode = InitializationMode.WhenAvailable)]
    public class QuestionsDatabaseModule : IModule
    {
        private readonly IRegionManager regionManager;

        [ImportingConstructor]
        public QuestionsDatabaseModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            this.regionManager.RegisterViewWithRegion(RegionNames.QuestionsDatabaseRegion, typeof(QuestionsDatabaseView));
        }
    }
}