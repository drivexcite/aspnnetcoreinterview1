use TraderMikesDb;
go

insert into [Location](LocationId, [Name], Latitude, Longitude, CreatedDate, CreatedBy) 
	values (1, 'Boise', 1, 1, getutcdate(), CURRENT_USER),
		   (2, 'Eagle', 1, 1, getutcdate(), CURRENT_USER),
		   (3, 'Nampa', 1, 1, getutcdate(), CURRENT_USER),
		   (4, 'Caldwell', 1, 1, getutcdate(), CURRENT_USER),
		   (5, 'Kuna', 1, 1, getutcdate(), CURRENT_USER);

insert into [Item](ItemId, [Name], Price, CreatedDate, CreatedBy)
	values (1, 'Fire TV Stick', 50, getutcdate(), CURRENT_USER),
		   (2, 'Play Doh', 10, getutcdate(), CURRENT_USER),
		   (3, 'Wyze Cam', 35, getutcdate(), CURRENT_USER),
		   (4, 'Makita 10" Saw Blade', 40, getutcdate(), CURRENT_USER),
		   (5, 'Cynical Theories by Helen Pluckrose & James Lindsay', 30, getutcdate(), CURRENT_USER),
		   (6, 'Rinnai RU199iN High-Efficiency Tankless Water Heater', 1600, getutcdate(), CURRENT_USER),
		   (7, 'Victor Classic - Hi-Pro Plus, Dry Dog Food', 50, getutcdate(), CURRENT_USER),
		   (8, 'Trace Minerals Research PGG02 - Greens Pak, 30 Packets', 25, getutcdate(), CURRENT_USER),
		   (9, 'Cracking the Coding Interview by Gayle Laakmann McDowell', 20, getutcdate(), CURRENT_USER),
		   (10, 'Breville Duo Temp Espresso Machine', 350, getutcdate(), CURRENT_USER),
		   (11, 'Exploding Kittens Card Game', 15, getutcdate(), CURRENT_USER),
		   (12, 'WD 1TB My Passport Wireless SSD External Portable Drive', 350, getutcdate(), CURRENT_USER),
		   (13, '5-pack: Dry-Fit Sweat Resistant Athletic Performance Shorts', 30, getutcdate(), CURRENT_USER),
		   (14, 'Scott Essential Multifold Paper Towels', 35, getutcdate(), CURRENT_USER),
		   (15, 'iSiLER 2 Slice Toaster, 1.3 Inches Wide Slot Toaster', 25, getutcdate(), CURRENT_USER),
		   (16, 'Homasy Cool Mist Humidifier Diffuser', 30, getutcdate(), CURRENT_USER),
		   (17, 'VIGBODY Exercise Bike Indoor Cycling Bicycle', 250, getutcdate(), CURRENT_USER),
		   (18, 'Vacuum-Insulated Stainless-Steel Water Bottle, 32oz', 25, getutcdate(), CURRENT_USER),
		   (19, 'Making Sense by Sam Harris', 25, getutcdate(), CURRENT_USER),
		   (20, '10-pack 4-1/2" Cut Off Wheels for Ferrous Metals', 10, getutcdate(), CURRENT_USER),
		   (20, 'Bobco Metals Heavy Duty Weldable Pair 3" x 3" Gate Hinges', 15, getutcdate(), CURRENT_USER);
		   
go

