namespace SimpleToster.QuestionsDatabase
{
    using Prism.Modularity;
    using Prism.Regions;

    using SimpleToster.Shared;

    public class QuestionsDatabaseModule : IModule
    {
        private readonly IRegionManager regionManager;

        public QuestionsDatabaseModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            this.regionManager.RegisterViewWithRegion(RegionNames.ConfigurationRegion, typeof(QuestionsDatabaseView));
        }
    }
}