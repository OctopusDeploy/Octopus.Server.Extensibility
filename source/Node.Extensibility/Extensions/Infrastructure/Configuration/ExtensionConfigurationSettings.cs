using Octopus.Node.Extensibility.HostServices.Mapping;

namespace Octopus.Node.Extensibility.Extensions.Infrastructure.Configuration
{
    public abstract class ExtensionConfigurationSettings<TConfiguration, TResource, TDocumentStore> : ConfigurationSettings<TConfiguration, TResource, TDocumentStore>
        where TConfiguration : ExtensionConfigurationDocument
        where TResource : ExtensionConfigurationResource
        where TDocumentStore : IConfigurationDocumentStore<TConfiguration>
    {
        protected ExtensionConfigurationSettings(TDocumentStore configurationDocumentStore) : base(configurationDocumentStore)
        {
        }
    }
}