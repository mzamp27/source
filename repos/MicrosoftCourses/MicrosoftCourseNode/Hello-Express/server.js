var express = require('express');
var app = express();
var port = 3000;

app.listen(port, function () {
    console.log('Express app listening on port ' + port);
});


app.get('/', function (request, response) {
    response.send('Hello, World! from express');
});

app.get('/test', function (request, response) {
    response.send('Hello from test');
});



