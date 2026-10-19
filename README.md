# TourManager – Tourist Tour Management Software

**English | Hrvatski**

## English

### About the Project

TourManager is a desktop application for managing tourist tours in the Varaždin area, developed as part of the **Software Engineering** course at the Faculty of Organization and Informatics (FOI), University of Zagreb.

The project focuses on managing tourist tours in the Varaždin area. Tourist agencies often manage their data manually or using simple spreadsheets, which can lead to errors such as duplicate reservations, exceeding tour capacity, difficulties in tracking bookings, and inefficient monitoring of total revenue and tour occupancy.

### Project Specification

The goal of this project is to develop a desktop application intended for internal use by a tourist agency. The application should allow employees to log into the system and create, view, update, and delete information about tourist tours. It should also support reservation management and maintain basic client information, including the number of registered participants.

Additionally, the software should provide an overview of available tours, reservations for selected tours, remaining available places, tour occupancy, and revenue reports.

### Technologies Used

- **C#** – application development and business logic
- **.NET / Windows Forms** – desktop application and graphical user interface
- **Microsoft SQL Server** – relational database management
- **SQL** – database queries and data manipulation
- **DBLayer.dll** – database communication
- **Visual Studio** – application development environment

### Main Features

**User Authentication:**
- User login system
- Different user roles (Organizer and Employee)
- Role-based access to application features

**Tour Management:**
- Viewing available tourist tours
- Adding new tourist tours
- Deleting existing tours
- Displaying tour details and capacity information

**Reservation Management:**
- Viewing existing reservations
- Creating new reservations
- Editing and deleting reservations
- Managing client information
- Checking available places and tour capacity

**Revenue Reports:**
- Generating revenue reports
- Filtering reports by selected date range
- Overview of revenue from tourist tours

### Assignment

