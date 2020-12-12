CREATE VIEW [dbo].[vwDepartmentCourseCount]
AS
SELECT   Department.DepartmentID, Department.Name, COUNT(Course.CourseID) as CourseCount
FROM     Department LEFT JOIN Course ON Course.DepartmentID = Department.DepartmentID
GROUP BY Department.DepartmentID, Department.Name
