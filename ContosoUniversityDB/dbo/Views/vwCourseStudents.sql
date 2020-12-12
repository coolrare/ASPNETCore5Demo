CREATE VIEW [dbo].[vwCourseStudents]
AS
SELECT   Department.DepartmentID, Department.Name as DepartmentName,
		 Course.CourseID, Course.Title as CourseTitle,
		 Person.ID as StudentID, Person.FirstName + ' ' + Person.LastName as StudentName
FROM     Course
		 LEFT JOIN Department ON Course.DepartmentID = Department.DepartmentID
		 LEFT JOIN Enrollment ON Enrollment.CourseID = Course.CourseID
		 LEFT JOIN Person ON Enrollment.StudentID = Person.ID
