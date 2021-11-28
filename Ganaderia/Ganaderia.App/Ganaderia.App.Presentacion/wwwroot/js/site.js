// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

$(".miperfil").on("click", function () {
  let tipo = $.cookie('Tipo');
  let id = $.cookie('Id');
  switch (tipo) {
    case "Admin":
        console.log("Admin")
        $(location).attr("href", "../Administrador/ListAdmin");
      break;
    case "Ganadero":
        console.log("Ganadero")
        $(location).attr("href", "../Ganadero/Register?idUser="+id);
      break;
    case "Veterinario":
        console.log("Veterinario")
        $(location).attr("href", "../Solicitud/ListSolicitud");
      break;
    default:
      break;
  }
});
