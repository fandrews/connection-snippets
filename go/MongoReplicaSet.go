// Assumes you have run 'go get gopkg.in/mgo.v2
package main

import (
    "fmt"
    "gopkg.in/mgo.v2"
)
//TODO: This hangs with the host is bogus. Is there a way to make it timeout?
func main() {
    Host := []string{
        "iad-c11-1.objectrocket.com:48152",
        "iad-c11-0.objectrocket.com:48152",
    }
    const (
        Username = "sooz"
        Password = "xxxxxxxx"
        Database = "test_db"
    )

    session, err := mgo.DialWithInfo(&mgo.DialInfo{
        Addrs:    Host,
        Username: Username,
        Password: Password,
        Database: Database,
    })
    if err != nil {
        panic(err)
    }

    fmt.Printf("Connected to replica set %v!\n", session.LiveServers())
}

// https://objectrocket.com/docs/mongodb_go_examples.html#connecting-to-a-replica-set
