Console.WriteLine("**********Girilen tek sayi*********");
Console.WriteLine("Bir Pozitif Sayi giriniz");
int sayi1 = Convert.ToInt32(Console.ReadLine());

    
if(sayi1 <= -1)
    Console.WriteLine("Girmis oldugunuz sayi pozitif degildir.");
else if (sayi1 >= 0)
    if(sayi1%2 == 0)
        Console.WriteLine("girmis oldugunuz sayi cifttir ve pozitiftir.");
else    
    Console.WriteLine("Tek sayi girdiniz");

Console.WriteLine("*****************************");
Console.WriteLine("**************N tane girilen sayi ciftleri bulan**********************");
Console.Write("Kaç Adet sayı girmek istersin: ");
var n = Convert.ToInt32(Console.ReadLine());
List<int> ciftSayilar = new List<int>();
for (int i = 0; i < n; i++)
    {
    int sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi % 2 == 0)
    {
        ciftSayilar.Add(sayi);
    }
    }

    foreach (var sayi in ciftSayilar)
    {
        Console.Write(sayi + " ");
    }

Console.Read();

Console.WriteLine("*************mye esit yada tam bolunenleri yazdiran console******************");


Console.WriteLine("lütfen bir sayı giriniz");
int n = int.Parse(Console.ReadLine());
int[] dizi2 = new int[n];

Console.WriteLine("lütfen bir sayı giriniz");
int m = int.Parse(Console.ReadLine());

for(int i=0;i<n;i++)
{
    Console.WriteLine("lütfen {0}. sayıyı giriniz",i+1);
    dizi2[i] = int.Parse(Console.ReadLine());
}

foreach (var i in dizi2)
{
    if(m%i==0){
        Console.WriteLine(i);
    }
    else if(m==i){
        Console.WriteLine(i);
    }
}
Console.WriteLine("lütfen bir sayı giriniz");
int sn = int.Parse(Console.ReadLine());
string[] dizi3 = new string[sn];

for(int i=0;i<sn;i++){
    Console.WriteLine("lütfen {0}. kelimeyi giriniz",i+1);
    dizi3[i] = Console.ReadLine();
}

for(int i=sn-1;i>=0;i--){
    Console.WriteLine(dizi3[i]);
}

string[] kelimeler;
Console.WriteLine("lütfen bir cümle giriniz");
string cümle = Console.ReadLine();
kelimeler = cümle.Split(" ");

Console.WriteLine("cümlede {0} kelime var",kelimeler.Length);
Console.WriteLine("cümlede {0} tane harf var",cümle.Length);    




