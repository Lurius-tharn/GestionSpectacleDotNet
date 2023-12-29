CREATE USER 'GestionSpectacle'@'localhost' IDENTIFIED BY 'GestionSpectacle';
GRANT ALL PRIVILEGES ON *.* TO 'GestionSpectacle'@'localhost' WITH GRANT OPTION;


create database GestionSpectacle;
use GestionSpectacle;

create table if not exists __efmigrationshistory
(
    MigrationId    varchar(150) not null,
    ProductVersion varchar(32)  not null,
    primary key (MigrationId)
);

create table if not exists spectacle
(
    id       int auto_increment
        primary key,
    titre    varchar(36)  null,
    date     varchar(36)  null,
    lieu     varchar(36)  null,
    nbPlace  int          null,
    idApi    varchar(140) null,
    imageUrl varchar(380) null,
    type     varchar(100) null
);
create table if not exists utilisateur
(
    id       int auto_increment
        primary key,
    nom      varchar(36)  null,
    userName varchar(36)  null,
    password varchar(364) null,
    salt     binary(16)   null
);

create table if not exists billet
(
    Id            int auto_increment
        primary key,
    idSpectacle   int         null,
    idUtilisateur int         null,
    statut        varchar(36) null,
    numeroBillet  int         null,
    constraint Billet_spectacle_null_fk
        foreign key (idSpectacle) references spectacle (id),
    constraint Billet_utilisateur_null_fk
        foreign key (idUtilisateur) references utilisateur (id)
);

create table if not exists billethistorique
(
    Id            int auto_increment
        primary key,
    idSpectacle   int         null,
    idUtilisateur int         null,
    statut        varchar(36) null,
    numeroBillet  int         null,
    dateSuppression datetime null,
    constraint historiqueBillet_spectacle_null_fk
        foreign key (idSpectacle) references spectacle (id),
    constraint historiqueBillet_utilisateur_null_fk
        foreign key (idUtilisateur) references utilisateur (id)
);






