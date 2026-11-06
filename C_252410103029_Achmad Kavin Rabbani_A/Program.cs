using System;


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
        int stok = stokDapur - jumlah;
        Console.WriteLine("Stok dapur setelah dikurangi: " + stok);
    }
    public void main()
    {
        idPaket ="paketMBG";
        namaPaket = "makananbergizi";
        stokDapur = 100;
    }
}


//soal 3

class PaketReguler : PaketMBG
{
    public void main()
    {
        Console.WriteLine("Paket makanan bergizi dengan harga Rp15.000 per paket");
    }
    class Paketkhusus : PaketMBG
    {
        public void main()
        {
            Console.WriteLine("Paket makanan dengan harga Rp20.000 per paket");
        }
    }



    //soal 4

    void hitungbiaya(int jumlah)
    {
        int hargaReguler = 15000;
        int hargaKhusus = 20000;
        int total = jumlah * hargaKhusus;
        int total1 = jumlah * hargaReguler;
        Console.WriteLine("Total biaya: " + total);
        Console.WriteLine("Total biaya reguler: " + total1);
    }
}


//soal 5
abstract class paketMBG
{
    

}



//soal 6

interface DapatDidistribusikan
{

}




