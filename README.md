# CompanyApp
Zadanie na pohovor - KROS

# Setup
- Ako bolo v pdfku odporúčané, použil som SQL Express
- V appke sa prepisuje connection string v CompanyApp\App.config

- Sú k dispozícií .sql súbory, pre setup stačí zapnúť FullSQLSetup, ktorý vytvorí databázu 'CompanyDB', pokiaľ neexistujem následne 2 tabuľky pre zamestnancov a organizačné jednotky
- V prípade potreby som tento setup rozdelil aj do CreateDatabase.SQL, Table_create_query.sql a TableExampleInserts.sql
- Taktiež sa tam nachádza DropTables.sql, ktorý zruší obe tabuľky.
- Po rozbehaní databázy stačí buď projekt otvoriť vo visual studiu a zapnúť, alebo v CompanyApp\bin\Release\net10.0-windows je .exe súbor cez ktorý sa dá appka spustiť


# Pozn.
- Manažéra/Vedúceho pre organizačnú jednotku môže byť priradený cez appku len taký zamestnanec, ktorý je priradený do tohto oddelenia
