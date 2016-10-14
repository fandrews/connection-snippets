# Ensure you have run 'gem install elasticsearch'
require 'elasticsearch'

settings = {
    port: '20538',
    user: 'sooz',
    password: 'xxxxxxxx',
    scheme: 'https'
}

begin
    client = Elasticsearch::Client.new hosts: [
        settings.merge(host: 'iad1-10538-0.es.objectrocket.com'),
        settings.merge(host: 'iad1-10538-1.es.objectrocket.com'),
        settings.merge(host: 'iad1-10538-2.es.objectrocket.com'),
        settings.merge(host: 'iad1-10538-3.es.objectrocket.com')
    ], log: true, retry_on_failure: true
    puts client.info
    clientPing = client.ping
    if clientPing
        puts 'Connected!'
    else
        raise 'Ping failed'
    end
rescue => e
    puts "Error: #{e}"
end

# {
#   host: 'iad1-10538-0.es.objectrocket.com,iad1-10538-1.es.objectrocket.com,iad1-10538-2.es.objectrocket.com',
#   port: '20538',
#   user: 'sooz',
#   password: 'xxxxxxxx',
#   scheme: 'https'}

# settings.merge({ host: 'iad1-10538-0.es.objectrocket.com'}),
# settings.merge({ host: 'iad1-10538-1.es.objectrocket.com'}),
# settings.merge({ host: 'iad1-10538-2.es.objectrocket.com'}),
# settings.merge({ host: 'iad1-10538-3.es.objectrocket.com'})

# https://iad1-10538-0.es.objectrocket.com:20538,https://iad1-10538-1.es.objectrocket.com:20538,https://iad1-10538-2.es.objectrocket.com:20538,https://iad1-10538-3.es.objectrocket.com:20538
# https://github.com/elastic/elasticsearch-ruby/tree/master/elasticsearch-extensions
# https://www.elastic.co/guide/en/elasticsearch/client/ruby-api/current/_the_ruby_client.html
