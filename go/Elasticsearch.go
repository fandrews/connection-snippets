// Driver Documentation: https://godoc.org/gopkg.in/olivere/elastic.v3
// Assumes you have run 'go get gopkg.in/olivere/elastic.v3'
// TODO: Fix this; always throws an error that no ES nodes are available
package main

import (
    "fmt"
    "gopkg.in/olivere/elastic.v3"
)

func main() {
    const (
        Url      = "https://iad1-10600-2.es.objectrocket.com:20600"
        Username = "greenarrow"
        Password = "greenarrow"
    )

    _, err := elastic.NewClient(
        elastic.SetURL(Url),
        elastic.SetBasicAuth(Username, Password),
        elastic.SetSniff(false))
    if err != nil {
        panic(err)
    }

    fmt.Printf("Connected")
}
