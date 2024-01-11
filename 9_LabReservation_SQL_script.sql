create database Lab_Reservation;
use [Lab_Reservation];

CREATE TABLE UserLogin (
	userID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	userName VARCHAR(15) NOT NULL,
	userPassword VARCHAR(15) NOT NULL,
);

insert UserLogin(userName,userPassword) VALUES ('admin','123');

CREATE TABLE LabTable (
	labID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	labName VARCHAR(50) NOT NULL UNIQUE,
	labSpecialization VARCHAR(50) NOT NULL,
	labPrice DECIMAL(10,2) NOT NULL,
	isReserved VARCHAR(20) default 'Available',
);

CREATE TABLE CustomerTable (
	customerID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	customerName VARCHAR(50) NOT NULL,
	customerNationalID VARCHAR(50) NOT NULL,
	customerGender VARCHAR(10),
	customerPhone VARCHAR(20) NOT NULL,
	customerAddress VARCHAR(400),
	customerCheckInDay VARCHAR(250) NOT NULL,
	customerCheckOutDay VARCHAR(250),
	customerCheckOutState VARCHAR(5) default 'NO',
	labID INT NOT NULL FOREIGN KEY REFERENCES LabTable(labID),
);

CREATE TABLE FeedbackTable (
	fbID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	fbType VARCHAR(1000) NOT NULL,
	fbTitle VARCHAR(1500) NOT NULL,
	fbContent VARCHAR(5000) NOT NULL,

);

