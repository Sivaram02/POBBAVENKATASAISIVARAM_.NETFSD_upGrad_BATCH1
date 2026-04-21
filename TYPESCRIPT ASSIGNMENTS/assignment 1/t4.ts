class Student {
    rollNo: number;
    studName: string;
    marksEng: number;
    marksMaths: number;
    marksScience: number;

    constructor(rollNo: number, name: string, eng: number, maths: number, sci: number) {
        this.rollNo = rollNo;
        this.studName = name;
        this.marksEng = eng;
        this.marksMaths = maths;
        this.marksScience = sci;
    }

    calculateTotal(): number {
        return this.marksEng + this.marksMaths + this.marksScience;
    }

    calculatePercentage(): number {
        return this.calculateTotal() / 3;
    }

    display(): void {
        console.log("Roll No:", this.rollNo);
        console.log("Name:", this.studName);
        console.log("Total Marks:", this.calculateTotal());
        console.log("Percentage:", this.calculatePercentage() + "%");
    }
}


const student1 = new Student(1, "Anjali", 85, 90, 80);
student1.display();