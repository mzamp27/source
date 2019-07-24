'use strict';

//Node.js relies on the package.json file to understand the basic information and dependencies for every Node.js project.

//1. Open your hello-node folder using Visual Studio Code.
//   In Visual Studio Code: select File > Open Folder then navigate to your hello-node folder and select select folder.
//   You should see the package.json that has been created in your folder.
//2. In the same folder, create a file called server.js.
//3. Open the server.js file in your Visual Studio Code editor window.


//4. Create a variable to access the http module, This will give you access to the http module in your project. The http module helps your server handle http requests and responses.
var http = require('http');

//5. Create a variable to store the port # your server will run on.
var port = 3000;


//6. Create a function that will handle requests from clients, called requestHandler.
//   This sets up a function that will handle requests from clients. This function has parameters to accept a request and reponse object.
//   The function uses the request object to identify the url the request was sent to. It uses the response object to create and send a response message.
var requestHandler = function (request, response) {
    console.log('New request to: ' + request.url);
    response.end('Hello, World! From Node JS');
}


//7. Use the http.createServer method to create a server object. The http.createServer method expects a function to handle requests. We'll use the function we created in step 6.
var server = http.createServer(requestHandler);


//8. Instruct the server to listen for requests on the port you defined. Also provide a callback function that will be run after the server begins listening on the port.
server.listen(port, function () {
    console.log('listening on port ' + port);
});



//RUN THIS SERVER.
//Right now, the server will not run the code you've written, until it's told to. We need our server to begin listening for requests, and we do so by using Node.js to run the server.

//1. In your command line interface, navigate into the folder that contains your Node.js project- hello-node.
//2. Run the server using the node command:    node server.js
//3. You should see a message in your console window telling you the server is listening.

//NOW YOU NEED TO SEND A REQUEST TO THIS SERVER
//The primary purpose of a server is to handle http requests from clients. Try accessing your server using your browser, which will send an http request to the server.

//1. Open your web browser.
//2. Enter your server URL into the address bar:    localhost: 3000
//3. You should see the text "Hello, World!" displayed on the page, since that's the message you printed from the requestHandler function, which handled this request from the browser.
//4. In the command line, you should now see a message letting you know what path on your server was requested, based on the URL the client accessed.
