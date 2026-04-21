"use strict";
class Book {
    isbn;
    bookName;
    bookTitle;
    bookAuthor;
    quantityOfBooks;
    bookPrice;
    constructor(isbn, name, title, author, qty, price) {
        this.isbn = isbn;
        this.bookName = name;
        this.bookTitle = title;
        this.bookAuthor = author;
        this.quantityOfBooks = qty;
        this.bookPrice = price;
    }
    calculateBill() {
        return this.quantityOfBooks * this.bookPrice;
    }
    displayDetails() {
        console.log("ISBN:", this.isbn);
        console.log("Book Name:", this.bookName);
        console.log("Title:", this.bookTitle);
        console.log("Author:", this.bookAuthor);
        console.log("Quantity:", this.quantityOfBooks);
        console.log("Price per Book:", this.bookPrice);
        console.log("Total Bill:", this.calculateBill());
    }
}
const book1 = new Book(101, "TS Guide", "Learn TypeScript", "John Doe", 3, 500);
book1.displayDetails();
