create table utilisateur
(
    id       int auto_increment
        primary key,
    nom      varchar(36)  null,
    userName varchar(36)  null,
    password varchar(364) null,
    salt     binary(16)   null
);

INSERT INTO gestionspectacle.utilisateur (id, nom, userName, password, salt) VALUES (10, 'Sajous', 'Sajous', 'i+zWjh3UkOOkS8IzG82XeLP7R0hjOONSCAh0li34b3U=', 0xF4E7517C132EED0548337FD332E43B7B);
