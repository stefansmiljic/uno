// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
"use strict";

const connection = new signalR.HubConnectionBuilder().withUrl("/gameHub").build();
const joinControls = document.getElementById("joinControls");
const leaveControls = document.getElementById("leaveControls");
const gameControls = document.getElementById("gameControls");

let gameIdSave = "";

connection.start().then(function () {

}).catch(function (err) {
    return console.error(err.toString());
});

connection.on("Send", (message) => {
    alert(message);
});
// send
function createGame() {
    showLeaveControls();
    connection.invoke("CreateGame").catch(function (err) {
        showJoinControls();
        return console.error(err.toString());
    });
}
function joinGame() {
    showLeaveControls();
    let gameId = document.getElementById("gameId").value;
    gameIdSave = gameId;
    connection.invoke("JoinGame", gameId).catch(function (err) {
        showJoinControls();
        return console.error(err.toString());
    });
}
function startGame() {
    connection.invoke("StartGame").catch(function (err) {
        document.getElementById("startGame").style.visibility = "hidden";
        return console.error(err.toString());
    });
}
function leaveGame() {
    showJoinControls();
    gameIdSave = "";
    connection.invoke("LeaveGame").catch(function (err) {
        document.getElementById("startGame").style.visibility = "visible";
        return console.error(err.toString());
    });
}
function sendAnswer() {
    let answer = document.getElementById("answer").value;
    connection.invoke("SendAnswer", answer).catch(function (err) {
        return console.error(err.toString());
    });
}
// receive
connection.on("PlayerJoined", (playerName) => {
    let message = playerName + " joined the game.";
    alert(message);
});
connection.on("JoinedGame", (gameId) => {
    let message = "Joined game " + gameId;
    alert(message);
});
connection.on("ShowQuestion", (question) => {
    alert(question);
});
connection.on("SwitchTurn", (isYourTurn) => {
    if (isYourTurn) {
        showGameControls();
    }
    else {
        hideGameControls();
    }
});
connection.on("NextGame", (game) => {
    showGameControls();
    document.getElementById("startGame").style.visibility = "hidden";
    alert("Next game");
});
connection.on("GameEnded", (game) => {
    alert("Game ended");
});
connection.on("PlayerLeft", (playerName) => {
    let message = playerName + " left the game.";
    alert(message);
});
connection.on("ScoreUpdated", (score) => {
    alert("Score: " + score);
});
connection.on("ShowAnswer", (answer) => {
    alert("Answer: " + answer);
});