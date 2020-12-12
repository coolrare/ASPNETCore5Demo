CREATE VIEW [dbo].[vwCourseStudentCount]
AS
SELECT   Department.DepartmentID, Department.Name, Course.CourseID, Course.Title, COUNT(Enrollment.StudentID) AS StudentCount
FROM     Course
		 LEFT JOIN Department ON Course.DepartmentID = Department.DepartmentID
		 LEFT JOIN Enrollment ON Enrollment.CourseID = Course.CourseID
GROUP BY Department.DepartmentID, Department.Name, Course.CourseID, Course.Title
