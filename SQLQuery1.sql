CREATE DATABASE DBPROJECT;

USE DBPROJECT;

INSERT INTO EVENTS (Title, Description, Location, StartDate, EndDate, Catery) 
	VALUES
	('AniCon', 'Convention for Anime Geeks', 'FAST Islamabad', '2024-12-10 09:00', '2024-12-10 17:00', 'Party');

INSERT INTO ATTENDEE_EVENT(AttendeeID, EventID) 
	VALUES
	(1,1);

-- USER Table
CREATE TABLE [USER] (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    PhoneNo NVARCHAR(15),
    Address NVARCHAR(255),
    UserType NVARCHAR(20) NOT NULL CHECK (UserType IN ('Attendee', 'Organizer', 'Admin', 'Vendor/Sponsor'))
);


-- ATTENDEE Table
CREATE TABLE ATTENDEE (
    AttendeeID INT PRIMARY KEY,
    EventPreferences NVARCHAR(MAX),
	FOREIGN KEY (AttendeeID) REFERENCES [USER](UserID)
);


-- ORGANIZER Table
CREATE TABLE ORGANIZER (
    OrganizerID INT PRIMARY KEY,
    OrganizationName NVARCHAR(100)
	FOREIGN KEY (OrganizerID) REFERENCES [USER](UserID)
);


-- SERVICE_PROVIDER Table
CREATE TABLE SERVICE_PROVIDER (
    ProviderID INT PRIMARY KEY,
    OrganizerID INT,
    BusinessType NVARCHAR(100),
    Type NVARCHAR(50),
    Contact NVARCHAR(100),
    FOREIGN KEY (OrganizerID) REFERENCES ORGANIZER(OrganizerID)
);


-- EVENTS Table
CREATE TABLE EVENTS (
    EventID INT IDENTITY(1,1) PRIMARY KEY,
    OrganizerID INT,
    AdminID INT,
    Title NVARCHAR(100),
    Description NVARCHAR(MAX),
    Location NVARCHAR(255),
    StartDate DATETIME,
    EndDate DATETIME,
    Catery NVARCHAR(50),
    FOREIGN KEY (OrganizerID) REFERENCES ORGANIZER(OrganizerID),
    FOREIGN KEY (AdminID) REFERENCES [USER](UserID)
);


-- TICKETS Table
CREATE TABLE TICKETS (
    TicketNumber INT IDENTITY(1,1) PRIMARY KEY,
    EventID INT,
    AttendeeID INT,
    OrganizerID INT,
    Type NVARCHAR(50),
    Price DECIMAL(10, 2),
    Availability BIT,
    FOREIGN KEY (EventID) REFERENCES EVENTS(EventID),
    FOREIGN KEY (AttendeeID) REFERENCES ATTENDEE(AttendeeID),
    FOREIGN KEY (OrganizerID) REFERENCES ORGANIZER(OrganizerID)
);

CREATE TABLE BOOK_TICKET (
	TicketNumber INT,
	BookingID INT,
	PRIMARY KEY (TicketNumber, BookingID),
    Payment DECIMAL(10,2) NOT NULL,
    BookingDate DATETIME NOT NULL DEFAULT GETDATE(),
    Status NVARCHAR(20) NOT NULL,
	FOREIGN KEY (TicketNumber) REFERENCES TICKETS(TicketNumber),
);

-- FEEDBACK Table
CREATE TABLE FEEDBACK (
    FeedbackID INT IDENTITY(1,1) PRIMARY KEY,
    AttendeeID INT,
    EventID INT,
    Rating DECIMAL(3, 2),
    Comments NVARCHAR(MAX),
    FOREIGN KEY (AttendeeID) REFERENCES ATTENDEE(AttendeeID),
    FOREIGN KEY (EventID) REFERENCES EVENTS(EventID)
);


-- REPORT Table
CREATE TABLE REPORT (
    ReportID INT IDENTITY(1,1) PRIMARY KEY,
    AdminID INT,
    EventActivity NVARCHAR(MAX),
    TicketSales DECIMAL(15, 2),
    UserEngagement NVARCHAR(MAX),
    PlatformGrowth NVARCHAR(MAX),
    FOREIGN KEY (AdminID) REFERENCES [USER](UserID)
);


-- SERVICE Table
CREATE TABLE SERVICE (
    ServiceID INT IDENTITY(1,1) PRIMARY KEY,
    Type NVARCHAR(50),
    Details NVARCHAR(MAX),
    Status NVARCHAR(50),
    Payment DECIMAL(10, 2)
);


-- SERVICEPROVIDED Table
CREATE TABLE SERVICEPROVIDED (
    ServiceID INT,
    ProviderID INT,
    PRIMARY KEY (ServiceID, ProviderID),
    FOREIGN KEY (ServiceID) REFERENCES SERVICE(ServiceID),
    FOREIGN KEY (ProviderID) REFERENCES SERVICE_PROVIDER(ProviderID)
);


-- SERVICEPROVIDEDTO Table
CREATE TABLE SERVICEPROVIDEDTO (
    ServiceID INT,
    EventID INT,
    PRIMARY KEY (ServiceID, EventID),
    FOREIGN KEY (ServiceID) REFERENCES SERVICE(ServiceID),
    FOREIGN KEY (EventID) REFERENCES EVENTS(EventID)
);


-- ATTENDEE_EVENT Table
CREATE TABLE ATTENDEE_EVENT (
    AttendeeID INT,
    EventID INT,
	OrganizerID INT,
    PRIMARY KEY (AttendeeID, EventID),
    FOREIGN KEY (AttendeeID) REFERENCES ATTENDEE(AttendeeID),
    FOREIGN KEY (EventID) REFERENCES EVENTS(EventID),
	FOREIGN KEY (OrganizerID) REFERENCES ORGANIZER(OrganizerID)
);