// Example Documentation: https://objectrocket.com/docs/mongodb_node_examples.html#connecting-to-a-sharded-instance-using-ssl
// Driver Documentation: https://godoc.org/gopkg.in/mgo.v2
// Assumes you have run 'go get gopkg.in/mgo.v2
package main

import (
    "crypto/tls"
    "fmt"
    "gopkg.in/mgo.v2"
    "net"
)

func main() {
    const (
        Host     = "iad1-mongos1.objectrocket.com:26215"
        Username = "superwoman"
        Password = "superwoman"
        Database = "test_db"
    )

    session, err := mgo.DialWithInfo(&mgo.DialInfo{
        Addrs:    []string{Host},
        Username: Username,
        Password: Password,
        Database: Database,
        DialServer: func(addr *mgo.ServerAddr) (net.Conn, error) {
            return tls.Dial("tcp", addr.String(), &tls.Config{})
        },
    })
    if err != nil {
        panic(err)
    }
    defer session.Close()

    fmt.Printf("Connected to %v!\n", session.LiveServers())
}
