// javascript code
function buscaSolicitacao() {
    var WhatsApp = limpaWhats(document.getElementById('WhatsApp').value);

    if (WhatsApp != '') {
        if (WhatsApp.length == 11) {
            document.getElementById('iframeSolicita').src = 'ItemSolicitacao.aspx?WhatsApp=' + WhatsApp;
        }
        else {
            alert('Coloque um WhatsApp válido!');
        }
    }
    else {
        alert('Coloque um WhatsApp válido!');
    }
}

function addItem() {
    var WhatsApp = limpaWhats(document.getElementById('WhatsApp').value);
    var Recheio = document.getElementById('Recheio').value;
    var Quantidade = document.getElementById('Quantidade').value;

    if (WhatsApp != '') {
        if (WhatsApp.length == 11) {
            var params = '';

            params += '&WhatsApp=' + WhatsApp;
            params += '&Recheio=' + Recheio;
            params += '&Quantidade=' + Quantidade;

            params = 'ItemSolicitacao.aspx?CMD=INCLUIR' + params;

            //alert(params);

            document.getElementById('iframeSolicita').src = params;
        }
        else {
            alert('Coloque um WhatsApp válido!');
        }
    }
    else {
        alert('Coloque um WhatsApp válido!');
    }
}

function excItem(ID, nome) {
    var WhatsApp = limpaWhats(document.getElementById('WhatsApp').value);

    if (confirm('Deseja apagar ' + nome + ' ?')) {
        location.href = 'ItemSolicitacao.aspx?CMD=DELETAR&ID=' + ID + '&WhatsApp=' + WhatsApp;
    }
}

function limpaWhats(num) {
    return num.replace('(', '').replace(')', '').replace('-', '').replace(/\s/g, '');
}

function doTab(ori, des) {
    if (!(ori.value.length > ori.maxlength)) {
        des.focus();
    }
}

function displayDivNone(obj) {
    if(obj != null)
        obj.style.display = 'none';
}

function pagoOkSolic(ID) {
    document.getElementById('CMD').value = 'PAGO';
    document.getElementById('IDSolicitacao').value = ID;
    document.getElementById('aspnetForm').submit();
}

function cancelarSolic(ID) {
    document.getElementById('CMD').value = 'CANCELAR';
    document.getElementById('IDSolicitacao').value = ID;
    document.getElementById('aspnetForm').submit();
}

function confirmaSolic(ID) {
//    document.getElementById('CMD').valzue = 'CONFIRMA';
//    __doPostBack('Page_load', '');
//    //document.aspnetForm.submit();
//    return true;
}

// jQuery Nativo ** NÃO MEXER **
window.onload = function () {
    var slideMenuButton = document.getElementById('slide-menu-button');
    slideMenuButton.onclick = function (e) {
        var site = document.getElementById('site');
        var cl = site.classList;
        if (cl.contains('open')) {
            cl.remove('open');
        } else {
            cl.add('open');
        }
    };

//    var pageNav = document.getElementById('pageNav');
//    var pageLinks = pageNav.getElementsByTagName('a');
//    for (var k = pageLinks.length - 1; k >= 0; k--) {
//        pageLinks[k].onclick = function (e) {
//            var site = document.getElementById('site');
//            var cl = site.classList;
//            if (cl.contains('open')) {
//                cl.remove('open');
//            }
//        };
//    };
}