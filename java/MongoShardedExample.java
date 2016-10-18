// Driver Documentation: https://docs.mongodb.com/ecosystem/drivers/java/
import java.util.*;
import com.mongodb.*;

public class MongoShardedExample {

    public static void main(String[] args) {
        String host = "iad1-mongos1.objectrocket.com:26215";
        String database = "test_db";
        String username = "superwoman";
        String password = "superwoman";
        String options = "ssl=true";

        String connectionString = String.format("mongodb://%s:%s@%s/%s?%s", username, password, host, database, options);

        MongoClientURI client_uri = new MongoClientURI(connectionString);

        MongoClient client = new MongoClient(client_uri);

        DB db = client.getDB("test_db");

        Set<String> collection = db.getCollectionNames();

        System.out.println(collection);
    }
}
