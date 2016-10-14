// Assumes you have run 'npm install ioredis'
var Redis = require('ioredis');
var fs = require('fs');

//redis://bf36cdba2cc244d5b145f71c6ce4ae72.publb.rackspaceclouddb.com:6380
//CskHfrMmPGvdNxPBFKu4rQfhPvDK33brEJca

console.log('fs', fs.readFileSync('./ca/rackspace-ca-2016.pem'));

var client = new Redis({
    host: 'bf36cdba2cc244d5b145f71c6ce4ae72.publb.rackspaceclouddb.com',
    port: 6380,
    password: 'CskHfrMmPGvdNxPBFKu4rQfhPvDK33brEJca',
    tls: {
        ca: fs.readFileSync('./ca/rackspace-ca-2016.pem') // FIX: SSL ever fucking works!
    },
    lazyConnect: true
});

var ping = function(e) {
    var result = client.ping()
        .then(function() {
            console.log('Connected!');
        })
        .catch(function() {
            console.log('Ping failed');
        })
        .finally(function() {
            client.disconnect();
        });
};

client.connect()
    .then(ping)
    .catch(function(e) {
        console.log('Failed to connect: ', e);
    });
// ✓ https://objectrocket.com/docs/redis_node_examples.html
