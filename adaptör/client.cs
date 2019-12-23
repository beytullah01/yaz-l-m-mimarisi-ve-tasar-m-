public class Client

	{

	    public void OdenecekMeblayiHesapla(ITutarHesaplayici hesaplayici)

	    {

	        Console.WriteLine("\nLütfen fiyatý giriniz.\n");

	        double fiyat = Convert.ToDouble(Console.ReadLine());

	        Console.WriteLine("\nLütfen miktarý giriniz.\n");

	        double miktar = Convert.ToDouble(Console.ReadLine());

	        Console.WriteLine("\nTutar = " + hesaplayici.Hesapla(fiyat, miktar));

	        Console.WriteLine();

	    }

	}