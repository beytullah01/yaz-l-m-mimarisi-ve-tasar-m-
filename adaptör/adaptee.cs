public class Adaptee

	{
	    public double IskontaliTutariHesapla(double fiyat, double adet)

	    {
	        Console.WriteLine("\nLütfen iskonto miktaryny giriniz.\n");           

	        double iskonto = Convert.ToDouble(Console.ReadLine());

	        return fiyat * adet * (1 - iskonto);

	    }

	}
