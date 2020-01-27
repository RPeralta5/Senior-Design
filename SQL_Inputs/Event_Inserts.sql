CREATE TABLE Event_Info(
    EventID INT IDENTITY,
    Event_Name VARCHAR(80),
    Event_Type VARCHAR(80),
    Href VARCHAR(80)
    PRIMARY KEY(EventID)
);

INSERT INTO Event_Info(Event_Name,Href)
VALUES
('Carnivals','Carnivals'),
('Circus','Circus'),
('Corporate Off-sites / Retreats','CorporateOffsitesRetreats'),
('Fairs','Fairs'),
('Family Reunions (Indoors)','FamilyReunionsIndoors'),
('Family Reunions (Outdoors)','FamilyReunionsOutdoors'),
('Large Fundraisers (Outdoors) > 500 tables','LargeFundraisersOutdoors500tables'),
('Large Outdoor Concerts > 5K Attendance','LargeOutdoorConcerts5KAttendance'),
('Large Outdoors Sports Events > 1K attendance','LargeOutdoorsSportsEvents1Kattendance'),
('Multi Day Festivals > 10K attendance','MultiDayFestivals10Kattendance'),
('Outdoor Concerts < 2K attendance','OutdoorConcerts2Kattendance'),
('Outdoors Sports Events < 500 attendance','OutdoorsSportsEvents500attendance'),
('Quinceanera','Quinceanera'),
('Small Fundraisers (Outdoors / Indoors) <100 tables','SmallFundraisersOutdoorsIndoors100tables'),
('Weddings (Outdoors / Indoors)','WeddingsOutdoorsIndoors'),
('Weddings (Outdoors Only)','WeddingsOutdoorsOnly');


CREATE TABLE Event(
    EventID INT FOREIGN KEY REFERENCES Event_Info(EventID),
    ParkID VARCHAR(6) FOREIGN KEY REFERENCES Parks(ParkID),
    Flag bit NOT NULL DEFAULT 0,
    PRIMARY KEY (EventID,ParkID)
);

DECLARE @i int = 1

WHILE @i < 17
BEGIN
    INSERT INTO Event(EventID,ParkID)
    VALUES
    (@i, 'BONE');
    SET @i = @i + 1
END

DECLARE @k int =1

WHILE @k < 17
BEGIN
    INSERT INTO Event(EventID,ParkID)
    VALUES
    (@k, 'CAST');
    SET @k = @k + 1
END

DECLARE @l int =1

WHILE @l < 17
BEGIN
    INSERT INTO Event(EventID,ParkID)
    VALUES
    (@l, 'ECNA');
    SET @l = @l + 1
END

DECLARE @m int =1

WHILE @m < 17
BEGIN
    INSERT INTO Event(EventID,ParkID)
    VALUES
    (@m, 'FARN');
    SET @m = @m + 1
END

DECLARE @n int =1

WHILE @n < 17
BEGIN
    INSERT INTO Event(EventID,ParkID)
    VALUES
    (@n, 'FRND');
    SET @n = @n + 1
END

DECLARE @o int =1

WHILE @o < 17
BEGIN
    INSERT INTO Event(EventID,ParkID)
    VALUES
    (@o, 'HAHN');
    SET @o = @o + 1
END

DECLARE @p int =1

WHILE @p < 17
BEGIN
    INSERT INTO Event(EventID,ParkID)
    VALUES
    (@p, 'HHTS');
    SET @p = @p + 1
END

DECLARE @q int =1

WHILE @q < 17
BEGIN
    INSERT INTO Event(EventID,ParkID)
    VALUES
    (@q, 'ROW');
    SET @q = @q + 1
END

DECLARE @r int =1

WHILE @r < 17
BEGIN
    INSERT INTO Event(EventID,ParkID)
    VALUES
    (@r, 'SCHA');
    SET @r = @r + 1
END

DECLARE @s int =1

WHILE @s < 17
BEGIN
    INSERT INTO Event(EventID,ParkID)
    VALUES
    (@s, 'SFD');
    SET @s = @s + 1
END

DECLARE @t int =1

WHILE @t < 17
BEGIN
    INSERT INTO Event(EventID,ParkID)
    VALUES
    (@t, 'SFPL');
    SET @t = @t + 1
END

DECLARE @u int =1

WHILE @u < 17
BEGIN
    INSERT INTO Event(EventID,ParkID)
    VALUES
    (@u, 'STON');
    SET @u = @u + 1
END

DECLARE @v int =1

WHILE @v < 17
BEGIN
    INSERT INTO Event(EventID,ParkID)
    VALUES
    (@v, 'TESO');
    SET @v = @v + 1
END

DECLARE @w int =1

WHILE @w < 17
BEGIN
    INSERT INTO Event(EventID,ParkID)
    VALUES
    (@w, 'WNRA');
    SET @w = @w + 1
END
 -- ADDING Carnivals 1...

UPDATE Event
SET Flag = 1
WHERE ParkID = 'CAST' AND EventID = 1;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'WNRA' AND EventID = 1;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'BONE' AND EventID = 1;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'SFD' AND EventID = 1;

 -- ADDING Circus 2...

UPDATE Event
SET Flag = 1
WHERE ParkID = 'CAST' AND EventID = 2;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'WNRA' AND EventID = 2;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'BONE' AND EventID = 2;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'SFD' AND EventID = 2;

 -- ADDING Corporate Off-sites / Retreats 3...

