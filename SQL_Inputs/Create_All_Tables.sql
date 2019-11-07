CREATE TABLE Questions(
    QuestionID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Question varchar(max) NOT NULL,
    Answer varchar(max),
    ShownFlag bit NOT NULL DEFAULT 0,
);

INSERT INTO Questions(Question, Answer, ShownFlag)
VALUES
('What is the basic permit / agreement for a Special Event?','If the Special Event is expected to attract more than 100 people or the estimated Special Event Fees & Charges are more than $5,000, you will need a Facility Use Agreement and/or a Special Events Agreement with the County of Los Angeles – Department of Parks and Recreation. Otherwise, you may just need a Facility Use Permit – P&R Form 82. Please contact the park directly to confirm what kind of permit you will need for your event.', 1),
('What permit do I need if my event has temporary structures such as a stage, tents, obstacles, etc.?', 'For special events on LA County Parks with temporary structures please contact Dept. of Public Works – Capital Project Section – Joshua Hussey at (626)458-6378 or e-mail at <a href="jhussey@dpw.lacounty.gov">jhussey@dpw.lacounty.gov</a>', 1),
('What permits do I need if my event will have alcohol served and/or sold in a beer garden?','<a href="https://www.abc.ca.gov/forms/PDFSpc.html>https://www.abc.ca.gov/forms/PDFSpc.html">https://www.abc.ca.gov/forms/PDFSpc.html</a>',1),
('What permits do I need if my event will have food prepared and sold on-site? What kind of permits do food trucks / stalls need?','<a href="https://publichealth.lacounty.gov/eh/DSE/CommunityEvent.htm">https://publichealth.lacounty.gov/eh/DSE/CommunityEvent.htm</a>',1),
('What are the fees & charges for Special Events?','Director may set fees depending on the actual cost of providing the program, impact on the park, usage of the facility, and internal resources required. Parking (general entrance fees and/or exclusive parking) fees and cost of DPR staff may be charged in addition to the Special Events fees.',1),
('What are the security deposit requirements for Special Events?','Clean-up / Damage Deposit $100 – $5,000 based on the Special Event parameters (security deposit for large events may be up to $50,000). The security deposit refund may take 3-6 weeks or 8-11 weeks depending on the payment method.',1),
('How far in advance can an area or facility at a LA County Park be reserved for a special event?','Reservations recommended at least 6-9 months in advance to obtain all necessary permits for large scale events (5,000+ attendance) and 3-6 months for (100-5,000 attendees)	',1),
('What are the security requirements for special events at LA County Parks with large attendance and/or alcohol sold/served?','For small scale events please contact the Park directly. For large scale events please call County of Los Angeles Sheriff’s Department Parks Bureau at (323)845-0070 after consulting with the Park regarding the Special Event parameters.	',1),
('What are the noise ordinances for live entertainment?','Amplified sound may not be permitted at any County park.  Please ask reservation staff for amplified sound requirements at your park of choice.',1);

CREATE TABLE Parks(
ParkID VARCHAR(6) PRIMARY KEY,
ParkName VARCHAR(100),
ParkLastName VARCHAR(100),
Address VARCHAR(100) NOT NULL,
Street_Number VARCHAR(10),
Street_Name VARCHAR(50),
City VARCHAR(20),
Zip VARCHAR(8),
FacilityPhone VARCHAR(20),
Lat FLOAT,
Lng FLOAT,
GIS_Acres FLOAT,
Inventory_Acres FLOAT,
Image VARCHAR(2000)
);


