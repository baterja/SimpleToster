using System.ComponentModel.Composition;
using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using SimpleToster.Shared;

namespace SimpleToster.Configuration
{
    [ModuleExport(typeof(ConfigurationModule), InitializationMode = InitializationMode.WhenAvailable)]
    public class ConfigurationModule : IModule
    {
        private readonly IRegionManager regionManager;

        [ImportingConstructor]
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