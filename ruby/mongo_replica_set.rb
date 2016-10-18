# Example Documentation: https://objectrocket.com/docs/mongodb_ruby_examples.html
# Driver Documentation: https://docs.mongodb.com/ruby-driver/master/

# Connecting to a replica set:
# The client has auto-discovery that will find all members of the replica set
# if not all are provided.

# !/usr/bin/env ruby
require 'mongo'

# Turn off debug-mode
Mongo::Logger.logger.level = Logger::WARN

client_host = ['iad-c11-1.objectrocket.com:48152,iad-c11-0.objectrocket.com:48152']
client_options = {
  database: 'test_db',
  replica_set: '99fc32e3c05e03597a692c4fd9a9d162',
  user: 'sooz',
  password: 'xxxxxxxx'
}

client = Mongo::Client.new(client_host, client_options)

puts('Client Connection: ')
puts(client.cluster.inspect)
puts
puts('Collection Names: ')
puts(client.database.collection_names)
