CREATE TABLE [dbo].[Doctor]
(
	[DoctorID] INT NOT NULL PRIMARY KEY, 
    [OfficeID] INT NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Room_Office] FOREIGN KEY ([OfficeID]) REFERENCES [Room]([RoomID])
)
