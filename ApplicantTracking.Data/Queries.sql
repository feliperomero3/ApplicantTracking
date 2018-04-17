/* Migrations */

USE [ApplicantTracking]
SELECT *
FROM [dbo].[__MigrationHistory]

EXEC sp_help '[dbo].[__MigrationHistory]'

/**/
USE [ApplicantTracking]
SELECT *
FROM [dbo].[AspNetRoles]

/**/
USE [ApplicantTracking]
SELECT *
FROM [dbo].[AspNetUserRoles]

/**/
USE [ApplicantTracking]
SELECT *
FROM [dbo].[AspNetUsers]

/**/

SELECT *
FROM [dbo].[Applicant]


SELECT *
FROM [dbo].[Domicilio]
