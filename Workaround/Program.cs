using Business.Concrete;
using Entities.Concrete;
//Degiskenler();
//Vatandas vatandas1 = new Vatandas();

//SelamVer("Engin");
//SelamVer("Ahmet");
//SelamVer("Eyşe");
//SelamVer();

//int sonuc = Topla(6,58);


//string ogr1 = "Engin";
//string ogr2 = "Kerem";
//string ogr3 = "Berkay";
//string[] ogrArray = {ogr1,ogr2, ogr3};

//foreach (string ogr in ogrArray)
//{
//    Console.WriteLine(ogr);
//}

//string[] sehirler1 = { "İzmir", "Ankara", "İstanbul" };
//string[] sehirler2 = { "İzmir2", "Ankara2", "İstanbul2" };
//sehirler1 = sehirler2;
//sehirler1[0] = "Smyrna";
//Console.WriteLine(sehirler2[0]);//reference type olduğu için smyrna yazar sehirler1 ve
//ve sehirler2 bellekte aynı adresi refere ediyor

//int sayi1 = 10;
//int sayi2 = 20;
//sayi1 = sayi2;
//sayi2 = 300;
//Console.WriteLine(sayi1);//10 value type olduğu için 



//List<string> listSehirler = new List<string> { "Ankara", "İstanbul", "Paris" };
//listSehirler.Add("new Ankara");

//foreach (string str in listSehirler)
//{
//    Console.WriteLine(str);
//}

Person person1 = new Person { FirstName = "Burak", LastName = "Usluer", NationalIdentity = 123, DateOfBirthYear = 1992 };
PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);



void SelamVer(string isim = "noname")//static main method olmadığı için yazmadım
{
    Console.WriteLine($"Merhaba {isim}");
}

int Topla(int sayi1 = 5, int sayi2 = 20)
{
    int sonuc = sayi1 + sayi2;
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