// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

setInterval(UpdateJoke, 3000);

function UpdateJoke() {
    $.ajax({
        url: '/Home/Index',
        type: 'GET',
        cache: false,
        async: true,
        success: function (result) {
            $('#myJoke').html(result);
        }
    });
}
