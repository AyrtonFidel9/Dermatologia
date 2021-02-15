var act = document.getElementById("act");

act.addEventListener("change", () => {
    if (act.checked == true) {
        document.getElementById("menuIzq").style.width = '20%';
        mostrarLetras(document.getElementsByClassName('letras'));
        cambiarTamanio(document.getElementsByClassName("opcionMn"), '7.15em');
    }
    else {
        document.getElementById("menuIzq").style.width = '6%';
        esconderLetras();
        cambiarTamanio(document.getElementsByClassName("opcionMn"), '2.364em');
    }
});

function cambiarTamanio(elem, tam)
{
    for (let i = 0; i < elem.length; i++)
    {
        elem[i].style.width = tam;
    }
}
var elementos = [];
function mostrarLetras(elem)
{
    let max = elem.length;
    
    for (let i = 0; i < max; i++)
    {
        elementos.push(elem[i]);
    }   

    for (let i = 0; i < elementos.length; i++)
    {
        elementos[i].removeAttribute("class", "hidden");
    }
}

function esconderLetras() {
    for (let i = 0; i < elementos.length; i++) {
        elementos[i].setAttribute("class", "hidden");
    }
}




