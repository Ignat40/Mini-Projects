let btnColor = ["red", "blue", "green", "yellow"];
let gamePattern = [];
let userPattern = [];
var level = 0;
var gameStarted = false;

$(document).keypress(function () {

    if (!gameStarted) {
        gameStarted = true;
        Sequence();
        $("h1").text("Level " + level);
    }

});

$(".btn").click(function () {

    if (!gameStarted) return;

    var clickedColor = $(this).attr("id");
    userPattern.push(clickedColor);

    addAnimation(clickedColor);
    playSound(clickedColor);

    checkAnswer(userPattern.length - 1);

});

function Sequence() {
    level++;
    userPattern = [];
    $("h1").text("Level " + level);

    var randomnumber = Math.floor(Math.random() * 4);
    let rdmColor = btnColor[randomnumber];
    gamePattern.push(rdmColor);

    startingColor();
}

function startingColor() {
    let color = gamePattern[gamePattern.length - 1];
    playSound(color);
    addAnimation(color);

    setTimeout(() => {
        gameStarted = true;  
    }, 1200);

    
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
        default:
            var audio = new Audio("sounds/" + clickedColor + ".mp3");
            audio.play();

    }
}

function addAnimation(clickedColor) {
    $("#" + clickedColor).addClass("pressed").animate({ opacity: 1 });

    setTimeout(() => {
        $("#" + clickedColor).removeClass("pressed")
    }, 200);
}

function checkAnswer(currentLevel) {

    if (userPattern[currentLevel] === gamePattern[currentLevel]) {
        if (userPattern.length === gamePattern.length) {
            setTimeout(() => {
                Sequence();
            }, 1000);
        }
    } else {
        gameOver();
    }
}

function gameOver() {
    $("body").addClass("game-over");
    setTimeout(() => {
        $("body").removeClass("game-over");
    }, 300);
    playSound("wrong");
    $("h1").text("Game over, Press Any Key to Restart...");
    gameStarted = false;
    level = 0;
    gamePattern = [];

}
