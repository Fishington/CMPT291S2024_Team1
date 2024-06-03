USE CarRental
insert into CarType (Type, DailyPrice, WeeklyPrice, MonthlyPrice) VALUES ('SMALL', 5, 15, 10)
insert into CarType (Type, DailyPrice, WeeklyPrice, MonthlyPrice) VALUES ('SUV', 5, 15, 10)

insert into Branches (Branch_ID, Name, Street, City, Postal_Code, Province, Country) VALUES (1, 'Edmonton South', 'Calgary Trail', 'T5Z ZZZ', 'AB', 'Canada')

insert into Cars(VIN, License_Plate, Make, Model, Transmission, Branch_ID, Type) VALUES ('WA1DGAFP4EA042058', 'BobRox', 'Volkswagen', 'Golf', 'Manual', 1)