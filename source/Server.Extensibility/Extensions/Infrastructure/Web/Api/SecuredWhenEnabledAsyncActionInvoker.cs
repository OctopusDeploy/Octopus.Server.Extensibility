﻿using System.Threading.Tasks;
using Octopus.Server.Extensibility.Extensions.Infrastructure.Configuration;

namespace Octopus.Server.Extensibility.Extensions.Infrastructure.Web.Api
{
    public class SecuredWhenEnabledAsyncActionInvoker<TAction, TConfigurationStore> : WhenEnabledAsyncActionInvoker<TAction, TConfigurationStore>
        where TAction : IAsyncApiAction
        where TConfigurationStore : IExtensionConfigurationStore
    {

        public SecuredWhenEnabledAsyncActionInvoker(TAction action, TConfigurationStore configurationStore) : base(action, configurationStore)
        {
        }

        public override Task<IOctoResponseProvider> ExecutionPrechecks(IOctoRequest request)
        {
            var veto = base.ExecutionPrechecks(request);
            if (veto != null)
                return veto;

            if (request.User == null)
            {
                return Task.FromResult<IOctoResponseProvider>(new BaseResponseRegistration.WrappedResponse(new OctoUnauthorisedResponse()));
            }

            return null;
        }
    }
}