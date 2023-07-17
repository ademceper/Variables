using System.Globalization;

string isimSoyisim = "Adem ÇEPER"; // Değişken Tanımlama Örneği
Console.WriteLine(isimSoyisim);   //Konsola Çıktı Örneği

string isim;                         //İkinci tanımlama yönetimi
isim = "Adem ÇEPER";                 //Devamı                           
Console.WriteLine(isim);


//STRİNG


string deneme = "Adem ÇEPER";       //string değişkene değer atıyoruz
Console.WriteLine(deneme);

deneme = "Hello World";              //Değişkenin değerini değiştirip tekrar yazdırdığımızda denemede yeni değer bulunuyor.
Console.WriteLine(deneme);

string buyukKarakter = deneme.ToUpper();      //Karakterleri büyültmek için kullanılan metod
Console.WriteLine(buyukKarakter);

string kucukKarakter = deneme.ToLower();       //Karakterleri küçültmek için kullanılan metod
Console.WriteLine(kucukKarakter);


//CHAR


string secimstring = "A";                                // Her iki kullanımda geçerlidir 
char secimchar = 'A';                                 // char bellek yönetimi için daha iyi bir seçimdir

Console.WriteLine(secimstring);
Console.WriteLine(secimchar);


//int


int intMinVal = int.MinValue;
int intMaxVal = int.MaxValue;
Console.WriteLine(intMaxVal);                      //int alacağı max değer
Console.WriteLine(intMinVal);                      //int alacağı min değer


//double


double dval = 10.2;
double dval1 = 10;
double dval2 = 10.2d;
double val3 = 10.2D;


//decimal


decimal mval = 10.2m;
decimal mval1 = 10;
decimal mval2 = 10.2M;


//float


float fval = 10.2f;
float fval1 = 10;
float fval2 = 10.2F;


//bool


bool kullaniciDeger;
kullaniciDeger = false;
kullaniciDeger = true;


//DateTime


DateTime date = DateTime.Now;


//Tür dönüşümleri

byte a = 100;
int i = a;
Console.WriteLine(a);
int inttn = 256;
byte bytetn = (byte)inttn;
Console.WriteLine(bytetn);

string metin1 = "15";
int sayi1 = int.Parse(metin1);
string metin2 = "15";
int sayi2 = Convert.ToInt32(metin1);