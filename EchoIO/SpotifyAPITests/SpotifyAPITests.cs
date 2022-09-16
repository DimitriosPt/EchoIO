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

            Console.WriteLine(response);
        }
	}
}