insert into LabTable (labName, labSpecialization, labPrice) values ('Thorshofn', 'Biophysics', 1301.23);
insert into LabTable (labName, labSpecialization, labPrice) values ('Hudson''s Hope', 'Earth science', 1188.33);
insert into LabTable (labName, labSpecialization, labPrice) values ('Humera', 'Biochemistry', 1672.34);
insert into LabTable (labName, labSpecialization, labPrice) values ('Yari', 'Physical science', 1191.84);
insert into LabTable (labName, labSpecialization, labPrice) values ('Drumduff', 'Physical science', 1138.36);
insert into LabTable (labName, labSpecialization, labPrice) values ('Telegraph Creek', 'Biophysics', 1450.03);
insert into LabTable (labName, labSpecialization, labPrice) values ('Marawaka', 'Cellular biology', 1805.16);
insert into LabTable (labName, labSpecialization, labPrice) values ('Hola', 'Earth science', 1622.79);
insert into LabTable (labName, labSpecialization, labPrice) values ('Tahneta Pass Lodge', 'Physical science', 1325.56);
insert into LabTable (labName, labSpecialization, labPrice) values ('Franceville', 'Kinesiology', 1532.56);
insert into LabTable (labName, labSpecialization, labPrice) values ('La Ceiba', 'Meteorology', 1296.2);
insert into LabTable (labName, labSpecialization, labPrice) values ('Inhaca', 'Physics', 1797.34);
insert into LabTable (labName, labSpecialization, labPrice) values ('Potosí', 'Astronomy', 1108.91);
insert into LabTable (labName, labSpecialization, labPrice) values ('Thandwe', 'Zoology', 1451.83);
insert into LabTable (labName, labSpecialization, labPrice) values ('Verkhnevilyuisk', 'Physical science', 1944.24);
insert into LabTable (labName, labSpecialization, labPrice) values ('Natashquan', 'Genetics', 1023.09);
insert into LabTable (labName, labSpecialization, labPrice) values ('Kingstown', 'Cellular biology', 1755.49);
insert into LabTable (labName, labSpecialization, labPrice) values ('Nyala', 'Kinesiology', 1209.14);
insert into LabTable (labName, labSpecialization, labPrice) values ('Lifou', 'Zoology', 1017.66);
insert into LabTable (labName, labSpecialization, labPrice) values ('Jasper', 'Microbiology', 1888.28);
insert into LabTable (labName, labSpecialization, labPrice) values ('Val-d''Or', 'Physics', 1749.0);
insert into LabTable (labName, labSpecialization, labPrice) values ('Dalaman', 'Computer Science', 1400.8);
insert into LabTable (labName, labSpecialization, labPrice) values ('Terapo Mission', 'Biology', 1405.08);
insert into LabTable (labName, labSpecialization, labPrice) values ('La Unión', 'Zoology', 1615.73);
insert into LabTable (labName, labSpecialization, labPrice) values ('Pangoa', 'Chemistry', 1505.68);
insert into LabTable (labName, labSpecialization, labPrice) values ('Arapongas', 'Zoology', 1601.79);
insert into LabTable (labName, labSpecialization, labPrice) values ('Zagora', 'Zoology', 1703.41);
insert into LabTable (labName, labSpecialization, labPrice) values ('Zhigansk', 'Physics', 1609.96);
insert into LabTable (labName, labSpecialization, labPrice) values ('Gaithersburg', 'Biophysics', 1118.72);
insert into LabTable (labName, labSpecialization, labPrice) values ('Hudson Bay', 'Cellular biology', 1147.94);
insert into LabTable (labName, labSpecialization, labPrice) values ('Gardez', 'Microbiology', 1329.68);
insert into LabTable (labName, labSpecialization, labPrice) values ('Mabuiag Island', 'Physical science', 1849.39);
insert into LabTable (labName, labSpecialization, labPrice) values ('Amos', 'Zoology', 1891.98);
insert into LabTable (labName, labSpecialization, labPrice) values ('Ubarana', 'Cellular biology', 1014.67);
insert into LabTable (labName, labSpecialization, labPrice) values ('Al-Jawf', 'Earth science', 1334.02);
insert into LabTable (labName, labSpecialization, labPrice) values ('Dinangat', 'Astronomy', 1294.74);
insert into LabTable (labName, labSpecialization, labPrice) values ('Tinian Island', 'Cellular biology', 1186.74);
insert into LabTable (labName, labSpecialization, labPrice) values ('Miquelon', 'Biochemistry', 1584.08);
insert into LabTable (labName, labSpecialization, labPrice) values ('Skellefteå', 'Biophysics', 1613.0);
insert into LabTable (labName, labSpecialization, labPrice) values ('Belfast', 'Cellular biology', 1947.02);
insert into LabTable (labName, labSpecialization, labPrice) values ('Karubaga-Papua Island', 'Biology', 1291.04);
insert into LabTable (labName, labSpecialization, labPrice) values ('Solapur', 'Agriculture', 1174.64);
insert into LabTable (labName, labSpecialization, labPrice) values ('Cleveland', 'Astronomy', 1597.59);
insert into LabTable (labName, labSpecialization, labPrice) values ('La Isabela', 'Biochemistry', 1537.27);
insert into LabTable (labName, labSpecialization, labPrice) values ('Lethbridge', 'Chemistry', 1605.0);
insert into LabTable (labName, labSpecialization, labPrice) values ('Khatanga', 'Kinesiology', 1792.3);
insert into LabTable (labName, labSpecialization, labPrice) values ('Ittoqqortoormiit', 'Kinesiology', 1621.29);

