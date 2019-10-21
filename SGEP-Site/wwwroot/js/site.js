﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/*$(document).ready(function () {
    $(".formulario").submit(function () {
        $(".submit-btn").prop("disabled", true);
        return true;
    });
});*/

$("form").submit(function () {
    if ($(this).valid()) {
        $(this).submit(() => false);
        return true;
    }
    else
    {
        return false;
    }
});

$("input:radio[id^=tipo-mov-]").on('change', (e) => {
    console.log(e.target.id);
    if (e.target.id == 'tipo-mov-saida')
        trocarElementos('saida', 'entrada');
    else if (e.target.id == 'tipo-mov-entrada')
        trocarElementos('entrada', 'saida');
});

$(document).ready(function() {
    $('[data-toggle="tooltip"]').tooltip()
});