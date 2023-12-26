create table billethistorique
(
    id         int auto_increment
        primary key,
    IdBillet   int         null,
    DateBillet datetime(6) not null,
    constraint Historique_Billet_billet_null_fk
        foreign key (IdBillet) references billet (Id)
);

create index IX_BilletHistorique_IdBillet
    on billethistorique (IdBillet);

