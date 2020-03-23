USE [CS4961]
GO
/****** Object:  Table [dbo].[Activity]    Script Date: 3/22/2020 11:39:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Activity](
	[ID] [int] NOT NULL,
	[ADate] [date] NULL,
	[AActivity] [varchar](256) NULL,
	[AAttendance] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ApplicationInformation]    Script Date: 3/22/2020 11:39:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplicationInformation](
	[ID] [int] NOT NULL,
	[AInameInsur1Input] [bit] NULL,
	[AInameInsur2Input] [bit] NULL,
	[AInameInsur3Input] [bit] NULL,
	[AInameInsur4Input] [bit] NULL,
	[AInameInsur5Input] [bit] NULL,
	[AInameInsur6Input] [bit] NULL,
	[AInameInsur7Input] [bit] NULL,
	[AInameInsur8Input] [bit] NULL,
	[AInameInsur9Input] [bit] NULL,
	[AInameInsur10Input] [bit] NULL,
	[AInameInsur11Input] [bit] NULL,
	[AInameInsur12Input] [bit] NULL,
	[AInameInsur13Input] [bit] NULL,
	[AInameInsur14Input] [bit] NULL,
	[AInameInsuredOther] [varchar](256) NULL,
	[AInameOnPolicy] [varchar](256) NULL,
	[AIbusinessAs] [varchar](256) NULL,
	[AImailAddress] [varchar](256) NULL,
	[AIcity] [varchar](256) NULL,
	[AIstate] [varchar](256) NULL,
	[AIzip] [int] NULL,
	[AIcontactPerson] [varchar](256) NULL,
	[AIemail] [varchar](256) NULL,
	[AIhomeNum] [int] NULL,
	[AIbusinessNum] [int] NULL,
	[AIfax] [int] NULL,
	[AIwebsite] [varchar](256) NULL,
 CONSTRAINT [PK_ApplicationInformationTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Event]    Script Date: 3/22/2020 11:39:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Event](
	[ID] [int] NOT NULL,
	[EDate] [date] NULL,
	[EHours] [varchar](256) NULL,
	[EAttendance] [int] NULL,
	[EIsAlcoholServed] [varchar](256) NULL,
	[EIsAlcoholSold] [varchar](256) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventInformation]    Script Date: 3/22/2020 11:39:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventInformation](
	[ID] [int] NOT NULL,
	[EINameOfEvent] [varchar](256) NULL,
	[EIDateEventHeldFile] [varchar](256) NULL,
	[EIActivitiesDescription] [varchar](256) NULL,
	[EIActivitiesDescriptionFile] [varchar](256) NULL,
	[EIBusOwner] [varchar](256) NULL,
	[EIBusManager] [varchar](256) NULL,
	[EIThirdParty] [varchar](256) NULL,
	[EIEventPrivacy] [varchar](256) NULL,
	[EIAdmissionCharge] [varchar](256) NULL,
	[EIAdmissionCost] [decimal](18, 2) NULL,
	[EISellAdmissionTicket] [varchar](256) NULL,
	[EISellHowManyTickets] [int] NULL,
	[EITotalTicketSalesAmount] [decimal](18, 2) NULL,
	[EIPricePerTicket] [decimal](18, 2) NULL,
	[EIHowTicketsSold] [varchar](256) NULL,
	[EIWhoSellTickets] [varchar](256) NULL,
	[EIDonationExpected] [varchar](256) NULL,
	[EIAssignedSeating] [varchar](256) NULL,
	[EIOpenSeating] [varchar](256) NULL,
	[EIBringYourOwnSeating] [varchar](256) NULL,
	[EIBleachersSeating] [varchar](256) NULL,
	[EISeatingNotApplicable] [varchar](256) NULL,
	[EIPrivateSecurityPersons] [int] NULL,
	[EIPoliceOrSheriffPersons] [int] NULL,
	[EIPeerGroupOrUshersPersons] [int] NULL,
	[EIEmployeesPersons] [int] NULL,
	[EIParentChaperonsPersons] [int] NULL,
	[EIVolunteersPersons] [int] NULL,
	[EISecurityArmed] [varchar](256) NULL,
	[EIWandingChecking] [varchar](256) NULL,
	[EIFirstAid] [varchar](256) NULL,
	[EIFirstAidCompany] [varchar](256) NULL,
	[EIReceivedInsuranceCert] [varchar](256) NULL,
	[EIADAExit] [varchar](256) NULL,
	[EIADAParking] [varchar](256) NULL,
	[EIEventAdvertising] [varchar](256) NULL,
	[EIAdvertiseByWeb] [varchar](256) NULL,
	[EIAdvertisementWebsite] [varchar](256) NULL,
	[EIEventIsOnTelevision] [varchar](256) NULL,
	[EIEventIsOnRadio] [varchar](256) NULL,
	[EIEventIsOnNewspaper] [varchar](256) NULL,
	[EIEventIsOnBrochure] [varchar](256) NULL,
	[EIEventIsOnHandout] [varchar](256) NULL,
	[EIEventIsOnBillboard] [varchar](256) NULL,
	[EIEventIsOnPoster] [varchar](256) NULL,
	[EIEventIsOnOther] [varchar](256) NULL,
	[EIIsAlcoholServed] [varchar](256) NULL,
	[EIIsAlcoholSold] [varchar](256) NULL,
	[EIIsEventCharged] [varchar](256) NULL,
	[EIIsEventPayToAttend] [varchar](256) NULL,
	[EIIsEventReceiveDonation] [varchar](256) NULL,
	[EIIsThereBeer] [varchar](256) NULL,
	[EIIsThereWineOrChampagne] [varchar](256) NULL,
	[EIIsThereMixedOrBar] [varchar](256) NULL,
	[EIIsThereAlcoholVendor] [varchar](256) NULL,
	[EIIsThereAlcoholVendingInsurance] [varchar](256) NULL,
	[EIEstimatedAlcoholSales] [decimal](18, 2) NULL,
	[EINumberOfAlcoholLocations] [int] NULL,
	[EIIsLiquorLicenseRequired] [varchar](256) NULL,
	[EIMustLiquorBeDrankInArea] [varchar](256) NULL,
	[EINeedIdToRecieveLiquor] [varchar](256) NULL,
	[EIOverAgeDrinkerHaveOtherID] [varchar](256) NULL,
	[EIIsThereLimitTwoServingLiquor] [varchar](256) NULL,
	[EIIsThereLiquorStaffMonitoring] [varchar](256) NULL,
	[EIIsLiquorBarClosedTwoHrsEarly] [varchar](256) NULL,
	[EIHasAthleticOrRecreationalActivity] [varchar](256) NULL,
	[EIWaiverLiabilityProcedure] [varchar](256) NULL,
	[EILiabilityReleaseFile] [varchar](256) NULL,
	[EIHasMusic] [varchar](256) NULL,
	[EIIsThereLiveMusic] [varchar](256) NULL,
	[EIIsThereDiskJockey] [varchar](256) NULL,
	[EIIsThereStereoCDPlayer] [varchar](256) NULL,
	[EIAmplifiedSound] [varchar](256) NULL,
	[EIHowManyArtists] [int] NULL,
	[EIOwnElectricity] [varchar](256) NULL,
	[EIArrangements] [varchar](256) NULL,
	[EIOtherEntertainment] [varchar](256) NULL,
	[EIDescribeOtherEntertainment] [varchar](256) NULL,
	[EIJumpsTanksTrains] [varchar](256) NULL,
	[EICompanyHired] [varchar](256) NULL,
	[EIFollowingActivitiesFile] [varchar](256) NULL,
	[EIWaiverDescription] [varchar](256) NULL,
 CONSTRAINT [PK_EventInformationTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventLocation]    Script Date: 3/22/2020 11:39:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventLocation](
	[ID] [int] NOT NULL,
	[ELNameOfFacility] [varchar](256) NULL,
	[ELStreetName] [varchar](256) NULL,
	[ELEventCity] [varchar](256) NULL,
	[ELEventState] [varchar](256) NULL,
	[ELEventZip] [int] NULL,
	[ELOutdoorSize] [varchar](256) NULL,
	[ELOutdoorAreaInsured] [varchar](256) NULL,
	[ELAreThereVendorsSellingAlcohol] [varchar](256) NULL,
	[ELVendorsFile] [varchar](256) NULL,
	[ELExhibitorsFile] [varchar](256) NULL,
	[ELAreTherePastEvents] [varchar](256) NULL,
	[ELCertificateOfInsuranceFile] [varchar](256) NULL,
	[ELIsThereEmergencyEvacPlan] [varchar](256) NULL,
	[ELEvacuationPlanDescription] [varchar](256) NULL,
	[ELIsThereMedicalPresence] [varchar](256) NULL,
	[ELNumOfDoctors] [int] NULL,
	[ELNumOfParamedics] [int] NULL,
	[ELNumOfNurses] [int] NULL,
	[ELNumOfEMTandEMS] [int] NULL,
	[ELNumOfOther] [int] NULL,
	[ELIsThereAmbulance] [varchar](256) NULL,
	[ELIsThereStreetClosure] [varchar](256) NULL,
	[ELIsThereTrafficMitigation] [varchar](256) NULL,
	[ELTrafficMitigationDescription] [varchar](256) NULL,
	[ELLACertificationFile] [varchar](256) NULL,
	[ELVendorsInsuredFile] [varchar](256) NULL,
	[ELBrochuresAdsFile] [varchar](256) NULL,
	[ELScheduleOfEventsFile] [varchar](256) NULL,
	[ELWaiversAndReleaseFile] [varchar](256) NULL,
	[ELSitePlanDiagramFile] [varchar](256) NULL,
	[ELFiveYearHistoryFile] [varchar](256) NULL,
	[ELEvacuationPlanFile] [varchar](256) NULL,
 CONSTRAINT [PK_EventLocationTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exhibitor]    Script Date: 3/22/2020 11:39:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exhibitor](
	[ID] [int] NOT NULL,
	[ExTypeofServvice] [varchar](256) NULL,
	[ExName] [varchar](256) NULL,
	[ExMailingAddress] [varchar](256) NULL,
	[ExCity] [varchar](256) NULL,
	[ExState] [varchar](256) NULL,
	[ExZip] [int] NULL,
	[ExPhone] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FinalSection]    Script Date: 3/22/2020 11:39:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FinalSection](
	[ID] [int] NOT NULL,
	[FSApplicantSignature] [varchar](256) NULL,
	[FSApplicantTitle] [varchar](256) NULL,
	[FSFinishedApplicationDate] [date] NULL,
	[FSSupervisorInitials] [varchar](256) NULL,
	[FSAssemblingsPermitDate] [date] NULL,
 CONSTRAINT [PK_FinalSectionTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ImportantNotice]    Script Date: 3/22/2020 11:39:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ImportantNotice](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Agreement] [varchar](5) NULL,
	[Password] [varchar](16) NULL,
 CONSTRAINT [PK_ImportantNoticeTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IncludeFollowingActivities1]    Script Date: 3/22/2020 11:39:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IncludeFollowingActivities1](
	[ID] [int] NOT NULL,
	[IsThereClimbing] [varchar](256) NULL,
	[IsThereSkateBoard] [varchar](256) NULL,
	[IsThereRoller] [varchar](256) NULL,
	[IsThereCycling] [varchar](256) NULL,
	[IsThereWatercraft] [varchar](256) NULL,
	[IsThereGun] [varchar](256) NULL,
	[IsThereFire] [varchar](256) NULL,
	[IsThereArmory] [varchar](256) NULL,
	[IsThereChemical] [varchar](256) NULL,
	[IsThereMedical] [varchar](256) NULL,
	[IsThereConstructOrDemo] [varchar](256) NULL,
	[IsThereScaffoldAbove4Ft] [varchar](256) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IncludeFollowingActivities2]    Script Date: 3/22/2020 11:39:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IncludeFollowingActivities2](
	[ID] [int] NOT NULL,
	[HasAirRides] [varchar](50) NULL,
	[HasTerrainBoarding] [varchar](50) NULL,
	[HasBaseJumping] [varchar](50) NULL,
	[HasBouldering] [varchar](50) NULL,
	[HasBoxingMartialArts] [varchar](50) NULL,
	[HasBungeeJumping] [varchar](50) NULL,
	[HasCircusCarnival] [varchar](50) NULL,
	[HasConcertsOver6Hrs] [varchar](50) NULL,
	[HasConcertwithMoshPit] [varchar](50) NULL,
	[HasPlatformBoardDiving] [varchar](50) NULL,
	[HasHangGliding] [varchar](50) NULL,
	[HasKayakRaftCanoe] [varchar](50) NULL,
	[HasMechanicalRide] [varchar](50) NULL,
	[HasMotorSport] [varchar](50) NULL,
	[HasMountainBiking] [varchar](50) NULL,
	[HasPowerBoats] [varchar](50) NULL,
	[HasProSportCashPrizeGames] [varchar](50) NULL,
	[HasPyroAndFire] [varchar](50) NULL,
	[HasRapHeavyMetalConcert] [varchar](50) NULL,
	[HasRockClimbing] [varchar](50) NULL,
	[HasRodeoAndRoping] [varchar](50) NULL,
	[HasSkinDiving] [varchar](50) NULL,
	[HasScubaDiving] [varchar](50) NULL,
	[HasTractorTruckPull] [varchar](50) NULL,
	[HasTrampoline] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MusicArtists]    Script Date: 3/22/2020 11:39:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusicArtists](
	[ID] [int] NOT NULL,
	[MName] [varchar](256) NULL,
	[MAddress] [varchar](256) NULL,
	[MPhone] [int] NULL,
	[MContact] [varchar](256) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MusicTypes]    Script Date: 3/22/2020 11:39:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusicTypes](
	[ID] [int] NOT NULL,
	[IsThereAcidRock] [varchar](256) NULL,
	[IsThereAlternative] [varchar](256) NULL,
	[IsThereBigBand] [varchar](256) NULL,
	[IsThereBlues] [varchar](256) NULL,
	[IsThereChristian] [varchar](256) NULL,
	[IsThereClassical] [varchar](256) NULL,
	[IsThereCountrySoul] [varchar](256) NULL,
	[IsThereCountryRock] [varchar](256) NULL,
	[IsThereDeathRock] [varchar](256) NULL,
	[IsThereDisco] [varchar](256) NULL,
	[IsThereContemporary] [varchar](256) NULL,
	[IsThereEthnicNForeignCultural] [varchar](256) NULL,
	[IsThere1950sN1960s] [varchar](256) NULL,
	[IsThereFunk] [varchar](256) NULL,
	[IsThereHardRock] [varchar](256) NULL,
	[IsThereHipHop] [varchar](256) NULL,
	[IsThereJazz] [varchar](256) NULL,
	[IsTherePop] [varchar](256) NULL,
	[IsThereRap] [varchar](256) NULL,
	[IsThereReggae] [varchar](256) NULL,
	[IsThereSoftRock] [varchar](256) NULL,
	[IsThereSoul] [varchar](256) NULL,
	[IsThereSymphony] [varchar](256) NULL,
	[IsThereSwing] [varchar](256) NULL,
	[IsThereHeavyMetal] [varchar](256) NULL,
	[IsThereFolk] [varchar](256) NULL,
	[IsThereGoth] [varchar](256) NULL,
	[IsThereGothMetal] [varchar](256) NULL,
	[IsThereGospel] [varchar](256) NULL,
	[IsThereIndustrial] [varchar](256) NULL,
	[IsTherePsychedelic] [varchar](256) NULL,
	[IsTherePunk] [varchar](256) NULL,
	[IsThereRave] [varchar](256) NULL,
	[IsThereSka] [varchar](256) NULL,
	[IsThereTechno] [varchar](256) NULL,
	[IsThereBubblegum] [varchar](256) NULL,
	[IsThereRockability] [varchar](256) NULL,
	[IsThereOther] [varchar](256) NULL,
	[IsThereOtherDescription] [varchar](256) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PastEvent]    Script Date: 3/22/2020 11:39:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PastEvent](
	[ID] [int] NOT NULL,
	[PEDateOfClaim] [date] NULL,
	[PEClaimant] [varchar](256) NULL,
	[PEDescription] [varchar](256) NULL,
	[PEDateOfPaid] [date] NULL,
	[PETotalIncurred] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permit]    Script Date: 3/22/2020 11:39:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permit](
	[ID] [int] NOT NULL,
	[FSPermitName] [varchar](256) NULL,
	[FSPermitYesOrNo] [varchar](256) NULL,
	[FSPermitApproval] [varchar](256) NULL,
	[FSPermitDate] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StreetClosure]    Script Date: 3/22/2020 11:39:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StreetClosure](
	[ID] [int] NOT NULL,
	[SCStreetName] [varchar](256) NULL,
	[SCZipCode] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vendor]    Script Date: 3/22/2020 11:39:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendor](
	[ID] [int] NOT NULL,
	[VTypeOfServ] [varchar](256) NULL,
	[VName] [varchar](256) NULL,
	[VMailingAddress] [varchar](256) NULL,
	[VCity] [varchar](256) NULL,
	[VState] [varchar](256) NULL,
	[VZip] [int] NULL,
	[VPhone] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Activity]  WITH CHECK ADD  CONSTRAINT [FK_ActivityTable_EventInformationTable] FOREIGN KEY([ID])
REFERENCES [dbo].[EventInformation] ([ID])
GO
ALTER TABLE [dbo].[Activity] CHECK CONSTRAINT [FK_ActivityTable_EventInformationTable]
GO
ALTER TABLE [dbo].[ApplicationInformation]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationInformationTable_ImportantNoticeTable] FOREIGN KEY([ID])
REFERENCES [dbo].[ImportantNotice] ([ID])
GO
ALTER TABLE [dbo].[ApplicationInformation] CHECK CONSTRAINT [FK_ApplicationInformationTable_ImportantNoticeTable]
GO
ALTER TABLE [dbo].[Event]  WITH CHECK ADD  CONSTRAINT [FK_EventTable_EventInformationTable] FOREIGN KEY([ID])
REFERENCES [dbo].[EventInformation] ([ID])
GO
ALTER TABLE [dbo].[Event] CHECK CONSTRAINT [FK_EventTable_EventInformationTable]
GO
ALTER TABLE [dbo].[EventInformation]  WITH CHECK ADD  CONSTRAINT [FK_EventInformationTable_ImportantNoticeTable] FOREIGN KEY([ID])
REFERENCES [dbo].[ImportantNotice] ([ID])
GO
ALTER TABLE [dbo].[EventInformation] CHECK CONSTRAINT [FK_EventInformationTable_ImportantNoticeTable]
GO
ALTER TABLE [dbo].[EventLocation]  WITH CHECK ADD  CONSTRAINT [FK_EventLocationTable_ImportantNoticeTable] FOREIGN KEY([ID])
REFERENCES [dbo].[ImportantNotice] ([ID])
GO
ALTER TABLE [dbo].[EventLocation] CHECK CONSTRAINT [FK_EventLocationTable_ImportantNoticeTable]
GO
ALTER TABLE [dbo].[Exhibitor]  WITH CHECK ADD  CONSTRAINT [FK_ExibitorsTable_EventLocationTable1] FOREIGN KEY([ID])
REFERENCES [dbo].[EventLocation] ([ID])
GO
ALTER TABLE [dbo].[Exhibitor] CHECK CONSTRAINT [FK_ExibitorsTable_EventLocationTable1]
GO
ALTER TABLE [dbo].[FinalSection]  WITH CHECK ADD  CONSTRAINT [FK_FinalSectionTable_ImportantNoticeTable] FOREIGN KEY([ID])
REFERENCES [dbo].[ImportantNotice] ([ID])
GO
ALTER TABLE [dbo].[FinalSection] CHECK CONSTRAINT [FK_FinalSectionTable_ImportantNoticeTable]
GO
ALTER TABLE [dbo].[IncludeFollowingActivities1]  WITH CHECK ADD  CONSTRAINT [FK_IncludeFollowingActivities1_EventInformation] FOREIGN KEY([ID])
REFERENCES [dbo].[EventInformation] ([ID])
GO
ALTER TABLE [dbo].[IncludeFollowingActivities1] CHECK CONSTRAINT [FK_IncludeFollowingActivities1_EventInformation]
GO
ALTER TABLE [dbo].[IncludeFollowingActivities2]  WITH CHECK ADD  CONSTRAINT [FK_IncludeFollowingActivities2_EventInformation] FOREIGN KEY([ID])
REFERENCES [dbo].[EventInformation] ([ID])
GO
ALTER TABLE [dbo].[IncludeFollowingActivities2] CHECK CONSTRAINT [FK_IncludeFollowingActivities2_EventInformation]
GO
ALTER TABLE [dbo].[MusicArtists]  WITH CHECK ADD  CONSTRAINT [FK_MusicTable_EventInformationTable] FOREIGN KEY([ID])
REFERENCES [dbo].[EventInformation] ([ID])
GO
ALTER TABLE [dbo].[MusicArtists] CHECK CONSTRAINT [FK_MusicTable_EventInformationTable]
GO
ALTER TABLE [dbo].[MusicTypes]  WITH CHECK ADD  CONSTRAINT [FK_MusicTypes_EventInformation] FOREIGN KEY([ID])
REFERENCES [dbo].[EventInformation] ([ID])
GO
ALTER TABLE [dbo].[MusicTypes] CHECK CONSTRAINT [FK_MusicTypes_EventInformation]
GO
ALTER TABLE [dbo].[PastEvent]  WITH CHECK ADD  CONSTRAINT [FK_PastEventTable_EventLocationTable] FOREIGN KEY([ID])
REFERENCES [dbo].[EventLocation] ([ID])
GO
ALTER TABLE [dbo].[PastEvent] CHECK CONSTRAINT [FK_PastEventTable_EventLocationTable]
GO
ALTER TABLE [dbo].[Permit]  WITH CHECK ADD  CONSTRAINT [FK_PermitTable_FinalSectionTable] FOREIGN KEY([ID])
REFERENCES [dbo].[FinalSection] ([ID])
GO
ALTER TABLE [dbo].[Permit] CHECK CONSTRAINT [FK_PermitTable_FinalSectionTable]
GO
ALTER TABLE [dbo].[StreetClosure]  WITH CHECK ADD  CONSTRAINT [FK_StreetClosureTable_EventLocationTable1] FOREIGN KEY([ID])
REFERENCES [dbo].[EventLocation] ([ID])
GO
ALTER TABLE [dbo].[StreetClosure] CHECK CONSTRAINT [FK_StreetClosureTable_EventLocationTable1]
GO
ALTER TABLE [dbo].[Vendor]  WITH CHECK ADD  CONSTRAINT [FK_VendorsTable_EventLocationTable] FOREIGN KEY([ID])
REFERENCES [dbo].[EventLocation] ([ID])
GO
ALTER TABLE [dbo].[Vendor] CHECK CONSTRAINT [FK_VendorsTable_EventLocationTable]
GO
