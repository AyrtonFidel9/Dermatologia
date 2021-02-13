var act = document.getElementById("act");

act.addEventListener("change", () => {
    if (act.checked == true) {
        document.getElementById("menuIzq").style.width = '20%';
        document.querySelector("#ops").removeAttribute("class", "hidden");
    }
    else {
        document.getElementById("menuIzq").style.width = '6%';
        document.querySelector("#ops").setAttribute("class", "hidden");
    }
});

var act = document.getElementById("act");


