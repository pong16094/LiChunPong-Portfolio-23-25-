import math
import json
from flask import Flask

app = Flask(__name__)

@app.route('/')
def index():
    return "Hello, World!"
@app.route('/ship_cost_api/<string:mode>')
@app.route('/ship_cost_api/<string:mode>/<float:value>')
@app.route('/<path:catch_all>')
def handle_catch_all(catch_all):
    response = {"result": "rejected", "reason": "Error: mod must be quantity or weight"}
    return json.dumps(response)

@app.route('/ship_cost_api/weight/<float:value>')
def weight(value):
    if value > 70:
        response = {"result": "rejected", "reason": "Maximum weight per package is 70kg"}
    else:
        price = 300 + (int(math.ceil(value))-1) * 50
        response = {"result": "accepted", "cost": price}
    return json.dumps(response)

@app.route('/ship_cost_api/quantity/<int:value>')
def quantity(value):
    if value > 30:
        response = {"result": "rejected", "reason": "Maximum number of units per package is 30"}
    else:
        price = 300 + (value-1) * 60
        response = {"result": "accepted", "cost": price}
    return json.dumps(response)

if __name__ == '__main__':
    app.run(port=8080)