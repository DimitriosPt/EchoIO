// <copyright file="SpotifyAuthorization.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SpotifyAPIWrapper
{
    using SpotifyAPI.Web;
    using System.Net;
    using System.Text;

    public class SpotifyAuthenticator
    {
        /// <summary>
        /// Gets a spotify access token given the stored client secrets.
        /// </summary>
        /// <returns>A spotify client with authentication completed.</returns>
        public async Task<SpotifyClient> GetAccessToken()
        {
            var config = SpotifyClientConfig
              .CreateDefault()
              .WithAuthenticator(new ClientCredentialsAuthenticator(Secrets.ClientID, Secrets.ClientSecret));

            var spotify = new SpotifyClient(config);

            return spotify;
        }
    }
}