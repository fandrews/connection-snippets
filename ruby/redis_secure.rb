# Ensure you have run 'gem install redis'
require 'redis'

begin
  redis = Redis.new(
    :host => "bf36cdba2cc244d5b145f71c6ce4ae72.publb.rackspaceclouddb.com",
    :port => 6380,
    :password => "CskHfrMmPGvdNxPBFKu4rQfhPvDK33brEJca",
    :ssl => :true)
  puts redis.info
  clientPing = redis.ping
  if clientPing
    puts "Connected!"
  else
    raise "Ping failed"
  end
rescue Exception => e
  puts "Error: #{e}"
end

# redis://bf36cdba2cc244d5b145f71c6ce4ae72.publb.rackspaceclouddb.com:6380
# https://objectrocket.com/docs/redis_ruby_examples.html
