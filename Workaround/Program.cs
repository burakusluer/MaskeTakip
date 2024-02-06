//Degiskenler();
//Vatandas vatandas1 = new Vatandas();

SelamVer("Engin");
SelamVer("Ahmet");
SelamVer("Eyşe");
SelamVer();

int sonuc = Topla(6,58);


void SelamVer(string isim="noname")//static main method olmadığı için yazmadım
{
    Console.WriteLine($"Merhaba {isim}");
}

int Topla(int sayi1=5,int sayi2 = 20)
{
    int sonuc=sayi1 + sayi2;
    Console.WriteLine($"Toplam : {sonuc}");
    return sonuc;
}

void Degiskenler()
{
    string mesaj = "Merhaba";
    double tutar = 10000;//db den gelicek
    int sayi = 100;
    bool girisYapmisMi = false;
}

public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
    //kelimelerin ilk harfleri büyük ise PascalCase
    //snake_case
    //camelCase
}