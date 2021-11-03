const test = document.querySelector('.test')
const form = document.querySelector('.form')
const inputId = document.querySelector('.inputId')
const inputText = document.querySelector('.inputText')

let btn = document.querySelector('.btn')

const socket = new WebSocket('ws://localhost:3000')

let oldText = btn.textContent
form.addEventListener('submit', (e) => {
  e.preventDefault()

  if (inputId.value && inputText.value && inputId.value.length > 3) {
    let data = { data: inputText.value, id: inputId.value }
    socket.send(JSON.stringify(data))
    btnUpd(false)
  } else {
    btnUpd(true)
  }
})

function btnUpd(error) {
  if (error) {
    btn.innerHTML = 'X'
    btn.classList.add('is_false')
  } else if (!error) {
    btn.innerHTML = 'ok'
    btn.classList.add('is_ok')
  }
  setTimeout(
    () => (
      btn.classList.remove('is_false', 'is_ok'), (btn.innerHTML = oldText)
    ),
    1500
  )
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
