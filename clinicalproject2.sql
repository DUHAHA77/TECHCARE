create database clinicalproject2;
use clinicalproject2;
CREATE TABLE users (
    username VARCHAR(50) UNIQUE ,
    password VARCHAR(255) 
);

CREATE TABLE Doctors (
    DoctorID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(255) NOT NULL,
    LastName VARCHAR(255) NOT NULL,
    Gender boolean,
    DateOfBirth DATE,
    PhoneNumber VARCHAR(20),
    Specialization VARCHAR(255)
);
CREATE TABLE Receptionists (
    ReceptionistID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(255) NOT NULL,
    LastName VARCHAR(255) NOT NULL,
    Gender boolean ,
    DateOfBirth DATE,
    PhoneNumber VARCHAR(20)
);

CREATE TABLE PATIENTS (
PATIENT_ID int AUTO_INCREMENT  NOT NULL ,
PATIENT_NATIONALID int ,
PATIENT_FIRSTNAME varchar(225) NOT NULL,
PATIENT_LASTNAME varchar(225) NOT NULL,
PATIENT_AGQ varchar(225) NOT NULL,
PATIENT_GENDER boolean,
PATIENT_PHONENUMBER INT ,
PATIENT_Address varchar(225) NOT NULL,
ANOTHER_PATEINT_PHONENUMBER INT , 
DEPARTMENT boolean,
VISIT_DATE DATE ,
VISIT_TIME TIME ,
VISTI_PRICE INT,
KNOWUS_FRIEND boolean,
KNOWUS_PHARMCY boolean,
KNOWUS_FACEBOOK boolean,
primary key (PATIENT_ID)
);

CREATE TABLE PatientMeasurements (
    MeasurementID INT AUTO_INCREMENT PRIMARY KEY,
   PATIENT_ID INT,
    Weight DECIMAL(5,2),
    Height DECIMAL(5,2),
    arm_size decimal(5,2),
	leg_size decimal(5,2),
    hips_size decimal(5,2),
	Breast_size decimal(5,2),
	neck_size decimal(5,2),
    BodyMassIndex DECIMAL(5,2),
    MeasurementDate DATE,
    FOREIGN KEY (PATIENT_ID) REFERENCES PATIENTS(PATIENT_ID)
);
create table personal_data (
Patient_ID INT,
ISDIABETE boolean,
ISBLOOD_PRESSURE boolean,
ISANEMIA boolean,
PEACMAKER boolean,
HADSURGERY boolean,
SURGERY_NAME text,
WORK_NATURE text,
OTHER_INFO text,
NOTE text,

FOREIGN KEY (PATIENT_ID) REFERENCES Patients(PATIENT_ID)
);
CREATE TABLE LabTests (
    Patient_ID INT,
    TestName VARCHAR(100),
    TestDate DATE,
    TestResult TEXT,
    FOREIGN KEY (Patient_ID) REFERENCES Patients(Patient_ID)
);
CREATE TABLE RadiologyReports (
    Patient_ID INT,
    ReportDate DATE,
    ReportDescription TEXT,
    ImagingType VARCHAR(50),
    ImagingResult TEXT,
    FOREIGN KEY (Patient_ID) REFERENCES Patients(Patient_ID)
);
CREATE TABLE Appointments (
    AppointmentID INT AUTO_INCREMENT PRIMARY KEY,
    Patient_ID INT,
    DoctorID INT,
    AppointmentDate DATE,
    AppointmentTime TIME,
    Description TEXT,
    FOREIGN KEY (Patient_ID) REFERENCES Patients(Patient_ID),
    FOREIGN KEY (DoctorID) REFERENCES Doctors(DoctorID)
);


CREATE TABLE IF NOT EXISTS Equipment (
    EquipmentId INT AUTO_INCREMENT PRIMARY KEY,
    EquipmentName VARCHAR(255) NOT NULL,
    PurchaseDate DATE,
    Model VARCHAR(50),
    MaintenanceDate DATE,
    MaintenancePrice DECIMAL(10, 2),
    EquipmentPrice DECIMAL(10, 2),
    ImageData MEDIUMBLOB
);

