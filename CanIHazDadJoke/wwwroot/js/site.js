// Rotate dad joke every 10 seconds

setInterval(getRandomJoke, 10000);

function getRandomJoke(){
    var xhr = new XMLHttpRequest();

    xhr.onload = function () {
        if (xhr.status === 200) {
            document.getElementById('rotatingJoke').innerHTML = xhr.responseText;
        }
    };

    xhr.open('GET', 'Home/DadJoke', true);
    xhr.send(null);
}

