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
	                Console.WriteLine("Malzemenin tutar�n� hesaplamak i�in 1 e," +

	                    "\niskontolu tutar�n� hesaplamak i�in 2 ye," +

	                    "\nuygulamadan ��kmak i�in 3'e bas�n�z.\n");

	                tercih = Console.ReadLine();
16
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

	            Console.WriteLine("Hata ile kar��la��ld�. Uygulama sonlanacakt�r.");

	            Thread.Sleep(1500);               

	        }

	    }

	}