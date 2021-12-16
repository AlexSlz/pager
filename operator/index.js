const express = require('express')
const path = require('path')
const app = express()
const http = require('http').createServer(app)

app.get('/', (req, res) => {
  res.sendFile(__dirname + '/index.html')
})

const port = process.env.PORT || 3000

app.use(express.static(path.join(__dirname, '/assets')))

const WebSocket = require('ws')
const wss = new WebSocket.Server({ server: http })
wss.on('connection', (ws) => {
  ws.id = wss.getUniqueID()
  console.log('new: ' + ws.id)
  ws.send('id: ' + ws.id)
  ws.on('message', (msg) => {
    let msgId = JSON.parse(Buffer.from(msg, 'base64').toString('ascii')).id
    let msgText = JSON.parse(Buffer.from(msg, 'base64').toString('ascii')).data
    console.log('new msg | id: ' + msgId + ' | text: ' + msgText)
    wss.clients.forEach(function each(client) {
      if (
        client !== ws &&
        client.readyState === WebSocket.OPEN &&
        msgId === client.id
      )
        client.send(msgText)
    })
  })
})
wss.getUniqueID = function () {
  function rand() {
    return Math.floor(Math.random() * (999 - 100 + 1)) + 100
  }
  return 'A' + rand()
}

http.listen(port, () => {
  console.log('Server Start')
  console.log(http.address())
})
