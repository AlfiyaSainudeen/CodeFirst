sp_helpindex person

--create index
create clustered index participa_cluster on Participants(ParticipantID)
create nonclustered index email_non_cluster on Participants(Email)
sp_helpindex Participants
