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