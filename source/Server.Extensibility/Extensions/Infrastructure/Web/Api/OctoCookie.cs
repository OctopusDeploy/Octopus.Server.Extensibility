using System;

namespace Octopus.Server.Extensibility.Extensions.Infrastructure.Web.Api
{
    public class OctoCookie
    {
        public OctoCookie(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>Gets or sets the name of the cookie.</summary>
        /// <returns>The name of the cookie.</returns>
        public string Name { get; set; }

        /// <summary>Gets or sets the cookie value.</summary>
        /// <returns>The value of the cookie.</returns>
        public string Value { get; set; }

        /// <summary>Gets or sets the domain to associate the cookie with.</summary>
        /// <returns>The domain to associate the cookie with.</returns>
        public string? Domain { get; set; }

        /// <summary>Gets or sets the cookie path.</summary>
        /// <returns>The cookie path.</returns>
        public string Path { get; set; } = "/";

        /// <summary>
        /// Gets or sets the expiration date and time for the cookie.
        /// </summary>
        /// <returns>The expiration date and time for the cookie.</returns>
        public DateTimeOffset? Expires { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether to transmit the cookie using Secure Sockets Layer (SSL)--that is, over
        /// HTTPS only.
        /// </summary>
        /// <returns>true to transmit the cookie only over an SSL connection (HTTPS); otherwise, false.</returns>
        public bool Secure { get; set; }

        /// <summary>
        /// Gets or sets the value for the SameSite attribute of the cookie.
        /// If not set (null), the web portal's configuration is used to determine the value.
        /// </summary>
        /// <returns>The <see cref="SameSiteMode" /> representing the enforcement mode of the cookie.</returns>
        public SameSiteMode? SameSite { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether a cookie is accessible by client-side script.
        /// </summary>
        /// <returns>true if a cookie must not be accessible by client-side script; otherwise, false.</returns>
        public bool HttpOnly { get; set; }

        /// <summary>Gets or sets the max-age for the cookie.</summary>
        /// <returns>The max-age date and time for the cookie.</returns>
        public TimeSpan? MaxAge { get; set; }
    }
}