INSERT INTO Parks (ParkID, ParkName, ParkLastName, Address, Street_Number, Street_Name, City, Zip, FacilityPhone, Lat, Lng, GIS_Acres, Inventory_Acres, Image)
VALUES
('CAST', 'Castaic Lake State Recreation Area', 'Castaic Lake State Recreation Area', '32132 Castaic Lake Drive, Castaic, CA  91384','32132','Castaic Lake Drive', 'Castaic', '91384','661-257-4050',34.5474913, -118.6003248, 12659.74214,12659.74, , '/images/ParkThumbnails/CastaicLakeCA.jpg'),
('BONE', 'Frank G. Bonelli Regional Park', 'Bonelli Regional Park', '120 Via Verde Park Road, San Dimas, CA  91773', '120', 'Via Verde Park Road', 'San Dimas','91773', '909-599-8411', 34.08333818, -117.8009131, 1824.126285, 1824.13, '/images/ParkThumbnails/BonelliCA.jpg'),
('SFD', 'Santa Fe Dam Recreational Area', 'Santa Fe Dam Recreational Area', '15501 East Arrow Highway, Irwindale, CA  91706', '15501', 'East Arrow Highway', 'Irwindale', '91706', '626-334-1065', 34.11771338, -117.9498507, 952.3812045, 952.38, '/images/ParkThumbnails/SantaFeDamCA.jpg'),
('WNRA', 'Whittier Narrows Recreation Area', 'Whittier Narrows Recreation Area', '750 South Santa Anita Avenue, South El Monte, CA  91733', '750',	'South Santa Anita Avenue',	'South El Monte','91733', '626-575-5526', 34.03970982, -118.0630891, 778.1836127, 778.18, '/images/ParkThumbnails/WhittierNarrowsCA.jpg'),
('SCHA', 'Peter F. Schabarum Regional Park','Schabarum Regional Park', '17250 East Colima Road, Rowland Heights, CA  91748', '17250',	'East Colima Road',	'Rowland Heights',	'91748', '626-854-5560',33.97947206, -117.9326415, 577.1059928, 577.11, '/images/ParkThumbnails/Schabarum.jpg'),
('HAHN', 'Kenneth Hahn State Recreation Area', 'Hahn State Recreation Area', '4100 South La Cienega Boulevard, Los Angeles, CA  90056','4100','South La Cienega Boulevard', 'Los Angeles', '90056','323-398-3660', 34.00730948, -118.3651387, 345.7330955, 345.7330955, '/images/ParkThumbnails/KennethHahnStateRecreationAreaCA.jpg'),
('ECNA', 'Eaton Canyon Natural Area and Nature Center', 'Eaton Canyon Natural Area and Nature Center', '1750 North Altadena Drive, Pasadena, CA  91001', '1750','North Altadena Drive',	'Pasadena',	'91001', '626-398-5420', 34.18330833, -118.0960384, 218.99713, 219, '/images/ParkThumbnails/EatonCanyonNationalCenter.jpg' ),
('FRND', 'Deane Dana Friendship Natural Area and Nature Center', 'Friendship Park and Nature Center', '1805 West 9th Street, San Pedro, CA  90732', '1805','West 9th Street', 'San Pedro', '90732','310-519-6115', 33.73216606, -118.3215791, 123.7289056, 123.7289056, '/images/ParkThumbnails/DeaneDanaPark.jpg'),
('FARN', 'Charles S. Farnsworth Park', 'Farnsworth Park', '568 East Mount Curve Avenue, Altadena, CA  91001', '568', 'East Mount Curve Avenue', 'Altadena', '91001', '626-798-6335', 34.20072512, -118.132779, 14.73544115, 14.74, '/images/ParkThumbnails/CharlesS.FarnsworthPark.jpg'),
('ROW', 'Rowland Heights Park', 'Rowland Heights County Park', '1500 South Banida Avenue, Rowland Heights, CA  91748', '1500', 'South Banida Avenue', 'Rowland Heights', '91748', '626-912-6774', 33.98902272, -117.8795735, 10.18154941, 10.18, '/images/ParkThumbnails/RowlandHeightsCommunityCenterCA.jpg'),
('HHTS', 'Hacienda Heights Community and Recreation Center', 'Hacienda Heights Community and Recreation Center', '1234 Valencia Avenue, Hacienda Heights, CA  91745', '1234', 'Valencia Avenue', 'Hacienda Heights', '91745', '626-333-3250', 34.01302705, -117.978249, 7.23637838, 7.24, '/images/ParkThumbnails/HaciendaHeightsCommunityCenter'),
('STON', 'Stoneview Nature Center', 'Stoneview Nature Center', '5950 Stoneview Drive, Culver City, CA  90232', '5950', 'Stoneview Drive','Culver City','90232', 'NULL', 34.01419001, -118.3769625 ,5.01100312,5.01, '/images/ParkThumbnails/StoneviewNationalCenter.jpg'),
('SFPL', 'San Fernando Regional Pool', 'San Fernando Regional Pool', '208 Park Avenue, San Fernando, CA  91340', '208', 'Park Avenue', 'San Fernando','91340','818-256-2033',34.28160102, -118.4330923, 3.09230818, 3.09, '/images/ParkThumbnails/SFVPoolRecCenterCA.jpg'),
('TESO', 'Tesoro Adobe Historic Park', 'Tesoro Adobe Historic Park', '29350 Avenida Ranchero Tesoro, Valencia, CA  91354','29350', 'Avenida Ranchero Tesoro','Valencia','91354', '661-702-8953', 34.47333241, -118.5562472, 2.25200442, 2.25, '/images/ParkThumbnails/TesoroAdobeHistoricalPark.jpg');

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


