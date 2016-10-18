// Driver Documentation: https://docs.mongodb.com/getting-started/csharp/client/
﻿using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ShardedMongoExample
{
	class MainClass
	{

		protected static IMongoClient _client;
		protected static IMongoDatabase _database;
		protected static IAsyncCursor<BsonDocument> _collections;

		public static void Main(string[] args)
		{
			string _host = "iad1-mongos0.objectrocket.com:26073";
			string _username = "sooz";
			string _password = "xxxxxxxx";
			string _databaseName = "test_db";
			string _connectionString = "mongodb://" + _username + ":" + _password + "@" + _host + "/" + _databaseName + "?ssl=true";

			try
			{
				_client = new MongoClient(_connectionString);
				_database = _client.GetDatabase(_databaseName);

				Console.WriteLine("Database: " + _database);

				_collections = _database.ListCollections();
				_collections.MoveNext();

				Console.Write("Collections:");

				foreach (var doc in _collections.Current)
				{
					Console.WriteLine(doc);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("Error: " + e);
			}

			Console.WriteLine("Done!");
		}
	}
}
