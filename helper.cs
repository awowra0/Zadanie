using Microsoft.Data.SqlClient;
using Zadanie1.Models;
using Microsoft.EntityFrameworkCore;

public static class Helper
{
    public static void CreateDatabase()
    {
        using var context = new AppDbContext();
        {
            context.Database.SetConnectionString("Server=localhost;Database=master;Integrated Security=true;TrustServerCertificate=True;");
            var query = context.Database.ExecuteSqlRaw(
            """
                CREATE DATABASE  db_prod
            """
            );
        }
    }
    
    public static void RunSql()
    {
        string connectionString =
            @"Server=localhost;Database=db_prod;Integrated Security=true;TrustServerCertificate=True;";

        string script = File.ReadAllText("script_db.sql");


        var batches = script.Split(
            new[] { "\r\nGO\r\n", "\nGO\n" },
            StringSplitOptions.RemoveEmptyEntries);

        using var connection = new SqlConnection(connectionString);
        connection.Open();

        foreach (var batch in batches)
        {
            using var command = new SqlCommand(batch, connection);
            command.ExecuteNonQuery();
        }
    }

    public static void TaskOneEF(int inputmode, int inputday, int inputweek, int inputmonth, int inputyear)
    {
        using var db = new AppDbContext();
        {
            string inputdaystr = inputday > 9 ? inputday.ToString() : $"0{inputday}"; 
            string inputmonthstr = inputmonth > 9 ? inputmonth.ToString() : $"0{inputmonth}"; 

            var query = db.RaportProdukcjis
            .FromSqlRaw(
            """
                SELECT * FROM dbo.RaportProdukcji
                WHERE  kod_receptury not like 'zwrot betonu%'
                AND CASE
                    WHEN @mode = 0 AND data = @day THEN 1
                    WHEN @mode = 1 AND DATEPART(WEEK, CONVERT(DATE, data, 105)) = @week AND DATEPART(YEAR, CONVERT(DATE, data, 105)) = @year THEN 1
                    WHEN @mode = 2 AND DATEPART(MONTH, CONVERT(DATE, data, 105)) = @month AND DATEPART(YEAR, CONVERT(DATE, data, 105)) = @year THEN 1
                    WHEN @mode = 3 AND DATEPART(YEAR, CONVERT(DATE, data, 105)) = @year THEN 1
                    WHEN @mode = 4 THEN 1
                    ELSE 0
                END = 1   
            """,
            new SqlParameter("@day", $"{inputdaystr}-{inputmonthstr}-{inputyear}"),
            new SqlParameter("@week", inputweek), 
            new SqlParameter("@month", inputmonthstr),
            new SqlParameter("@year", inputyear),
            new SqlParameter("@mode", inputmode))
            .Select(s => new {s.data, s.godzina, s.zamowiono, s.wyrodukowano})
            .AsNoTracking()
            .ToList();
            string savedata = "data;godzina;zamówiono;wyprodukowano";
            foreach(var record in query)
            {
                savedata += $"\n{record.data};{record.godzina};{record.zamowiono};{record.wyrodukowano}";
            }
            //Console.WriteLine(savedata);        
            File.WriteAllText("taskOne.csv", savedata);
        }
    }
    public static void TaskTwoEF(int inputmode, int inputday, int inputweek, int inputmonth, int inputyear)
    {
        using var db = new AppDbContext();
        {
            string inputdaystr = inputday > 9 ? inputday.ToString() : $"0{inputday}"; 
            string inputmonthstr = inputmonth > 9 ? inputmonth.ToString() : $"0{inputmonth}"; 

            var query = db.Set<TaskTwoRep>()
            .FromSqlRaw(
            """
                select [data], [godzina] ,c.surN as [surowiec_nazwa], c.surR as [surowiec_receptura], c.surP as [surowiec_wyprodukowany] from dbo.RaportProdukcji
                --select convert(DATE, [data], 105) as dzien, data, surN as [surowiec_nazwa], sum(surR) as [surowiec_receptura], sum(surP) as [surowiec_wyprodukowany] from dbo.RaportProdukcji
                CROSS APPLY(
                    VALUES
                        ([cement 1 nazwa], [cement 1 ilosc z receptury], [cement 1 ilosc wyprodukowana]),
                        ([cement 2 nazwa], [cement 2 ilosc z receptury], [cement 2 ilosc wyprodukowana]),
                        ([cement 3 nazwa], [cement 3 ilosc z receptury], [cement 3 ilosc wyprodukowana]),
                        ([cement 4 nazwa], [cement 4 ilosc z receptury], [cement 4 ilosc wyprodukowana]),
                        ([cement 5 nazwa], [cement 5 ilosc z receptury], [cement 5 ilosc wyprodukowana]),
                        ([cement 6 nazwa], [cement 6 ilosc z receptury], [cement 6 ilosc wyprodukowana]),
                        ([cement_7_nazwa], [cement_7_ilosc_receptura], [cement_7_ilosc_wyprodukowano]),
                        ([cement_8_nazwa], [cement_8_ilosc_receptura], [cement_8_ilosc_wyprodukowano]),

                        ([kruszywo 1 nazwa], [kruszywo 1 ilosc z receptury], [kruszywo 1 ilosc wyprodukowana]),
                        ([kruszywo 2 nazwa], [kruszywo 2 ilosc z receptury], [kruszywo 2 ilosc wyprodukowana]),
                        ([kruszywo 3 nazwa], [kruszywo 3 ilosc z receptury], [kruszywo 3 ilosc wyprodukowana]),
                        ([kruszywo 4 nazwa], [kruszywo 4 ilosc z receptury], [kruszywo 4 ilosc wyprodukowana]),
                        ([kruszywo 5 nazwa], [kruszywo 5 ilosc z receptury], [kruszywo 5 ilosc wyprodukowana]),
                        ([kruszywo 6 nazwa], [kruszywo 6 ilosc z receptury], [kruszywo 6 ilosc wyprodukowana]),
                        ([kruszywo_7_nazwa], [kruszywo_7_ilosc_receptura], [kruszywo_7_ilosc_wyprodukowano]),
                        ([kruszywo_8_nazwa], [kruszywo_8_ilosc_receptura], [kruszywo_8_ilosc_wyprodukowano]),

                        ([dodatek 1 nazwa], [dodatek 1 ilosc z receptury], [dodatek 1 ilosc wyprodukowana]),
                        ([dodatek 2 nazwa], [dodatek 2 ilosc z receptury], [dodatek 2 ilosc wyprodukowana]),
                        ([dodatek 3 nazwa], [dodatek 3 ilosc z receptury], [dodatek 3 ilosc wyprodukowana]),
                        ([dodatek 4 nazwa], [dodatek 4 ilosc z receptury], [dodatek 4 ilosc wyprodukowana]),
                        ([dodatek 5 nazwa], [dodatek 5 ilosc z receptury], [dodatek 5 ilosc wyprodukowana]),
                        ([dodatek 6 nazwa], [dodatek 6 ilosc z receptury], [dodatek 6 ilosc wyprodukowana]),
                        ([dodatek_7_nazwa], [dodatek_7_ilosc_receptura], [dodatek_7_ilosc_wyprodukowano]),
                        ([dodatek_8_nazwa], [dodatek_8_ilosc_receptura], [dodatek_8_ilosc_wyprodukowano]),

                        ('woda czysta', [woda czysta  ilosc z receptury],[woda czysta ilosc wyprodukowana]),
                        ('woda brudna', [woda brudna  ilosc z receptury],[woda brudna ilosc wyprodukowana])
                )c(surN, surR, surP)
                WHERE surN != '-' AND (surR != 0 OR surP != 0)
                AND CASE
                    WHEN @mode = 0 AND data = @day THEN 1
                    WHEN @mode = 1 AND DATEPART(WEEK, CONVERT(DATE, data, 105)) = @week AND DATEPART(YEAR, CONVERT(DATE, data, 105)) = @year THEN 1
                    WHEN @mode = 2 AND DATEPART(MONTH, CONVERT(DATE, data, 105)) = @month AND DATEPART(YEAR, CONVERT(DATE, data, 105)) = @year THEN 1
                    WHEN @mode = 3 AND DATEPART(YEAR, CONVERT(DATE, data, 105)) = @year THEN 1
                    WHEN @mode = 4 THEN 1
                    ELSE 0
                END = 1 
                --GROUP BY [data], surN
                --ORDER BY dzien
            """,
            new SqlParameter("@day", $"{inputdaystr}-{inputmonthstr}-{inputyear}"),
            new SqlParameter("@week", inputweek), 
            new SqlParameter("@month", inputmonthstr),
            new SqlParameter("@year", inputyear),
            new SqlParameter("@mode", inputmode))
            .AsNoTracking()
            .ToList();
            //string savedata = "data,godzina,surowiec nazwa,surowiec receptura,surowiec wyprodukowany";
            string savedata = "data;surowiec nazwa;surowiec receptura;surowiec wyprodukowany";
            foreach(var record in query)
            {
                //savedata += $"\n{record.data},{record.godzina},{record.surowiec_nazwa},{record.surowiec_receptura},{record.surowiec_wyprodukowany}";
                savedata += $"\n{record.data};{record.surowiec_nazwa};{record.surowiec_receptura};{record.surowiec_wyprodukowany}";
            }
            //Console.WriteLine(savedata);        
            File.WriteAllText("taskTwo.csv", savedata);
        }
    }

