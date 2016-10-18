// Example Documentation: https://objectrocket.com/docs/mongodb_node_examples.html#installation
// Driver Dcoumentation: https://github.com/mongodb/node-mongodb-native
// Ensure you have run 'npm install mongodb'
var MongoClient = require('mongodb').MongoClient;

var username = 'sooz';
var password = 'xxxxxxxx';
var hosts = 'iad-c11-1.objectrocket.com:48152,iad-c11-0.objectrocket.com:48152';
var database = '/test_db';
var replicaSet = '99fc32e3c05e03597a692c4fd9a9d162';
var connectionString = 'mongodb://' + username + ':' + password + '@' + hosts + database + '?replicaSet=' + replicaSet;

MongoClient.connect(connectionString, function(err, db) {
  if (err) {
    console.log('Error: ', err);
  } else {
    console.log('Connected!');
    process.exit();
  }
});
