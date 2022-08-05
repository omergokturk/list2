
using System.Collections;

HalkbankList.HalkbankList.MaxElemanSayisi = 9;
var hbList = new HalkbankList.HalkbankList(9);

hbList.Ekle("Omer1");
hbList.Ekle("Omer2");
hbList.Ekle("Omer3");
hbList.Ekle("Omer4");
hbList.Ekle("Omer6");
hbList.Ekle("Omer6");
hbList.Ekle("Omer6");
hbList.Ekle("Omer6");
Console.WriteLine("***************HB LIST Foreach***************");
foreach (var item in hbList)
{
    Console.WriteLine(item);
}
hbList.TersCevir();

Console.WriteLine("***************HB LIST REVERSE*************** :");
foreach (var item in hbList)
{
    Console.WriteLine(item);
}
object a = "Omer8";
Console.WriteLine($"Index Of input : '{a}' Sonuc: {hbList.IndexOf(a)} ");
a = "Omer6";
Console.WriteLine($"Last Index Of input : '{a}' Sonuc: {hbList.LastIndexOf(a)} ");

Object[] yeniDizi = new Object[11];
yeniDizi[0] = "Dizi0";
yeniDizi[1] = "Dizi1";
yeniDizi[2] = "Dizi2";
yeniDizi[3] = "Dizi3";
yeniDizi[4] = "Dizi4";
yeniDizi[5] = "Dizi5";
yeniDizi[6] = "Dizi6";
yeniDizi[7] = "Dizi7";
yeniDizi[8] = "Dizi8";
yeniDizi[9] = "Dizi9";
yeniDizi[10] = "Dizi10";

foreach (var eleman in yeniDizi)
{
    Console.WriteLine($"Eleman : {eleman}");

}
int index = 3;
Console.WriteLine($"***************COPY TO*************** input = {index}");
hbList.ItibarenKopyala(yeniDizi, index);
foreach (var eleman in yeniDizi)
{
    Console.WriteLine(eleman);

}

object ara = "Omer2";
Console.WriteLine($"Contains input : '{ara}' sonuc : {hbList.Contains(ara)}"); 

Console.ReadLine();
Console.WriteLine("Hello, World!");
