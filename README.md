# Zadanie

Zadanie polegające na znalezieniu we wskazanej bazie danych odpowiednich informacji.  

# Sposób wykonania

1. Założenie lokalnie bazy danych "db_prod" na SQL Server.
2. Uruchomienie funkcji wykonującej polecenia z pliku .sql.  
3. Uruchomienie osobno funkcji generujących pliki .csv.  
4. Wizualizacja wyników w Power BI.  

# Dodatkowe informacje

Wymagany jest własnoręczne utworzenie bazy danych o konkretnej nazwie.  
Sposób połączenia z bazą danych jest ustawiony na sztywno - connectorstring został zdefiniowany w pliku AppDBContext.cs i w metodzie Helper.RunSql().  
Nie należy uruchamiać kilku metod klasy Helper jednocześnie.
