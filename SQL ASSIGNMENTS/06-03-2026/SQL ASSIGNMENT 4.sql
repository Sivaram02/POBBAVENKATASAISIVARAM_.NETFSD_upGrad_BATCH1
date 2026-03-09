--ASSIGNMENT 4--
INSERT INTO Departments VALUES
(1,'Computer Science','Block A'),
(2,'Mechanical','Block B'),
(3,'Electrical','Block C'),
(4,'Civil','Block D'),
(5,'Business','Block E');

INSERT INTO Teachers VALUES
(1,'John','john@mail.com',1,'2021-01-10'),
(2,'David','david@mail.com',2,'2023-02-10'),
(3,'Smith','smith@mail.com',1,'2020-06-15'),
(4,'Anna','anna@mail.com',3,'2022-08-12'),
(5,'Peter','peter@mail.com',4,'2021-04-22');

INSERT INTO Students VALUES
(1,'Amit','Kumar','2006-05-10','M',1,'2023-06-01'),
(2,'Anita','Sharma','2005-07-11','F',1,'2023-06-01'),
(3,'Rahul','Reddy','2007-03-12','M',2,'2023-06-01'),
(4,'Priya','Nair','2006-01-02','F',3,'2023-06-01'),
(5,'Arjun','Singh','2005-10-10','M',1,'2023-06-01');

INSERT INTO Courses VALUES
(1,'Database Systems',4,1,1),
(2,'Thermodynamics',3,2,2),
(3,'Circuit Analysis',4,3,4),
(4,'Structural Design',3,4,5),
(5,'Business Analytics',4,5,NULL);

INSERT INTO Enrollments VALUES
(1,1,1,GETDATE()),
(2,2,1,GETDATE()),
(3,3,2,GETDATE()),
(4,4,3,GETDATE()),
(5,5,1,GETDATE());

INSERT INTO Exams VALUES
(1,1,'2024-05-10','Midterm'),
(2,1,'2024-06-15','Final'),
(3,2,'2024-05-12','Midterm'),
(4,3,'2024-05-20','Midterm'),
(5,4,'2024-05-25','Final');

INSERT INTO Marks VALUES
(1,1,1,85),
(2,2,1,78),
(3,3,3,70),
(4,4,4,88),
(5,5,2,92);