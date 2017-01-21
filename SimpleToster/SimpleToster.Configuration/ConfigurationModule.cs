namespace SimpleToster.Configuration
{
    using Prism.Modularity;
    using Prism.Regions;

    using SimpleToster.Shared;

    public class ConfigurationModule : IModule
    {
        private readonly IRegionManager regionManager;

        public ConfigurationModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            this.regionManager.RegisterViewWithRegion(RegionNames.ConfigurationRegion, typeof(ConfigurationView));
        }
    }
}