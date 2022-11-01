'use strict'

const display= document.querySelector('.calculater-input');
const keys=document.querySelector('.calculater-keys');

let displayValue='0';

updateDisplay();

function updateDisplay() {
    display.value='0';
}

keys.addEventListener('click',function (event) {
    const element = event.target;
    if (!element.matches('button')) return;
    if (element.classList.contains('operator')) {
        console.log('operator');
    }else if(element.classList.contains('deciamal')){
        console.log('decımal');
    }else if(element.classList.contains('clear')){
        console.log('clear');
    }else{
        console.log('bır rakama tıklandı');
    }
});