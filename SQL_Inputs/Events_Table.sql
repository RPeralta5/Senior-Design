CREATE TABLE Events(
EventID INT IDENTITY,
ParkID VARCHAR(6) NOT NULL,
Event_Info INT,
Event VARCHAR(80),
Event_Type VARCHAR(80),
Href VARCHAR(80)
PRIMARY KEY(EventID),
FOREIGN KEY (ParkID) REFERENCES Parks(ParkID)
);

INSERT INTO Events (ParkID, Event_Info)
VALUES
('CAST', 1),
('WNRA', 1),
('WNRA', 2),
('CAST', 2),
('CAST', 3),
('BONE', 3),
('SFD', 3),
('WNRA', 3),
('SCHA', 3),
('HAHN', 3),
('FARN', 3),

('CAST', 4),
('WNRA', 4),
('BONE', 4),
('SFD', 4),
('SCHA', 4),
('HAHN', 4),
('STON', 4),
('TESO', 4),
('ECNA', 4),
('FRND', 4),
('FARN', 4),
('CAST',5),
('WNRA',5),
('ROW',5),
('HHTS',5),
('ECNA',5),
('FARN',5),
('CAST', 6),
('WNRA', 6),
('BONE', 6),
('SFD', 6),
('SCHA', 6),
('HAHN', 6),
('TESO', 6),


('CAST', 7),
('WNRA', 7),
('BONE', 7),
('SFD', 7),
('SCHA', 7),
('HAHN', 7),
('ROW', 7),
('HHTS', 7),
('STON', 7),
('TESO', 7),
('ECNA', 7),
('FRND', 7),
('FARN', 7),


('CAST',8),
('BONE',8),
('SFD',8),
('WNRA',8),
('SCHA',8),
('HAHN',8),
('ECNA',8),
('FRND',8),
('FARN',8),
('ROW',8),
('HHTS',8),
('STON',8),
('SFPL',8),
('TESO',8),
('CAST',9),
('WNRA',9),
('BONE',9),
('SFD',9),
('SCHA',9),
('HAHN',9),
('STON',9),
('TESO',9),
('ECNA',9),
('FRND',9),
('FARN',9),
('SFPL',10),
('ROW',10),
('HHTS',10),
('ECNA',10),
('FARN',10),
('CAST',11),
('WNRA',11),
('BONE',11),
('SFD',11),
('CAST',12),
('WNRA',12),
('BONE',12),
('SFD',12),
('CAST',13),
('WNRA',13),
('BONE',13),
('SFD',13),
('CAST',14),
('WNRA',14),
('BONE',14),
('SFD',14),
('HAHN',14),
('ROW',14),
('HHTS',14),
('STON',14),
('TESO',14),
('ECNA',14),
('CAST',15),
('WNRA',15),
('BONE',15),
('SFD',15),
('HAHN',15),
('CAST',16),
('WNRA',16),
('BONE',16),
('SFD',16),
('SCHA',16),
('HAHN',16);

UPDATE Events
SET Event = 'Multi Day Festivals > 10K attendance', Href = 'MultiDayFestivals10Kattendance'
WHERE Event_Info = 1

UPDATE Events
SET Event = 'Large Outdoor Concerts > 5K Attendance', Href = 'LargeOutdoorConcerts5KAttendance'
WHERE Event_Info = 2

UPDATE Events
SET Event = 'Outdoor Concerts < 2K attendance', Href = 'OutdoorConcerts2Kattendance'
WHERE Event_Info = 3

UPDATE Events
SET Event = 'Weddings (Outdoors Only)', Href = 'WeddingsOutdoorsOnly'
WHERE Event_Info = 4

UPDATE Events
SET Event = 'Weddings (Outdoors / Indoors)', Href = 'WeddingsOutdoorsIndoors'
WHERE Event_Info = 5

UPDATE Events
SET Event = 'Large Fundraisers (Outdoors) > 500 tables', Href = 'LargeFundraisersOutdoors500tables'
WHERE Event_Info = 6

UPDATE Events
SET Event = 'Small Fundraisers (Outdoors / Indoors) <100 tables', Href = 'SmallFundraisersOutdoorsIndoors100tables'
WHERE Event_Info = 7

UPDATE Events
SET Event = 'Quinceanera', Href = 'Quinceanera'
WHERE Event_Info = 8

UPDATE Events
SET Event = 'Family Reunions (Outdoors)', Href = 'FamilyReunionsOutdoors'
WHERE Event_Info = 9

UPDATE Events
SET Event = 'Family Reunions (Indoors)', Href = 'FamilyReunionsIndoors'
WHERE Event_Info = 10

UPDATE Events
SET Event = 'Carnivals', Href = 'Carnivals'
WHERE Event_Info = 11


UPDATE Events
SET Event = 'Fairs', Href = 'Fairs'
WHERE Event_Info = 12

UPDATE Events
SET Event = 'Circus', Href = 'Circus'
WHERE Event_Info = 13

UPDATE Events
SET Event = 'Corporate Off-sites / Retreats', Href = 'CorporateOffsitesRetreats'
WHERE Event_Info = 14

UPDATE Events
SET Event = 'Large Outdoors Sports Events > 1K attendance', Href = 'LargeOutdoorsSportsEvents1Kattendance'
WHERE Event_Info = 15

UPDATE Events
SET Event = 'Outdoors Sports Events < 500 attendance', Href = 'OutdoorsSportsEvents500attendance'
WHERE Event_Info = 16

ALTER TABLE Events
DROP Column Event_Info
