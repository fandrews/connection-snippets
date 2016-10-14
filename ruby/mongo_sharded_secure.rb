# Connecting to a sharded instance using SSL:
# Make sure to change the port number when using an SSL connection.

#!/usr/bin/env ruby
require 'mongo'

# Turn off debug-mode
Mongo::Logger.logger.level = Logger::WARN

client_host = ['iad1-mongos0.objectrocket.com:266073']
client_options = {
  database: 'tedst_db',
  user: 'sooz',
  password: 'xxxxxxxx',
  ssl: true
}

client = Mongo::Client.new(client_host, client_options)

puts('Client Connection: ')
puts(client.cluster.inspect)
puts
puts('Collection Names: ')
puts(client.database.collection_names)
