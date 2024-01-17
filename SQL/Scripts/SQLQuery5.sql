select*from Participants
--add column
alter table Participants add mobile varchar(1)
--drop column
alter table Participants drop column mobile
alter table Participants add mobile varchar(1)
insert into Participants values('james','Kanna','james@gmail.com','9090909090')
--change data type
alter table Participants alter column mobile varchar(10)
--add primry key
alter table Participants and constraint id_pk primary key(ParticipantID)

--drop constraints
alter table Participants drop constraint id_pk

sp_helpconstraint Participants