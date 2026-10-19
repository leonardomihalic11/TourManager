CREATE TABLE UlogaKorisnika (
    uloga_id INT IDENTITY(1,1) PRIMARY KEY,
    naziv_uloge VARCHAR(50) NOT NULL
);

CREATE TABLE Korisnik (
    korisnik_id INT IDENTITY(1,1) PRIMARY KEY,
    uloga_id INT NOT NULL,
    korisnicko_ime VARCHAR(50) NOT NULL,
    lozinka VARCHAR(100) NOT NULL,

    CONSTRAINT FK_Korisnik_UlogaKorisnika
        FOREIGN KEY (uloga_id)
        REFERENCES UlogaKorisnika(uloga_id)
);

CREATE TABLE Klijent (
    klijent_id INT IDENTITY(1,1) PRIMARY KEY,
    ime_prezime VARCHAR(100) NOT NULL,
    kontakt VARCHAR(100) NOT NULL
);

CREATE TABLE TuristickaTura (
    tura_id INT IDENTITY(1,1) PRIMARY KEY,
    naziv_ture VARCHAR(100) NOT NULL,
    datum_vrijeme DATETIME NOT NULL,
    trajanje VARCHAR(50) NOT NULL,
    cijena_po_osobi DECIMAL(10,2) NOT NULL,
    maksimalan_broj_sudionika INT NOT NULL
);

CREATE TABLE Rezervacija (
    rezervacija_id INT IDENTITY(1,1) PRIMARY KEY,
    tura_id INT NOT NULL,
    klijent_id INT NOT NULL,
    korisnik_id INT NOT NULL,
    broj_prijavljenih_osoba INT NOT NULL,
    datum_rezervacije DATETIME NOT NULL,
    ukupan_iznos DECIMAL(10,2) NOT NULL,

    CONSTRAINT FK_Rezervacija_TuristickaTura
        FOREIGN KEY (tura_id)
        REFERENCES TuristickaTura(tura_id),

    CONSTRAINT FK_Rezervacija_Klijent
        FOREIGN KEY (klijent_id)
        REFERENCES Klijent(klijent_id),

    CONSTRAINT FK_Rezervacija_Korisnik
        FOREIGN KEY (korisnik_id)
        REFERENCES Korisnik(korisnik_id)
);