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
