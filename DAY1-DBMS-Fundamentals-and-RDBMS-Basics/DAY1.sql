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

