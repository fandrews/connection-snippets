# Ensure you have run 'pip install elasticsearch' and 'pip install certifi'
# Docs for elasticsearch package: https://elasticsearch-py.readthedocs.io/en/master/
# Docs for certifi package: https://pypi.python.org/pypi/certifi
from elasticsearch import Elasticsearch
import certifi

try:
    es = Elasticsearch([
            'iad1-10538-0.es.objectrocket.com',
            'iad1-10538-1.es.objectrocket.com',
            'iad1-10538-2.es.objectrocket.com',
            'iad1-10538-3.es.objectrocket.com'],
        http_auth=('sooz', 'xxxxxxxx'),
        port=20538,
        use_ssl=True,
        verify_certs=True,
        ca_certs=certifi.where(),
    )
    print "Connection Succeeded:", es.ping()
except Exception as ex:
    print "Error:", ex
