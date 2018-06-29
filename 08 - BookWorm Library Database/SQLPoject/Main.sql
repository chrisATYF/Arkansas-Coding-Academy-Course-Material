/*
	1. List the most popular genre of books checked out for each member

Chris: Classics - 16
Gauri: Classics - 15
Paul: Classics & Philosophy - 9
Phillip: Classics - 9
*/
select g.Name, m.FirstName, count(g.Name) as 'GenreCount' from Checkouts c
join Books b on b.Id = c.BookId
join Genres g on g.Id = b.GenreId
join Members m on m.Id = c.MemberId
group by g.Name, m.FirstName
order by GenreCount desc

/*
	2. List the most popular author of books checked out for each member

	Chris: F. Scott Fitzgerald & Plato - 6
	Gauri: F. Scott Fitzgerald - 6
	Paul: F. Scott Fitzgerald & John Steinbeck - 4
	Phillip: F. Scott Fitzgerald - 4
*/
select a.Name, m.FirstName, count(a.Name) as 'AuthorCount' from Checkouts c
join Books b on b.Id = c.BookId
join Authors a on a.Id = b.AuthorId
join Members m on m.Id = c.MemberId
group by a.Name, m.FirstName
order by AuthorCount desc

/*
	3. If checked out and returned after the due date, what is the most expensive book?

	Candide at $13.07
*/
select Title, Price, LatePrice, sum(Price + LatePrice) as 'AddedPrice'
from Books
where Price + LatePrice > 13.00
group by Title, Price, LatePrice

/*
	4. List the first book that was checked out by each member

	Chris: Open on January 8th, 2017
	Gauri: Open on January 12th, 2017
	Paul: The Shape of Water on January 3rd 2017
	Phillip: Candide on January 1st 2017
*/
select b.Title, m.FirstName, CheckOutDate from Checkouts c
join Books b on b.Id = c.BookId
join Members m on m.Id = c.MemberId
-- Put each member name into quotes
where m.FirstName = 'Phillip'
group by b.Title, m.FirstName, CheckoutDate
order by CheckOutDate asc

/*
	5. List the most recent book that was checked out by each member

	Chris: The Alchemist on December 30th 2017
	Gauri: The Alchemist on December 30th 2017
	Paul: The Symposium on December 22nd 2017
	Phillip: Siddhartha on December 28th 2017
*/
select b.Title, m.FirstName, CheckOutDate from Checkouts c
join Books b on b.Id = c.BookId
join Members m on m.Id = c.MemberId
-- Put each member name into quotes
where m.FirstName = 'Phillip'
group by b.Title, m.FirstName, CheckoutDate
order by CheckOutDate desc

/*
	6. Which decade in the 20th century has the most books?
	The 1920's
*/
select Title, PublishedYear from Books
where PublishedYear between 1900 and 1999

/*
	7. List the number of currently checked out books by author

	13 books currently not Checked in
*/
select DueDate, CheckInDate from Checkouts
where CheckInDate is null

/*
	8. List the sum of book price by genre

	Biography: $25.94
	Classics: $39.87
	Philosophy: $19.67
	Science Fiction: $35.90
	Poetry: null
	Cookbooks: null
	Young Adult: null
*/
select sum(Price) from Books
-- increment GenreId
where GenreId = 1

/*
	9. Which book has the greatest difference between the Price and the LatePrice?

	The Grapes Of Wrath: $9.30 difference
*/
select Title, sum(Price - LatePrice) as 'PriceDifference' from Books
group by Title
order by PriceDifference desc

/*
	10. Which author had the most books checked out (and returned) in Feb 2017?

	F. Scott Fitzgerald with five books checked out and returned in February
*/
select a.Name, c.CheckInDate from Checkouts c
join Books b on b.Id = c.BookId
join Authors a on a.Id = b.AuthorId
where c.CheckInDate is not null
and b.AuthorId = 7
and CheckInDate between '2017-02-01 00:00:00.0000000' and '2017-02-28 00:00:00.0000000'
order by CheckInDate asc