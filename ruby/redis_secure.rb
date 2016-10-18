# Driver Documentation: https://github.com/redis/redis-rb
# Ensure you have run 'gem install redis'
require 'redis'

begin
  redis = Redis.new(
    :host => "bf36cdba2cc244d5b145f71c6ce4ae72.publb.rackspaceclouddb.com",
    :port => 6380,
    :password => "CskHfrMmPGvdNxPBFKu4rQfhPvDK33brEJca",
    :ssl => :true)
  puts redis.info
  client_ping = redis.ping
  if client_ping
    puts 'Connected!'
  else
    raise 'Ping failed'
  end
rescue => e
  puts "Error: #{e}"
end
