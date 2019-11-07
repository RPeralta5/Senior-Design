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
