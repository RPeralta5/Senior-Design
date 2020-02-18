
CREATE TABLE ParkImages (
    ImageID INT IDENTITY PRIMARY KEY,
    ParkID varchar(6) FOREIGN KEY REFERENCES Parks(ParkID),
    ImagePath VARCHAR(255)
)

INSERT INTO ParkImages(ParkID, ImagePath)
VALUES
('BONE', '/images/BoneliCA/BR6I1564.jpg'),
('BONE', '/images/BoneliCA/BR6I1601.jpg'),
('BONE', '/images/BoneliCA/BR6I1617.jpg'),
('BONE', '/images/BoneliCA/BR6I1621.jpg'),
('BONE', '/images/BoneliCA/BR6I1630.jpg'),
('BONE', '/images/BoneliCA/BR6I1634.jpg'),
('BONE', '/images/BoneliCA/BR6I1661.jpg'),
('BONE', '/images/BoneliCA/BR6I1702.jpg'),
('BONE', '/images/BoneliCA/BR6I1707.jpg'),
('BONE', '/images/BoneliCA/BR6I1721.jpg'),
('SFD', '/images/SantaFeDamCA/BR6I2653.jpg'),
('SFD', '/images/SantaFeDamCA/BR6I2662.jpg'),
('SFD', '/images/SantaFeDamCA/BR6I2682.jpg'),
('SFD', '/images/SantaFeDamCA/BR6I2721.jpg'),
('SFD', '/images/SantaFeDamCA/BR6I2751.jpg'),
('SFD', '/images/SantaFeDamCA/BR6I2811.jpg'),
('SFD', '/images/SantaFeDamCA/BR6I2820.jpg'),
('SFD', '/images/SantaFeDamCA/BR6I2840.jpg'),
('SFD', '/images/SantaFeDamCA/BR6I2854.jpg'),
('SFD', '/images/SantaFeDamCA/BR6I2931.jpg'),
('SFD', '/images/SantaFeDamCA/BR6I2978.jpg'),
('SCHA', '/images/SchabarumCA/Edited_PeterFSchabarumRegionalPark-1-of-52.jpg'),
('SCHA', '/images/SchabarumCA/Edited_PeterFSchabarumRegionalPark-3-of-52.jpg'),
('SCHA', '/images/SchabarumCA/Edited_PeterFSchabarumRegionalPark-4-of-52.jpg'),
('SCHA', '/images/SchabarumCA/Edited_PeterFSchabarumRegionalPark-7-of-52.jpg'),
('SCHA', '/images/SchabarumCA/Edited_PeterFSchabarumRegionalPark-8-of-52.jpg'),
('SCHA', '/images/SchabarumCA/Edited_PeterFSchabarumRegionalPark-22-of-52.jpg'),
('SCHA', '/images/SchabarumCA/Edited_PeterFSchabarumRegionalPark-25-of-52.jpg'),
('SCHA', '/images/SchabarumCA/Edited_PeterFSchabarumRegionalPark-28-of-52.jpg'),
('SCHA', '/images/SchabarumCA/Edited_PeterFSchabarumRegionalPark-36-of-52.jpg'),
('SCHA', '/images/SchabarumCA/Edited_PeterFSchabarumRegionalPark-42-of-52.jpg'),
('HAHN', '/images/KennethHahnStateRecreationAreaCA/BR6I8004.jpg'),
('HAHN', '/images/KennethHahnStateRecreationAreaCA/BR6I8028.jpg'),
('HAHN', '/images/KennethHahnStateRecreationAreaCA/BR6I8044.jpg'),
('HAHN', '/images/KennethHahnStateRecreationAreaCA/BR6I8115.jpg'),
('HAHN', '/images/KennethHahnStateRecreationAreaCA/BR6I8123.jpg'),
('HAHN', '/images/KennethHahnStateRecreationAreaCA/BR6I8128.jpg'),
('HAHN', '/images/KennethHahnStateRecreationAreaCA/BR6I8168.jpg'),
('SFPL', '/images/SFVPoolRecCenterCA/BR6I9848.jpg'),
('SFPL', '/images/SFVPoolRecCenterCA/BR6I9913.jpg'),
('SFPL', '/images/SFVPoolRecCenterCA/BR6I9932.jpg'),
('SFPL', '/images/SFVPoolRecCenterCA/BR6I9976.jpg'),
('SFPL', '/images/SFVPoolRecCenterCA/BR6I9983.jpg'),
('SFPL', '/images/SFVPoolRecCenterCA/Edited_-SanFernandoRecreationPark-1-of-10.jpg'),
('SFPL', '/images/SFVPoolRecCenterCA/Edited_-SanFernandoRecreationPark-2-of-10.jpg'),
('SFPL', '/images/SFVPoolRecCenterCA/Edited_-SanFernandoRecreationPark-3-of-10.jpg'),
('SFPL', '/images/SFVPoolRecCenterCA/Edited_-SanFernandoRecreationPark-4-of-10.jpg'),
('SFPL', '/images/SFVPoolRecCenterCA/Edited_-SanFernandoRecreationPark-5-of-10.jpg'),
('SFPL', '/images/SFVPoolRecCenterCA/Edited_-SanFernandoRecreationPark-6-of-10.jpg'),
('SFPL', '/images/SFVPoolRecCenterCA/Edited_-SanFernandoRecreationPark-7-of-10.jpg'),
('SFPL', '/images/SFVPoolRecCenterCA/Edited_-SanFernandoRecreationPark-8-of-10.jpg'),
('SFPL', '/images/SFVPoolRecCenterCA/Edited_-SanFernandoRecreationPark-9-of-10.jpg'),
('SFPL', '/images/SFVPoolRecCenterCA/Edited_-SanFernandoRecreationPark-10-of-10.jpg'),
('ROW', '/images/RowlandHeightsCommunityCenterCA/2_Rowland_Heights_Park-2-of-17.jpg'),
('ROW', '/images/RowlandHeightsCommunityCenterCA/2_Rowland_Heights_Park-3-of-17.jpg'),
('ROW', '/images/RowlandHeightsCommunityCenterCA/2_Rowland_Heights_Park-4-of-17.jpg'),
('ROW', '/images/RowlandHeightsCommunityCenterCA/2_Rowland_Heights_Park-6-of-17.jpg'),
('ROW', '/images/RowlandHeightsCommunityCenterCA/2_Rowland_Heights_Park-7-of-17.jpg'),
('ROW', '/images/RowlandHeightsCommunityCenterCA/2_Rowland_Heights_Park-8-of-17.jpg'),
('ROW', '/images/RowlandHeightsCommunityCenterCA/2_Rowland_Heights_Park-12-of-17.jpg'),
('ROW', '/images/RowlandHeightsCommunityCenterCA/2_Rowland_Heights_Park-13-of-17.jpg'),
('ROW', '/images/RowlandHeightsCommunityCenterCA/2_Rowland_Heights_Park-14-of-17.jpg'),
('ROW', '/images/RowlandHeightsCommunityCenterCA/2_Rowland_Heights_Park-15-of-17.jpg'),
('FRND', '/images/DeaneDanaPark/BR6I1461.jpg'),
('FRND', '/images/DeaneDanaPark/BR6I1448.jpg'),
('FRND', '/images/DeaneDanaPark/BR6I1423.jpg'),
('FRND', '/images/DeaneDanaPark/BR6I1404.jpg'),
('FRND', '/images/DeaneDanaPark/BR6I1376.jpg'),
('FRND', '/images/DeaneDanaPark/BR6I1344.jpg'),
('FRND', '/images/DeaneDanaPark/BR6I1340.jpg'),
('FRND', '/images/DeaneDanaPark/BR6I1337.jpg'),
('FARN', '/images/CharlesS.FarnsworthPark/BR6I7226.jpg'),
('FARN', '/images/CharlesS.FarnsworthPark/BR6I7229.jpg'),
('FARN', '/images/CharlesS.FarnsworthPark/BR6I7237.jpg'),
('FARN', '/images/CharlesS.FarnsworthPark/BR6I7241.jpg'),
('FARN', '/images/CharlesS.FarnsworthPark/BR6I7245.jpg'),
('FARN', '/images/CharlesS.FarnsworthPark/BR6I7249.jpg'),
('FARN', '/images/CharlesS.FarnsworthPark/BR6I7277.jpg'),
('FARN', '/images/CharlesS.FarnsworthPark/BR6I7290.jpg'),
('FARN', '/images/CharlesS.FarnsworthPark/BR6I7297.jpg'),
('FARN', '/images/CharlesS.FarnsworthPark/BR6I7312.jpg'),
('CAST', '/images/CastaicLakeCA/BR6I1096.jpg'),
('CAST', '/images/CastaicLakeCA/BR6I1105.jpg'),
('CAST', '/images/CastaicLakeCA/BR6I1109.jpg'),
('CAST', '/images/CastaicLakeCA/BR6I1157.jpg'),
('CAST', '/images/CastaicLakeCA/BR6I1183.jpg'),
('CAST', '/images/CastaicLakeCA/BR6I1199.jpg'),
('CAST', '/images/CastaicLakeCA/BR6I1235.jpg'),
('CAST', '/images/CastaicLakeCA/BR6I1244.jpg'),
('CAST', '/images/CastaicLakeCA/BR6I1260.jpg'),

