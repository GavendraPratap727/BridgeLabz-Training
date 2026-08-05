use HealthClinic;

CREATE TABLE Doctor(
DoctorID INT IDENTITY(1,1) Primary KEy,
Name VARCHAR(50) NOT NULL,
Expertise VARCHAR(100) NOT NULL,
Phone VARCHAR(15) NOT NULL UNIQUE );

CREATE TABLE Patient(
PatientID INT IDENTITY(1,1) Primary KEy,
Name VARCHAR(50) NOT NULL,
DOB DATE not null,
Gender CHAR(1) Check(Gender IN('M','F','O')),
Phone VARCHAR(15)  UNIQUE,
PDescription  VARCHAR(500),
Address VARCHAR(200) ,
DoctorID INT NOT NULL, 
CONSTRAINT FRDoctor   
FOREIGN KEY (DoctorID)
REFERENCES Doctor(DoctorID)
);

CREATE TABLE Appointment(
AppointmentID int Identity(1,1) PRIMARY KEY,
DoctorID INT NOT NULL,
PatientID INT NOT NULL,
AppointmentDate DATETIME NOT NULL,
Status VARCHAR(20) DEFAULT 'Scheduled' check (STATUS in('Scheduled','Completed','Cancelled','No Show')),
Reason VARCHAR(255),
CONSTRAINT FDOCTOR FOREIGN KEY (DoctorID) 
 REFERENCES Doctor(DoctorID) ON DELETE CASCADE,
CONSTRAINT FPatient FOREIGN KEY (PatientID) 
 REFERENCES Patient(PatientID) ON DELETE CASCADE
);
--day2 
--Q1
CREATE TABLE Room(
RoomId int Identity(1,1) PRIMARY KEY,
RoomNumber VARCHAR(10) not null,
RoomType VARCHAR(50)
);
ALTER TABLE Doctor
ADD RoomID INT NULL,
CONSTRAINT FK_Doctor_Room FOREIGN KEY (RoomID) REFERENCES Room(RoomID);
------


Insert into Room(RoomNumber,RoomType)
Values
('101','Consultation'),
('102','Consultation'),
('103','Consultation'),
('104','Consultation');

INSERT INTO Doctor (Name, Expertise, Phone)
VALUES
('Dr. Sharma','Cardiology','9000000001'),
('Dr. Verma','Dermatology','9000000002'),
('Dr. Khan','Orthopedics','9000000003'),
('Dr. Gupta','Pediatrics','9000000004');

UPDATE Doctor SET RoomID = 1 WHERE DoctorID = 1;
UPDATE Doctor SET RoomID = 2 WHERE DoctorID = 2;
UPDATE Doctor SET RoomID = 3 WHERE DoctorID = 3;
UPDATE Doctor SET RoomID = 4 WHERE DoctorID = 4;

INSERT INTO Patient (Name, DOB, Gender, Phone, PDescription, Address, DoctorID)
VALUES
('Patient1','1990-01-01','M','9800000001','Routine patient record','Address line 1',1),
('Patient2','1985-05-12','F','9800000002','Routine patient record','Address line 2',2),
('Patient3','1978-03-23','M','9800000003','Routine patient record','Address line 3',3),
('Patient4','1995-07-15','F','9800000004','Routine patient record','Address line 4',4),
('Patient5','2000-11-02','O','9800000005','Routine patient record','Address line 5',1),
('Patient6','1992-09-09','M','9800000006','Routine patient record','Address line 6',2);

INSERT INTO Appointment (DoctorID, PatientID, AppointmentDate, Status, Reason)
VALUES
(1,6,'2025-01-05','Scheduled','Routine checkup'),
(2,7,'2025-01-10','Completed','Routine checkup'),
(3,8,'2025-01-15','Cancelled','Routine checkup'),
(4,9,'2025-01-20','No Show','Routine checkup'),
(1,10,'2025-02-01','Scheduled','Routine checkup');


--Q2

SELECT * FROM Appointment where Reason='Routine checkup'; -- NO IndEx

CREATE INDEX IN_Appointment_Status ON Appointment(Status); -- Singke column indexing
SELECT * FROM Appointment WHERE Status = 'Scheduled';

CREATE INDEX IN_Appointment_Status_Date ON Appointment(Status, AppointmentDate); --composite indexing
SELECT * FROM Appointment 
WHERE Status = 'Scheduled' 
AND AppointmentDate >= '2025-01-01';


--q3 
Create table  PatientPhones (
PatientID INT NOT NULL,
Phone VARCHAR(15) NOT NULL,
 PhoneType VARCHAR(20) DEFAULT 'Mobile',
PRIMARY KEY (PatientID, Phone),
CONSTRAINT FK_PatientPhones_Patient FOREIGN KEY (PatientID) 
REFERENCES Patient(PatientID) ON DELETE CASCADE
);

