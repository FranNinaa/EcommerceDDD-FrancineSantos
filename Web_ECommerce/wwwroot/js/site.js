﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var ObjetoAlerta = new Object();

ObjetoAlerta.AlertaTela = function (tipo, messagem) {
    

    var classeTipoAlerta = "";

    if (tipo == 1) {
        classeTipoAlerta = "alert alert-sucess";
    } else if(tipo == 2){
        classeTipoAlerta = "alert alert-warning";
    } else if (tipo == 3) {
        classeTipoAlerta = "alert alert-danger";
    }

    var divAlert = $("<div>", { class: classeTipoAlerta });
    divAlert.append('<a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>')
    divAlert.append('<strong> ' + messagem + ' </strong>');

    $("#AlertaJS").html(divAlert);
    window.setTimeout(function () {
        $(".alert").fadeTo(1500, 0).slideUp(500, function () {
            $(this).remove();
        })
    }, 5000);
}
