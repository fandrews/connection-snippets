// Driver Documentation: https://github.com/StackExchange/StackExchange.Redis
using System;
using StackExchange.Redis;

namespace RedisExample
{
	class MainClass
	{
		protected static IConnectionMultiplexer _client;

		public static void Main(string[] args)
		{
			try
			{
				var host = "bf36cdba2cc244d5b145f71c6ce4ae72.publb.rackspaceclouddb.com:6379";
				var password = "CskHfrMmPGvdNxPBFKu4rQfhPvDK33brEJca";
				// TODO: Connection never completes; just hangs.
				_client = ConnectionMultiplexer.Connect(host + ",password=" + password ",connectRetry=5,abortConnect=false");
				Console.WriteLine("redis", _client);
				//IDatabase db = redis.GetDatabase();
			}
			catch (Exception e)
			{
				Console.WriteLine("Error:" + e.ToString());
			}
		}
	}
}
