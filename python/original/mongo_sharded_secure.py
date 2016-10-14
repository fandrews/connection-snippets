# Connecting to a sharded instance with a write concern of 1:
import pymongo

settings = {
    'host': 'iad1-mongos1.objectrocket.com:26338',
    'database': 'test_db',
    'username': 'sooz',
    'password': 'xxxxxxxx',
    'options': 'ssl=true'
}

try:
    conn = pymongo.MongoClient("mongodb://{username}:{password}@{host}/{database}?{options}".format(**settings))
except Exception as ex:
    print "Error:", ex
    exit('Failed to connect, terminating.')
