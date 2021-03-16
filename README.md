# Project6
Small C# GUI Assignment for CSC2330. Improves on project 5 by adding a database.



NOTE:
Requires a local database set up as follows:



Database Name: Project6


1st Table: Orders

Column 1 Name: DateTime

Column 1 Data Type: datetime

Column 2 Name: OrderTotalPrice

Column 2 Data Type: decimal(18, 2)

No nulls allowed.

2nd Table: Prices

Column 1 Name: ChocolatePrice

Column 1 Data Type: decimal(18, 2)

Column 2 Name: VanillaPrice

Column 2 Data Type: decimal(18, 2)

Column 3 Name: StrawberryPrice

Column 3 Data Type: decimal(18, 2)

Column 4 Name: SprinklesPrice

Column 4 Data Type: decimal(18, 2)

Column 5 Name: ChoppedNutsPrice

Column 5 Data Type: decimal(18, 2)

Column 6 Name: CherryPrice

Column 6 Data Type: decimal(18, 2)

Column 7 Name: ID

Column 7 Data Type: int

No nulls allowed, except for ID.

!!! Must add an initial data entry to 2nd Table with SQL:

INSERT INTO PRICES (ChocolatePrice, VanillaPrice, StrawberryPrice, SprinklesPrice, ChoppedNutsPrice, CherryPrice, ID) VALUES ('4.00', '4.00', '4.00', '0.50', '1.75', '1.00', '0')

Enjoy!
