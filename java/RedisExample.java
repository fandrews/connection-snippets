// Driver Documentation: https://github.com/xetorthio/jedis
// Assumes you have downloaded the Jedis library to your classpath or added it as a Maven dependency
// TODO: Get this working using SSL. 

import redis.clients.jedis.*;

public class RedisExample{

     public static void main(String []args){
        try {
                JedisPool pool = new JedisPool("e11eb048df7d46158db2e436cc293a8f.publb.rackspaceclouddb.com", 6379);
                Jedis jedis = pool.getResource();
                          jedis.auth("XgRYVmyg7b7c3xEVZsGa9jRGNJnGenzbm7GY");
                          pool.returnResource(jedis);
                pool.destroy();
            }
            catch(Exception e) {
                    System.out.println(e);
            }
     }
}
