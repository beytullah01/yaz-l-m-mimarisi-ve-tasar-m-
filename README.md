# yazilimmimarisivetasarimi
## Fabrika Tasarım Deseni  

Factory Method (Fabrika metod) tasarım deseni creational grubununa ait, aynı arayüzü kullanan nesnelerin üretiminden sorumlu tasarım desenidir. 
Yazdığınız program da birbirine benzeyen birden fazla sınıf olabilir. Bu tür sınıfları oluştururken her seferinde new operatörünü kullanmayın ya da o sınıflardan sanki birbirinden bağımsızmış gibi kod yazmayalım diye böyle bir örüntü tasarlanmış.

Factory Method tasarım deseni aynı abstract sınıfı veya arayüzü uygulayan sınıfların üretiminden sorumludur. Kullanımı 2 şekilde olabilir. Birinci kullanım şeklinde nesne üretiminden sorumlu bir class olur ve bu sınıftaki metoda gönderilen parametre ile üretilecek sınıfın türü belirlenir. İkinci kullanım şeklinde ise her nesne üretimi için aynı arayüzü kullanan sınıflar oluşturulur ve hangi sınıftan nesne istenirse belirli bir sınıfı verir. Abstract method tasarım deseni abstract factory tasarım deseni ile çok benzer bir yapıdadır.   
2 tarz uml vardır:  
1.Kullanım şekli:    
![Imega of Class](https://github.com/beytullah01/yaz-l-m-mimarisi-ve-tasar-m-/blob/master/FactoryMethod1UML.jpg)  

2.Kullanım Şekli  
![Imega of Class](https://github.com/beytullah01/yaz-l-m-mimarisi-ve-tasar-m-/blob/master/FactoryMethod2UML.jpg)


Örneğin; tablo ve grafik rapor veren bir uygulamamız olsun. İlk önce rapor sınıflarımızın türetileceği bir arayüz tanımlayalım. Raporgrafik ve raportablo sınıflarımızı bu arayüzden türetelim. Son olarak da istediğimiz tipteki rapor sınıfının referansını veren bir sınıf ve metodu tanımlayalım.  


İlk olarak product sınıflarımızı oluşturalım.
```c#
/// Product Interface
public interface IRapor
{
    void Olustur();
}
 
/// Concrete Product
public class RaporTablo : IRapor
{
    public void Olustur()
    {
        Console.WriteLine("Tablo şeklinde rapor");
    }
}

/// Concrete Product
public class RaporGrafik : IRapor
{
    public void Olustur()
    {
        Console.WriteLine("Grafik şeklinde rapor");
    }
}
 ```
Şimdi de istediğimiz product sınıfının örneğini elde edeceğimiz factory metodumuzu oluşturalım.
```c#
public IRapor RaporFactory(RaporTip raporTip)
{
    IRapor rapor = null;
    switch (raporTip)
    {
        case RaporTip.Tablo:
            rapor = new RaporTablo();
            break;
        case RaporTip.Grafik:
            rapor = new RaporGrafik();
            break;
        default:
            break;
    }
    return rapor;
}
```
 
Oluşturduğumuz deseni aşağıdaki gibi kullanabiliriz.
```c#
static void Main(string[] args)
{
    Creator1 RaporCreator = new Creator1();
 
    IRapor rapor = RaporCreator.RaporFactory(RaporTip.Grafik);
    rapor.Olustur();
 
    rapor = RaporCreator.RaporFactory(RaporTip.Tablo);
    rapor.Olustur();
}
```
##Adaptör Tasarım Deseni  

Gerçek hayatta karşılığı olan bir tasarım örüntüsüdür. Farklı girişleri(interface) ler uyum sağlayabilmek için Adaptörler kullanılır. Örneğin bir tarafta Integer olan veri diğer tarafta Hexadecimal formatta isteniyorsa Adapter bu dönüşümü sizin için yaparak iki farklı cihazın birlikte çalışmasını sağlar.  
Gerçek hayattaki adaptörün benzeri yazılımda geçerlidir. Farklı interface uyum sağlamak için sınıfınızı saracak adaptör sınıflara ihtiyaç duyarsınız.
![Imega of Class](https://github.com/beytullah01/yaz-l-m-mimarisi-ve-tasar-m-/blob/master/adapt%C3%B6r_metot.jpg)  
Bu desen adapte edilecek sınıf, adapte edilecek sınıfın nesnesini yeni bir interface ile içinde sarmalayarak (ya da adaptör sınıfı adapte edilecek sınıftan da türeyebilir) kullanacak olan adaptörden oluşur.  

Sisteme Adapte Edilecek Sınıf (Adaptee sınıfı)  
public class Adaptee
```c#
	{

	    public double IskontaliTutariHesapla(double fiyat, double adet)

	    {

	        Console.WriteLine("\nLütfen iskonto miktarını giriniz.\n");           

	        double iskonto = Convert.ToDouble(Console.ReadLine());

	        return fiyat * adet * (1 - iskonto);

	    }

	}
 ```
 Adaptör sınıfı içinde (yeni sisteme adapte edilecek sınıf) kullanıcıdan alınan fiyat, miktar ve iskonto bilgileri ile toplam tutarın hesaplanması yapılmaktadır.


ITutarHesaplayici

```c#
	public interface ITutarHesaplayici

	   {

	       double Hesapla(double fiyat, double adet);

	   }
  ```
  
  Adaptör nesnemizin implement edeceği ITutarHeaplayici interface'i data tipi double olan ve 2 tane parametre alan bir fonksiyon imzası taşımaktadır.

public class Adapter:ITutarHesaplayici
  ```c#
	{
        private Adaptee adaptee;
	 

	    public Adapter()

	    {

	        adaptee = new Adaptee();

	    }         

	 

	    public double Hesapla(double fiyat, double adet)

	    {

	        return adaptee.IskontaliTutariHesapla(fiyat, adet);

	    }

	}
 ```
            

Adaptör sınıfında private Adaptee tipinde değişken bulunmaktadır. Adapter sınıfının içinde ITutarHesaplayici interfacinin Hesapla fonksiyonunu implement ederken, bu fonksiyon içinde Adaptee tipindeki değişkenin IskontaliTutariHesapla fonksiyonunu çağırarak adapte edeceğimiz sınıfın örneğini kullanmış bulunmaktayız.

Client Sınıfı
```c#
	public class Client

	{

	    public void OdenecekMeblayiHesapla(ITutarHesaplayici hesaplayici)

	    {

	        Console.WriteLine("\nLütfen fiyatı giriniz.\n");

	        double fiyat = Convert.ToDouble(Console.ReadLine());

	        Console.WriteLine("\nLütfen miktarı giriniz.\n");

	        double miktar = Convert.ToDouble(Console.ReadLine());

	        Console.WriteLine("\nTutar = " + hesaplayici.Hesapla(fiyat, miktar));

	        Console.WriteLine();

	    }

	}
```
Bu sınıfın içindeki OdenecekMeblayiHesapla fonksiyonu kullanıcıdan fiyat ve miktar bilgilerini aldıktan sonra ITutarHesaplayici interfacini implement etmiş sınıfların nesnelerini parametre olarak alarak hesaplama işlemini yapmaktadır.

Program.cs
```c#

	class Program

	{

	    static void Main(string[] args)

	    {

	        Adapter adapter = new Adapter();

	        string tercih = null;

	        Client client = new Client();

	        try

	        {

	            while (true)

	            {

	                Console.WriteLine("Malzemenin tutarını hesaplamak için 1 e," +

	                    "\niskontolu tutarını hesaplamak için 2 ye," +

	                    "\nuygulamadan çıkmak için 3'e basınız.\n");

	                tercih = Console.ReadLine();

	                int secenek = Convert.ToInt32(tercih);

	                Console.WriteLine();

	                if (secenek == 1)

	                {

	                    client.OdenecekMeblayiHesapla(new MalzemeTipineGoreToplamTutariniHesapla());
	                }
                    

	                else if (secenek == 2)

	                {

	                    client.OdenecekMeblayiHesapla(new Adapter());

	                }

	                else

	                {

	                    return;

	                }

	            }

	        }

	        catch

	        {

	            Console.WriteLine("Hata ile karşılaşıldı. Uygulama sonlanacaktır.");

	            Thread.Sleep(1500);               

	        }

	    }


	}
 ```

Main fonksiyonu içinde kullanıcıdan hangi tür hesaplama işlemini yapacağı bilgisini aldıktan sonra, client nesnesi oluşturarak içine ilgili nesneleri parametre olarak geçiyoruz. Adapter ve MalzemeTipineGoreToplamTutariniHesapla nesnelerini tutar hesaplamak için kullanıyoruz. MalzemeTipineGoreToplamTutariniHesapla nesnesini kendimiz yazdığımız halde Adapter nesnesi sayesinde önceden yazılmış olan Adaptee nesnesini sisteme adapte ederek kullanıyoruz.
