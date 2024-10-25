const säule1 = document.getElementById(säule1);
let startPosition = 0;
let richitung = 1;

function moveUpDown(){
    if (startPosition>=450 || startPosition <= 0) {
        richitung*= -1
    }
    startPosition += richitung * 2;
    säule1.style.top = richitung + 'px';
}
const moveInterval =setInterval(moveUpDown, 20);