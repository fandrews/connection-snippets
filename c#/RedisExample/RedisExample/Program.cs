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
				_client = ConnectionMultiplexer.Connect("bf36cdba2cc244d5b145f71c6ce4ae72.publb.rackspaceclouddb.com:6379,password=CskHfrMmPGvdNxPBFKu4rQfhPvDK33brEJca,allowAdmin=true,connectRetry=5,abortConnect=false");
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