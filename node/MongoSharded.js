
// Require mongodb
var MongoClient = require('mongodb').MongoClient;

MongoClient.connect("mongodb://sooz:xxxxxxxx@iad1-mongos0.objectrocket.com:26073/test_db?ssl=true", function(err, db) {
  if (err) {
    console.dir(err);
  } else {
    console.log("Connected!");
    process.exit();
  }
});
