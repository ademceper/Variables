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