CREATE TABLE PHYSICAL_EXERCISES (
    EXERCISE_ID INT AUTO_INCREMENT PRIMARY KEY,
    EXERCISE_NAME VARCHAR(255) NOT NULL,
    EXERCISE_CATEGORY VARCHAR(255),
    EXERCISE_DESCRIPTION TEXT,
    EXERCISE_DIFFICULTY VARCHAR(50),
    EXERCISE_DURATION INT,  
    EXERCISE_EQUIPMENT_REQUIRED BOOLEAN,
    EXERCISE_VIDEO_URL VARCHAR(255)
);

CREATE TABLE MEDICINES (
    MED_ID INT AUTO_INCREMENT PRIMARY KEY,
    MED_NAME VARCHAR(255) NOT NULL,
    MED_TYPE VARCHAR(255),
    MED_DESCRIPTION TEXT,
    MED_MANUFACTURER VARCHAR(255),
    MED_EXPIRY_DATE DATE,
    MED_PRICE DECIMAL(10, 2),
    MED_STOCK INT
    );
    
    
CREATE TABLE Carbohydrates (
    CarbID INT AUTO_INCREMENT PRIMARY KEY,
    Carbohydrates_Name VARCHAR(50) NOT NULL
);

CREATE TABLE Fats (
    FatID INT AUTO_INCREMENT PRIMARY KEY,
    fat_Name VARCHAR(50) NOT NULL
);

CREATE TABLE Proteins (
    ProteinID INT AUTO_INCREMENT PRIMARY KEY,
    protien_Name VARCHAR(50) NOT NULL
);

CREATE TABLE Fibers (
    FiberID INT AUTO_INCREMENT PRIMARY KEY,
    fiber_Name VARCHAR(50) NOT NULL
);


CREATE TABLE Breakfast (
    BREAKFAST_MealID INT AUTO_INCREMENT PRIMARY KEY,
     Carbohydrates_Name boolean,
    fat_Name boolean,
    protien_Name boolean,
    fiber_Name  boolean,
     CarbID int ,
     fatID INT,
     ProteinID INT,
     FiberID INT,
    -- Other columns for Breakfast details
    FOREIGN KEY ( CarbID) REFERENCES Carbohydrates(CarbID),
    FOREIGN KEY (FatID) REFERENCES Fats(FatID),
    FOREIGN KEY (ProteinID) REFERENCES Proteins(ProteinID),
    FOREIGN KEY (FiberID) REFERENCES Fibers(FiberID)
);
-- Lunch Table
CREATE TABLE Lunch (
     LUNCH_MealID INT AUTO_INCREMENT PRIMARY KEY,
     Carbohydrates_Name boolean,
    fat_Name boolean,
    protien_Name boolean,
    fiber_Name  boolean,
       CarbID int ,
     fatID INT,
     ProteinID INT,
     FiberID INT,
    -- Other columns for Breakfast details
    FOREIGN KEY ( CarbID) REFERENCES Carbohydrates(CarbID),
    FOREIGN KEY (FatID) REFERENCES Fats(FatID),
    FOREIGN KEY (ProteinID) REFERENCES Proteins(ProteinID),
    FOREIGN KEY (FiberID) REFERENCES Fibers(FiberID)
);

-- Dinner Table
CREATE TABLE Dinner (
    DINNER_MealID INT AUTO_INCREMENT PRIMARY KEY,
    Carbohydrates_Name boolean,
    fat_Name boolean,
    protien_Name boolean,
    fiber_Name  boolean,
         CarbID int ,
     fatID INT,
     ProteinID INT,
     FiberID INT,
    -- Other columns for Breakfast details
    FOREIGN KEY ( CarbID) REFERENCES Carbohydrates(CarbID),
    FOREIGN KEY (FatID) REFERENCES Fats(FatID),
    FOREIGN KEY (ProteinID) REFERENCES Proteins(ProteinID),
    FOREIGN KEY (FiberID) REFERENCES Fibers(FiberID)
);
    
    -- Snack1 Table
CREATE TABLE Snack1 (
    snack1_MealID INT AUTO_INCREMENT PRIMARY KEY,
	Carbohydrates_Name boolean,
    fat_Name boolean,
    protien_Name boolean,
    fiber_Name  boolean,
         CarbID int ,
     fatID INT,
     ProteinID INT,
     FiberID INT,
    -- Other columns for Breakfast details
    FOREIGN KEY ( CarbID) REFERENCES Carbohydrates(CarbID),
    FOREIGN KEY (FatID) REFERENCES Fats(FatID),
    FOREIGN KEY (ProteinID) REFERENCES Proteins(ProteinID),
    FOREIGN KEY (FiberID) REFERENCES Fibers(FiberID)
);