[User Requirements for Tourist Tour Management Software (PDF)](https://github.com/leonardomihalic11/TourManager/blob/main/Korisni%C4%8Dki%20zahtjevi%20za%20Softver%20za%20upravljanje%20turisti%C4%8Dkim%20turama%20u%20okolici%20Vara%C5%BEdina.pdf)

### Resources

All project resources can be found in the `Documentation` folder.

### Installation and Running the Project

**Requirements:**
- Windows operating system
- Visual Studio with .NET desktop development support
- Microsoft SQL Server
- Access to a configured database
- Required project dependencies, including `DBLayer.dll`

**Step 1:** Download or clone the GitHub repository.

**Step 2:** Open the `TourManager.sln` solution in Visual Studio.

**Step 3:** Prepare a Microsoft SQL Server database.

**Step 4:** Use the provided SQL scripts to create the database structure and insert test data:

- `CreateDatabase.sql`
- `InsertTestData.sql`

**Step 5:** Configure the database connection settings to match your SQL Server environment.

**Step 6:** Build and run the application using Visual Studio.

**Note:** The application was originally developed using a university-provided SQL Server database. A properly configured database connection is required for database-dependent features to function correctly. Additional configuration adjustments may be necessary when using a different SQL Server environment.

### Author

**Leonardo Mihalic**

**Course:** Software Engineering (*Programsko inženjerstvo*)

Faculty of Organization and Informatics (FOI)

University of Zagreb, Croatia

*This application was developed as an educational project and is not intended for production use.*

---

## Hrvatski

### Softver za upravljanje turističkim turama u okolici Varaždina

### O projektu

TourManager je desktop aplikacija za upravljanje turističkim turama u okolici Varaždina, izrađena u sklopu kolegija **Programsko inženjerstvo** na Fakultetu organizacije i informatike (FOI) Sveučilišta u Zagrebu.

### Opis domene

Projekt se bavi domenom upravljanja turističkim turama u okolici Varaždina. Podaci se u turističkoj agenciji vode ručno ili pomoću jednostavnih tablica, stoga to dovodi do pogrešaka kao što su dvostruke rezervacije, prekoračenje kapaciteta ture, nepregledno praćenje prijava te otežano praćenje ukupnih prihoda i popunjenosti.

### Specifikacija projekta

Zahtjevi ovog projekta su izraditi softversko rješenje u obliku desktop aplikacije namijenjene internoj uporabi turističke agencije. Aplikacija treba omogućiti prijavu zaposlenika u sustav, unos, prikaz, izmjenu i brisanje podataka o turističkim turama, vođenje rezervacija te evidenciju osnovnih podataka o klijentima i broja prijavljenih osoba. Softversko rješenje također treba omogućiti pregled popisa tura, pregled rezervacija za odabranu turu, prikaz broja slobodnih mjesta, prikaz popunjenosti ture te izradu izvještaja o prihodima.

### Korištene tehnologije

- **C#** – razvoj aplikacije i poslovne logike
- **.NET / Windows Forms** – izrada desktop aplikacije i grafičkog korisničkog sučelja
- **Microsoft SQL Server** – upravljanje relacijskom bazom podataka
- **SQL** – upiti i upravljanje podacima
- **DBLayer.dll** – komunikacija s bazom podataka
- **Visual Studio** – razvojno okruženje

### Glavne funkcionalnosti

**Prijava korisnika:**
- Prijava korisnika u sustav
- Različite korisničke uloge (Organizator i Zaposlenik)
- Pristup funkcionalnostima ovisno o korisničkoj ulozi

**Upravljanje turističkim turama:**
- Pregled dostupnih turističkih tura
- Dodavanje novih turističkih tura
- Brisanje postojećih tura
- Prikaz detalja i kapaciteta pojedine ture

**Upravljanje rezervacijama:**
- Pregled postojećih rezervacija
- Unos novih rezervacija
- Izmjena i brisanje rezervacija
- Evidencija osnovnih podataka o klijentima
- Provjera slobodnih mjesta i kapaciteta ture

**Izvještaji o prihodima:**
- Generiranje izvještaja o prihodima
- Filtriranje izvještaja prema odabranom vremenskom razdoblju
- Pregled prihoda ostvarenih turističkim turama

### Zadatak

[Korisnički zahtjevi za Softver za upravljanje turističkim turama u okolici Varaždina (PDF)](https://github.com/leonardomihalic11/TourManager/blob/main/Korisni%C4%8Dki%20zahtjevi%20za%20Softver%20za%20upravljanje%20turisti%C4%8Dkim%20turama%20u%20okolici%20Vara%C5%BEdina.pdf)

### Resursi

Svi resursi nalaze se u mapi `Documentation`.

### Instalacija i pokretanje projekta

**Preduvjeti:**
- Windows operacijski sustav
- Visual Studio s podrškom za .NET desktop razvoj
- Microsoft SQL Server
- Pristup konfiguriranoj bazi podataka
- Potrebne biblioteke projekta, uključujući `DBLayer.dll`

**Korak 1:** Preuzeti ili klonirati GitHub repozitorij.

**Korak 2:** Otvoriti datoteku `TourManager.sln` u programu Visual Studio.

**Korak 3:** Pripremiti Microsoft SQL Server bazu podataka.

**Korak 4:** Pokrenuti priložene SQL skripte za stvaranje strukture baze i unos testnih podataka:

- `CreateDatabase.sql`
- `InsertTestData.sql`

**Korak 5:** Prilagoditi konfiguraciju povezivanja s bazom podataka vlastitom SQL Server okruženju.

**Korak 6:** Pokrenuti aplikaciju putem Visual Studija.

**Napomena:** Aplikacija je izvorno razvijena uz korištenje fakultetskog SQL Servera. Za ispravno funkcioniranje mogućnosti koje koriste bazu podataka potrebna je dostupna i pravilno konfigurirana baza. Pri korištenju drugog SQL Server okruženja mogu biti potrebne dodatne prilagodbe konfiguracije.

### Autor

**Leonardo Mihalic**

**Kolegij:** Programsko inženjerstvo

Fakultet organizacije i informatike (FOI)

Sveučilište u Zagrebu

*Projekt je izrađen u obrazovne svrhe i nije namijenjen produkcijskoj upotrebi.*
