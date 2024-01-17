-- Creating a new database
create database TrainingDB
--select database
use TrainingDB
-- Creating a new table
CREATE TABLE ParticipantList
(
	ParticipantID BIGINT IDENTITY(1,1) NOT NULL,
	FirstName VARCHAR(30),
	LastName VARCHAR(30),
	OfficialEmail VARCHAR(100)
)
--add table value
insert into ParticipantList values('Alfiya','Sainudeen','alfiya@gmail.com')
insert into ParticipantList values('Althaf','Sainudeen','althaf@gmail.com')

select*from ParticipantList

-- Deleting all rows from the ParticipantList table
TRUNCATE TABLE ParticipantList


-- Deleting table from the database
DROP TABLE ParticipantList


-- Deleting the database
DROP DATABASE TrainingDB

--rename table name
sp_rename 'ParticipantList','Participants'
select*from Participants                                                                                                                                                                                    
sp_rename 'Participants.OfficialEmail' ,'Email' 