UPDATE Event
SET Flag = 1
WHERE ParkID = 'CAST' AND EventID = 3;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'WNRA' AND EventID = 3;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'BONE' AND EventID = 3;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'SFD' AND EventID = 3;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'HAHN' AND EventID = 3;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'ROW' AND EventID = 3;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'HHTS' AND EventID = 3;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'STON' AND EventID = 3;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'TESO' AND EventID = 3;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'ECNA' AND EventID = 3;

 -- ADDING Fairs 4...

UPDATE Event
SET Flag = 1
WHERE ParkID = 'CAST' AND EventID = 4;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'WNRA' AND EventID = 4;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'BONE' AND EventID = 4;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'SFD' AND EventID = 4;

-- ADDING Family Reunions (Indoors) 5...

UPDATE Event
SET Flag = 1
WHERE ParkID = 'SFPL' AND EventID = 5;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'ROW' AND EventID = 5;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'HHTS' AND EventID = 5;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'ECNA' AND EventID = 5;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'FARN' AND EventID = 5;

 -- ADDING Family Reunions (Outdoors) 6...

UPDATE Event
SET Flag = 1
WHERE ParkID = 'CAST' AND EventID = 6;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'WNRA' AND EventID = 6;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'BONE' AND EventID = 6;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'SFD' AND EventID = 6;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'SCHA' AND EventID = 6;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'HAHN' AND EventID = 6;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'STON' AND EventID = 6;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'TESO' AND EventID = 6;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'ECNA' AND EventID = 6;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'FRND' AND EventID = 6;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'FARN' AND EventID = 6;

-- ADDING Large Fundraisers (Outdoors) > 500 tables 7...

UPDATE Event
SET Flag = 1
WHERE ParkID = 'CAST' AND EventID = 7;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'WNRA' AND EventID = 7;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'BONE' AND EventID = 7;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'SFD' AND EventID = 7;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'SCHA' AND EventID = 7;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'HAHN' AND EventID = 7;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'TESO' AND EventID = 7;

 -- ADDING Large Outdoor Concerts > 5K Attendance 8...

UPDATE Event
SET Flag = 1
WHERE ParkID = 'CAST' AND EventID = 8;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'WNRA' AND EventID = 8;

-- ADDING Large Outdoors Sports Events > 1K attendance 9...

UPDATE Event
SET Flag = 1
WHERE ParkID = 'CAST' AND EventID = 9;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'WNRA' AND EventID = 9;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'BONE' AND EventID = 9;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'SFD' AND EventID = 9;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'HAHN' AND EventID = 9;

-- ADDING Multi Day Festivals > 10K attendance 10...

UPDATE Event
SET Flag = 1
WHERE ParkID = 'CAST' AND EventID = 10;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'WNRA' AND EventID = 10;

 -- ADDING Outdoor Concerts < 2K attendance 11...

UPDATE Event
SET Flag = 1
WHERE ParkID = 'CAST' AND EventID = 11;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'WNRA' AND EventID = 11;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'BONE' AND EventID = 11;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'SFD' AND EventID = 11;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'SCHA' AND EventID = 11;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'HAHN' AND EventID = 11;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'FARN' AND EventID = 11;

 -- ADDING Outdoors Sports Events < 500 attendance 12...

UPDATE Event
SET Flag = 1
WHERE ParkID = 'CAST' AND EventID = 12;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'WNRA' AND EventID = 12;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'BONE' AND EventID = 12;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'SFD' AND EventID = 12;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'SCHA' AND EventID = 12;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'HAHN' AND EventID = 12;

 -- ADDING Quinceanera 13...

UPDATE Event
SET Flag = 1
WHERE ParkID = 'CAST' AND EventID = 13;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'WNRA' AND EventID = 13;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'BONE' AND EventID = 13;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'SFD' AND EventID = 13;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'SCHA' AND EventID = 13;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'HAHN' AND EventID = 13;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'SFPL' AND EventID = 13;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'ROW' AND EventID = 13;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'HHTS' AND EventID = 13;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'STON' AND EventID = 13;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'TESO' AND EventID = 13;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'ECNA' AND EventID = 13;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'FRND' AND EventID = 13;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'FARN' AND EventID = 13;

 -- ADDING Small Fundraisers (Outdoors / Indoors) <100 tables 14...

UPDATE Event
SET Flag = 1
WHERE ParkID = 'CAST' AND EventID = 14;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'WNRA' AND EventID = 14;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'BONE' AND EventID = 14;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'SFD' AND EventID = 14;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'SCHA' AND EventID = 14;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'HAHN' AND EventID = 14;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'ROW' AND EventID = 14;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'HHTS' AND EventID = 14;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'STON' AND EventID = 14;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'TESO' AND EventID = 14;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'ECNA' AND EventID = 14;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'FRND' AND EventID = 14;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'FARN' AND EventID = 14;

 -- ADDING Weddings (Outdoors / Indoors) 15...

UPDATE Event
SET Flag = 1
WHERE ParkID = 'CAST' AND EventID = 15;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'WNRA' AND EventID = 15;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'ROW' AND EventID = 15;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'HHTS' AND EventID = 15;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'ECNA' AND EventID = 15;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'FARN' AND EventID = 15;

 -- ADDING Weddings (Outdoors Only) 16... FINALLY LAST ONE!!!!

UPDATE Event
SET Flag = 1
WHERE ParkID = 'CAST' AND EventID = 16;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'WNRA' AND EventID = 16;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'BONE' AND EventID = 16;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'SFD' AND EventID = 16;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'SCHA' AND EventID = 16;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'HAHN' AND EventID = 16;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'STON' AND EventID = 16;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'TESO' AND EventID = 16;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'ECNA' AND EventID = 16;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'FRND' AND EventID = 16;

UPDATE Event
SET Flag = 1
WHERE ParkID = 'FARN' AND EventID = 16;