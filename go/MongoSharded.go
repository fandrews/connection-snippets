package main

import (
    "crypto/tls"
    "fmt"
    "gopkg.in/mgo.v2"
    "net"
)

func main() {
    const (
      //iad1-mongos0.objectrocket.com:16073
      //iad1-mongos0.objectrocket.com:26073
        Host     = "iad1-mongos0.objectrocket.com:16073"
        Username = "sooz"
        Password = "xxxxxxxx"
        Database = "test_db"
    )

    session, err := mgo.DialWithInfo(&mgo.DialInfo{
        Addrs:    []string{Host},
        Username: Username,
        Password: Password,
        Database: Database,
        // FIX: SSL doesn't work
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
