// Rotate dad joke every 10 seconds

setInterval(getRandomJoke, 10000);

function getRandomJoke() {
    var xhr = new XMLHttpRequest();

    xhr.onload = function () {
        if (xhr.status === 200) {
            document.getElementById('rotatingJoke').innerHTML = xhr.responseText;
        }
    };

    xhr.open('GET', 'Home/DadJoke', true);
    xhr.send(null);
}

$(document).ready(function () {
    var searchTerm = document.getElementById("searchInput").defaultValue;
    var jokeElements = document.getElementsByClassName("joke-result");

    if (jokeElements.length > 0) {
        for (var x = 0; x < jokeElements.length; x++) {
            jokeElements[x].innerHTML = highlightSearchTerms(searchTerm, jokeElements[x].innerHTML);
        }
    }
});

function highlightSearchTerms(searchTerm, targetJoke) {
    var re = new RegExp(searchTerm, "g");
    var highlightedJoke = targetJoke.replace(re, "<span class=highlight>" + searchTerm + "</span>");

    return highlightedJoke;
}



