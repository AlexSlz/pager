const test = document.querySelector('.test')
const form = document.querySelector('.form')
const inputId = document.querySelector('.inputId')
const inputText = document.querySelector('.inputText')

const btn = document.querySelector('.btn')
const info = document.querySelector('.info')

const socket = new WebSocket('ws://localhost:3000')

let oldText = info.textContent
form.addEventListener('submit', (e) => {
  e.preventDefault()

  if (inputText.value && inputId.value.length > 3) {
    let data = { data: inputText.value, id: inputId.value }
    socket.send(JSON.stringify(data))
    btnUpd(false)
  } else {
    btnUpd(true)
  }
})

inputId.addEventListener('change', function () {
  if (inputId.value.length == 0 || !inputId.value.includes('A', 0))
    inputId.value = 'A'
})

function btnUpd(error) {
  if (error) {
    info.innerHTML = 'X'
    btn.classList.add('is_false')
  } else if (!error) {
    info.innerHTML = 'ok'
    btn.classList.add('is_ok')
  }
  setTimeout(() => {
    btn.classList.remove('is_false', 'is_ok')
  }, 1500)
}

socket.addEventListener('message', (e) => {
  if (e.data instanceof Blob) {
    reader = new FileReader()

    reader.onload = () => {
      console.log(reader.result)
    }

    reader.readAsText(e.data)
  } else {
    console.log(e.data)
  }
})

socket.addEventListener('connect', (e) => {
  console.log(socket.id)
})
