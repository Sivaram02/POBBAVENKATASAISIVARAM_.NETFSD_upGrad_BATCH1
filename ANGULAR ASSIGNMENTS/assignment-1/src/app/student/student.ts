import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common'; // ✅ needed for ngIf & ngFor

// 🔹 Product Model
interface Product {
  id: number;
  name: string;
  price: number;
  quantity: number;
}

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [FormsModule, CommonModule], // ✅ FIXED HERE
  templateUrl: './student.html',
  styleUrls: ['./student.css']
})
export class StudentComponent {

  // 🔹 Task 1: One-way binding
  name = "John";
  imageUrl = 'task1.png';

  showAlert() {
    alert("Button clicked!");
  }

  // 🔹 Task 2: Two-way binding
  name2 = '';
  email = '';

  // 🔹 Task 3 & 4: Model + Product Data
  products: Product[] = [
    { id: 1, name: 'Laptop', price: 800, quantity: 5 },
    { id: 2, name: 'Mouse', price: 200, quantity: 10 },
    { id: 3, name: 'Keyboard', price: 600, quantity: 3 }
  ];

  // 🔹 Task 5: ngIf (Login toggle)
  isLoggedIn = false;

  toggleLogin() {
    this.isLoggedIn = !this.isLoggedIn;
  }

  // 🔹 Task 6: ngFor (Courses)
  courses = ['Angular', 'React', '.NET'];

  // 🔹 Task 8: Student Info
  age = 22;
  course = 'Angular';
}