
// Require mongodb
var MongoClient = require('mongodb').MongoClient;

MongoClient.connect("mongodb://sooz:xxxxxxxx@iad-c11-1.objectrocket.com:48152,iad-c11-0.objectrocket.com:48152/test_db?replicaSet=99fc32e3c05e03597a692c4fd9a9d162", function(err, db) {
  if (err) {
    console.dir(err);
  } else {
    console.log("Connected!");
    process.exit();
  }
});
