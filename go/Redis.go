// Example Documentation: https://objectrocket.com/docs/redis_go_examples.html
// Driver Documentation: https://github.com/garyburd/redigo
// TODO: Test this with SSL. Reformat example so it is more consistent with others (i.e. ping instead of adding and removing stuff from DB)
package main

import "github.com/garyburd/redigo/redis"
import "fmt"

func main() {
      //Connect
      options := DialOptions {

    }
      c, err := redis.Dial("tcp", "bf36cdba2cc244d5b145f71c6ce4ae72.publb.rackspaceclouddb.com:6380")
      if err != nil {
              panic(err)
      }
      defer c.Close()

      //Authenticate
      c.Do("AUTH", "CskHfrMmPGvdNxPBFKu4rQfhPvDK33brEJca")

      //Set two keys
      // c.Do("SET", "best_car_ever", "Tesla Model S")
      // c.Do("SET", "worst_car_ever", "Geo Metro")
      //
      // //Get a key
      // best_car_ever, err := redis.String(c.Do("GET", "best_car_ever"))
      // if err != nil {
      //         fmt.Println("best_car_ever not found")
      // } else {
      //         //Print our key if it exists
      //         fmt.Println("best_car_ever exists: " + best_car_ever)
      // }
      //
      // //Delete a key
      // c.Do("DEL", "worst_car_ever")
      //
      // //Try to retrieve the key we just deleted
      // worst_car_ever, err := redis.String(c.Do("GET", "worst_car_ever"))
      // if err != nil {
      //         fmt.Println("worst_car_ever not found", err)
      // } else {
      //         //Print our key if it exists
      //         fmt.Println(worst_car_ever)
      // }
}
