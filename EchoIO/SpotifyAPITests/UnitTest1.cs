using EchoIO;

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
	}
}