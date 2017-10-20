﻿using Nevermore.Contracts;
using Octopus.Node.Extensibility.Metadata;

namespace Octopus.Node.Extensibility.Extensions.Infrastructure.Configuration
{
    public abstract class ExtensionConfigurationDocument : IDocument
    {
        protected ExtensionConfigurationDocument()
        {
        }

        protected ExtensionConfigurationDocument(string name, string extensionAuthor, string configurationSchemaVersion)
        {
            Name = name;
            ExtensionAuthor = extensionAuthor;
            ConfigurationSchemaVersion = configurationSchemaVersion;
        }

        public string Id { get; set; }

        [ReadOnly]
        public string Name { get; set; }

        [ReadOnly]
        public string ExtensionAuthor { get; set; }

        [ReadOnly]
        public string ConfigurationSchemaVersion { get; set; }

        public bool IsEnabled { get; set; }
    }
}