-- Snack2 Table
CREATE TABLE Snack2 (
    snack2_MealID INT AUTO_INCREMENT PRIMARY KEY,
	Carbohydrates_Name boolean,
    fat_Name boolean,
    protien_Name boolean,
    fiber_Name  boolean,
         CarbID int ,
     fatID INT,
     ProteinID INT,
     FiberID INT,
    -- Other columns for Breakfast details
    FOREIGN KEY ( CarbID) REFERENCES Carbohydrates(CarbID),
    FOREIGN KEY (FatID) REFERENCES Fats(FatID),
    FOREIGN KEY (ProteinID) REFERENCES Proteins(ProteinID),
    FOREIGN KEY (FiberID) REFERENCES Fibers(FiberID)
);
CREATE TABLE PatientMeals (
    PatientMealID INT AUTO_INCREMENT PRIMARY KEY,
    PATIENT_ID INT,
    BREAKFAST_MealID INT,
    LUNCH_MealID INT,
    DINNER_MealID INT,
    SNACK1_MealID INT,
    SNACK2_MealID INT,
    FOREIGN KEY (PATIENT_ID) REFERENCES PATIENTS(PATIENT_ID),
    FOREIGN KEY (BREAKFAST_MealID) REFERENCES Breakfast(BREAKFAST_MealID),
    FOREIGN KEY (LUNCH_MealID) REFERENCES Lunch(LUNCH_MealID),
    FOREIGN KEY (DINNER_MealID) REFERENCES Dinner(DINNER_MealID),
    FOREIGN KEY (SNACK1_MealID) REFERENCES Snack1(snack1_MealID),
    FOREIGN KEY (SNACK2_MealID) REFERENCES Snack2(snack2_MealID)
);

CREATE TABLE NUTRION_Prescription (
    PrescriptionID INT AUTO_INCREMENT PRIMARY KEY,
    PATIENT_ID INT,
    BREAKFAST_MealID INT,
    LUNCH_MealID INT,
    DINNER_MealID INT,
    SNACK1_MealID INT,
    SNACK2_MealID INT,
    FOREIGN KEY (PATIENT_ID) REFERENCES PATIENTS(PATIENT_ID),
    FOREIGN KEY (BREAKFAST_MealID) REFERENCES Breakfast(BREAKFAST_MealID),
    FOREIGN KEY (LUNCH_MealID) REFERENCES Lunch(LUNCH_MealID),
    FOREIGN KEY (DINNER_MealID) REFERENCES Dinner(DINNER_MealID),
    FOREIGN KEY (SNACK1_MealID) REFERENCES Snack1(snack1_MealID),
    FOREIGN KEY (SNACK2_MealID) REFERENCES Snack2(snack2_MealID)
);

CREATE TABLE Finance (
    TransactionID INT PRIMARY KEY AUTO_INCREMENT,
    Patient_ID INT,
    Amount DECIMAL(10, 2),
    Date DATE,
    PaymentType VARCHAR(50),
    FOREIGN KEY (Patient_ID) REFERENCES Patients(Patient_ID)
);

CREATE TABLE TreatmentPlans (
    PlanID INT PRIMARY KEY AUTO_INCREMENT,
    Patient_ID INT,
    BodyPart VARCHAR(50) NOT NULL,
    Description TEXT,
     EXERCISE_ID  INT,
    FOREIGN KEY (Patient_ID) REFERENCES Patients(Patient_ID),
    FOREIGN KEY ( EXERCISE_ID ) REFERENCES PHYSICAL_EXERCISES( EXERCISE_ID )
);
create table skin_care(
patient_ID int , 
 MED_ID int ,
 EquipmentId int ,
no_sessions int ,
FOREIGN KEY (Patient_ID) REFERENCES Patients(Patient_ID),
FOREIGN KEY ( MED_ID ) REFERENCES MEDICINES( MED_ID),
FOREIGN KEY ( EquipmentId ) REFERENCES Equipment ( EquipmentId)
);