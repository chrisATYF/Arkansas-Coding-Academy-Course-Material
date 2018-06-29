
class TicTac{
    constructor(xPos, yPos){
        this._xPos = xPos;
        this._yPos = yPos;
        this._value;
        this._isChecked = false;
    }

    get xPos(){
        return this._xPos;
    }
    get yPos(){
        return this._yPos;
    }
    get isChecked(){
        return this._isChecked;
    }
    get value(){
        return this._value;
    }
    setTicTac(play){
        if(!this._isChecked){
            this._value = play;
        } else {
            this._value = '';
        }

        this._isChecked = !this._isChecked;
    }
    toString(){
        return 'I am (' + this._xPos + ', ' + this._yPos + '). Value: ' + this._value;
    }
}


class TicTacToeBoard{
    constructor(ticTacs){
        this._ticTacs = ticTacs;
    }

    get ticTacs(){
        return this._ticTacs;
    }

    makeMove(){
        var nextPlay = 'X';
        if (this.nextPlay == 'X'){
            this.nextPlay = 'O';
        } else {
            this.nextPlay = 'X'
        }
        return this.nextPlay;
    }

    isWinner(){
        for(var i = 0; i < this._ticTacs.length; i++){

            if(this._ticTacs[i].isChecked){

                //look diag l-to-r
                if (this._ticTacs[i].xPos == 0 && this._ticTacs[i].yPos == 0){

                    var diagTicTac1 = this._ticTacs[i + 4];
                    var diagTicTac2 = this._ticTacs[i + 8];

                    if (diagTicTac1.isChecked && diagTicTac2.isChecked){
                        if ((this._ticTacs[i].value == diagTicTac1.value) && (this._ticTacs[i].value  == diagTicTac2.value)){
                            alert('winner');
                        }
                    }
                }

                //look diag r-to-l
                if (this._ticTacs[i].xPos == 0 && this._ticTacs[i].yPos == 2){
                    
                    var diagTicTac11 = this._ticTacs[i + 2];
                    var diagTicTac22 = this._ticTacs[i + 4];

                    if (diagTicTac11.isChecked && diagTicTac22.isChecked){
                        if ((this._ticTacs[i].value == diagTicTac11.value) && (this._ticTacs[i].value  == diagTicTac22.value)){
                            alert('winner');
                        }
                    }
                }

                //look to the right if it's in the first column
                if (this._ticTacs[i].yPos == 0){

                    var rightTicTac1 = this._ticTacs[i + 1];
                    var rightTicTac2 = this._ticTacs[i + 2];

                    if (rightTicTac1.isChecked && rightTicTac2.isChecked){
                        if ((this._ticTacs[i].value == rightTicTac1.value) && (this._ticTacs[i].value  == rightTicTac2.value)){
                            alert('winner');
                        }
                    }
                }

                //look down if it's in the first row
                if (this._ticTacs[i].xPos == 0){

                    var downTicTac1 = this._ticTacs[i + 3];
                    var downTicTac2 = this._ticTacs[i + 6];

                    if(downTicTac1.isChecked && downTicTac2.isChecked){
                        if ((this._ticTacs[i].value == downTicTac1.value) && (this._ticTacs[i].value  == downTicTac2.value)){
                            alert("winner");
                        }
                    }
                }
            }
        }
    }
}

var tics = new TicTac();
var theGame = new TicTacToeBoard(tics);

$(document).ready(function () {

    $('.ticBox').click(function (e) {
        $(this).text(theGame.makeMove());
    });

    $('.btn').click(function (e) {
        $('.ticBox').html('<pre> </pre>');
        theGame.nextPlay = 'O';
    });

});