    public static void TaskThreeEF(int inputmode, int inputday, int inputweek, int inputmonth, int inputyear)
    {
        using var db = new AppDbContext();
        {
            string inputdaystr = inputday > 9 ? inputday.ToString() : $"0{inputday}"; 
            string inputmonthstr = inputmonth > 9 ? inputmonth.ToString() : $"0{inputmonth}"; 

            var query = db.RaportProdukcjis
            .FromSqlRaw(
            """
                SELECT * FROM dbo.RaportProdukcji
                WHERE kod_receptury like 'zwrot betonu%'
                AND CASE
                    WHEN @mode = 0 AND data = @day THEN 1
                    WHEN @mode = 1 AND DATEPART(WEEK, CONVERT(DATE, data, 105)) = @week AND DATEPART(YEAR, CONVERT(DATE, data, 105)) = @year THEN 1
                    WHEN @mode = 2 AND DATEPART(MONTH, CONVERT(DATE, data, 105)) = @month AND DATEPART(YEAR, CONVERT(DATE, data, 105)) = @year THEN 1
                    WHEN @mode = 3 AND DATEPART(YEAR, CONVERT(DATE, data, 105)) = @year THEN 1
                    WHEN @mode = 4 THEN 1
                    ELSE 0
                END = 1   
            """,
            new SqlParameter("@day", $"{inputdaystr}-{inputmonthstr}-{inputyear}"),
            new SqlParameter("@week", inputweek), 
            new SqlParameter("@month", inputmonthstr),
            new SqlParameter("@year", inputyear),
            new SqlParameter("@mode", inputmode))
            .Select(s => new {s.data, s.godzina, s.zamowiono, s.wyrodukowano})
            .AsNoTracking()
            .ToList();
            double sum_zamowiono = 0;
            int counter = 0;
            string savedata = "data;godzina;zamówiono;wyprodukowano";
            foreach(var record in query)
            {
                savedata += $"\n{record.data};{record.godzina};{record.zamowiono};{record.wyrodukowano}";
                sum_zamowiono += record.zamowiono.GetValueOrDefault(0);
                counter++;
            }
            savedata = $"Zamówiono łącznie: {sum_zamowiono}\nLiczba zwrotów: {counter}\n{savedata}";
            //Console.WriteLine(savedata);
            File.WriteAllText("taskThree.csv", savedata);
        }
    }

}
