CREATE TABLE [dbo].[Patient]
(
	[PatientID] INT NOT NULL PRIMARY KEY, 
    [RoomNumberID] INT NOT NULL, 
    [MedicalCardID] INT NOT NULL, 
    [DateOfBirth] NCHAR(10) NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Gender] NCHAR(10) NOT NULL, 
    CONSTRAINT [FK_Patient_RoomNumber] FOREIGN KEY ([RoomNumberID]) REFERENCES [Room]([RoomID])
)
