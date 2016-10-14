using MongoDB.Bson;
using MongoDB.Driver;
using System;

protected static IMongoClient _client;
protected static IMongoDatabase _database;
protected static MongoClientSettings _settings;

namespace MongoReplicaSetExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
          Console.WriteLine("Hello, World!");

          _username = "sooz";
          _settings.Servers = ["syd-mongos0.objectrocket.com:12345"];
          _settings.ReplicaSetName = "replica_set_name";
          _credentials = new MongoCredentials('_username', "xxxxxxxx");
          _settings.CredentialsStore.Add(_username, _credentials);

          _client = new MongoClient(_settings);
          _database = _client.GetDatabase("db1");
        }
    }
}
