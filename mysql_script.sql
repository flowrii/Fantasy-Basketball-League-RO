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
alter table league add scoreValue float;
alter table league add quarterValue float;
alter table league add lastUpdate varchar(10);

#update league set scorevalue=1 where userId="user";
#update league set quartervalue=5 where userId="user";

#update league set scorevalue=1.5 where userId="user3";
#update league set quartervalue=6 where userId="user3";

#update league set scorevalue=1.2 where userId="user4";
#update league set quartervalue=5.5 where userId="user4";

select CONSTRAINT_NAME
from INFORMATION_SCHEMA.TABLE_CONSTRAINTS
where TABLE_NAME = 'League';

create table LeagueUser(
	userId varchar(50) primary key, team1 int, team2 int, team3 int
);
alter table LeagueUser add constraint foreign key (team1) references Team(teamID);
alter table LeagueUser add constraint foreign key (team2) references Team(teamID);
alter table LeagueUser add constraint foreign key (team3) references Team(teamID);
alter table LeagueUser add constraint foreign key (userId) references Ulogin(userId);
ALTER TABLE LeagueUser ADD points int;
ALTER TABLE LeagueUser ADD lastgame1 int;
ALTER TABLE LeagueUser ADD lastgame2 int;
ALTER TABLE LeagueUser ADD lastgame3 int;
ALTER TABLE LeagueUser ADD leagueId varchar(10);

ALTER TABLE LeagueUser MODIFY points decimal(10,2);


alter table LeagueUser add constraint foreign key league_fk (leagueId) references League(leagueId);

create table TeamData(
	userId varchar(50) primary key, teamName varchar(50), logo varchar(150)
);

alter table TeamData add constraint foreign key (userId) references LeagueUser(userId);

create table LastGameDay( lastUpdate varchar(10));