CREATE TABLE AmenityImages(
    ImageID INT IDENTITY PRIMARY KEY,
    Image VARCHAR(150)
)

CREATE TABLE Amenities(
    AmenityID INT IDENTITY PRIMARY KEY,
    ParkID VARCHAR(6) FOREIGN KEY REFERENCES Parks(ParkID),
    Amenity VARCHAR(100),
    Quantity INT,
    ImageID INT FOREIGN KEY REFERENCES AmenityImages(ImageID)
)

INSERT INTO AmenityImages(Image)
VALUES
('/images/AmenityImages/boatingInstructionSafteyCenter.png'),
('/images/AmenityImages/restrooms.png'),
('/images/AmenityImages/classroom.png'),
('/images/AmenityImages/library.png'),
('/images/AmenityImages/computerLabs.png'),
('/images/AmenityImages/exhibitArea.png'),
('/images/AmenityImages/museum.png'),
('/images/AmenityImages/historicalValue.png'),
('/images/AmenityImages/civicArt.png'),
('/images/AmenityImages/memorial.png'),
('/images/AmenityImages/theater.png'),
('/images/AmenityImages/giftShop.png'),
('/images/AmenityImages/sheriffSubStation.png'),
('/images/AmenityImages/picnicShelter.png'),
('/images/AmenityImages/groupPicnic.png'),
('/images/AmenityImages/amphitheater.png'),
('/images/AmenityImages/ticketBooth.png'),
('/images/AmenityImages/maintenanceYardBldg.png'),
('/images/AmenityImages/softballField.png'),
('/images/AmenityImages/baseball.png'),
('/images/AmenityImages/soccerField.png'),
('/images/AmenityImages/tennisCourt.png'),
('/images/AmenityImages/basketballFullCourt.png'),
('/images/AmenityImages/volleyballSand.png'),
('/images/AmenityImages/swimmingPool.png'),
('/images/AmenityImages/SplashPad.png'),
('/images/AmenityImages/FitnessZone.png'),
('/images/AmenityImages/BoatingArea.png'),
('/images/AmenityImages/lakes.png'),
('/images/AmenityImages/BoatRental.png'),
('/images/AmenityImages/SWIM_BEACH.png'),
('/images/AmenityImages/SailingArea.png'),
('/images/AmenityImages/FishingLake.png'),
('/images/AmenityImages/HorseTrail.png'),
('/images/AmenityImages/HikingTrail.png'),
('/images/AmenityImages/BicycleTrail.png'),
('/images/AmenityImages/HorseshoePit.png'),
('/images/AmenityImages/CommunityGarden.png'),
('/images/AmenityImages/ControlAirplaneArea.png'),
('/images/AmenityImages/AnimalExhibit.png'),
('/images/AmenityImages/ShootingRange.png'),
('/images/AmenityImages/PlayArea2-5YRS.png'),
('/images/AmenityImages/ChildrensPlayArea.png'),
('/images/AmenityImages/campingTent.png'),
('/images/AmenityImages/campingGroups.png'),
('/images/AmenityImages/BBQ.png'),
('/images/AmenityImages/OutdoorKitchen.png'),
('/images/AmenityImages/PicnicTables.png'),
('/images/AmenityImages/banquetRoom.png'),
('/images/AmenityImages/OutdoorStage.png'),
('/images/AmenityImages/concessionStands.png');


