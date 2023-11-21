// dizi tanımlama 
string [] renkler = new string [5];
string [] hayvanlar = {"kedi", "köpek", "kuş", "maymun"};

int [] dizi;
dizi = new int [5];


// dizilere değer atama ve erişim

renkler [0] = "Mavi";
dizi [3] = 10;
Console.WriteLine(hayvanlar[1]); 
Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);
 // döngülerle dizi kullanımı
 // klavyede girilen n tane sayının ortalaması

Console.WriteLine("lütfen dizinin eleman sayısını giriniz.");
int diziUzunlugu = int.Parse(Console.ReadLine());
int [] sayıDizisi = new int[diziUzunlugu];

for (int i = 0; i < diziUzunlugu; i++)
{
  Console.WriteLine("lütfen {0}. sayıyı giriniz: " , i+1);
  sayıDizisi[i] = int.Parse(Console.ReadLine());
}

int toplam = 0;
foreach (var sayı in sayıDizisi)
{
    toplam += sayı;
}
Console.WriteLine("ortalama: " + toplam/diziUzunlugu);
    




{
    
}