insert into CustomerTable (customerName, customerNationalID, customerGender, customerPhone, customerAddress, customerCheckInDay, customerCheckOutDay, customerCheckOutState, labID) values ('Aymer Farrer', 15802, 'Other', '8322032889', 'Fort-de-France', '11/06/2023', '20/07/2023', 'YES', 1);
insert into CustomerTable (customerName, customerNationalID, customerGender, customerPhone, customerAddress, customerCheckInDay, customerCheckOutDay, customerCheckOutState, labID) values ('Toiboid Muckloe', 93966, 'Female', '5155715358', 'Bolinao', '31/12/2022', '02/09/2023', 'YES', 5);
insert into CustomerTable (customerName, customerNationalID, customerGender, customerPhone, customerAddress, customerCheckInDay, customerCheckOutDay, customerCheckOutState, labID) values ('Will Taveriner', 73204, 'Female', '9601083863', 'Repatriación', '11/03/2023', '17/12/2023', 'YES', 6);
insert into CustomerTable (customerName, customerNationalID, customerGender, customerPhone, customerAddress, customerCheckInDay, customerCheckOutDay, customerCheckOutState, labID) values ('Winfield Whitsey', 65676, 'Female', '1996675873', 'Ciudad Guayana', '20/02/2023', '13/10/2023', 'YES', 8);
insert into CustomerTable (customerName, customerNationalID, customerGender, customerPhone, customerAddress, customerCheckInDay, customerCheckOutDay, customerCheckOutState, labID) values ('Amitie Dyka', 10054, 'Other', '6443299174', 'Blangpulo', '27/03/2023', '31/08/2023', 'YES', 7);
insert into CustomerTable (customerName, customerNationalID, customerGender, customerPhone, customerAddress, customerCheckInDay, customerCheckOutDay, customerCheckOutState, labID) values ('Sena Kitchingham', 41520, 'Female', '7073572039', 'Beloeil', '22/04/2023', '05/12/2023', 'YES', 10);
insert into CustomerTable (customerName, customerNationalID, customerGender, customerPhone, customerAddress, customerCheckInDay, customerCheckOutDay, customerCheckOutState, labID) values ('Karmen Spurritt', 92093, 'Male', '3571712652', 'Damasak', '17/06/2023', '19/11/2023', 'YES', 12);
insert into CustomerTable (customerName, customerNationalID, customerGender, customerPhone, customerAddress, customerCheckInDay, customerCheckOutDay, customerCheckOutState, labID) values ('Christye Mallison', 86804, 'Male', '1539940212', 'Imtarfa', '02/02/2023', '04/12/2023', 'YES', 15);
insert into CustomerTable (customerName, customerNationalID, customerGender, customerPhone, customerAddress, customerCheckInDay, customerCheckOutDay, customerCheckOutState, labID) values ('Tiphany Ruff', 70998, 'Male', '2167928265', 'Rogóźno', '19/01/2023', '01/09/2023', 'YES', 17);
insert into CustomerTable (customerName, customerNationalID, customerGender, customerPhone, customerAddress, customerCheckInDay, customerCheckOutDay, customerCheckOutState, labID) values ('Bevan Backhurst', 21198, 'Other', '5372129561', 'Yangying', '08/04/2023', '06/08/2023', 'YES', 19);
insert into CustomerTable (customerName, customerNationalID, customerGender, customerPhone, customerAddress, customerCheckInDay, customerCheckOutDay, customerCheckOutState, labID) values ('Teresa Isacoff', 57576, 'Male', '1808692387', 'Oslo', '29/03/2023', '08/07/2023', 'YES', 20);
insert into CustomerTable (customerName, customerNationalID, customerGender, customerPhone, customerAddress, customerCheckInDay, customerCheckOutDay, customerCheckOutState, labID) values ('Barbi Woodnutt', 89119, 'Other', '7289494721', 'El Carmen', '21/05/2023', '20/12/2023', 'YES', 22);
insert into CustomerTable (customerName, customerNationalID, customerGender, customerPhone, customerAddress, customerCheckInDay, customerCheckOutDay, customerCheckOutState, labID) values ('Chrissy Jodlowski', 31428, 'Other', '9258660881', 'Mtwango', '16/01/2023', '30/08/2023', 'YES', 25);
insert into CustomerTable (customerName, customerNationalID, customerGender, customerPhone, customerAddress, customerCheckInDay, customerCheckOutDay, customerCheckOutState, labID) values ('Margalit Cavet', 29007, 'Other', '7575572504', 'Campamento', '21/02/2023', '16/11/2023', 'YES', 27);
insert into CustomerTable (customerName, customerNationalID, customerGender, customerPhone, customerAddress, customerCheckInDay, customerCheckOutDay, customerCheckOutState, labID) values ('Robinette Amis', 73772, 'Other', '7497489436', 'Bununu Dass', '15/06/2023', '28/09/2023', 'YES', 40);
