﻿using System;

namespace Octopus.Server.Extensibility.Diagnostics
{
    public class CorrelationId
    {
        public CorrelationId()
        {
            Id = Guid.NewGuid().ToString("N");
        }

        public CorrelationId(string id)
        {
            Id = id;
        }

        public string Id { get; }

        public override string ToString()
        {
            return Id;
        }
    }
}