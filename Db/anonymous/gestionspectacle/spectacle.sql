create table spectacle
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

INSERT INTO gestionspectacle.spectacle (id, titre, date, lieu, nbPlace, idApi, imageUrl, type) VALUES (11, 'THE MUSIC OF HANS ZIMMER & OTHERS', '2024-01-04', 'SALLE PLEYEL', 50, 'rZ7SnyZ1Ad_g7f', 'https://s1.ticketm.net/dam/c/aae/b503db1a-c908-473b-a218-96d123cd5aae_105501_TABLET_LANDSCAPE_16_9.jpg', 'event');
INSERT INTO gestionspectacle.spectacle (id, titre, date, lieu, nbPlace, idApi, imageUrl, type) VALUES (12, 'THE MUSIC OF HANS ZIMMER & OTHERS', '2024-01-04', 'SALLE PLEYEL', 35, 'rZ7SnyZ1Ad_g7f', 'https://s1.ticketm.net/dam/c/aae/b503db1a-c908-473b-a218-96d123cd5aae_105501_TABLET_LANDSCAPE_16_9.jpg', 'event');
INSERT INTO gestionspectacle.spectacle (id, titre, date, lieu, nbPlace, idApi, imageUrl, type) VALUES (13, 'THE MUSIC OF HANS ZIMMER & OTHERS', '2024-01-04', 'SALLE PLEYEL', 47, 'rZ7SnyZ1Ad_g7f', 'https://s1.ticketm.net/dam/c/aae/b503db1a-c908-473b-a218-96d123cd5aae_105501_TABLET_LANDSCAPE_16_9.jpg', 'event');
