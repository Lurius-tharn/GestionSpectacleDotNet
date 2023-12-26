create table __efmigrationshistory
(
    MigrationId    varchar(150) not null
        primary key,
    ProductVersion varchar(32)  not null
);

INSERT INTO gestionspectacle.__efmigrationshistory (MigrationId, ProductVersion) VALUES ('20231217134615_HistoriqueBillet', '6.0.25');
