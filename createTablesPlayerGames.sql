Begin Transaction;

create table player(
	id		int			identity(1,1)	primary key,
	name	varchar(24)	not null
	);

create table gameType(
	id		int			identity(1,1)	primary key,
	name	varchar(16)	not null,
	);

create table game(
	id		int			identity(1,1)	primary key,
	name	varchar(32)	not null,
	typeId	int			not null,

	constraint fk_gameTypeId foreign key (typeId) references gameType(id)
	);

create table gameMatch(
	id			int		identity(1,1)	primary key,
	gameId		int		not null,
	playerId	int		not null,

	constraint fk_gameId foreign key (gameId) references game(id),
	constraint fk_playerId foreign key (playerId) references player(id)
	);

Commit Transaction