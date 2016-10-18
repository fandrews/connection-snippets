# Example Documenetation: https://objectrocket.com/docs/mongodb_python_examples.html#connecting (modified version)
# Pymonogo Documentation: https://api.mongodb.com/python/current/
# Assumed you have run 'pip install pymongo'
import pymongo

settings = {
    'host': 'iad-c11-1.objectrocket.com:48152,iad-c11-0.objectrocket.com:48152',
    'database': 'test_db',
    'username': 'sooz',
    'password': 'xxxxxxxx',
    'options': 'replicaSet=99fc32e3c05e03597a692c4fd9a9d162'
}

try:
    conn = pymongo.MongoClient("mongodb://{username}:{password}@{host}/{database}?{options}".format(**settings))
    print "Connected"
    collectionNames = conn[settings['database']].collection_names() # This line actually triggers something that test the credentials
    print "Collection Names", collectionNames
    conn.close(); # Actually close the connection
except Exception as ex:
    print "Error:", ex
    exit('Failed to connect, terminating.')

print "Finished" # Done!
