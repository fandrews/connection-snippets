// Driver Documentation: https://github.com/ServiceStack/ServiceStack.Redis
﻿using System;
using Elasticsearch.Net;


namespace ElasticsearchExample
{
	class MainClass
	{
		protected static IElasticLowLevelClient _client;

		public static void Main(string[] args)
		{
			var hosts = new[] {
				new Uri("https://iadd1-s10538-0.es.objectrocket.com:20538"),
				new Uri("https://iadd1-s10538-1.es.objectrocket.com:20538"),
				new Uri("https://iadd1-s10538-2.es.objectrocket.com:20538"),
				new Uri("https://iadd1-s10538-3.es.objectrocket.com:20538")
			};

			try
			{
				var connectionPool = new SniffingConnectionPool(hosts);
				var config = new ConnectionConfiguration(connectionPool)
					.BasicAuthentication("sooz", "xxxxxxxx");
				_client = new ElasticLowLevelClient(config);
				// TODO: Figure out format of a client-level action to trigger actual connection.
				_client.Ping((PingRequestParameters x, PingRequestParameters y) => x);
			}
			catch (Exception e) {
				Console.WriteLine("Error: " + e);
			}
			
			Console.WriteLine("Done!");
		}
	}
}
