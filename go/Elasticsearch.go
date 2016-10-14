// Assumes you have run 'go get gopkg.in/olivere/elastic.v3'
package main

import (
    "gopkg.in/olivere/elastic.v3"
    "fmt"
)

//https://iad1-10538-0.es.objectrocket.com:20538,https://iad1-10538-1.es.objectrocket.com:20538,https://iad1-10538-2.es.objectrocket.com:20538,https://iad1-10538-3.es.objectrocket.com:20538
func main() {
    // Host := []string{
    //     "iad1-10538-0.es.objectrocket.com:20538",
    //     "iad1-10538-1.es.objectrocket.com:20538",
    //     "iad1-10538-2.es.objectrocket.com:20538",
    //     "iad1-10538-3.es.objectrocket.com:20538",
    // }

    const (
        Host = "iad1-10538-1.es.objectrocket.com:20538"
        Username = "sooz"
        Password = "xxxxxxxx"
    )

    connection_string := fmt.Sprintf("http://%v:%v@%v", Username, Password, Host)
    client, err := elastic.NewClient(elastic.SetURL(connection_string)) //Accepts multiple hosts as separate arguments
    if err != nil {
        // Handle error
        panic(err)
    }


    fmt.Printf("Connected to", client)
}
