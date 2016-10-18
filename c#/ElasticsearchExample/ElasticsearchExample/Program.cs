using System;
using System.Linq;
using Elasticsearch.Net;
using Nest;


namespace ElasticsearchExample
{
	class MainClass
	{
		protected static IElasticLowLevelClient _client;

		public static void Main(string[] args)
		{
			var hostString = "https://ord2-18107-0.es.objectrocket.com:18107,https://ord2-18107-1.es.objectrocket.com:18107,https://ord2-18107-2.es.objectrocket.com:18107,https://ord2-18107-3.es.objectrocket.com:18107";
			var hosts = hostString.Split(',').Select(x => new Uri(x)).ToArray();
			try
			{
				
				var connectionPool = new SniffingConnectionPool(hosts);
				var config = new ConnectionConfiguration(connectionPool)
					.BasicAuthentication("username", "password");
				_client = new ElasticLowLevelClient(config);
				var result = _client.Search<SearchResponse<object>>(new { size = 12 });
			}
			catch (Exception e)
			{
				Console.WriteLine("Error: " + e);
			}

			Console.WriteLine("Done!");
		}
	}
}
