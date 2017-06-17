(function sololetras(e) {
    key = e.keyCode || e.which;
    teclado = String.fromCharCode(key).toLowerCase();
    letras = " abcdefghijklmnopqrstuvwxy";
    especiales = "8-37-38-46-164" //8 esoacio, 37 flecha Izq 38 fecha derecha 46 suprimir 164 ñ
    teclado_especial = false;
    for (var i in especiales) {
        if (key == especiales[i]) {
            teclado_especial = true; break;
        }
    }
    if (letras.indexOf(teclado) == -1 && !teclado_especial) {
        return false;
    }
})


(function verifica(ori, dest) {
    if (ori.value == "" && dest.value == "") {
        alert("Debe completar todos los campos");
        document.getElementById('ori').style.border = 'thin solid #FF0000';
        document.getElementById('destiny').style.border = 'thin solid #FF0000';
        return false;
    }
    if (ori.value == "") {
        alert("El campo Origen está vacio");
        document.getElementById('ori').style.border = 'thin solid #FF0000';
        return false;
    }
    if (dest.value == "") {
        alert("El campo Destino está vacio");
        document.getElementById('destiny').style.border = 'thin solid #FF0000';
        return false;
    }
    else {
        location.href = "listaVuelos.html"
        return true;
    }
})