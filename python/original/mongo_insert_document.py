import pymongo
from datetime import datetime

print "Starting insert"

settings = {
    'host': 'iad-c11-1.objectrocket.com:48152,iad-c11-0.objectrocket.com:48152',
    'database': 'test_db',
    'username': 'sooz',
    'password': 'xxxxxxxx',
    'options': 'w=1'
}

example_doc = { "start": datetime.utcnow(),
    "end": datetime(2015, 8, 22, 16, 22, 38),
    "location": "Texas",
    "official_game": False,
    "winner": "Javi",
    "players": [
        {
    "name": "Javi",
            "decks": [
                "Dinosaurs",
                "Plants"
            ],
            "points": 24,
            "place": 1
        },
        {
            "name": "Seth",
            "decks": [
                "Spies",
                "Zombies"
            ],
            "points": 20,
            "place": 2
        },
        {
            "name": "Dave",
            "decks": [
                "Steampunk",
                "Wizard"
            ],
            "points": 20,
            "place": 2
        },
        {
            "name": "Castro",
            "decks": [
                "Shapeshifters",
                "Ninjas"
            ],
            "points": 18,
            "place": 4
        }
    ]
}

try:
    conn = pymongo.MongoClient("mongodb://{username}:{password}@{host}/{database}?{options}".format(**settings))
except Exception as ex:
    print "Error:", ex
    exit('Failed to connect, terminating.')

db = conn.test_db
collection = db.test_collection

print 'inserting?'

doc_id = collection.insert_one(example_doc).inserted_id

print "Heres the _id of the doc I inserted: %s." % doc_id
