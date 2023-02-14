if not exists(select 1 from dbo.Machine)
begin 
	insert into dbo.Machine (Name)
	values ('Machine1'), 
	('Machine2'),
	('Machine3'),
	('Machine4'),
	('Machine5'),
	('Machine6'),
	('Machine7'),
	('Machine8'),
	('Machine9'),
	('Washing Machine');
end

if not exists(select 1 from dbo.Malfunction)
begin 
	insert into dbo.Malfunction(Name, Priority, StartTime, EndTime,Description,Status,MachineId )
	values ('Malfunction1', 'nizak' , '1996-12-12' , '1996-12-16', 'Desc1', 'Otklonjen', 2), 
	('Malfunction2', 'nizak' , '1999-12-16' , '1999-12-20', 'Desc2', 'Otklonjen', 2), 
	('Malfunction3', 'srednji' , '2016-12-14' , '2016-12-18', 'Desc3', 'Otklonjen', 3), 
	('Malfunction4', 'nizak' , '2023-01-13' , '2023-01-17', 'Desc4', 'Otklonjen', 2), 
	('Malfunction5', 'visok' , '2023-01-20' , '2023-01-23', 'Desc5', 'Otklonjen', 9), 
	('Malfunction6', 'visok' , '2023-02-10' , '2023-02-15', 'Desc6', 'Ne', 3), 
	('Malfunction7', 'srednji' , '2023-02-01' , '2023-02-09', 'Desc7', 'Otklonjen', 5), 
	('Malfunction8', 'visok' , '2023-02-03' , '2023-02-10', 'Desc8', 'Otklonjen', 5), 
	('Malfunction9', 'srednji' , '2023-02-01' , '2023-02-13', 'Desc9', 'Ne', 6), 
	('Malfunction10', 'nizak' , '2023-02-01' , '2023-02-05', 'Desc10', 'Otklonjen', 2) 
end