INSERT INTO PatientPhones (PatientID, Phone, PhoneType)
VALUES 
(6, '9800000001', 'Mobile'),
(6, '9800000099', 'Home'),
(7, '9800000002', 'Mobile'),
(8, '9800000003', 'Work');


--Normalization justification

--1NF- Satisfied all column have 1 value 
--2NF-Satisfied There are no partial dependencies
--3NF-Satisfied  There are no transitive dependencies

--Q4

CREATE INDEX IN_Appointment_Covering ON Appointment(DoctorID, AppointmentDate, Status); --Create a covering index for DoctorID, AppointmentDate, and Status

SELECT DoctorID, AppointmentDate, Status 
FROM Appointment 
WHERE DoctorID = 1;



-- day 3

Create table AUditLog(
AuditId int identity(1,1) primary key,
TableName VARCHAR(50) not null,
OperationType VarChar(10) not null,
RecordId int not null,
ChangeDate DATETIME Default GETDATE()
);

CREATE TRIGGER trg_DoctorInsert on Doctor 
After insert
AS
Begin
INSERT into AUditLog(TableName,OperationType,RecordId)
Select 'Doctor','Insert',DoctorID from inserted;
End

CREATE TRIGGER trg_DoctorUpdate ON Doctor
AFTER UPDATE
AS
BEGIN
INSERT into AUditLog(TableName,OperationType,RecordId)
Select 'Doctor','Update',DoctorID from inserted;
End

CREATE TRIGGER trg_Doctor_Delete ON Doctor
AFTER DELETE
AS
BEGIN
    INSERT INTO AuditLog (TableName, OperationType, RecordID)
    SELECT 'Doctor', 'DELETE', DoctorID FROM deleted;
END

CREATE TRIGGER trg_PatientInsert ON Patient
AFTER INSERT
AS
BEGIN
    INSERT INTO AuditLog (TableName, OperationType, RecordID)
    SELECT 'Patient', 'INSERT', PatientID FROM inserted;
END

CREATE TRIGGER trg_PatientUpdate
ON Patient
AFTER UPDATE
AS
BEGIN
    INSERT INTO AuditLog (TableName, OperationType, RecordID)
    SELECT 'Patient', 'UPDATE', PatientID FROM inserted;
END

CREATE TRIGGER trg_PatientDelete
ON Patient
AFTER DELETE
AS
BEGIN
    INSERT INTO AuditLog (TableName, OperationType, RecordID)
    SELECT 'Patient', 'DELETE', PatientID FROM deleted;
END


CREATE TRIGGER trg_AppointmentInsert
ON Appointment
AFTER INSERT
AS
BEGIN
    INSERT INTO AuditLog (TableName, OperationType, RecordID)
    SELECT 'Appointment', 'INSERT', AppointmentID FROM inserted;
END

CREATE TRIGGER trg_Appointment_Update
ON Appointment
AFTER UPDATE
AS
BEGIN
    INSERT INTO AuditLog (TableName, OperationType, RecordID)
    SELECT 'Appointment', 'UPDATE', AppointmentID FROM inserted;
END

CREATE TRIGGER trg_AppointmentDelete
ON Appointment
AFTER DELETE
AS
BEGIN
    INSERT INTO AuditLog (TableName, OperationType, RecordID)
    SELECT 'Appointment', 'DELETE', AppointmentID FROM deleted;
END

select * from AUditLog;


--store procedure



CREATE PROCEDURE sp_InsertPatient
@Name VARCHAR(50),
@DOB DATE,
@Gender CHAR(1),
@Phone VARCHAR(15),
@PDescription VARCHAR(500),
 @Address VARCHAR(200),
@DoctorID INT
AS
BEGIN
INSERT INTO Patient (Name, DOB, Gender, Phone, PDescription, Address, DoctorID)
VALUES (@Name, @DOB, @Gender, @Phone, @PDescription, @Address, @DoctorID);
END

CREATE PROCEDURE sp_UpdatePatient
    @PatientID INT,
    @Name VARCHAR(50),
    @DOB DATE,
    @Gender CHAR(1),
    @Phone VARCHAR(15),
    @PDescription VARCHAR(500),
    @Address VARCHAR(200),
    @DoctorID INT
AS
BEGIN
    UPDATE Patient
    SET
        Name = @Name,
        DOB = @DOB,
        Gender = @Gender,
        Phone = @Phone,
        PDescription = @PDescription,
        Address = @Address,
        DoctorID = @DoctorID
    WHERE PatientID = @PatientID;
END;

CREATE PROCEDURE sp_DeletePatient
    @PatientID INT
AS
BEGIN
    DELETE FROM Patient
    WHERE PatientID = @PatientID;
END;