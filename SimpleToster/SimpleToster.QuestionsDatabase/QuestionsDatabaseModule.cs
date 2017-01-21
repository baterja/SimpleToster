namespace SimpleToster.QuestionsDatabase
{
    using System.ComponentModel.Composition;

    using Prism.Mef.Modularity;
    using Prism.Modularity;
    using Prism.Regions;

    using SimpleToster.Shared;

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
            this.regionManager.RegisterViewWithRegion(
                RegionNames.QuestionsDatabaseRegion,
                typeof(VVM.QuestionsDatabaseView));
        }
    }
}