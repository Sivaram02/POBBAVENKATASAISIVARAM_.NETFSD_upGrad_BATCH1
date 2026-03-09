--ASSIGNMENT 10--
CREATE INDEX idx_student_lastname ON Students(LastName);

CREATE INDEX idx_teacher_email ON Teachers(Email);

CREATE INDEX idx_enrollments ON Enrollments(StudentID, CourseID);

CREATE UNIQUE INDEX idx_departmentname ON Departments(DepartmentName);

DROP INDEX idx_teacher_email ON Teachers;