import com.mongodb.*;

public class MongoReplicaSetExample {

    public static void main(String[] args) {
        String host = "iad-c11-1.objectrocket.com:48152,iad-c11-0.objectrocket.com:48152";
        String database = "test_db";
        String username = "sooz";
        String password = "xxxxxxxx";
        String options = "replicaSet=99fc32e3c05e03597a692c4fd9a9d162";

        String connectionString = String.format("mongodb://%s:%s@%s/%s?%s", username, password, host, database, options);

        MongoClientURI client_uri = new MongoClientURI(connectionString);

        MongoClient client = new MongoClient(client_uri);
    }

}
