class Shapes {

    area(length: number, breadth?: number): number {
        if (breadth !== undefined) {
            return length * breadth; 
        } else {
            return length * length; 
        }
    }

    areaCircle(radius: number): number {
        return Math.PI * radius * radius;
    }

    areaTriangle(base: number, height: number): number {
        return 0.5 * base * height;
    }
}

const shape = new Shapes();

console.log("Rectangle Area:", shape.area(10, 5));
console.log("Square Area:", shape.area(4));
console.log("Circle Area:", shape.areaCircle(7));
console.log("Triangle Area:", shape.areaTriangle(6, 8));