﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Net;

namespace Octopus.Server.Extensibility.Extensions.Infrastructure.Web.Api
{
    public abstract class OctoResponse
    {
        readonly List<OctoCookie> cookies = new List<OctoCookie>();
        readonly IDictionary<string, IEnumerable<string>> headers = new Dictionary<string, IEnumerable<string>>();

        protected OctoResponse(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
        }

        public HttpStatusCode StatusCode { get; }


        public IReadOnlyDictionary<string, IEnumerable<string>> GetHeaders()
        {
            return new ReadOnlyDictionary<string, IEnumerable<string>>(headers);
        }

        public IReadOnlyList<OctoCookie> GetCookies()
        {
            return cookies;
        }

        public virtual OctoResponse WithCookie(OctoCookie cookie)
        {
            cookies.Add(cookie);
            return this;
        }

        public virtual OctoResponse WithHeader(string name, IEnumerable<string> value)
        {
            headers[name] = value;
            return this;
        }
    }

    public class OctoDataResponse : OctoResponse
    {
        public OctoDataResponse(object model, HttpStatusCode statusCode = HttpStatusCode.OK) : base(statusCode)
        {
            Model = model;
        }

        public Stream Body { get; set; }

        public object Model { get; }
    }

    public class OctoBadRequestResponse : OctoResponse
    {
        public OctoBadRequestResponse(params string[] errorMessages) : base(HttpStatusCode.BadRequest)
        {
            ErrorMessages = errorMessages;
        }

        public string[] ErrorMessages { get; }
    }

    public class OctoBadRequestWithDetailsResponse : OctoBadRequestResponse
    {
        public OctoBadRequestWithDetailsResponse(object details) : base("Request failed. Please check Details property for more information.")
        {
            Details = details;
        }

        public object Details { get; }
    }

    public class OctoRedirectResponse : OctoResponse
    {
        public OctoRedirectResponse(string url) : base(HttpStatusCode.Redirect)
        {
            Url = url;
        }

        public string Url { get; }
    }

    public class OctoUnauthorisedResponse : OctoResponse
    {
        public OctoUnauthorisedResponse() : base(HttpStatusCode.Unauthorized)
        {
        }
    }


}