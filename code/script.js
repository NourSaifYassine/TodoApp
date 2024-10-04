const input = document.getElementById('input');
const btnAdd = document.getElementById('btnAdd');
const ul = document.getElementById('tasks');
const removeBtn = document.createElement('button');
const img  = document.createElement('img');
const done  = document.createElement('img');

function createTask() {
    const li = document.createElement('li');
    li.textContent = input.value;
    input.value = ""; 
    img.src = 'close.svg';
    img.alt = 'Close todo';
    done.src = 'done.svg';
    done.alt = 'Done todo';
    li.appendChild(done);
    li.appendChild(img);
    img.addEventListener('click', () => {
        alert('List removed');
        li.remove();
    });
    done.addEventListener('click', () => {
        li.style.textDecorationLine = 'line-through';
    });
    ul.appendChild(li);
}

input.addEventListener('keydown', (event) => {
    if (event.key == 'Enter') {
        createTask();
    }
});

btnAdd.addEventListener('click', () => {
    createTask();
});