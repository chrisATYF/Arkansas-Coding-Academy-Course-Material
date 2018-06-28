class UserList{
    constructor(name, genre) {
        var self = this;
        this._name = name;
        this._genre = genre;
    }
    get name() {
        return this._name;
    }
    set name(name) {
        this._name = name;
    }
    get genre() {
        return this._genre;
    }
    set genre(genre) {
        this._genre = genre;
    }
}

var favBandList = [];

function enterKeyPressed() {
    if (window.event.keyCode == 13) {
        addBand();
    }
}

function addBand() {
    //get the text from the textbox
    var bandBox = document.getElementById('bandName').value;
    var bandBoxGenre = document.getElementById('bandGenre').value;

    if (bandBox == '' && bandBoxGenre == '' || bandBox == '' || bandBoxGenre == '') {
        alert('Enter two values');
    } else {

        //create new instance of BandList() and pass the text from the textbox
        var newBand = new UserList(bandBox, bandBoxGenre);

        //push that new instance of the BandList() to the array
        favBandList.push(newBand);

        //create a tr & td element
        var tableRow = document.createElement('tr');
        var tableData = document.createElement('td');
        var tableGenre = document.createElement('td');
        tableRow.appendChild(tableData);
        tableRow.appendChild(tableGenre);

        //set it's text to the new instance of the BandList().name
        tableData.textContent = newBand.name;
        tableGenre.textContent = newBand.genre;

        //add the td element to the DOM
        var tableBody = document.getElementById('bandBody');
        tableBody.appendChild(tableRow);

        //clear out the textbox
        document.getElementById('bandName').value = '';
        document.getElementById('bandGenre').value = '';
        document.getElementById('bandName').focus();
    }
}