INSERT INTO Amenities(ParkID, Amenity, Quantity, ImageID)
VALUES
('CAST', 'Boat Instr. Safety Ctr.', 1, 1),
('CAST', 'Restrooms', 20, 2),
('CAST', 'Concession Stand', 1, 51),
('CAST', 'Classroom', 4, 3),
('CAST', 'Historical Value', 1, 8),
('CAST', 'Civic Art', 1, 9),
('CAST', 'Sheriff Sub Station', 1, 13),
('CAST', 'Picnic Shelter', 15, 14),
('CAST', 'Group Picnic Shelter', 25, 15),
('CAST', 'Ticket Booth', 1, 17),
('CAST', 'Maintenance Yard Bldg', 1, 18),
('CAST', 'Wi-Fi', 1, 1),
('CAST', 'Boating Area', 1, 28),
('CAST', 'Lake', 2, 29),
('CAST', 'Boat Rental', 1, 30),
('CAST', 'Swimming Beach', 1, 31),
('CAST', 'Sailing Area', 1, 32),
('CAST', 'Fishing Lake', 1, 33),
('CAST', 'Trail Staging Areas', 1, 1),
('CAST', 'Multi-Use Trail', 1, 1),
('CAST', 'Horse Trail', 1, 34),
('CAST', 'Hiking Trail', 1, 35),
('CAST', 'Bicycle Trail', 1, 36),
('CAST', 'Horseshoe Pit', 4, 37),
('CAST', 'BMX Track', 1, 1),
('CAST', 'Control Airplane Area', 1, 39),
('CAST', 'Play Area 2-5 Years', 3, 42),
('CAST', 'Children Play Area', 3, 43),
('CAST', 'Camping Tent', 1, 44),
('CAST', 'Camping - Group', 1, 45),
('CAST', 'Camping - RV', 1, 1),
('CAST', 'RV Dump Station', 1, 1),
('CAST', 'Showers', 1, 1),
('CAST', 'BBQs', 1, 46),
('CAST', 'Outdoor Kitchen', 1, 47),
('CAST', 'Picnic Tables', 1, 48),
('CAST', 'Banners/Kiosks', 1, 1),
('CAST', 'Educational Signage', 1, 1),
('CAST', 'Maintenance Yard', 1, 1),
('CAST', 'Security Lighting', 1, 1),
('CAST', 'Parking Onsite', 1, 1),
('CAST', 'Parking Over Sized Vehicle', 1, 1),
('BONE', 'Restrooms', 27, 2),
('BONE', 'Concession Stand', 1, 51),
('BONE', 'Historical Value', 1, 8),
('BONE', 'Civic Art', 6, 9),
('BONE', 'Memorial', 1, 10),
('BONE', 'Group Picnic Shelter', 17, 15),
('BONE', 'Ticket Booth', 1, 17),
('BONE', 'Maintenance Yard Bldg', 1, 18),
('BONE', 'Trash Enclosure', 1, 1),
('BONE', 'Baseball Field', 1, 1),
('BONE', 'Softball Field', 6, 19),
('BONE', 'Soccer Field', 10, 21),
('BONE', 'Wi-Fi', 1, 1),
('BONE', 'Tennis Court', 16, 22),
('BONE', 'Volleyball Sand', 1, 24),
('BONE', 'Fitness Zone', 2, 27),
('BONE', 'Boating Area', 1, 28),
('BONE', 'Lake', 3, 29),
('BONE', 'Boat Rental', 1, 30),
('BONE', 'Fishing Lake', 1, 33),
('BONE', 'Trail Staging Areas', 1, 1),
('BONE', 'Multi-Use Trail', 1, 1),
('BONE', 'Horse Trail', 1, 34),
('BONE', 'Hiking Trail', 1, 35),
('BONE', 'Bicycle Trail', 1, 36),
('BONE', 'Horseshoe Pit', 2, 37),
('BONE', 'Community Garden', 1, 38),
('BONE', 'Specialty Garden', 1, 1),
('BONE', 'Control Airplane Area', 1, 39),
('BONE', 'Model Boat Area', 1, 1),
('BONE', 'Shooting Range', 1, 41),
('BONE', 'Children Play Area', 7, 43),
('BONE', 'BBQs', 1, 46),
('BONE', 'Picnic Tables', 1, 48),
('BONE', 'Drinking Fountains', 1, 1),
('BONE', 'Telephone', 1, 1),
('BONE', 'Banners/Kiosks', 1, 1),
('BONE', 'Educational Signage', 1, 1),
('BONE', 'Outdoor Stage', 1, 50),
('BONE', 'Maintenance Yard', 1, 1),
('BONE', 'Security Lighting', 1, 1),
('BONE', 'Parking Onsite', 1, 1),
('BONE', 'Disc Golf No. of Holes', 18, 1),
('BONE', 'BMX Track', 1, 1),
('SFD', 'Restrooms', 16, 2),
('SFD', 'Concession Stand', 2, 51),
('SFD', 'Sheriff Sub Station', 1, 13),
('SFD', 'Picnic Shelter', 110, 14),
('SFD', 'Group Picnic Shelter', 6, 15),
('SFD', 'Ticket Booth', 1, 17),
('SFD', 'Maintenance Yard Bldg', 1, 18),
('SFD', 'Softball Field', 1, 19),
('SFD', 'Boating Area', 1, 28),
('SFD', 'Lake', 1, 29),
('SFD', 'Boat Rental', 1, 30),
('SFD', 'Swimming Beach', 1, 31),
('SFD', 'Sailing Area', 1, 32),
('SFD', 'Fishing Lake', 1, 33),
('SFD', 'Trail Staging Areas', 1, 1),
('SFD', 'Multi-Use Trail', 1, 1),
('SFD', 'Horse Trail', 1, 34),
('SFD', 'Hiking Trail', 1, 35),
('SFD', 'Bicycle Trail', 1, 36),
('SFD', 'Horseshoe Pit', 1, 37),
('SFD', 'Play Area 2-5 Years', 1, 42),
('SFD', 'Children Play Area', 3, 43),
('SFD', 'Camping - RV', 1, 1),
('SFD', 'BBQs', 1, 46),
('SFD', 'Outdoor Kitchen', 1, 47),
('SFD', 'Picnic Tables', 1, 48),
('SFD', 'Drinking Fountains', 1, 1),
('SFD', 'Telephone', 1, 1),
('SFD', 'Vending Machine', 1, 1),
('SFD', 'Banners/Kiosks', 1, 1),
('SFD', 'Educational Signage', 1, 1),
('SFD', 'Maintenance Yard', 1, 1),
('SFD', 'Security Lighting', 1, 1),
('SFD', 'Parking Onsite', 1, 1),
('WNRA', 'Nature Center', 1, 1),
('WNRA', 'Restrooms', 9, 2),
('WNRA', 'Concession Stand', 1, 51),
('WNRA', 'Group Picnic Shelter', 5, 15),
('WNRA', 'Maintenance Yard Bldg', 1, 18),
('WNRA', 'Trash Enclosure', 1, 1),
('WNRA', 'Wi-Fi', 1, 1),
('WNRA', 'Volleyball Sand', 2, 24),
('WNRA', 'Splash Pad', 1, 26),
('WNRA', 'Fitness Zone', 1, 27),
('WNRA', 'Boating Area', 1, 28),
('WNRA', 'Lake', 1, 29),
('WNRA', 'Boat Rental', 1, 30),
('WNRA', 'Swimming Beach', 1, 31),
('WNRA', 'Sailing Area', 1, 32),
('WNRA', 'Fishing Lake', 1, 33),
('WNRA', 'Bicycle Trail', 1, 36),
('WNRA', 'Wildlife Sanctuary', 1, 1),
('WNRA', 'Play Area 2-5 Years', 1, 42),
('WNRA', 'Children Play Area', 2, 43),
('WNRA', 'Camping - Group', 1, 45),
('WNRA', 'Showers', 1, 1),
('WNRA', 'BBQs', 1, 46),
('WNRA', 'Picnic Tables', 1, 48),
('WNRA', 'Drinking Fountains', 1, 1),
('WNRA', 'Telephone', 1, 1),
('WNRA', 'Vending Machine', 1, 1),
('WNRA', 'Educational Signage', 1, 1),
('WNRA', 'Maintenance Yard', 1, 1),
('WNRA', 'Security Lighting', 1, 1),
('WNRA', 'Parking Onsite', 1, 1),
('SCHA', 'Restrooms', 1, 2),
('SCHA', 'Historical Value', 1, 8),
('SCHA', 'Memorial', 1, 10),
('SCHA', 'Picnic Shelter', 2, 14),
('SCHA', 'Group Picnic Shelter', 5, 15),
('SCHA', 'Amphitheater', 1, 16),
('SCHA', 'Maintenance Yard Bldg', 1, 18),
('SCHA', 'Trash Enclosure', 1, 1),
('SCHA', 'Soccer Field', 2, 21),
('SCHA', 'Tennis Court', 2, 22),
('SCHA', 'Fitness Zone', 1, 27),
('SCHA', 'Trail Staging Areas', 1, 1),
('SCHA', 'Multi-Use Trail', 1, 1),
('SCHA', 'Horse Trail', 1, 34),
('SCHA', 'Hiking Trail', 1, 35),
('SCHA', 'Bicycle Trail', 1, 36),
('SCHA', 'Play Area 2-5 Years', 1, 42),
('SCHA', 'Children Play Area', 2, 43),
('SCHA', 'Camping - Group', 1, 45),
('SCHA', 'BBQs', 1, 46),
('SCHA', 'Outdoor Kitchen', 1, 47),
('SCHA', 'Picnic Tables', 1, 48),
('SCHA', 'Drinking Fountains', 1, 1),
('SCHA', 'Telephone', 1, 1),
('SCHA', 'Vending Machine', 1, 1),
('SCHA', 'Banners/Kiosks', 1, 1),
('SCHA', 'Outdoor Stage', 1, 50),
('SCHA', 'Maintenance Yard', 1, 1),
('SCHA', 'Security Lighting', 1, 1),
('SCHA', 'Parking Onsite', 1, 1);
