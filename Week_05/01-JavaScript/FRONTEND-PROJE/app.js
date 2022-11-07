'use strict';
let btnAddNew=document.getElementById('btnAddNew');
let txtName=document.getElementById('txtName');
btnAddNew.onclick=function name() {
    
}


let notListesi = [
    {},
    {},
    {},
];

let ul = document.getElementById('note-list');
  
for (const not of notListesi) {
    let li = ` 
        <li class="note-list-item">
            <input type="text" id="txtNameNew">
            <button type="button"  id="btnCheck"><i class="fa-regular fa-square-check"></i></button>
            <button type="button"  id="btnDelete"><i class="fa-regular fa-trash-can"></i></button>
        </li>
    `;
    ul.insertAdjacentHTML('beforeend',li);
}









