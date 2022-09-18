using EchoIO;
using System.Net;

namespace SpotifyAPITests
{
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

		[Test]
		public void TestBasicGetRequest()
		{
			var id = "4aawyAB9vmqN3uQ7FjRGTy";

            var url = $"https://api.spotify.com/v1/search/";

			var client = new HttpClient();
			client.BaseAddress = new Uri(url);
           
			var response = client.GetAsync(id).Result;

			var albumReq = new SpotifyAPI.Web.AlbumRequest();

			albumReq.BuildQueryParams();

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
		}
	}
}