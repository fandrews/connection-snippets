# Driver Documentation: https://www.elastic.co/guide/en/elasticsearch/client/ruby-api/current/_the_ruby_client.htm
# Ensure you have run 'gem install elasticsearch'
require 'elasticsearch'

settings = {
    port: '20538',
    user: 'sooz',
    password: 'xxxxxxxx',
    scheme: 'https'
}

begin
  client = Elasticsearch::Client.new hosts:[
        settings.merge(host: 'iad1-10538-0.es.objectrocket.com'),
        settings.merge(host: 'iad1-10538-1.es.objectrocket.com'),
        settings.merge(host: 'iad1-10538-2.es.objectrocket.com'),
        settings.merge(host: 'iad1-10538-3.es.objectrocket.com')
    ], log: true, retry_on_failure: true
  puts client.info
  client_ping = client.ping
  if client_ping
    puts 'Connected!'
  else
    raise 'Ping failed'
  end
rescue => e
  puts "Error: #{e}"
end
