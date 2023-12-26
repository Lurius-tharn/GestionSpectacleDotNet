create table billet
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

INSERT INTO gestionspectacle.billet (Id, idSpectacle, idUtilisateur, statut, numeroBillet) VALUES (12, 12, 10, 'Reserve', 5);
INSERT INTO gestionspectacle.billet (Id, idSpectacle, idUtilisateur, statut, numeroBillet) VALUES (13, 13, 10, 'Reserve', 1);
INSERT INTO gestionspectacle.billet (Id, idSpectacle, idUtilisateur, statut, numeroBillet) VALUES (14, 13, 10, 'Reserve', 2);
INSERT INTO gestionspectacle.billet (Id, idSpectacle, idUtilisateur, statut, numeroBillet) VALUES (15, 13, 10, 'Reserve', 3);
