
USE newdb
SELECT s.StudentFirstName, d.DepartmentName
FROM Students s
JOIN Departments d
ON s.DepartmentID = d.DepartmentID;

SELECT c.CourseName, t.TeacherName
FROM Courses c
JOIN Teachers t
ON c.TeacherID = t.TeacherID;

SELECT s.StudentFirstName, c.CourseName
FROM Students s
JOIN Enrollments e ON s.StudentID = e.StudentID
JOIN Courses c ON e.CourseID = c.CourseID;

SELECT s.StudentFirstName, e.ExamType, m.MarksObtained
FROM Students s
JOIN Marks m ON s.StudentID = m.StudentID
JOIN Exams e ON m.ExamID = e.ExamID;

SELECT c.CourseName, t.TeacherName
FROM Courses c
LEFT JOIN Teachers t
ON c.TeacherID = t.TeacherID;

SELECT * FROM Teachers WHERE TeacherID NOT IN (SELECT TeacherID FROM Courses);