('ECNA', '/images/EatonCanyonNationalCenter/BR6I6729.jpg'),
('ECNA', '/images/EatonCanyonNationalCenter/BR6I6737.jpg'),
('ECNA', '/images/EatonCanyonNationalCenter/BR6I6777.jpg'),
('ECNA', '/images/EatonCanyonNationalCenter/BR6I6784.jpg'),
('ECNA', '/images/EatonCanyonNationalCenter/BR6I6786.jpg'),

('HHTS', '/images/HaciendaHeightsCommunityCenter/23_HaciendaHeights_CommunityCenter-1-of-18.jpg'),
('HHTS', '/images/HaciendaHeightsCommunityCenter/23_HaciendaHeights_CommunityCenter-2-of-18.jpg'),
('HHTS', '/images/HaciendaHeightsCommunityCenter/23_HaciendaHeights_CommunityCenter-3-of-18.jpg'),
('HHTS', '/images/HaciendaHeightsCommunityCenter/23_HaciendaHeights_CommunityCenter-4-of-18.jpg'),
('HHTS', '/images/HaciendaHeightsCommunityCenter/23_HaciendaHeights_CommunityCenter-5-of-18.jpg'),
('HHTS', '/images/HaciendaHeightsCommunityCenter/23_HaciendaHeights_CommunityCenter-6-of-18.jpg'),
('HHTS', '/images/HaciendaHeightsCommunityCenter/23_HaciendaHeights_CommunityCenter-7-of-18.jpg'),
('HHTS', '/images/HaciendaHeightsCommunityCenter/23_HaciendaHeights_CommunityCenter-8-of-18.jpg'),
('HHTS', '/images/HaciendaHeightsCommunityCenter/23_HaciendaHeights_CommunityCenter-9-of-18.jpg'),
('HHTS', '/images/HaciendaHeightsCommunityCenter/23_HaciendaHeights_CommunityCenter-10-of-18.jpg'),
('HHTS', '/images/HaciendaHeightsCommunityCenter/23_HaciendaHeights_CommunityCenter-11-of-18.jpg'),
('HHTS', '/images/HaciendaHeightsCommunityCenter/23_HaciendaHeights_CommunityCenter-12-of-18.jpg'),
('HHTS', '/images/HaciendaHeightsCommunityCenter/23_HaciendaHeights_CommunityCenter-14-of-18.jpg'),
('HHTS', '/images/HaciendaHeightsCommunityCenter/23_HaciendaHeights_CommunityCenter-15-of-18.jpg'),
('HHTS', '/images/HaciendaHeightsCommunityCenter/23_HaciendaHeights_CommunityCenter-16-of-18.jpg'),
('HHTS', '/images/HaciendaHeightsCommunityCenter/23_HaciendaHeights_CommunityCenter-17-of-18.jpg'),
('HHTS', '/images/HaciendaHeightsCommunityCenter/23_HaciendaHeights_CommunityCenter-18-of-18.jpg'),

