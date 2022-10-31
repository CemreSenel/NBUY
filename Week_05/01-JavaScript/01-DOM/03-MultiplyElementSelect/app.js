let sonuc;
//getElementByClassName    geriye bırden cok sonuc dondurebılır

// sonuc=document.getElementsByClassName('card-header');
// sonuc=document.getElementsByClassName('task');
// sonuc=document.getElementsByClassName('task')[2].innerText;
// sonuc=document.getElementByClassName('task');
// for (let i = 0; i < sonuc.length; i++) {
//     console.log(sonuc[i].innerText);
    
// }


// let taskList = document.getElementByClassName('task');
// for (const task of taskList) {
//     task.style.color='red';
//     task.style.fontSize='60px';
// }

let taskList2 =document.getElementById('task-list-2');
// sonuc= taskList2.getElementByClassName('task');

sonuc = taskList2.getElementsByTagName('li');
//geriye bırden cok sonuc dondurebılır


sonuc = document.querySelectorAll('#task-list-2 li');
//geriye bırden cok sonuc dondurur.

for (const task of sonuc) {
    task.style.backgroundColor='navy';
    task.style.color='white';
}

console.log(sonuc);
