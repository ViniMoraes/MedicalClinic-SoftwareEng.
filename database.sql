BEGIN TRANSACTION;
CREATE TABLE `Specialization` (
	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`name`	TEXT NOT NULL
);
CREATE TABLE "Servicescheduling" (
	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`schedule`	TEXT NOT NULL,
	`person_id`	INTEGER NOT NULL,
	FOREIGN KEY(`person_id`) REFERENCES `person`
);
CREATE TABLE `Service_Servicesheduling` (
	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`service_id`	INTEGER NOT NULL,
	`servicescheduling_id`	INTEGER NOT NULL,
	FOREIGN KEY(`service_id`) REFERENCES service,
	FOREIGN KEY(`servicescheduling_id`) REFERENCES servicescheduling
);
CREATE TABLE "Service" (
	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`name`	TEXT NOT NULL,
	`price`	NUMERIC NOT NULL DEFAULT 0
);
CREATE TABLE "Productsale" (
	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`person_id`	INTEGER NOT NULL,
	`schedule`	NUMERIC NOT NULL,
	`quantity`	NUMERIC NOT NULL DEFAULT 0,
	`total`	NUMERIC NOT NULL DEFAULT 0,
	FOREIGN KEY(`person_id`) REFERENCES `person`
);
CREATE TABLE "Product_Productsale" (
	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`product_id`	INTEGER NOT NULL,
	`productsale_id`	INTEGER NOT NULL,
	FOREIGN KEY(`product_id`) REFERENCES `product`,
	FOREIGN KEY(`productsale_id`) REFERENCES `productsale`
);
CREATE TABLE "Product" (
	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`name`	INTEGER NOT NULL,
	`price`	NUMERIC NOT NULL DEFAULT 0,
	`stock`	NUMERIC NOT NULL DEFAULT 0
);
CREATE TABLE `Prescription` (
	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`name`	TEXT NOT NULL
);
CREATE TABLE `Person_Healthplan` (
	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`person_id`	INTEGER,
	`healthplan_id`	INTEGER,
	FOREIGN KEY(`person_id`) REFERENCES person,
	FOREIGN KEY(`healthplan_id`) REFERENCES healthplan
);
CREATE TABLE "Person" (
	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`name`	TEXT NOT NULL,
	`age`	INTEGER,
	`phone`	TEXT,
	`address`	TEXT,
	`specialization_id`	INTEGER,
	FOREIGN KEY(`specialization_id`) REFERENCES specialization
);
CREATE TABLE "Payment" (
	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`schedule`	TEXT,
	`total`	NUMERIC NOT NULL,
	`paymentform`	TEXT,
	`plotn`	INTEGER NOT NULL DEFAULT 1,
	`plottotal`	INTEGER NOT NULL DEFAULT 1,
	`person_id`	INTEGER NOT NULL,
	`productsale_id`	INTEGER NOT NULL,
	FOREIGN KEY(`person_id`) REFERENCES `person`,
	FOREIGN KEY(`productsale_id`) REFERENCES `productsale`
);
CREATE TABLE `Medicine_Prescription` (
	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`medicine_id`	INTEGER NOT NULL,
	`prescription_id`	INTEGER NOT NULL,
	FOREIGN KEY(`medicine_id`) REFERENCES medicine,
	FOREIGN KEY(`prescription_id`) REFERENCES prescription
);
CREATE TABLE `Medicine` (
	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`name`	TEXT NOT NULL
);
CREATE TABLE `Healthplan` (
	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`name`	TEXT NOT NULL
);
CREATE TABLE "Exam" (
	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`name`	TEXT NOT NULL,
	`person_id`	INTEGER NOT NULL,
	FOREIGN KEY(`person_id`) REFERENCES person
);
CREATE TABLE "Doctor_Appointment" (
	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`doctor_id`	INTEGER NOT NULL,
	`appointment_id`	INTEGER NOT NULL,
	FOREIGN KEY(`doctor_id`) REFERENCES person,
	FOREIGN KEY(`appointment_id`) REFERENCES appointment
);
CREATE TABLE "Appointment" (
	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`person_id`	INTEGER NOT NULL,
	`healthplan_id`	INTEGER,
	`schedule`	TEXT,
	FOREIGN KEY(`person_id`) REFERENCES `person`,
	FOREIGN KEY(`healthplan_id`) REFERENCES `healthplan`
);
COMMIT;
