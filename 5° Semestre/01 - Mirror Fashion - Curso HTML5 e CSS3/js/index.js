
//#region  Busca

var sectionBusca = document.querySelector('.busca');
var formBusca = document.querySelector('#form-busca');
var inputBusca = document.querySelector('#q');

var corOriginal = sectionBusca.style.backgroundColor


formBusca.onsubmit = function () {

    if (inputBusca.value.trim() == '') {
        //alert('Insira um texto válido para pesquisa');
        sectionBusca.style.background = '#f7948d';
        return false;
    }
    else {
        sectionBusca.style.background = corOriginal;
    }
}

//#endregion Busca



//#region Banner Rotativo

var imgDestaques = document.querySelector('#img-destaque');
//var permiteTrocaBanner = true;
var bannersSrc = ["Assets/destaque-home.png", "Assets/destaque-home-2.png"];
var bannersAlt = ["Promoção: Big City Night", "Promoção: Sunny Days"];

var bannerAtual = 0;

function trocaBanner() {

    //if (!permiteTrocaBanner) return;

    bannerAtual = (bannerAtual + 1) % 2;

    imgDestaques.classList.add("fade-in");
    imgDestaques.classList.add("fade-out");

    setTimeout(function () {
        imgDestaques.src = bannersSrc[bannerAtual];
        imgDestaques.alt = bannersAlt[bannerAtual];

        imgDestaques.classList.remove("fade-out");

    }, 300);
}


var timer = setInterval(trocaBanner, 4000);

// Pause

imgDestaques.onmousedown = function () {
    //permiteTrocaBanner = false;
    clearInterval(timer);
    btnPause.className = 'play';
}


imgDestaques.onmouseup = function () {
    //permiteTrocaBanner = true;

    timer = setInterval(trocaBanner, 4000);
    btnPause.className = 'pause';
}



// Pause Apostila

var btnPause = document.querySelector('.pause');

btnPause.onclick = function () {

    if (btnPause.className == 'pause') {
        clearInterval(timer);
        btnPause.className = 'play';

    } else {
        timer = setInterval(trocaBanner, 4000);
        btnPause.className = 'pause';
    }

    return false;
};


//#endregion Banner Rotativo
