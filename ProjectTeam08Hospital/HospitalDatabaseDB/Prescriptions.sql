CREATE TABLE [dbo].[Prescriptions]
(
	[PrescriptionID] INT NOT NULL PRIMARY KEY, 
    [DoctorID] INT NOT NULL, 
    [PatientID] INT NOT NULL, 
    [MedicineID] INT NOT NULL, 
    CONSTRAINT [FK_Prescriptions_Doctor] FOREIGN KEY ([DoctorID]) REFERENCES [Doctor]([DoctorID]), 
    CONSTRAINT [FK_Prescriptions_Patient] FOREIGN KEY ([PatientID]) REFERENCES [Patient]([PatientID]),
	CONSTRAINT [FK_Prescriptions_Medicine] FOREIGN KEY ([MedicineID]) REFERENCES [Medicine]([MedicineID])
)
