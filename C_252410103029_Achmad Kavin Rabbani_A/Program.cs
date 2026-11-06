using System;
using System.Xml.Schema;


//soal 1
class Sekolah
{
    String idSekolah;
    string namaSekolah;
    int jumlahPaketDiterima;


    public void TampilkanData()
    {
        Console.WriteLine("idSekolah:" + idSekolah);
        Console.WriteLine("NamaSekolah:" + namaSekolah);
        Console.WriteLine("JumlahPaketDiterima :" + jumlahPaketDiterima);
    }
    
    public void main()
    {
        idSekolah = "sekolah1";
        namaSekolah = "SMA 1";
        jumlahPaketDiterima = 130;
    }
}



//soal 2

class PaketMBG
{
    String idPaket;
    String namaPaket;
    int stokDapur;

    public void tampilkan()
    {
        Console.WriteLine("id paket:" + idPaket);
        Console.WriteLine("Nama Paket:" + namaPaket);
        Console.WriteLine("stok dapur:" + stokDapur);
    }
    void KurangiStok(int jumlah)
    {
        stokDapur = jumlah;
    }
    public void main()
    {
        idPaket ="paketMBG";
        namaPaket = "makananbergizi";
        stokDapur = 100;
    }
}


//soal 3

class PaketReguler: PaketMBG
{
    String idPaket;
    string namaPaket;
    int stokDapur;
}




