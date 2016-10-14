using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoReplicaSetExample
{
	class MainClass
	{

		protected static IMongoClient _client;
		protected static IMongoDatabase _database;
		protected static IAsyncCursor<BsonDocument> _collections;

		public static void Main(string[] args)
		{
			string _hosts = "iad-c11-1.objectrocket.com:48152,iad-c11-0.objectrocket.com:48152";
			string _username = "sooz";
			string _password = "xxxxxxxx";
			string _replicaSet = "99fc32e3c05e03597a692c4fd9a9d162";
			string _databaseName = "test_db";
			string _connectionString = "mongodb://" + _username + ":" + _password + "@" + _hosts + "/" + _databaseName + "?replicaSet=" + _replicaSet;

			// Maybe update connection string to include DB?

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
