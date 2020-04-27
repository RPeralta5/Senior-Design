/*
This table is to show upcoming events for each park in their corresponding Parks.cshtml page
*/

CREATE TABLE RegisteredEvents(
    ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    ParkID VARCHAR(6) FOREIGN KEY REFERENCES Parks(ParkID),
    EventName varchar(max) NOT NULL,
    StartTime varchar(max) NOT NULL,
    EndTime varchar(max) NOT NULL,
    StartDate varchar(max) NOT NULL,
    EndDate varchar(max) NOT NULL
);

/*
Sample values for Registered Events
*/

INSERT INTO RegisteredEvents (ParkID, EventName, StartTime, EndTime, StartDate, EndDate)
VALUES
('CAST','Fourth of July Celebration','10:00am', '9:00pm', '07/04/2020', '07/04/2020'),
('CAST','Movies in the Park','8:00pm', '11:30pm', '06/20/2020', '06/22/2020'),

('BONE','Movies in the Park','8:00pm', '11:30pm', '06/20/2020', '06/22/2020'),
('BONE','North Central Animal Shelter Adoption Day','9:00am', '6:30pm', '07/12/2020', '07/13/2020'),
('BONE','Electronic Music Concert','1:00pm', '11:00pm', '08/03/2020', '08/06/2020'),

('SFD','Fourth of July Celebration','10:00am', '9:00pm', '07/04/2020', '07/04/2020'),
('SFD','Movies in the Park','8:00pm', '11:30pm', '06/20/2020', '06/22/2020'),

('WNRA','Fourth of July Celebration','10:00am', '9:00pm', '07/04/2020', '07/04/2020'),
('WNRA','Movies in the Park','8:00pm', '11:30pm', '06/20/2020', '06/22/2020'),

('SCHA','Fourth of July Celebration','10:00am', '9:00pm', '07/04/2020', '07/04/2020'),
('SCHA','Movies in the Park','8:00pm', '11:30pm', '06/20/2020', '06/22/2020'),

('HAHN','Fourth of July Celebration','10:00am', '9:00pm', '07/04/2020', '07/04/2020'),
('HAHN','Movies in the Park','8:00pm', '11:30pm', '06/20/2020', '06/22/2020'),

('ECNA','Fourth of July Celebration','10:00am', '9:00pm', '07/04/2020', '07/04/2020'),
('ECNA','Movies in the Park','8:00pm', '11:30pm', '06/20/2020', '06/22/2020'),

('FRND','Fourth of July Celebration','10:00am', '9:00pm', '07/04/2020', '07/04/2020'),
('FRND','Movies in the Park','8:00pm', '11:30pm', '06/20/2020', '06/22/2020'),

('FARN','Fourth of July Celebration','10:00am', '9:00pm', '07/04/2020', '07/04/2020'),
('FARN','Movies in the Park','8:00pm', '11:30pm', '06/20/2020', '06/22/2020'),

('ROW','Fourth of July Celebration','10:00am', '9:00pm', '07/04/2020', '07/04/2020'),
('ROW','Movies in the Park','8:00pm', '11:30pm', '06/20/2020', '06/22/2020'),

('HHTS','Fourth of July Celebration','10:00am', '9:00pm', '07/04/2020', '07/04/2020'),
('HHTS','Movies in the Park','8:00pm', '11:30pm', '06/20/2020', '06/22/2020'),

('STON','Fourth of July Celebration','10:00am', '9:00pm', '07/04/2020', '07/04/2020'),
('STON','Movies in the Park','8:00pm', '11:30pm', '06/20/2020', '06/22/2020'),

('SFPL','Fourth of July Celebration','10:00am', '9:00pm', '07/04/2020', '07/04/2020'),
('SFPL','Movies in the Park','8:00pm', '11:30pm', '06/20/2020', '06/22/2020'),

('TESO','Fourth of July Celebration','10:00am', '9:00pm', '07/04/2020', '07/04/2020'),
('TESO','Movies in the Park','8:00pm', '11:30pm', '06/20/2020', '06/22/2020');
