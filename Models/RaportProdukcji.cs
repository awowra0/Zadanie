using System;
using System.Collections.Generic;

namespace Zadanie1.Models;

public partial class RaportProdukcji
{
    public int nr { get; set; }

    public double? nr_raportu { get; set; }

    public string? data { get; set; }

    public string? godzina { get; set; }

    public double? nr_receptury { get; set; }

    public string? kod_receptury { get; set; }

    public string? nazwa_receptury { get; set; }

    public double? zamowiono { get; set; }

    public double? wyrodukowano { get; set; }

    public double? zamowiono_colosc { get; set; }

    public double? wyslano { get; set; }

    public string? samochod { get; set; }

    public string? samochod_kierowca { get; set; }

    public string? pompa { get; set; }

    public string? pompa_kierowca { get; set; }

    public string? klient { get; set; }

    public string? klient2 { get; set; }

    public string? klient3 { get; set; }

    public string? budowa { get; set; }

    public string? budowa2 { get; set; }

    public string? budowa3 { get; set; }

    public string? cement_1_nazwa { get; set; }

    public double? cement_1_ilosc_z_receptury { get; set; }

    public double? cement_1_ilosc_wyprodukowana { get; set; }

    public string? cement_2_nazwa { get; set; }

    public double? cement_2_ilosc_z_receptury { get; set; }

    public double? cement_2_ilosc_wyprodukowana { get; set; }

    public string? cement_3_nazwa { get; set; }

    public double? cement_3_ilosc_z_receptury { get; set; }

    public double? cement_3_ilosc_wyprodukowana { get; set; }

    public string? cement_4_nazwa { get; set; }

    public double? cement_4_ilosc_z_receptury { get; set; }

    public double? cement_4_ilosc_wyprodukowana { get; set; }

    public string? cement_5_nazwa { get; set; }

    public double? cement_5_ilosc_z_receptury { get; set; }

    public double? cement_5_ilosc_wyprodukowana { get; set; }

    public string? cement_6_nazwa { get; set; }

    public double? cement_6_ilosc_z_receptury { get; set; }

    public double? cement_6_ilosc_wyprodukowana { get; set; }

    public string? kruszywo_1_nazwa { get; set; }

    public double? kruszywo_1_ilosc_z_receptury { get; set; }

    public double? kruszywo_1_ilosc_wyprodukowana { get; set; }

    public string? kruszywo_2_nazwa { get; set; }

    public double? kruszywo_2_ilosc_z_receptury { get; set; }

    public double? kruszywo_2_ilosc_wyprodukowana { get; set; }

    public string? kruszywo_3_nazwa { get; set; }

    public double? kruszywo_3_ilosc_z_receptury { get; set; }

    public double? kruszywo_3_ilosc_wyprodukowana { get; set; }

    public string? kruszywo_4_nazwa { get; set; }

    public double? kruszywo_4_ilosc_z_receptury { get; set; }

    public double? kruszywo_4_ilosc_wyprodukowana { get; set; }

    public string? kruszywo_5_nazwa { get; set; }

    public double? kruszywo_5_ilosc_z_receptury { get; set; }

    public double? kruszywo_5_ilosc_wyprodukowana { get; set; }

    public string? kruszywo_6_nazwa { get; set; }

    public double? kruszywo_6_ilosc_z_receptury { get; set; }

    public double? kruszywo_6_ilosc_wyprodukowana { get; set; }

    public double? kruszywo1wilgotnosc { get; set; }

    public double? kruszywo2wilgotnosc { get; set; }

    public double? kruszywo3wilgotnosc { get; set; }

    public double? kruszywo4wilgotnosc { get; set; }

    public double? kruszywo5wilgotnosc { get; set; }

    public double? kruszywo6wilgotnosc { get; set; }

    public string? dodatek_1_nazwa { get; set; }

    public double? dodatek_1_ilosc_z_receptury { get; set; }

    public double? dodatek_1_ilosc_wyprodukowana { get; set; }

