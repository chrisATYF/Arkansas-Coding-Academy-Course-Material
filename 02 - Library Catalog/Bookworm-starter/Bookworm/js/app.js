class Library{
    constructor() {
        this._books = [];
    }
    get books() {
        return this._books;
    }

    addBook(book) {
        this._books.push(book);
    }

    buildLibrary(target) {
        var $tbody = $(target);

        $.each(this._books, function (b, book) {
            $tbody.append(book.createBookData());
        });
    }

    setBookCount() {
        var count = $('#bookCount').text('Found ' + this._books.length + ' book(s)');
        return count;
    }

    getBookId(pageBookId) {
        var bookId;
        $.each(this._books, function (b, book) {
            bookId = book.id;
            if (bookId == pageBookId) {
                book.updateDetails();
                console.log(book.id);
            }
        });
        return bookId;
    }
}

class Book{
    constructor(id, title, author, genre, coverImg) {
        this._id = id;
        this._title = title;
        this._author = author;
        this._genre = genre;
        this._coverImg = coverImg;
    }
    get id() {
        return this._id;
    }
    get title() {
        return this._title;
    }
    get author() {
        return this._author;
    }
    get genre() {
        return this._genre;
    }
    get coverImg() {
        return this._coverImg;
    }

    createBookData() {
        var row = $('<tr>');
        row.append('<td>' + this._id + '</td>');
        row.append('<td><a href="./details.html?bookId=' + this._id + '">' + this._title + '</a></td>');
        row.append('<td><li>' + this._author + '</li></td>');
        row.append('<td>' + this._genre + '</td>');
        row.append('<td><img src="' + this._coverUrl + '" alt="' + this._title + '" height="100" width="100"/></td>');
        return row;
    }

    updateDetails() {
        $('#bookId').val(this._id);
        $('#bookTitle').val(this._title);
        $('#bookAuthor').append('<li>' + this._author + '</li>');
        $('#bookImg').append('<img src="' + this._coverUrl + '" alt="' + this._title + '" height="250" width="250"/>');
        $('#crumbTitle').text(this._title);
    }
}

$(document).ready(function() {
    var currentPage = $('body').data('page');

    $.getJSON({
        url: "./data/books.json",
        success: function(d) {
            
            var library = new Library();
            $.each(d.books, function (i, book) {
                var currentBook = new Book(book.id, book.title, book.author, book.genre, book.coverUrl);
                library.addBook(currentBook);
                library.getBookId();
            });

            if (currentPage == 'catalog') {
                library.buildLibrary('#booksToShow');
                library.setBookCount();
            }

            if (currentPage == 'details') {
                var pageBookId = getQueryParameterByName('bookId');
                library.getBookId(pageBookId);
            }

            if (currentPage == 'create') {
                console.log('Create!');
            }
        },
        error: function(d) {
            console.log('Uhh..');
        }
    });

});