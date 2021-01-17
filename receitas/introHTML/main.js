// alert("meu primeiro js");


function clicou(){
    var disp = document.getElementById("post")

    if(disp.style.display === "none"){
        disp.style.display = 'block';
    }
    
    else{
        disp.style.display = 'none'
    }
}

function redirecionar(){
    window.open("https://github.com/mhenrique94");
}