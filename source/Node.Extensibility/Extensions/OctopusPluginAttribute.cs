﻿using System;

namespace Octopus.Node.Extensibility.Extensions
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class OctopusPluginAttribute : Attribute, IOctopusExtensionMetadata
    {
        public OctopusPluginAttribute(string friendlyName, string author)
        {
            FriendlyName = friendlyName;
            Author = author;
        }

        public string FriendlyName { get; }
        public string Author { get; }
    }
}