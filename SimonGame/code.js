let btnColor = ["red", "blue", "green", "yellow"];
let rdmColor = btnColor[Sequence()];
let gamePattern = [];
gamePattern.push(rdmColor);
let userPattern = [];
var level = 0;

$(document).keypress(function() {
    startingColor();
    $("h1").text("Level " + level);
});

$(".btn").click(function () {
    var clickedColor = $(this).attr("id");
    userPattern.push(clickedColor);

    addAnimation(clickedColor);
    playSound(clickedColor);

    console.log(userPattern);
});

function startingColor() {
    for (let i = 0; i < gamePattern.length; i++) {
        playSound(gamePattern[i]);
        addAnimation(gamePattern[i]);
    }
}

function playSound(clickedColor) {
    switch (clickedColor) {
        case 'red':
            let red = new Audio("sounds/red.mp3");
            red.play();
            break;
        case 'blue':
            let blue = new Audio("sounds/blue.mp3");
            blue.play();
            break;
        case 'green':
            let green = new Audio("sounds/green.mp3");
            green.play();
            break;
        case 'yellow':
            let yellow = new Audio("sounds/yellow.mp3");
            yellow.play();
            break;
        default: console.log(gamePattern);
    }
}

function addAnimation(clickedColor) {
    $("#" + clickedColor).addClass("pressed").animate({ opacity: 1 });

    setTimeout(() => {
        $("#" + clickedColor).removeClass("pressed")
    }, 200);
}

function Sequence() {
    var randomnumber = Math.floor(Math.random() * 4);
    return randomnumber;
}



