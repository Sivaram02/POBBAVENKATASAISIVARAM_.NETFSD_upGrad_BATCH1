"use strict";
class Student {
    rollNo;
    studName;
    marksEng;
    marksMaths;
    marksScience;
    constructor(rollNo, name, eng, maths, sci) {
        this.rollNo = rollNo;
        this.studName = name;
        this.marksEng = eng;
        this.marksMaths = maths;
        this.marksScience = sci;
    }
    calculateTotal() {
        return this.marksEng + this.marksMaths + this.marksScience;
    }
    calculatePercentage() {
        return this.calculateTotal() / 3;
    }
    display() {
        console.log("Roll No:", this.rollNo);
        console.log("Name:", this.studName);
        console.log("Total Marks:", this.calculateTotal());
        console.log("Percentage:", this.calculatePercentage() + "%");
    }
}
const student1 = new Student(1, "Anjali", 85, 90, 80);
student1.display();
