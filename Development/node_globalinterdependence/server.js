const express = require('express');
const path = require('path');

const app = express();

const port = 3000;

console.log('restarting');

app.use(express.static(path.join(__dirname, './static')));
app.get('/', (request, response) => {
  response.sendFile(path.join(__dirname, './static/index.html'));
});

app.get('/How', (request, response) => {
  response.sendFile(path.join(__dirname, './static/html/How.html'));
});

app.get('/What', (request, response) => {
  response.sendFile(path.join(__dirname, './static/html/What.html'));
});

app.get('/Why', (request, response) => {
  response.sendFile(path.join(__dirname, './static/html/Why.html'));
});

app.listen(port, () => {
  console.log(`Express Server Listening on port ${port}!`);
});
