INSERT INTO UlogaKorisnika (naziv_uloge)
VALUES 
('Organizator ture'),
('Zaposlenik za rad s klijentima');

INSERT INTO Korisnik (uloga_id, korisnicko_ime, lozinka)
VALUES
(1, 'organizator', 'test'),
(2, 'zaposlenik', 'test');

INSERT INTO TuristickaTura (naziv_ture, datum_vrijeme, trajanje, cijena_po_osobi, maksimalan_broj_sudionika)
VALUES
('Barokni Varaždin', '2026-06-12 10:00:00', '2 h', 20.00, 25),
('Dvorci okolice', '2026-06-13 09:00:00', '5 h', 35.00, 40),
('Vinske ceste', '2026-06-14 16:00:00', '3 h', 28.00, 18),
('Stari grad', '2026-06-15 11:00:00', '1.5 h', 15.00, 30);

INSERT INTO Klijent (ime_prezime, kontakt)
VALUES
('Ana Horvat', '091/123-456'),
('Marko Kovač', '098/222-333'),
('Ivana Novak', '099/444-555');

INSERT INTO Rezervacija (tura_id, klijent_id, korisnik_id, broj_prijavljenih_osoba, datum_rezervacije, ukupan_iznos)
VALUES
(1, 1, 2, 2, '2026-06-01 10:00:00', 40.00),
(1, 2, 2, 4, '2026-06-02 11:30:00', 80.00),
(2, 3, 2, 1, '2026-06-03 09:15:00', 35.00);