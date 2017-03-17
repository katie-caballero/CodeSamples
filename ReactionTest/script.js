var start = new Date().getTime();

document.getElementById("startGame").onclick = function(){
    appearAfterDelay();
}

document.getElementById("stopGame").onclick = function() {
    document.getElementById("thanksForPlaying").innerHTML = "Thank you for playing!";
    document.getElementById("thanksForPlaying").style.display = "block";
    document.getElementById("shape").style.display = "none";
}

function getRandomColor() {
    var letters = '0123456789ABCDEF';
    var color = '#';
    for (var i = 0; i < 6; i++ ) {
        color += letters[Math.floor(Math.random() * 16)];
    }
    return color;
}

function makeShapeAppear(){

    var top = Math.random() * 400;
    var left = Math.random() * 400;
    var width = (Math.random() * 300) + 100;

    if(Math.random() > 0.5){
        document.getElementById("shape").style.borderRadius = "50%";
    }
    else
        document.getElementById("shape").style.borderRadius = "0%";


    document.getElementById("shape").style.top = top + "px";
    document.getElementById("shape").style.left = left + "px";
    document.getElementById("shape").style.width = width + "px";
    document.getElementById("shape").style.height = width + "px";
    document.getElementById("shape").style.backgroundColor = getRandomColor();

    document.getElementById("shape").style.display = "block";
    start = new Date().getTime();
}

function appearAfterDelay(){
    setTimeout(makeShapeAppear, Math.random() * 2000);
}

document.getElementById("shape").onclick = function(){
    
    document.getElementById("shape").style.display = "none";
    
    var end = new Date().getTime(); //milliseconds
    var timetaken = (end - start) / 1000; //divide to get seconds

    document.getElementById("timeTaken").innerHTML = timetaken + "s";

   appearAfterDelay();

   var seasons = ["sring", "winter"];
   console.log = seasons[0].value;
}

