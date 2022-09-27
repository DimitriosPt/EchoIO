// <copyright file="SpotifyAPITests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SpotifyAPITests
{
    using System.Net;
    using EchoIO;
    using static SpotifyAPI.Web.SearchRequest;

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// A simple test to ensure retrieval of our secrets.
        /// </summary>
        [Test]
        public void TestClientSecretRetrieval()
        {
            Assert.That(Secrets.ClientSecret, Is.Not.Null);
            Assert.That(Secrets.ClientID, Is.Not.Null);
        }

        /// <summary>
        /// Tests submitting a get request for album information.
        /// </summary>
        [Test]
        public void TestBasicGetRequest()
        {
            var id = "4aawyAB9vmqN3uQ7FjRGTy";

            var url = $"https://api.spotify.com/v1/search/";

            var client = new HttpClient();
            client.BaseAddress = new Uri(url);

            var response = client.GetAsync(id).Result;

            var albumReq = new SpotifyAPI.Web.AlbumRequest();

            _ = albumReq.BuildQueryParams();

            Console.WriteLine(response);
        }

        /// <summary>
        /// A live tests that retrieves an OAuth token given the local secrets.
        /// </summary>
        [Test]
        public async Task TestGetSpotifyClient()
        {
            var authorizer = new SpotifyAPIWrapper.SpotifyAuthenticator();
            var client = await authorizer.GetAccessToken();

            Assert.That(client, Is.Not.Null);

            var album = await client.Albums.Get("4aawyAB9vmqN3uQ7FjRGTy");
            Assert.That(album, Is.Not.Null);
            Assert.That(album.Artists.First().Name, Is.EqualTo("Pitbull").IgnoreCase);
        }

        /// <summary>
        /// A live tests that uses the search capability of the Spotify API to retrieve artist albums.
        /// </summary>
        [Test]
        public async Task TestSearchArtist()
        {
            var authorizer = new SpotifyAPIWrapper.SpotifyAuthenticator();
            var client = await authorizer.GetAccessToken();

            Types types = Types.Artist;

            string bandName = "Rush";

            var response = await client.Search.Item(new SpotifyAPI.Web.SearchRequest(types, bandName));

            Assert.That(response, Is.Not.Null);
            Assert.That(bandName, Is.EqualTo(response.Artists?.Items?.First().Name));
        }
    }
}