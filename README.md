# ADO.NET connected 5 - De FruitShop

## Setup
### Database
- Maak een nieuwe database aan met de naam ```FruitDb``` (gebruik hiervoor SSMS)
- Gebruik de nieuwe database om onderstaande query uit te voeren:
```
CREATE TABLE Fruit(
	[Id] [int] PRIMARY KEY,
	[Name] [NVARCHAR](100) NOT NULL,
	[Color] [NVARCHAR](50) NOT NULL,
	[Season] [NVARCHAR](50) NOT NULL
);

INSERT INTO Fruit (Id, Name, Color, Season)
	VALUES
	(1, 'Appel', 'Rood/Groen', 'Herfst'),
	(2, 'Banaan', 'Geel', 'Hele jaar'),
	(3, 'Sinaasappel', 'Oranje', 'Winter'),
	(4, 'Aardbei', 'Rood', 'Zomer');
```
- Maak in het *Settings*-bestand een ConnectionString aan die verwijst naar de nieuwe database

### Projects
- Maak een link tussen de AppLogic class library en het UI project zodat de classes uit het AppLogic project gebruikt kunnen worden in het UI project
- Zorg ervoor dat het FruitWindow wordt getoond wanneer de applicatie gestart wordt

### Fruit
- Zorg dat de klasse *Fruit* de volgende eigenschappen heeft:
	- int : Id
	- string : Name
	- string : Color
	- string : Season

### Data
- Installeer het ```Microsoft.Data.SqlClient``` NuGet package in de AppLogic class library
- Implementeer alle methodes die in de *Data* klasse beschreven staan

## Vereisten
#### Startup
- Tijdens het laden van het FruitWindow moet de connectionstring uit het settings-bestand worden ingelezen. De waarde ervan wordt doorgegeven aan de ConnectionString eigenschap van de data klasse
- Nadat de connectiestring is ingevuld moet de fruitDataGrid gevuld worden met de data uit de Fruit tabel van de database
	- Gebruik de lijst van Fruit objecten (Data.Fruits) als ItemsSource van de fruitDataGrid
	- Gebruik de ```GetAllFruit``` functie van de data klasse om deze lijst (Data.Fruits) te vullen

#### Delete
- Wanneer er op de knop "Delete" geklikt wordt moet het (in de DataGrid) geselecteerde Fruit object verwijderd worden uit de lijst van Fruit objecten **EN uit de database**.

#### Create
- Wanneer er op de "Create"-knop geklikt wordt moet het CreateWindow modaal geopend worden
- Nadat de gebruiker op "Bewaren" klikt moet met de ingegeven waarden een Fruit object gemaakt worden
	- Gebruik de Data.CreateFruit functie om dit object in de database te bewaren
	- Voeg het nieuwe object ook toe aan de lijst van Fruit objecten (Data.Fruits) die in de DataGrid getoond worden

