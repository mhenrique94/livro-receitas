// var btn = document.getElementsByClassName('.botao2');
// var container = document.querySelector('.trailerpopup');
// btn.addEventListener('click', function() {
    
//   if(container.style.display === 'block') {
//       container.style.display = 'none';
//   } else {
//       container.style.display = 'block';
//   }
// });



function Mudarestado(trailerpopup) {
    var display = document.getElementsByClassName(trailerpopup);
    if(display[0].style.display == "none")
        display[0].style.display = 'block';
    else
    display[0].style.display = 'none';
}

function caixapesq(caixa_pesq) {
    var display = document.getElementsByClassName(caixa_pesq);
    if(display[0].style.display == "none")
        display[0].style.display = 'block';
    else
    display[0].style.display = 'none';
}