# ADO.NET connected 5 - De FruitShop

## Setup
### Database
- Maak een nieuwe database aan met de naam ```FruitDb``` (gebruik hiervoor SSMS)
- Gebruik de nieuwe database om onderstaande query uit te voeren:
```
CREATE TABLE Fruit(
	[Id] [int] PRIMARY KEY IDENTITY(1,1),
	[Name] [NVARCHAR](100) NOT NULL,
	[Color] [NVARCHAR](50) NOT NULL,
	[Season] [NVARCHAR](50) NOT NULL
);

INSERT INTO Fruit (Name, Color, Season)
	VALUES
	('Appel', 'Rood/Groen', 'Herfst'),
	('Banaan', 'Geel', 'Hele jaar'),
	('Sinaasappel', 'Oranje', 'Winter'),
	('Aardbei', 'Rood', 'Zomer');
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
- Nadat de connectiestring is ingevuld moet de fruitListBox gevuld worden met de data uit de Fruit tabel van de database
	- Gebruik hiervoor de ```GetAllFruit``` functie van de data klasse
	- Zorg dat elke instantie van de klasse Fruit correct wordt weergegeven als tekst in de ListBox

#### Detail / Delete
- Wanneer er op de knop "Detail" geklikt wordt moet er een MessageBox getoond worden met alle gegevens van het (in de ListBox) geselecteerde fruit
- Wanneer er op de knop "Delete" geklikt wordt moet het (in de ListBox) geselecteerde fruit verwijderd worden uit de ListBox **EN uit de database**.

#### Create / Update
- Zowel bij de "Create"- als bij de "Update"-knop wordt het DetailWindow modaal geopend
	- Voor "Create" wordt er een nieuwe instantie van de Fruit klasse doorgegeven via een eigenschap ```FruitToDisplay``` van het DetailWindow
	- Voor "Update" wordt het geselecteerde object uit de ListBox doorgegeven via dezelfde eigenschap van het DetailWindow
- Gebruik de "setter" van de *FruitToDisplay* eigenschap ook om de titel van het venster aan te passen
	- In creatie-modus moet de titel "Toevoegen" zijn
	- In update-modus moet de titel "Bewerken" zijn
> [!TIP]
> De *Id* eigenschap van een nieuw Fruit object is gelijk aan 0 

- Gebruik de functies *CreateFruit* en *UpdateFruit* uit de *Data* klasse wanneer er op de "Bewaren"-knop geklikt wordt
- Zorg dat de nieuwe en/of gewijzigde gegevens uit het DetailWindow ook zichtbaar worden in het FruitWindow na het bewaren
