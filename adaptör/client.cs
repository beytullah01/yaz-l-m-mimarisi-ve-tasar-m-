public class Client

	{

	    public void OdenecekMeblayiHesapla(ITutarHesaplayici hesaplayici)

	    {

	        Console.WriteLine("\nL�tfen fiyat� giriniz.\n");

	        double fiyat = Convert.ToDouble(Console.ReadLine());

	        Console.WriteLine("\nL�tfen miktar� giriniz.\n");

	        double miktar = Convert.ToDouble(Console.ReadLine());

	        Console.WriteLine("\nTutar = " + hesaplayici.Hesapla(fiyat, miktar));

	        Console.WriteLine();

	    }

	}