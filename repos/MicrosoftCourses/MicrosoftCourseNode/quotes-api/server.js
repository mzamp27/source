var express = require('express');
var bodyParser = require('body-parser');
var sqlite3 = require('sqlite3');


var name = "quotes-api";
var app = express();
app.use(bodyParser.urlencoded({ extended: true }));
var db = new sqlite3.Database('quotes.db');

var port = 3000;
app.listen(port, function () {
    console.log(name + ' listening on port ' + port);
});





//NEW QUOTES WERE CREATED IN THE SQLITE3 SHELL

// **OLD HARD CODED QUOTES


//var quotes = [
//    {
//        id: 1,
//        quote: "The best is yet to come",
//        author: "Unknown",
//        year: 2000
//    },
//    {
//        id: 2,
//        quote: "This is a quote",
//        author: "First Last",
//        year: 1930
//    },
//    {
//        id: 3,
//        quote: "This is another quote",
//        author: "First2 Last2",
//        year: 1910
//    }
//];


app.get('/', function (request, response) {
    response.send('Test api response');
});


//replaces code for get path underneath 
app.get('/quotes', function (req, res) {
    if (req.query.year) {
        db.all('SELECT * FROM quotes WHERE year = ?', [parseInt(req.query.year)], function (err, rows) {
            if (err) {
                res.send(err.message);
            }
            else {
                console.log("Return a list of quotes from the year: " + req.query.year);
                res.json(rows);
            }
        });
    }
    else {
        db.all('SELECT * FROM quotes', function processRows(err, rows) {
            if (err) {
                res.send(err.message);
            }
            else {
                for (var i = 0; i < rows.length; i++) {
                    console.log(rows[i].quote);
                }
                res.json(rows);
            }
        });
    }
});

//app.get('/quotes', function (req, res) {
//    console.log("Get a list of all quotes as json");
//    if (req.query.year) {
//        res.send("Return a list of quotes from the year: " + req.query.year);
//    }
//    else {
//        res.json(quotes);
//    }    
//});


//replaces code for get path underneath 
app.get('/quotes/:id', function (req, res) {
    console.log("return quote with the ID: " + req.params.id);
    db.get('SELECT * FROM quotes WHERE rowid = ?', [req.params.id], function (err, row) {
        if (err) {
            console.log(err.message);
        }
        else {
            res.json(row);
        }
    });
});


//app.get('/quotes/:id', function (req, res) {
//    console.log("return quote with the ID: " + req.params.id);
//    res.send("Return quote with the ID: " + req.params.id);
//});


//replaces code for post path underneath 
app.post('/quotes', function (req, res) {
    console.log("Insert a new quote: " + req.body.quote);
    db.run('INSERT INTO quotes VALUE (?, ?, ?)', [req.body.quote, req.body.author, req.body.year],
        function (err) {
            if (err) {
                console.log(err.message);
            }
            else {
                res.send('Inserted quote with ID: ' + this.lastID);
            }
        });
});

//app.post('/quotes', function (req, res) {
//    console.log("Insert a new quote: " + req.body.quote);
//    res.json(req.body);
//});

//TO TEST THIS METHOD YOU NEED TO USE POSTMAN or the REST client of your choice and build an API POST request.

















// ** THIS IS THE ORIGINAL DISPLAY EXAMPLE WE ARE WORKING TOWARDS UNDERSTANDING
//db.serialize(function () {
//    //create table
//    db.run('CREATE TABLE Contacts (first_name TEXT, last_name TEXT, age INTEGER)');

//    //insert values
//    db.run('INSERT INTO Contacts VALUES ("John", "Doe", 25)');
//    db.run('INSERT INTO Contacts VALUES ("Jane", "Doe", 19)');
//    db.run('INSERT INTO Contacts VALUES ("Sue", "Smith", 42)');

//    //queries
//    db.all('SELECT * FROM Contacts', processRows);
//    db.each('SELECT * FROM Contacts', processRow);
//    db.each('SELECT * FROM Contacts WHERE last_name = "Doe"', processRow);
//    var firstName = 'John';
//    db.get('SELECT * FROM Contacts WHERE first_name = ?', [firstName], function (err, row) {
//        console.log("Get John's Age:");
//        if (err) {
//            console.log("ERROR: " + err.message);
//        }
//        else {
//            console.log(row.age);
//        }
//    });
//});


//function processRows(err, rows) {
//    console.log("PROCESS ROWS");
//    if (err) {
//        console.log("ERROR: " + err.message);
//    }
//    else {
//        for (var i = 0; i < rows.length; i++) {
//            console.log(rows[i].first_name);
//        }
//    }
//}

//function processRow(err, row) {
//    console.log("PROCESS ROW");
//    if (err) {
//        console.log("ERROR: " + err.message);
//    }
//    else {
//        console.log(row.first_name);
//    }
//}

//db.close();


//Here's a summary of the steps needed to execute SQL statements using SQLite from your Node.js project:

//1. Install the sqlite3 module and save it as a dependency for your Node.js project

//2. Import the sqlite3 module in your Node.js project

//3. Connect to a SQLite database, either an in -memory temporary database, or by providing a file path to a persistent database.

//4. Identify which SQL statement is appropriate for each of the routes you've defined in your app.

//5. For GET routes, you'll likely need to use a SQL SELECT statement. Use db.all(), db.each(), or db.get() to run a SQL SELECT statement in JavaScript.

//6. For all other routes, use the db.run() method to run the appropriate INSERT, UPDATE or DELETE SQL statement.

//7. Use response.send() or response.json() to return data to the client as needed.

