Create database proiectIS;  
use proiectIS;
Create table Ulogin    
(    
   userId varchar(50) primary key not null,    
   password varchar(100) not null,
   tip int
);
insert into  Ulogin values ('user','pass',0);

drop procedure if exists creare_utilizator;
delimiter // 
create procedure creare_utilizator
(
	userId varchar(50), password varchar(100), tip int
)
begin
	insert into Ulogin (userId,password,tip) 
    values (userId, password, tip);
end; //
delimiter ;

create table Team (
	teamID int primary key ,teamName varchar(50),logo varchar(150),nationalTeam bool,countryID int);
    
create table Country(
	countryID int primary key,countryName varchar(50),countryCode varchar(20),Flag varchar(150));
alter table Team add constraint foreign key  (countryID) references Country(countryID);

insert into country values (23,'ROm','RO','asff.asd');
insert into Team values (1,'Ferentari','adshjk.asd',false,23);

SELECT * FROM Team where teamID=1;

create table League(
	leagueId varchar(10) primary key, userId varchar(50)
);
alter table League add constraint foreign key (userId) references LeagueUser(userId);

create table LeagueUser(
	userId varchar(50) primary key, team1 int, team2 int, team3 int
);
alter table LeagueUser add constraint foreign key (team1) references Team(teamID);
alter table LeagueUser add constraint foreign key (team2) references Team(teamID);
alter table LeagueUser add constraint foreign key (team3) references Team(teamID);
alter table LeagueUser add constraint foreign key (userId) references Ulogin(userId);

create table TeamData(
	userId varchar(50) primary key, teamName varchar(50), logo varchar(150)
);

alter table TeamData add constraint foreign key (userId) references LeagueUser(userId);
