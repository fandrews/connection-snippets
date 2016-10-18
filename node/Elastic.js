// Example Documentation: https://objectrocket.com/docs/elastic_node_examples.html
// Driver Example: https://www.elastic.co/guide/en/elasticsearch/client/javascript-api/current/index.html
// Assumes you have run 'npm install elasticsearch'
var elasticsearch = require('elasticsearch');

var auth = 'sooz:xxxxxxxx';
var port = 20538;
var protocol = 'https';
var hostUrls = [
    'iad1-10538-0.es.objectrocket.com',
    'iad1-10538-1.es.objectrocket.com',
    'iad1-10538-2.es.objectrocket.com',
    'iad1-10538-3.es.objectrocket.com'
];
var hosts = hostUrls.map(function(host) {
    return {
        protocol: protocol,
        host: host,
        port: port,
        auth: auth
    };
});

var client = new elasticsearch.Client({
    hosts: hosts
});

client.ping({
    requestTimeout: 5000
}, function(error) {
    if (error) {
        console.trace('Error:', error);
    } else {
        console.log('Connected!');
    }
    // on finish
    client.close();
});
