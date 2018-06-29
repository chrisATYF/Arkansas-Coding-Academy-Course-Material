class Card{
    constructor(suite, value) {
        
    }
}

var cardValues = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'Jack', 'Queen', 'King', 'Ace', '2', '3', '4', '5', '6', '7', '8', '9', '10', 'Jack', 'Queen', 'King', 'Ace', '2', '3', '4', '5', '6', '7', '8', '9', '10', 'Jack', 'Queen', 'King', 'Ace', '2', '3', '4', '5', '6', '7', '8', '9', '10', 'Jack', 'Queen', 'King', 'Ace'];
var cardSuites = ['Hearts', 'Clubs', 'Diamonds', 'Spades'];

function shuffle(cards) {
    var shuffledHand = [];
    for (var i = 0; i < 5; i++) {
        shuffledHand.push(cards.splice(Math.random() * (cards.length - 1), 1).pop());
    }
    return shuffledHand;
}

function shuffleSuite(suites) {
    var shuffledSuite = [];
    for (var i = 0; i < 5; i++) {
        shuffledSuite.push(suites.splice(Math.random() * (suites.length - 1), 1).pop());
    }
    if (shuffledSuite[4] == undefined) {
        shuffledSuite.pop();
    }
    return shuffledSuite;
}

console.log(shuffle(cardValues));
console.log(shuffleSuite(cardSuites));