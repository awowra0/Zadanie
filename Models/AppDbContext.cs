using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Zadanie1.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<TaskTwoRep> TwoRep {get; set;}
    public virtual DbSet<RaportProdukcji> RaportProdukcjis { get; set; }

    public virtual DbSet<Receptury> Recepturies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=db_prod;Integrated Security=true;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TaskTwoRep>(entity => {entity.HasNoKey();});

        modelBuilder.Entity<RaportProdukcji>(entity =>
        {
            entity.HasKey(e => e.nr);

            entity.ToTable("RaportProdukcji");

            entity.Property(e => e.Cement_7_Nazwa).HasMaxLength(255);
            entity.Property(e => e.Cement_8_Nazwa).HasMaxLength(255);
            entity.Property(e => e.Dodatek_7_Nazwa).HasMaxLength(255);
            entity.Property(e => e.Dodatek_8_Nazwa).HasMaxLength(255);
            entity.Property(e => e.Kruszywo_7_Nazwa).HasMaxLength(255);
            entity.Property(e => e.Kruszywo_8_Nazwa).HasMaxLength(255);
            entity.Property(e => e.Rezerwa10).HasMaxLength(255);
            entity.Property(e => e.Rezerwa9).HasMaxLength(255);
            entity.Property(e => e.Rodzaj_betonu).HasMaxLength(255);
            entity.Property(e => e.Rozwoj_wytrzymalosci).HasMaxLength(255);
            entity.Property(e => e.budowa).HasMaxLength(255);
            entity.Property(e => e.budowa2).HasMaxLength(255);
            entity.Property(e => e.budowa3).HasMaxLength(255);
            entity.Property(e => e.cement_1_ilosc_wyprodukowana).HasColumnName("cement 1 ilosc wyprodukowana");
            entity.Property(e => e.cement_1_ilosc_z_receptury).HasColumnName("cement 1 ilosc z receptury");
            entity.Property(e => e.cement_1_nazwa)
                .HasMaxLength(255)
                .HasColumnName("cement 1 nazwa");
            entity.Property(e => e.cement_2_ilosc_wyprodukowana).HasColumnName("cement 2 ilosc wyprodukowana");
            entity.Property(e => e.cement_2_ilosc_z_receptury).HasColumnName("cement 2 ilosc z receptury");
            entity.Property(e => e.cement_2_nazwa)
                .HasMaxLength(255)
                .HasColumnName("cement 2 nazwa");
            entity.Property(e => e.cement_3_ilosc_wyprodukowana).HasColumnName("cement 3 ilosc wyprodukowana");
            entity.Property(e => e.cement_3_ilosc_z_receptury).HasColumnName("cement 3 ilosc z receptury");
            entity.Property(e => e.cement_3_nazwa)
                .HasMaxLength(255)
                .HasColumnName("cement 3 nazwa");
            entity.Property(e => e.cement_4_ilosc_wyprodukowana).HasColumnName("cement 4 ilosc wyprodukowana");
            entity.Property(e => e.cement_4_ilosc_z_receptury).HasColumnName("cement 4 ilosc z receptury");
            entity.Property(e => e.cement_4_nazwa)
                .HasMaxLength(255)
                .HasColumnName("cement 4 nazwa");
            entity.Property(e => e.cement_5_ilosc_wyprodukowana).HasColumnName("cement 5 ilosc wyprodukowana");
            entity.Property(e => e.cement_5_ilosc_z_receptury).HasColumnName("cement 5 ilosc z receptury");
            entity.Property(e => e.cement_5_nazwa)
                .HasMaxLength(255)
                .HasColumnName("cement 5 nazwa");
            entity.Property(e => e.cement_6_ilosc_wyprodukowana).HasColumnName("cement 6 ilosc wyprodukowana");
            entity.Property(e => e.cement_6_ilosc_z_receptury).HasColumnName("cement 6 ilosc z receptury");
            entity.Property(e => e.cement_6_nazwa)
                .HasMaxLength(255)
                .HasColumnName("cement 6 nazwa");
            entity.Property(e => e.data).HasMaxLength(255);
            entity.Property(e => e.data_czas).HasColumnType("datetime");
            entity.Property(e => e.deklaracja_nazwa).HasMaxLength(255);
            entity.Property(e => e.deklaracja_numer).HasMaxLength(255);
            entity.Property(e => e.deklaracja_rezerwa1).HasMaxLength(255);
            entity.Property(e => e.deklaracja_wlasciwosci).HasMaxLength(255);
            entity.Property(e => e.dodatek_1_ilosc_wyprodukowana).HasColumnName("dodatek 1 ilosc wyprodukowana");
            entity.Property(e => e.dodatek_1_ilosc_z_receptury).HasColumnName("dodatek 1 ilosc z receptury");
            entity.Property(e => e.dodatek_1_nazwa)
                .HasMaxLength(255)
                .HasColumnName("dodatek 1 nazwa");
            entity.Property(e => e.dodatek_2_ilosc_wyprodukowana).HasColumnName("dodatek 2 ilosc wyprodukowana");
            entity.Property(e => e.dodatek_2_ilosc_z_receptury).HasColumnName("dodatek 2 ilosc z receptury");
            entity.Property(e => e.dodatek_2_nazwa)
                .HasMaxLength(255)
                .HasColumnName("dodatek 2 nazwa");
            entity.Property(e => e.dodatek_3_ilosc_wyprodukowana).HasColumnName("dodatek 3 ilosc wyprodukowana");
            entity.Property(e => e.dodatek_3_ilosc_z_receptury).HasColumnName("dodatek 3 ilosc z receptury");
            entity.Property(e => e.dodatek_3_nazwa)
                .HasMaxLength(255)
                .HasColumnName("dodatek 3 nazwa");
            entity.Property(e => e.dodatek_4_ilosc_wyprodukowana).HasColumnName("dodatek 4 ilosc wyprodukowana");
            entity.Property(e => e.dodatek_4_ilosc_z_receptury).HasColumnName("dodatek 4 ilosc z receptury");
            entity.Property(e => e.dodatek_4_nazwa)
                .HasMaxLength(255)
                .HasColumnName("dodatek 4 nazwa");
            entity.Property(e => e.dodatek_5_ilosc_wyprodukowana).HasColumnName("dodatek 5 ilosc wyprodukowana");
            entity.Property(e => e.dodatek_5_ilosc_z_receptury).HasColumnName("dodatek 5 ilosc z receptury");
            entity.Property(e => e.dodatek_5_nazwa)
                .HasMaxLength(255)
                .HasColumnName("dodatek 5 nazwa");
            entity.Property(e => e.dodatek_6_ilosc_wyprodukowana).HasColumnName("dodatek 6 ilosc wyprodukowana");
            entity.Property(e => e.dodatek_6_ilosc_z_receptury).HasColumnName("dodatek 6 ilosc z receptury");
            entity.Property(e => e.dodatek_6_nazwa)
                .HasMaxLength(255)
                .HasColumnName("dodatek 6 nazwa");
            entity.Property(e => e.ekspozycja).HasMaxLength(255);
            entity.Property(e => e.godzina).HasMaxLength(255);
            entity.Property(e => e.infarmacja_o_produkcji)
                .HasMaxLength(255)
                .HasColumnName("infarmacja o produkcji");
            entity.Property(e => e.klient).HasMaxLength(255);
            entity.Property(e => e.klient2).HasMaxLength(255);
            entity.Property(e => e.klient3).HasMaxLength(255);
            entity.Property(e => e.kod_receptury).HasMaxLength(255);
            entity.Property(e => e.konsystencja).HasMaxLength(255);
            entity.Property(e => e.kruszywo_1_ilosc_wyprodukowana).HasColumnName("kruszywo 1 ilosc wyprodukowana");
            entity.Property(e => e.kruszywo_1_ilosc_z_receptury).HasColumnName("kruszywo 1 ilosc z receptury");
            entity.Property(e => e.kruszywo_1_nazwa)
                .HasMaxLength(255)
                .HasColumnName("kruszywo 1 nazwa");
            entity.Property(e => e.kruszywo_2_ilosc_wyprodukowana).HasColumnName("kruszywo 2 ilosc wyprodukowana");
            entity.Property(e => e.kruszywo_2_ilosc_z_receptury).HasColumnName("kruszywo 2 ilosc z receptury");
            entity.Property(e => e.kruszywo_2_nazwa)
                .HasMaxLength(255)
                .HasColumnName("kruszywo 2 nazwa");
            entity.Property(e => e.kruszywo_3_ilosc_wyprodukowana).HasColumnName("kruszywo 3 ilosc wyprodukowana");
            entity.Property(e => e.kruszywo_3_ilosc_z_receptury).HasColumnName("kruszywo 3 ilosc z receptury");
            entity.Property(e => e.kruszywo_3_nazwa)
                .HasMaxLength(255)
                .HasColumnName("kruszywo 3 nazwa");
            entity.Property(e => e.kruszywo_4_ilosc_wyprodukowana).HasColumnName("kruszywo 4 ilosc wyprodukowana");
            entity.Property(e => e.kruszywo_4_ilosc_z_receptury).HasColumnName("kruszywo 4 ilosc z receptury");
            entity.Property(e => e.kruszywo_4_nazwa)
                .HasMaxLength(255)
                .HasColumnName("kruszywo 4 nazwa");
            entity.Property(e => e.kruszywo_5_ilosc_wyprodukowana).HasColumnName("kruszywo 5 ilosc wyprodukowana");
            entity.Property(e => e.kruszywo_5_ilosc_z_receptury).HasColumnName("kruszywo 5 ilosc z receptury");
            entity.Property(e => e.kruszywo_5_nazwa)
                .HasMaxLength(255)
                .HasColumnName("kruszywo 5 nazwa");
            entity.Property(e => e.kruszywo_6_ilosc_wyprodukowana).HasColumnName("kruszywo 6 ilosc wyprodukowana");
            entity.Property(e => e.kruszywo_6_ilosc_z_receptury).HasColumnName("kruszywo 6 ilosc z receptury");
            entity.Property(e => e.kruszywo_6_nazwa)
                .HasMaxLength(255)
                .HasColumnName("kruszywo 6 nazwa");
            entity.Property(e => e.nazwa_receptury).HasMaxLength(255);
            entity.Property(e => e.nr_wezla).HasMaxLength(255);
            entity.Property(e => e.nr_zamowienia).HasMaxLength(255);
            entity.Property(e => e.pompa).HasMaxLength(255);
            entity.Property(e => e.pompa_kierowca).HasMaxLength(255);
            entity.Property(e => e.rezerwa1).HasMaxLength(255);
            entity.Property(e => e.rezerwa2).HasMaxLength(255);
            entity.Property(e => e.samochod).HasMaxLength(255);
            entity.Property(e => e.samochod_kierowca).HasMaxLength(255);
            entity.Property(e => e.wlasciwosci_specjalne).HasMaxLength(255);
            entity.Property(e => e.woda_brudna__ilosc_z_receptury).HasColumnName("woda brudna  ilosc z receptury");
            entity.Property(e => e.woda_brudna_ilosc_wyprodukowana).HasColumnName("woda brudna ilosc wyprodukowana");
            entity.Property(e => e.woda_czysta__ilosc_z_receptury).HasColumnName("woda czysta  ilosc z receptury");
            entity.Property(e => e.woda_czysta_ilosc_wyprodukowana).HasColumnName("woda czysta ilosc wyprodukowana");
            entity.Property(e => e.wytrzymalosc).HasMaxLength(255);
            entity.Property(e => e.ziarnoMax).HasMaxLength(255);
        });

        modelBuilder.Entity<Receptury>(entity =>
        {
            entity.HasKey(e => e.nr);

            entity.ToTable("Receptury");

            entity.Property(e => e.Cement_1_ilosc).HasColumnName("Cement 1 ilosc");
            entity.Property(e => e.Cement_1_nazwa)
                .HasMaxLength(255)
                .HasColumnName("Cement 1 nazwa");
            entity.Property(e => e.Cement_2_ilosc).HasColumnName("Cement 2 ilosc");
            entity.Property(e => e.Cement_2_nazwa)
                .HasMaxLength(255)
                .HasColumnName("Cement 2 nazwa");
            entity.Property(e => e.Cement_3_ilosc).HasColumnName("Cement 3 ilosc");
            entity.Property(e => e.Cement_3_nazwa)
                .HasMaxLength(255)
                .HasColumnName("Cement 3 nazwa");
            entity.Property(e => e.Cement_4_ilosc).HasColumnName("Cement 4 ilosc");
            entity.Property(e => e.Cement_4_nazwa)
                .HasMaxLength(255)
                .HasColumnName("Cement 4 nazwa");
            entity.Property(e => e.Cement_5_ilosc).HasColumnName("Cement 5 ilosc");
            entity.Property(e => e.Cement_5_nazwa)
                .HasMaxLength(255)
                .HasColumnName("Cement 5 nazwa");
            entity.Property(e => e.Cement_6_Nazwa).HasMaxLength(255);
            entity.Property(e => e.Cement_7_Nazwa).HasMaxLength(255);
            entity.Property(e => e.Cement_8_Nazwa).HasMaxLength(255);
            entity.Property(e => e.Czas_mieszania).HasColumnName("Czas mieszania");
            entity.Property(e => e.Dodatek_1_ilosc).HasColumnName("Dodatek 1 ilosc");
            entity.Property(e => e.Dodatek_1_nazwa)
                .HasMaxLength(255)
                .HasColumnName("Dodatek 1 nazwa");
            entity.Property(e => e.Dodatek_2_ilosc).HasColumnName("Dodatek 2 ilosc");
            entity.Property(e => e.Dodatek_2_nazwa)
                .HasMaxLength(255)
                .HasColumnName("Dodatek 2 nazwa");
            entity.Property(e => e.Dodatek_3_ilosc).HasColumnName("Dodatek 3 ilosc");
            entity.Property(e => e.Dodatek_3_nazwa)
                .HasMaxLength(255)
                .HasColumnName("Dodatek 3 nazwa");
            entity.Property(e => e.Dodatek_4_ilosc).HasColumnName("Dodatek 4 ilosc");
            entity.Property(e => e.Dodatek_4_nazwa)
                .HasMaxLength(255)
                .HasColumnName("Dodatek 4 nazwa");
            entity.Property(e => e.Dodatek_5_Nazwa).HasMaxLength(255);
            entity.Property(e => e.Dodatek_6_Nazwa).HasMaxLength(255);
            entity.Property(e => e.Dodatek_7_Nazwa).HasMaxLength(255);
            entity.Property(e => e.Dodatek_8_Nazwa).HasMaxLength(255);
            entity.Property(e => e.Ekspozycja).HasMaxLength(255);
            entity.Property(e => e.Klasa_gestosci).HasMaxLength(255);
            entity.Property(e => e.Kod_receptury).HasMaxLength(255);
            entity.Property(e => e.Konsystencja).HasMaxLength(255);
            entity.Property(e => e.Kruszywo_1_ilosc).HasColumnName("Kruszywo 1 ilosc");
            entity.Property(e => e.Kruszywo_1_nazwa)
                .HasMaxLength(255)
                .HasColumnName("Kruszywo 1 nazwa");
            entity.Property(e => e.Kruszywo_2_ilosc).HasColumnName("Kruszywo 2 ilosc");
            entity.Property(e => e.Kruszywo_2_nazwa)
                .HasMaxLength(255)
                .HasColumnName("Kruszywo 2 nazwa");
            entity.Property(e => e.Kruszywo_3_ilosc).HasColumnName("Kruszywo 3 ilosc");
            entity.Property(e => e.Kruszywo_3_nazwa)
                .HasMaxLength(255)
                .HasColumnName("Kruszywo 3 nazwa");
            entity.Property(e => e.Kruszywo_4_ilosc).HasColumnName("Kruszywo 4 ilosc");
            entity.Property(e => e.Kruszywo_4_nazwa)
                .HasMaxLength(255)
                .HasColumnName("Kruszywo 4 nazwa");
            entity.Property(e => e.Kruszywo_5_ilosc).HasColumnName("Kruszywo 5 ilosc");
            entity.Property(e => e.Kruszywo_5_nazwa)
                .HasMaxLength(255)
                .HasColumnName("Kruszywo 5 nazwa");
            entity.Property(e => e.Kruszywo_6_ilosc).HasColumnName("Kruszywo 6 ilosc");
            entity.Property(e => e.Kruszywo_6_nazwa)
                .HasMaxLength(255)
                .HasColumnName("Kruszywo 6 nazwa");
            entity.Property(e => e.Kruszywo_7_Nazwa).HasMaxLength(255);
            entity.Property(e => e.Kruszywo_8_Nazwa).HasMaxLength(255);
            entity.Property(e => e.Nazwa_receptury).HasMaxLength(255);
            entity.Property(e => e.Rezerwa10).HasMaxLength(255);
            entity.Property(e => e.Rezerwa9).HasMaxLength(255);
            entity.Property(e => e.Rezerwa_5)
                .HasMaxLength(255)
                .HasColumnName("Rezerwa 5");
            entity.Property(e => e.Rezerwa_6)
                .HasMaxLength(255)
                .HasColumnName("Rezerwa 6");
            entity.Property(e => e.Rezerwa_7)
                .HasMaxLength(255)
                .HasColumnName("Rezerwa 7");
            entity.Property(e => e.Rezerwa_8)
                .HasMaxLength(255)
                .HasColumnName("Rezerwa 8");
            entity.Property(e => e.Rodzaj_betonu).HasMaxLength(255);
            entity.Property(e => e.Rozwoj_wytrzymalosci).HasMaxLength(255);
            entity.Property(e => e.W_C_kD).HasMaxLength(255);
            entity.Property(e => e.W_C_recznie).HasMaxLength(255);
            entity.Property(e => e.Woda_brudna).HasColumnName("Woda brudna");
            entity.Property(e => e.Woda_czysta).HasColumnName("Woda czysta");
            entity.Property(e => e.Wytrzymalosc).HasMaxLength(255);
            entity.Property(e => e.Zaw_chlorkow).HasMaxLength(255);
            entity.Property(e => e.ZiarnoMax).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
