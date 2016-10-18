# Example Documenetation: https://objectrocket.com/docs/mongodb_python_examples.html#connecting (modified version)
# Pymonogo Documentation: https://api.mongodb.com/python/current/
# Assumed you have run 'pip install pymongo'
import pymongo

settings = {
    'host': 'iad1-mongos0.objectrocket.com:26139',
    'database': 'test_db',
    'username': 'sooz',
    'password': 'xxxxxxxx',
    'options': 'ssl=true'
}

connection_string = "mongodb://{username}:{password}@{host}/{database}?{options}".format(**settings);

try:
    conn = pymongo.MongoClient(connection_string)
    collectionNames = conn[settings['database']].collection_names() # This line actually triggers something that test the credentials
    print "Connected; collection Names", collectionNames
    conn.close(); # Actually close the connection
except Exception as ex:
    print "Error:", ex
    exit('Failed to connect, terminating.')
