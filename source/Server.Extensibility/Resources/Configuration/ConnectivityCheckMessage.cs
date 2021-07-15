using System;
using Newtonsoft.Json;

namespace Octopus.Server.Extensibility.Resources.Configuration
{
    public class ConnectivityCheckMessage
    {
        [JsonConstructor]
        internal ConnectivityCheckMessage(ConnectivityCheckMessageCategory category, string message)
        {
            Category = category;
            Message = message;
        }

        public ConnectivityCheckMessageCategory Category { get; }
        public string Message { get; }
    }
}