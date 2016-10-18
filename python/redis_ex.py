# Example Dcoumentation:  https://objectrocket.com/docs/redis_python_examples.html (modified)
# Packge Documentation: https://redis-py.readthedocs.io/en/latest/
# Ensure you have run 'pip install redis'
import redis

try:
    conn = redis.StrictRedis(
        host='bf36cdba2cc244d5b145f71c6ce4ae72.publb.rackspaceclouddb.com',
        port=6380,
        password='CskHfrMmPGvdNxPBFKu4rQfhPvDK33brEJca',
        ssl=True)
    print conn
    conn.ping()
    print 'Connected!'
except Exception as ex:
    print 'Error:', ex
    exit('Failed to connect, terminating.')