    public string? dodatek_2_nazwa { get; set; }

    public double? dodatek_2_ilosc_z_receptury { get; set; }

    public double? dodatek_2_ilosc_wyprodukowana { get; set; }

    public string? dodatek_3_nazwa { get; set; }

    public double? dodatek_3_ilosc_z_receptury { get; set; }

    public double? dodatek_3_ilosc_wyprodukowana { get; set; }

    public string? dodatek_4_nazwa { get; set; }

    public double? dodatek_4_ilosc_z_receptury { get; set; }

    public double? dodatek_4_ilosc_wyprodukowana { get; set; }

    public string? dodatek_5_nazwa { get; set; }

    public double? dodatek_5_ilosc_z_receptury { get; set; }

    public double? dodatek_5_ilosc_wyprodukowana { get; set; }

    public string? dodatek_6_nazwa { get; set; }

    public double? dodatek_6_ilosc_z_receptury { get; set; }

    public double? dodatek_6_ilosc_wyprodukowana { get; set; }

    public double? woda_czysta__ilosc_z_receptury { get; set; }

    public double? woda_czysta_ilosc_wyprodukowana { get; set; }

    public double? woda_brudna__ilosc_z_receptury { get; set; }

    public double? woda_brudna_ilosc_wyprodukowana { get; set; }

    public string? infarmacja_o_produkcji { get; set; }

    public string? wytrzymalosc { get; set; }

    public string? konsystencja { get; set; }

    public string? ekspozycja { get; set; }

    public string? ziarnoMax { get; set; }

    public string? rezerwa1 { get; set; }

    public string? rezerwa2 { get; set; }

    public string? Cement_7_Nazwa { get; set; }

    public double? Cement_7_Ilosc_receptura { get; set; }

    public double? Cement_7_Ilosc_wyprodukowano { get; set; }

    public string? Cement_8_Nazwa { get; set; }

    public double? Cement_8_Ilosc_receptura { get; set; }

    public double? Cement_8_Ilosc_wyprodukowano { get; set; }

    public string? Kruszywo_7_Nazwa { get; set; }

    public double? Kruszywo_7_Ilosc_receptura { get; set; }

    public double? Kruszywo_7_Ilosc_wyprodukowano { get; set; }

    public string? Kruszywo_8_Nazwa { get; set; }

    public double? Kruszywo_8_Ilosc_receptura { get; set; }

    public double? Kruszywo_8_Ilosc_wyprodukowano { get; set; }

    public string? Dodatek_7_Nazwa { get; set; }

    public double? Dodatek_7_Ilosc_receptura { get; set; }

    public double? Dodatek_7_Ilosc_wyprodukowano { get; set; }

    public string? Dodatek_8_Nazwa { get; set; }

    public double? Dodatek_8_Ilosc_receptura { get; set; }

    public double? Dodatek_8_Ilosc_wyprodukowano { get; set; }

    public double? Kruszywo_7_wilgotnosc { get; set; }

    public double? Kruszywo_8_wilgotnosc { get; set; }

    public double? Woda_ciepla_receptura { get; set; }

    public double? Woda_ciepla_wyprodukowano { get; set; }

    public string? nr_zamowienia { get; set; }

    public string? nr_wezla { get; set; }

    public string? Rodzaj_betonu { get; set; }

    public long? Klasa_gestosci { get; set; }

    public string? Rozwoj_wytrzymalosci { get; set; }

    public string? Rezerwa9 { get; set; }

    public string? Rezerwa10 { get; set; }

    public double? RezerwaReal1 { get; set; }

    public double? RezerwaReal2 { get; set; }

    public DateTime? data_czas { get; set; }

    public string? wlasciwosci_specjalne { get; set; }

    public string? deklaracja_nazwa { get; set; }

    public string? deklaracja_numer { get; set; }

    public string? deklaracja_wlasciwosci { get; set; }

    public string? deklaracja_rezerwa1 { get; set; }
}
