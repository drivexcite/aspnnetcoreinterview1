if not exists (select 1 from master.dbo.sysdatabases where name = 'TraderMikesDb')
begin
	create database TraderMikesDb;
end
go

use TraderMikesDb;
go

create table [Location]
(
	LocationId int not null primary key clustered,
	[Name] varchar(60) not null,	
	CreatedDate datetime2(2) not null,
	CreatedBy varchar(100) not null
);
go

create table [Item]
(
	ItemId int not null primary key clustered,
	[Name] varchar(60) not null,
	Price money not null,
	CreatedDate datetime2(2) not null,
	CreatedBy varchar(100) not null
);
go