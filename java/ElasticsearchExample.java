// Driver Documentation: https://www.elastic.co/guide/en/elasticsearch/client/java-api/current/transport-client.html
// TODO: This snippet is directly from the ES Java documentation. Needs to be tested.

// on startup
Settings settings = Settings.settingsBuilder()
        .put("cluster.name", "myClusterName")
         .put("client.transport.sniff", true) //SF: Unsure if this is needed; auto-detects other nodes in the cluster and excludes non-data nodes from receiving requests
        .build();

TransportClient client = TransportClient.builder()
         .settings(settings)
         .build()
        .addTransportAddress(new InetSocketTransportAddress(InetAddress.getByName("host1"), 9300))
        .addTransportAddress(new InetSocketTransportAddress(InetAddress.getByName("host2"), 9300)); // SF: Don't think multiple hosts are is nessary if sniffing is enabled

// on shutdown

client.close();


//Not sure how to deal w/ SSL
