﻿using System;
using System.Collections.Generic;

namespace Octopus.Server.Extensibility.HostServices.Model
{
    public class LinkCollection : Dictionary<string, Href>
    {
        public LinkCollection()
            : base(StringComparer.OrdinalIgnoreCase)
        {
        }

        public new LinkCollection Add(string name, Href value)
        {
            base.Add(name, value);
            return this;
        }

        public static LinkCollection Self(Href self)
        {
            return new LinkCollection().Add("Self", self);
        }
    }
}