('STON', '/images/StoneviewNationalCenter/BR6I8181.jpg'),
('STON', '/images/StoneviewNationalCenter/BR6I8188.jpg'),
('STON', '/images/StoneviewNationalCenter/BR6I8195.jpg'),
('STON', '/images/StoneviewNationalCenter/BR6I8199.jpg'),
('STON', '/images/StoneviewNationalCenter/BR6I8206.jpg'),
('STON', '/images/StoneviewNationalCenter/BR6I8252.jpg'),
('STON', '/images/StoneviewNationalCenter/BR6I8277.jpg'),
('STON', '/images/StoneviewNationalCenter/BR6I8289.jpg'),
('STON', '/images/StoneviewNationalCenter/BR6I8302.jpg'),
('STON', '/images/StoneviewNationalCenter/BR6I8306.jpg'),
('STON', '/images/StoneviewNationalCenter/BR6I8308.jpg'),

('TESO', '/images/TesoroAdobeHistoricalPark/BR6I0489.jpg'),
('TESO', '/images/TesoroAdobeHistoricalPark/BR6I0493.jpg'),
('TESO', '/images/TesoroAdobeHistoricalPark/BR6I0494.jpg'),
('TESO', '/images/TesoroAdobeHistoricalPark/BR6I0497.jpg'),
('TESO', '/images/TesoroAdobeHistoricalPark/BR6I0504.jpg'),
('TESO', '/images/TesoroAdobeHistoricalPark/BR6I0506.jpg'),
('TESO', '/images/TesoroAdobeHistoricalPark/BR6I0519.jpg'),
('TESO', '/images/TesoroAdobeHistoricalPark/BR6I0522.jpg'),
('TESO', '/images/TesoroAdobeHistoricalPark/BR6I0525.jpg'),
('TESO', '/images/TesoroAdobeHistoricalPark/BR6I0528.jpg'),
('TESO', '/images/TesoroAdobeHistoricalPark/BR6I0538.jpg'),
('TESO', '/images/TesoroAdobeHistoricalPark/BR6I0549.jpg'),

('WNRA', '/images/WhittierNarrowsCA/BR6I6420.jpg'),
('WNRA', '/images/WhittierNarrowsCA/BR6I6421.jpg'),
('WNRA', '/images/WhittierNarrowsCA/BR6I6427.jpg'),
('WNRA', '/images/WhittierNarrowsCA/BR6I6433.jpg'),
('WNRA', '/images/WhittierNarrowsCA/BR6I6441.jpg'),
('WNRA', '/images/WhittierNarrowsCA/BR6I6451.jpg'),
('WNRA', '/images/WhittierNarrowsCA/BR6I6458.jpg'),
('WNRA', '/images/WhittierNarrowsCA/BR6I6463.jpg'),
('WNRA', '/images/WhittierNarrowsCA/BR6I6467.jpg'),
('WNRA', '/images/WhittierNarrowsCA/BR6I6476.jpg'),
('WNRA', '/images/WhittierNarrowsCA/BR6I6504.jpg'),
('WNRA', '/images/WhittierNarrowsCA/BR6I6518.jpg')