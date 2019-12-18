public class Adaptee

	{
	    public double IskontaliTutariHesapla(double fiyat, double adet)

	    {
	        Console.WriteLine("\nLütfen iskonto miktarýný giriniz.\n");           

	        double iskonto = Convert.ToDouble(Console.ReadLine());

	        return fiyat * adet * (1 - iskonto);

	    }

	}

public interface ITutarHesaplayici

	   {

	       double Hesapla(double fiyat, double adet);

	   }
public class Adapter:ITutarHesaplayici

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