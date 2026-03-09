--ASSIGNMENT 9--
CREATE VIEW StudentInfo AS SELECT s.StudentID,s.StudentFirstName + ' ' + s.LastName AS StudentName,d.DepartmentName
FROM Students s
JOIN Departments d
ON s.DepartmentID = d.DepartmentID;

CREATE VIEW StudentCourses AS
SELECT s.StudentFirstName,
       c.CourseName,
       e.EnrollmentDate
FROM Students s
JOIN Enrollments e ON s.StudentID=e.StudentID
JOIN Courses c ON e.CourseID=c.CourseID;

CREATE VIEW ExamResults AS
SELECT s.StudentFirstName,
       c.CourseName,
       ex.ExamType,
       m.MarksObtained
FROM Students s
JOIN Marks m ON s.StudentID=m.StudentID
JOIN Exams ex ON m.ExamID=ex.ExamID
JOIN Courses c ON ex.CourseID=c.CourseID;

SELECT * FROM StudentInfo;

DROP VIEW StudentInfo;