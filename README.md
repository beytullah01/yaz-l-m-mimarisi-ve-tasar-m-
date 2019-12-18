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
