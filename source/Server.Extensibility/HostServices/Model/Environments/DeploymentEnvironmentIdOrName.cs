﻿using Octopus.Server.Extensibility.TinyTypes;

namespace Octopus.Server.Extensibility.HostServices.Model.Environments
{
    public class DeploymentEnvironmentIdOrName : CaseInsensitiveStringTinyType
    {
        public DeploymentEnvironmentIdOrName(string value) : base(value)
        {
        }
    }
}