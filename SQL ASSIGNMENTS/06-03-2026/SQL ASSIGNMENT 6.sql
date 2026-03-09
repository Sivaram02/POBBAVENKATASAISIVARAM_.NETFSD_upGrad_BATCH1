--ASSIGMENT 6--
SELECT DepartmentID, COUNT(*) AS TotalStudents FROM Students GROUP BY DepartmentID;

SELECT ExamID, AVG(MarksObtained) FROM Marks GROUP BY ExamID;

SELECT CourseID, COUNT(StudentID) FROM Enrollments GROUP BY CourseID;

SELECT ExamID, MAX(MarksObtained) FROM Marks GROUP BY ExamID;

SELECT CourseID, MIN(MarksObtained) FROM Exams JOIN Marks ON Exams.ExamID = Marks.ExamID
GROUP BY CourseID;

SELECT DepartmentID, COUNT(*) AS StudentCount FROM Students GROUP BY DepartmentID HAVING COUNT(*) > 5;